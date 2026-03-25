<?php
session_start();
require_once '../includes/db.php';
require_once '../includes/cart_functions.php';

header('Content-Type: application/json');

$input = json_decode(file_get_contents('php://input'), true);
$productId = isset($input['product_id']) ? (int)$input['product_id'] : 0;
$newQty = isset($input['qty']) ? (int)$input['qty'] : 0;

if ($productId <= 0 || !isset($_SESSION['cart'][$productId])) {
    echo json_encode(['success' => false, 'message' => 'Sản phẩm không hợp lệ']);
    exit;
}

if ($newQty <= 0) {
    unset($_SESSION['cart'][$productId]);
    removeFromCartDB($pdo, $productId);
    $removed = true;
} else {
    $_SESSION['cart'][$productId]['qty'] = $newQty;
    syncCartWithDatabase($pdo);
    $removed = false;
}

// Recalculate totals
$total = 0;
foreach ($_SESSION['cart'] as $id => $item) {
    $total += $item['price'] * $item['qty'];
}

$subtotal = $removed ? 0 : ($_SESSION['cart'][$productId]['price'] * $newQty);

echo json_encode([
    'success' => true,
    'removed' => $removed,
    'new_qty' => $newQty,
    'subtotal' => number_format($subtotal, 0, ',', '.') . '₫',
    'total' => number_format($total, 0, ',', '.') . '₫'
]);
