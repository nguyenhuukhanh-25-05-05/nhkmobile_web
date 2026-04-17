<?php
/**
 * Script tạo tài khoản Admin - Chạy 1 lần rồi XOÁ FILE NÀY
 */
require_once __DIR__ . '/includes/db.php';

$username = 'admin';
$password = 'admin123';
$hashedPassword = password_hash($password, PASSWORD_DEFAULT);

try {
    // Xoá admin cũ nếu có (tránh lỗi trùng username)
    $pdo->prepare("DELETE FROM admins WHERE username = ?")->execute([$username]);

    // Tạo admin mới
    $stmt = $pdo->prepare("INSERT INTO admins (username, password) VALUES (?, ?)");
    $stmt->execute([$username, $hashedPassword]);

    echo "<h2>Tao tai khoan admin thanh cong!</h2>";
    echo "<p><b>Username:</b> $username</p>";
    echo "<p><b>Password:</b> $password</p>";
    echo "<p style='color:red;font-weight:bold;'>HAY XOA FILE create_admin.php NGAY SAU KHI SU DUNG!</p>";
    echo "<p><a href='login.php'>Dang nhap ngay</a></p>";
} catch (PDOException $e) {
    echo "<h2>Loi:</h2><p>" . htmlspecialchars($e->getMessage()) . "</p>";
}
?>
