<?php
session_start();
require_once '../includes/db.php';
require_once '../includes/auth_functions.php';
require_once '../includes/cart_functions.php';

header('Content-Type: application/json');

// NHK MOBILE V2.0 API STANDARDIZATION

// 1. Auth Protection
if (!is_logged_in()) {
    echo json_encode([
        'status' => 'error', 
        'message' => 'Vui lòng đăng nhập để thực hiện thao tác này.'
    ]);
    exit;
}

// 2. CSRF Security
if (!verify_csrf_token()) {
    echo json_encode([
        'status' => 'error', 
        'message' => 'Yêu cầu không hợp lệ (Security mismatch).'
    ]);
    exit;
}

// 3. Input Validation
if (!isset($_POST['product_id'])) {
    echo json_encode([
        'status' => 'error', 
        'message' => 'Thiếu thông tin sản phẩm.'
    ]);
    exit;
}

$productId = (int)$_POST['product_id'];
$installment = isset($_POST['installment']) ? (int)$_POST['installment'] : 0;

try {
    // 4. Fetch Core Data
    $stmt = $pdo->prepare("SELECT id, name, price, image, stock FROM products WHERE id = ?");
    $stmt->execute([$productId]);
    $product = $stmt->fetch();

    if (!$product) {
        throw new Exception('Sản phẩm không tồn tại.');
    }

    if ($product['stock'] <= 0) {
        throw new Exception('Sản phẩm hiện đang tạm hết hàng.');
    }

    // 5. Cart Business Logic
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

    // 6. DB Sync & Response
    syncCartWithDatabase($pdo);

    $cartCount = 0;
    foreach ($_SESSION['cart'] as $item) {
        $cartCount += $item['qty'];
    }

    echo json_encode([
        'status' => 'success', 
        'message' => 'Đã thêm "' . $product['name'] . '" vào giỏ hàng.',
        'cart_count' => $cartCount
    ]);

} catch (Exception $e) {
    echo json_encode([
        'status' => 'error', 
        'message' => $e->getMessage()
    ]);
}
exit;
