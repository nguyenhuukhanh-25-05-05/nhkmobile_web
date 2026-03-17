<?php
/**
 * TRÌNH KHỞI TẠO CƠ SỞ DỮ LIỆU (DATABASE INITIALIZER) - PHIÊN BẢN NÂNG CẤP
 */

error_reporting(E_ALL);
ini_set('display_errors', 1);

require_once 'includes/db.php';

echo "<html><head><meta charset='UTF-8'><title>Khởi tạo CSDL</title></head><body style='font-family: sans-serif; padding: 50px;'>";

try {
    // 1. Kiểm tra thông tin kết nối (giấu mật khẩu)
    echo "<h3>🔍 Kiểm tra kết nối cơ sở dữ liệu:</h3>";
    $databaseUrl = $_ENV['DATABASE_URL'] ?? $_SERVER['DATABASE_URL'] ?? getenv('DATABASE_URL');
    
    if ($databaseUrl) {
        $maskedUrl = preg_replace('/:([^:@]+)@/', ':******@', $databaseUrl);
        echo "<p style='color: blue;'>Đang sử dụng DATABASE_URL: <code>$maskedUrl</code></p>";
    } else {
        echo "<p style='color: orange;'>⚠️ Không tìm thấy biến môi trường DATABASE_URL. Đang dùng cấu hình mặc định hoặc DB_HOST.</p>";
    }

    // 2. Thử truy vấn cơ bản
    $pdo->query("SELECT 1");
    echo "<p style='color: green;'>✅ Kết nối tới máy chủ PostgreSQL thành công!</p>";

    // 3. Đọc và thực thi file SQL
    echo "<h3>🚀 Bắt đầu tạo bảng...</h3>";
    $sqlFile = 'php/config/init_db.sql';
    if (!file_exists($sqlFile)) {
        throw new Exception("Không tìm thấy file SQL tại: $sqlFile");
    }

    $sql = file_get_contents($sqlFile);
    $pdo->exec($sql);
    
    echo "<h2 style='color: green;'>✅ ĐÃ KHỞI TẠO CSDL THÀNH CÔNG!</h2>";
    echo "<p>Tất cả các bảng (products, orders, order_items, cart_items, admins) đã được tạo.</p>";
    echo "<p>Dữ liệu mẫu đã được thêm đầy đủ.</p>";
    echo "<hr>";
    echo "<h3>👉 Bước tiếp theo:</h3>";
    echo "<ul>
            <li><a href='index.php' style='font-size: 20px; font-weight: bold;'>Bấm vào đây để vào trang chủ Web</a></li>
            <li>Sau khi kiểm tra web chạy ổn, hãy báo để tôi xóa file này.</li>
          </ul>";

} catch (PDOException $e) {
    echo "<h2 style='color: red;'>❌ Lỗi CSDL:</h2>";
    echo "<div style='background: #fee; padding: 20px; border-radius: 10px; border: 1px solid red;'>";
    echo "<strong>Mã lỗi:</strong> " . $e->getCode() . "<br>";
    echo "<strong>Thông báo:</strong> " . $e->getMessage();
    echo "</div>";
    echo "<p>Vui lòng kiểm tra lại <code>DATABASE_URL</code> trên Render.</p>";
} catch (Exception $e) {
    echo "<h2 style='color: red;'>❌ Lỗi hệ thống:</h2>";
    echo "<p>" . $e->getMessage() . "</p>";
}

echo "</body></html>";
?>
