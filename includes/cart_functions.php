<?php
/**
 * NHK Mobile - Cart Persistence Services
 * 
 * Description: Specialized logic for bidirectional synchronization 
 * between client-side PHP sessions and server-side database storage. 
 * Ensures cart contents persist across devices and sessions.
 * 
 * Author: NguyenHuuKhanh
 * Version: 2.2
 * Date: 2026-04-08
 */

/**
 * Đồng bộ giỏ hàng của người dùng với cơ sở dữ liệu.
 * - Nếu session rỗng: Tải dữ liệu giỏ hàng từ DB lên session.
 * - Nếu session có hàng: Lưu đè dữ liệu từ session xuống DB để đảm bảo tính đồng nhất.
 * 
 * @param PDO $pdo Đối tượng kết nối cơ sở dữ liệu
 */
function syncCartWithDatabase($pdo) {
    if (session_status() === PHP_SESSION_NONE) {
        session_start();
    }
    
    $userId = $_SESSION['user_id'] ?? null;
    $isAdmin = isset($_SESSION['admin_id']);
    $sessionId = session_id();

    // Nếu chưa đăng nhập, chỉ dùng session (không load từ DB)
    if (!$userId && !$isAdmin) {
        if (!isset($_SESSION['cart'])) {
            $_SESSION['cart'] = [];
        }
        return;
    }
    
    // Đối với admin, sử dụng admin_id như user_id tạm thời
    $effectiveUserId = $userId ?? ($isAdmin ? ($_SESSION['admin_id'] ?? null) : null);
    if (!$effectiveUserId) {
        if (!isset($_SESSION['cart'])) {
            $_SESSION['cart'] = [];
        }
        return;
    }
    
    // TRƯỜNG HỢP 1: Session rỗng -> Nạp giỏ hàng từ DB theo user_id
    if (!isset($_SESSION['cart']) || empty($_SESSION['cart'])) {
        try {
            $sql = "SELECT ci.*, p.name, p.price, p.image FROM cart_items ci 
                    JOIN products p ON ci.product_id = p.id 
                    WHERE ci.user_id = ?";
            $stmt = $pdo->prepare($sql);
            $stmt->execute([$effectiveUserId]);
            $items = $stmt->fetchAll();
            
            $_SESSION['cart'] = [];
            foreach ($items as $item) {
                $_SESSION['cart'][$item['product_id']] = [
                    'name'  => $item['name'],
                    'price' => $item['price'],
                    'image' => $item['image'],
                    'qty'   => (int)$item['quantity']
                ];
            }
        } catch (Exception $e) {
            error_log("[Cart] Error loading cart from DB: " . $e->getMessage());
            $_SESSION['cart'] = [];
        }
    } 
    // TRƯỜNG HỢP 2: Session có hàng -> Lưu xuống DB theo user_id
    else {
        try {
            // Xóa những món trong DB mà session không giữ nữa trước
            $productIds = array_keys($_SESSION['cart']);
            if (!empty($productIds)) {
                $placeholders = implode(',', array_fill(0, count($productIds), '?'));
                $stmt = $pdo->prepare("
                    DELETE FROM cart_items 
                    WHERE user_id = ? AND product_id NOT IN ($placeholders)
                ");
                $params = array_merge([$effectiveUserId], $productIds);
                $stmt->execute($params);
            }
            
            // Lưu/Update từng sản phẩm xuống DB
            foreach ($_SESSION['cart'] as $pid => $item) {
                $stmt = $pdo->prepare("
                    INSERT INTO cart_items (user_id, product_id, quantity, session_id) 
                    VALUES (?, ?, ?, ?)
                    ON CONFLICT (user_id, product_id) 
                    DO UPDATE SET quantity = EXCLUDED.quantity, session_id = EXCLUDED.session_id
                ");
                $stmt->execute([$effectiveUserId, $pid, (int)$item['qty'], $sessionId]);
            }
        } catch (Exception $e) {
            error_log("[Cart] Error syncing cart to DB: " . $e->getMessage());
        }
    }
}

/**
 * Xóa một sản phẩm cụ thể khỏi giỏ hàng trong cơ sở dữ liệu.
 * 
 * @param PDO $pdo Đối tượng kết nối cơ sở dữ liệu
 * @param int $pid ID của sản phẩm cần xóa
 */
function removeFromCartDB($pdo, $pid) {
    if (session_status() === PHP_SESSION_NONE) {
        session_start();
    }
    $userId = $_SESSION['user_id'] ?? null;
    $isAdmin = isset($_SESSION['admin_id']);
    
    // Hỗ trợ cả admin và user thường
    $effectiveUserId = $userId ?? ($isAdmin ? ($_SESSION['admin_id'] ?? null) : null);
    if ($effectiveUserId) {
        $stmt = $pdo->prepare("DELETE FROM cart_items WHERE user_id = ? AND product_id = ?");
        $stmt->execute([$effectiveUserId, $pid]);
    }
}
?>
