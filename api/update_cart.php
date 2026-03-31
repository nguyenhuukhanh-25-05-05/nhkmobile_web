<?php
session_start();
require_once '../includes/db.php';
require_once '../includes/auth_functions.php';
require_once '../includes/cart_functions.php';

header('Content-Type: application/json');

// Verify CSRF token
if (!verify_csrf_token()) {
    echo json_encode(['status' => 'error', 'message' => 'Yêu cầu không hợp lệ (CSRF Token mismatch).']);
    exit;
}

if (!isset($_POST['product_id']) || !isset($_POST['quantity'])) {
    echo json_encode(['status' => 'error', 'message' => 'Thiếu thông tin cập nhật.']);
    exit;
}

$productId = (int)$_POST['product_id'];
$quantity = (int)$_POST['quantity'];

if (!isset($_SESSION['cart'][$productId])) {
    echo json_encode(['status' => 'error', 'message' => 'Sản phẩm không có trong giỏ hàng.']);
    exit;
}

if ($quantity <= 0) {
    unset($_SESSION['cart'][$productId]);
    removeFromCartDB($pdo, $productId);
} else {
    // Check stock
    $stmt = $pdo->prepare("SELECT stock FROM products WHERE id = ?");
    $stmt->execute([$productId]);
    $stock = $stmt->fetchColumn();
    
    if ($quantity > $stock) {
        $quantity = $stock;
        $message = "Chỉ còn $stock sản phẩm trong kho.";
    }
    
    $_SESSION['cart'][$productId]['qty'] = $quantity;
    syncCartWithDatabase($pdo);
}

// Recalculate totals
$cartCount = 0;
$total = 0;
$subtotal = 0;
if (isset($_SESSION['cart'][$productId])) {
    $subtotal = $_SESSION['cart'][$productId]['price'] * $_SESSION['cart'][$productId]['qty'];
}

foreach ($_SESSION['cart'] as $item) {
    $cartCount += $item['qty'];
    $total += $item['price'] * $item['qty'];
}

echo json_encode([
    'status' => 'success',
    'message' => $message ?? 'Đã cập nhật giỏ hàng.',
    'cart_count' => $cartCount,
    'item_subtotal' => number_format($subtotal, 0, ',', '.') . '₫',
    'cart_total' => number_format($total, 0, ',', '.') . '₫',
    'is_removed' => ($quantity <= 0)
]);
exit;
