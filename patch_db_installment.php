<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);

require_once 'includes/db.php';

echo "<h2>Database Patch: Adding 'is_installment' to 'orders'</h2>";

try {
    // Check if column exists
    $stmt = $pdo->prepare("
        SELECT count(*) 
        FROM information_schema.columns 
        WHERE table_name = 'orders' 
        AND column_name = 'is_installment'
    ");
    $stmt->execute();
    $columnExists = (int)$stmt->fetchColumn() > 0;

    if (!$columnExists) {
        $pdo->exec("ALTER TABLE orders ADD COLUMN is_installment BOOLEAN DEFAULT FALSE");
        echo "<p style='color: green;'> Bổ sung cột 'is_installment' thành công!</p>";
    } else {
        echo "<p style='color: orange;'> Cột 'is_installment' đã tồn tại. Không cần thực hiện gì thêm.</p>";
    }

    echo "<p><a href='index.php'>Quay lại Trang chủ</a></p>";

} catch (PDOException $e) {
    echo "<p style='color: red;'> Lỗi: " . $e->getMessage() . "</p>";
}
