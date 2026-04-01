<?php
session_start();
require_once 'includes/db.php';

// Xử lý tìm kiếm, lọc danh mục và sắp xếp
$category = isset($_GET['category']) ? $_GET['category'] : null;
$search = isset($_GET['q']) ? $_GET['q'] : null;
$sort = isset($_GET['sort']) ? $_GET['sort'] : 'newest';

// Lấy danh sách tất cả các hãng (Categories) từ DB để làm bộ lọc động
$stmtCats = $pdo->query("SELECT DISTINCT category FROM products ORDER BY category ASC");
$categories = $stmtCats->fetchAll(PDO::FETCH_COLUMN);

// Xây dựng câu lệnh SQL cơ bản
$sql = "SELECT * FROM products WHERE 1=1";
$params = [];

if ($category) {
    $sql .= " AND category = ?";
    $params[] = $category;
}

if ($search) {
    $sql .= " AND name ILIKE ?";
    $params[] = "%$search%";
}

switch ($sort) {
    case 'price_asc':
        $sql .= " ORDER BY price ASC";
        break;
    case 'price_desc':
        $sql .= " ORDER BY price DESC";
        break;
    default:
        $sql .= " ORDER BY created_at DESC";
        break;
}

$stmt = $pdo->prepare($sql);
$stmt->execute($params);
$products = $stmt->fetchAll();

$pageTitle = $search ? "Kết quả tìm kiếm: $search" : ($category ? "Điện thoại $category" : "Tất cả điện thoại");
$basePath = "";

include 'includes/header.php';
?>

<style>
.filter-brands-scroll::-webkit-scrollbar { display: none; }
.filter-brands-scroll { -ms-overflow-style: none; scrollbar-width: none; }
.btn-filter { 
    background: var(--bg-gray);
    border: 1px solid var(--border-light);
    color: var(--text-secondary);
    border-radius: 980px;
    padding: 8px 24px;
    font-size: 14px;
    font-weight: 500;
    white-space: nowrap;
    transition: all 0.2s;
}
.btn-filter:hover {
    background: var(--bg-white);
    border-color: var(--primary);
    color: var(--primary);
}
.btn-filter.active {
    background: var(--text-main);
    color: #fff;
    border-color: var(--text-main);
}
</style>

<main>
    <section class="mt-5">
        <div class="container-wide">
            <!-- Header Page -->
            <div class="d-flex flex-column gap-4 mb-5">
                <div class="d-flex flex-column flex-md-row justify-content-between align-items-md-end gap-3">
                    <div>
                        <span class="section-subtitle">Danh mục sản phẩm</span>
                        <h1 class="display-4 fw-bold mb-0">
                            <?php echo $search ? "Kết quả cho <span class='text-primary'>'$search'</span>" : ($category ? $category : "Tất cả sản phẩm."); ?>
                        </h1>
                        <p class="text-muted mt-2">Tìm thấy <?php echo count($products); ?> siêu phẩm công nghệ.</p>
                    </div>
                    
                    <!-- Sort -->
                    <div class="sort-wrapper">
                         <form action="product.php" method="GET" id="sortForm" class="d-flex align-items-center gap-2">
                              <?php if($category): ?><input type="hidden" name="category" value="<?php echo $category; ?>"><?php endif; ?>
                              <?php if($search): ?><input type="hidden" name="q" value="<?php echo $search; ?>"><?php endif; ?>
                              <span class="text-muted small fw-bold text-uppercase">Sắp xếp:</span>
                              <select name="sort" class="form-select form-select-sm border-0 bg-light rounded-pill px-3 py-2 cursor-pointer shadow-sm" onchange="this.form.submit()">
                                   <option value="newest" <?php echo $sort == 'newest' ? 'selected' : ''; ?>>Mới nhất</option>
                                   <option value="price_asc" <?php echo $sort == 'price_asc' ? 'selected' : ''; ?>>Giá: Thấp đến Cao</option>
                                   <option value="price_desc" <?php echo $sort == 'price_desc' ? 'selected' : ''; ?>>Giá: Cao đến Thấp</option>
                              </select>
                         </form>
                    </div>
                </div>

                <!-- Category Filters -->
                <div class="filter-brands-scroll d-flex gap-2 overflow-auto pb-2">
                    <a href="product.php" class="btn-filter <?php echo !$category ? 'active' : ''; ?>">Tất cả</a>
                    <?php foreach($categories as $cat): ?>
                         <a href="product.php?category=<?php echo urlencode($cat); ?>" 
                            class="btn-filter <?php echo $category == $cat ? 'active' : ''; ?>">
                            <?php echo $cat; ?>
                         </a>
                    <?php endforeach; ?>
                </div>
            </div>

            <!-- Product List -->
            <div class="product-grid-new">
                <?php if (empty($products)): ?>
                    <div class="col-12 text-center py-5">
                        <i class="bi bi-search display-1 mb-4 opacity-10"></i>
                        <p class="h5 text-muted">Không tìm thấy sản phẩm nào phù hợp.</p>
                        <a href="product.php" class="btn-main btn-primary mt-4">Quay lại cửa hàng</a>
                    </div>
                <?php else: ?>
                    <?php foreach ($products as $p): ?>
                        <div class="product-card-new">
                            <a href="product-detail.php?id=<?php echo $p['id']; ?>">
                                <div class="product-img-box">
                                    <img src="assets/images/<?php echo $p['image']; ?>" alt="<?php echo $p['name']; ?>"
                                        onerror="this.src='https://placehold.co/300x400/f5f5f7/1d1d1f?text=Phone'">
                                </div>
                                <div class="product-info-new">
                                    <span class="p-cat"><?php echo $p['category']; ?></span>
                                    <h3 class="p-name"><?php echo $p['name']; ?></h3>
                                    <div class="p-price-new"><?php echo number_format($p['price'], 0, ',', '.'); ?>₫</div>
                                </div>
                            </a>
                            <a href="cart_functions.php?action=add&id=<?php echo $p['id']; ?>" class="add-to-cart-btn">
                                <i class="bi bi-plus-lg"></i>
                            </a>
                        </div>
                    <?php endforeach; ?>
                <?php endif; ?>
            </div>
        </div>
    </section>
</main>

<?php include 'includes/footer.php'; ?>
