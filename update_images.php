<?php
/**
 * NHK Mobile - Image Path Updater
 *
 * Script này cập nhật tên ảnh trong database từ tên cũ
 * sang convention mới: brand-model-slug.png
 * Chạy một lần, sau đó xóa file này.
 */
session_start();
require_once 'includes/db.php';

if (!isset($_GET['confirm']) && !isset($_SESSION['admin_id'])) {
    die("Truy cập: update_images.php?confirm=yes để chạy script này.");
}

$imageMap = [
    // Old name => New name
    'ai_ip17_pm.png'        => 'apple-iphone-17-pro-max.png',
    'ai_ip16_pro.png'       => 'apple-iphone-16-pro.png',
    'ai_ip16e.png'          => 'apple-iphone-16e.png',
    'ai_ip15_pm.png'        => 'apple-iphone-15-pro-max.png',
    'ai_s25_ultra.png'      => 'samsung-galaxy-s25-ultra.png',
    'ai_s24_ultra.png'      => 'samsung-galaxy-s24-ultra.png',
    'ai_s23.png'            => 'samsung-galaxy-s23.png',
    'ai_mi17_ultra.png'     => 'xiaomi-17-ultra.png',
    'ai_mi15t.png'          => 'xiaomi-15t.png',
    'ai_mi_flip.png'        => 'xiaomi-mix-flip.png',
    'oppo_findx10.png'      => 'oppo-find-x10.png',
    'oppo_k300.png'         => 'oppo-k300.png',
    'oppo_mixflip5090.png'  => 'oppo-mix-flip-5090.png',
    'oneplus13.png'         => 'oneplus-13.png',
    'oneplus15.png'         => 'oneplus-15.png',
    'oneplus15r.png'        => 'oneplus-15r.png',
    'realme_gt8pro.png'     => 'realme-gt8-pro.png',
    'realme_gt9.png'        => 'realme-gt9.png',
    'realmegt8problue.png'  => 'realme-gt8-pro-blue.png',
    'ai_realme_gt7.png'     => 'realme-gt7.png',
    'ai_vivo_x200_black.png'=> 'vivo-x200-black.png',
    'ai_vivo_x200.png'      => 'vivo-x200-black.png',
    'ai_vivo_x300.png'      => 'vivo-x300.png',
    'honor_magic10.png'     => 'honor-magic-10.png',
    'honor_magic9.png'      => 'honor-magic-9.png',
    'nubia_magic15.png'     => 'nubia-magic-15.png',
    'nubia_v1000.png'       => 'nubia-v1000.png',
    'nubia_v90.png'         => 'nubia-v90.png',
    'samsung_s25.png'       => 'samsung-galaxy-s25-ultra.png',
    'xiaomi_15.png'         => 'xiaomi-17-ultra.png',
];

try {
    $pdo->beginTransaction();
    $updated = 0;
    $skipped = 0;

    foreach ($imageMap as $oldName => $newName) {
        $stmt = $pdo->prepare("UPDATE products SET image = ? WHERE image = ?");
        $stmt->execute([$newName, $oldName]);
        $rows = $stmt->rowCount();
        if ($rows > 0) {
            echo "✅ Updated: <code>$oldName</code> → <code>$newName</code> ($rows sản phẩm)<br>";
            $updated += $rows;
        } else {
            $skipped++;
        }
    }

    $pdo->commit();
    echo "<br><hr>";
    echo "<h3>✅ Hoàn tất!</h3>";
    echo "<p>Đã cập nhật: <strong>$updated</strong> bản ghi</p>";
    echo "<p>Bỏ qua (không tìm thấy): <strong>$skipped</strong></p>";
    echo "<br><a href='index.php' style='background:#007AFF;color:#fff;padding:10px 20px;border-radius:8px;text-decoration:none;font-weight:bold;'>Về trang chủ</a>";
    echo " &nbsp; <a href='product.php' style='background:#34c759;color:#fff;padding:10px 20px;border-radius:8px;text-decoration:none;font-weight:bold;'>Xem sản phẩm</a>";

} catch (Exception $e) {
    $pdo->rollBack();
    die("<strong>❌ Lỗi:</strong> " . $e->getMessage());
}
?>
