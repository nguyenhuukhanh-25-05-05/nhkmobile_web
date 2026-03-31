<?php
session_start();
require_once '../includes/db.php';
require_once '../includes/auth_functions.php';
require_once '../includes/cart_functions.php';

header('Content-Type: application/json');

// Check if user is logged in
if (!is_logged_in()) {
    echo json_encode(['status' => 'unauthorized', 'message' => 'Vui lòng đăng nhập để mua hàng.']);
    exit;
}

// Verify CSRF token
if (!verify_csrf_token()) {
    echo json_encode(['status' => 'error', 'message' => 'Yêu cầu không hợp lệ (CSRF Token mismatch).']);
    exit;
}

if (!isset($_POST['product_id'])) {
    echo json_encode(['status' => 'error', 'message' => 'Thiếu ID sản phẩm.']);
    exit;
}

$productId = (int)$_POST['product_id'];
$installment = isset($_POST['installment']) ? (int)$_POST['installment'] : 0;

// Fetch product details
$stmt = $pdo->prepare("SELECT * FROM products WHERE id = ?");
$stmt->execute([$productId]);
$product = $stmt->fetch();

if (!$product) {
    echo json_encode(['status' => 'error', 'message' => 'Sản phẩm không tồn tại.']);
    exit;
}

if ($product['stock'] <= 0) {
    echo json_encode(['status' => 'error', 'message' => 'Sản phẩm hiện đang hết hàng.']);
    exit;
}

// Logic add to cart (similar to cart.php but for JSON response)
if ($installment === 1) {
    $_SESSION['cart'] = [];
    $_SESSION['is_installment'] = true;
} else {
    $_SESSION['is_installment'] = false;
}

if (!isset($_SESSION['cart'])) {
    $_SESSION['cart'] = [];
}

if (isset($_SESSION['cart'][$productId])) {
    $_SESSION['cart'][$productId]['qty']++;
} else {
    $_SESSION['cart'][$productId] = [
        'name' => $product['name'],
        'price' => $product['price'],
        'image' => $product['image'],
        'qty' => 1
    ];
}

// Sync with DB
syncCartWithDatabase($pdo);

// Calculate new cart count
$cartCount = 0;
foreach ($_SESSION['cart'] as $item) {
    $cartCount += $item['qty'];
}

echo json_encode([
    'status' => 'success', 
    'message' => 'Đã thêm "' . $product['name'] . '" vào giỏ hàng!',
    'cart_count' => $cartCount
]);
exit;
