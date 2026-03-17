<?php
/**
 * TỆP KẾT NỐI CƠ SỞ DỮ LIỆU POSTGRESQL
 * Sử dụng PDO (PHP Data Objects) để đảm bảo an toàn và bảo mật cho ứng dụng.
 * Hỗ trợ Biến môi trường (Environment Variables) để dễ dàng triển khai lên Render.com
 */

// Lấy thông tin kết nối từ biến môi trường (Nếu có), nếu không thì dùng giá trị mặc định Localhost
// Lấy thông tin kết nối từ biến môi trường (Ưu tiên dùng $_ENV hoặc $_SERVER)
$host = $_ENV['DB_HOST'] ?? $_SERVER['DB_HOST'] ?? getenv('DB_HOST') ?: 'localhost';
$port = $_ENV['DB_PORT'] ?? $_SERVER['DB_PORT'] ?? getenv('DB_PORT') ?: '5432';
$db   = $_ENV['DB_NAME'] ?? $_SERVER['DB_NAME'] ?? getenv('DB_NAME') ?: 'web_ban_dien_thoai';
$user = $_ENV['DB_USER'] ?? $_SERVER['DB_USER'] ?? getenv('DB_USER') ?: 'postgres';
$pass = $_ENV['DB_PASS'] ?? $_SERVER['DB_PASS'] ?? getenv('DB_PASS') ?: '123456';

// Chuỗi kết nối DSN
$dsn = "pgsql:host=$host;port=$port;dbname=$db";

$options = [
    PDO::ATTR_ERRMODE            => PDO::ERRMODE_EXCEPTION, // Bật chế độ báo lỗi exception
    PDO::ATTR_DEFAULT_FETCH_MODE => PDO::FETCH_ASSOC,       // Dữ liệu trả về dạng mảng kết hợp
    PDO::ATTR_EMULATE_PREPARES   => false,                  // Sử dụng prepared statements thật
];

try {
     // Khởi tạo đối tượng kết nối $pdo
     $pdo = new PDO($dsn, $user, $pass, $options);
} catch (\PDOException $e) {
     // Nếu có lỗi, dừng chương trình và thông báo
     die("Lỗi kết nối CSDL: " . $e->getMessage());
}
?>
