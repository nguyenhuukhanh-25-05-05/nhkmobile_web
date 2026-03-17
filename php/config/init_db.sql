-- Database Schema cho NHK Mobile (PostgreSQL)

-- 1. Bảng sản phẩm (Lưu trữ thông tin điện thoại, phụ kiện)
CREATE TABLE IF NOT EXISTS products (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    category VARCHAR(100),
    price DECIMAL(15, 2) NOT NULL,
    stock INT DEFAULT 0,
    image VARCHAR(255),
    description TEXT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- 2. Bảng đơn hàng (Lưu trữ thông tin khách mua hàng)
CREATE TABLE IF NOT EXISTS orders (
    id SERIAL PRIMARY KEY,
    customer_name VARCHAR(255) NOT NULL,
    customer_phone VARCHAR(20),
    total_price DECIMAL(15, 2) NOT NULL,
    status VARCHAR(50) DEFAULT 'Pending', -- Pending, Processing, Completed, Cancelled
    payment_method VARCHAR(50),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- 3. Bảng Chi tiết đơn hàng (Lưu trữ danh sách máy trong mỗi đơn)
CREATE TABLE IF NOT EXISTS order_items (
    id SERIAL PRIMARY KEY,
    order_id INT REFERENCES orders(id) ON DELETE CASCADE,
    product_id INT REFERENCES products(id),
    product_name VARCHAR(255),
    price DECIMAL(15, 2),
    quantity INT
);

-- 4. Bảng Giỏ hàng bền vững (Lưu giỏ hàng theo session_id)
CREATE TABLE IF NOT EXISTS cart_items (
    id SERIAL PRIMARY KEY,
    session_id VARCHAR(255) NOT NULL,
    product_id INT REFERENCES products(id),
    quantity INT DEFAULT 1,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    UNIQUE(session_id, product_id)
);

-- 5. Bảng User (Khách hàng)
CREATE TABLE IF NOT EXISTS users (
    id SERIAL PRIMARY KEY,
    fullname VARCHAR(255) NOT NULL,
    email VARCHAR(255) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL,
    phone VARCHAR(20),
    address TEXT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- 6. Bảng Admin (Lưu trữ tài khoản quản trị)
CREATE TABLE IF NOT EXISTS admins (
    id SERIAL PRIMARY KEY,
    username VARCHAR(100) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL,
    role VARCHAR(50) DEFAULT 'admin',
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Cập nhật cấu trúc Orders (Thêm user_id để theo dõi lịch sử)
ALTER TABLE orders ADD COLUMN IF NOT EXISTS user_id INT REFERENCES users(id);

-- Cập nhật cấu trúc Cart Items (Cho phép liên kết với user_id thay vì chỉ session_id)
ALTER TABLE cart_items ADD COLUMN IF NOT EXISTS user_id INT REFERENCES users(id);

-- Dữ liệu mẫu Admin (Mặc định: admin / admin123)
-- Lưu ý: Thực tế nên dùng password_hash, đây là bản demo
INSERT INTO admins (username, password) VALUES ('admin', 'admin123') ON CONFLICT (username) DO NOTHING;

-- Dữ liệu mẫu Sản phẩm (Sử dụng ảnh thật trong assets/images)
INSERT INTO products (name, category, price, stock, image, description) VALUES 
('iPhone 17 Pro Max', 'Apple', 32990000, 45, 'ai_ip17_pm.png', 'Siêu phẩm Apple 2026 với trí tuệ nhân tạo tích hợp sâu.'),
('iPhone 16 Pro', 'Apple', 28990000, 20, 'ai_ip16_pro.png', 'Thiết kế sang trọng, hiệu năng mạnh mẽ.'),
('Samsung Galaxy S25 Ultra', 'Samsung', 29490000, 30, 'ai_s25_ultra.png', 'Đỉnh cao công nghệ màn hình và camera từ Samsung.'),
('Samsung Galaxy S24 Ultra', 'Samsung', 24990000, 15, 'ai_s24_ultra.png', 'Siêu phẩm Galaxy với AI kiến tạo trải nghiệm mới.'),
('Xiaomi 15 Pro', 'Xiaomi', 18500000, 50, 'ai_mi15t.png', 'Flagship Xiaomi với sạc siêu nhanh và camera Leica.'),
('Xiaomi Mix Flip', 'Xiaomi', 21500000, 10, 'ai_mi_flip.png', 'Điện thoại gập thời thượng từ nhà Xiaomi.'),
('Oppo Find X10', 'Oppo', 19900000, 15, 'oppo_findx10.png', 'Nghệ thuật nhiếp ảnh di động với cảm biến lớn nhất.'),
('Vivo X200 Pro', 'Vivo', 17900000, 25, 'ai_vivo_x200_black.png', 'Đỉnh cao nhiếp ảnh chân dung và thiết kế tối giản.'),
('Honor Magic 10', 'Honor', 16500000, 20, 'honor magic10.png', 'Công nghệ pin và màn hình vượt thời đại.'),
('OnePlus 15', 'OnePlus', 15900000, 30, 'oneplus15.png', 'Sát thủ flagship với hiệu năng cực đại.');
