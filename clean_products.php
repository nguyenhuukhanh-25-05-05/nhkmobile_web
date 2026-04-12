<?php
require_once 'includes/db.php';

try {
    // 1. Tìm các sản phẩm trùng tên
    $sql = "SELECT name, COUNT(*) as count FROM products GROUP BY name HAVING COUNT(*) > 1";
    $stmt = $pdo->query($sql);
    $duplicates = $stmt->fetchAll();

    if (empty($duplicates)) {
        echo "Không tìm thấy sản phẩm nào bị trùng lặp.";
    } else {
        echo "<h2>Danh sách sản phẩm trùng lặp:</h2>";
        foreach ($duplicates as $d) {
            echo "- " . htmlspecialchars($d['name']) . " (" . $d['count'] . " bản ghi)<br>";
        }

        // 2. Thực hiện xóa các bản ghi trùng lặp, chỉ giữ lại bản ghi có ID nhỏ nhất
        // Trong Postgres, ta có thể dùng CTID hoặc ID
        $deleteSql = "
            DELETE FROM products 
            WHERE id IN (
                SELECT id 
                FROM (
                    SELECT id, ROW_NUMBER() OVER (PARTITION BY name ORDER BY id ASC) as row_num 
                    FROM products
                ) t 
                WHERE t.row_num > 1
            )
        ";
        
        $pdo->beginTransaction();
        
        // Trước khi xóa sản phẩm, cần xử lý các ràng buộc (giỏ hàng, đánh giá, chi tiết đơn hàng)
        // Tuy nhiên do trong reset_database đã thiết lập ON DELETE CASCADE/SET NULL nên ta có thể xóa trực tiếp
        
        $countDeleted = $pdo->exec($deleteSql);
        $pdo->commit();
        
        echo "<br><strong>Đã xóa thành công $countDeleted bản ghi trùng lặp!</strong>";
    }
    
    echo "<br><br><a href='index.php'>Quay về trang chủ</a>";

} catch (Exception $e) {
    if ($pdo->inTransaction()) $pdo->rollBack();
    echo "Lỗi: " . $e->getMessage();
}
?>