<?php 
session_start();
require_once 'includes/db.php';
$id = isset($_GET['id']) ? $_GET['id'] : null;

if (!$id) {
    header("Location: product.php");
    exit;
}

$stmt = $pdo->prepare("SELECT * FROM products WHERE id = ?");
$stmt->execute([$id]);
$product = $stmt->fetch();

if (!$product) {
    die("Sản phẩm không tồn tại!");
}

$pageTitle = "NHK Mobile | " . $product['name'];
$basePath = "";
include 'includes/header.php';
?>

<main>
    <section class="mt-5">
        <div class="container-wide">
            <div class="row g-5 align-items-center">
                <!-- Product Image -->
                <div class="col-lg-6">
                    <div class="bg-light p-5 rounded-4 text-center border">
                        <img src="assets/images/<?php echo $product['image']; ?>" class="img-fluid" 
                             alt="<?php echo $product['name']; ?>" 
                             style="max-height: 600px;"
                             onerror="this.src='https://placehold.co/600x800/f5f5f7/1d1d1f?text=Phone'">
                    </div>
                </div>

                <!-- Product Info -->
                <div class="col-lg-6">
                    <div class="ps-lg-5">
                        <nav aria-label="breadcrumb" class="mb-4">
                            <ol class="breadcrumb small">
                                <li class="breadcrumb-item"><a href="product.php" class="text-muted">Sản phẩm</a></li>
                                <li class="breadcrumb-item active text-primary fw-bold"><?php echo $product['category']; ?></li>
                            </ol>
                        </nav>
                        
                        <h1 class="display-4 fw-bold mb-3"><?php echo $product['name']; ?></h1>
                        <p class="h2 text-primary fw-bold mb-4"><?php echo number_format($product['price'], 0, ',', '.'); ?>₫</p>
                        
                        <div class="mb-5">
                            <h5 class="fw-bold mb-3 text-uppercase small letter-spacing text-muted">Mô tả sản phẩm</h5>
                            <p class="text-secondary leading-relaxed fs-5">
                                <?php echo nl2br($product['description'] ? $product['description'] : 'Trải nghiệm công nghệ đỉnh cao với thiết kế tinh tế và hiệu năng mạnh mẽ nhất hiện nay.'); ?>
                            </p>
                        </div>

                        <div class="d-flex flex-column gap-3">
                            <?php if ($product['stock'] > 0): ?>
                                <a href="cart.php?add=<?php echo $product['id']; ?>" class="btn-main btn-primary w-100 py-3 fs-5">Thêm vào giỏ hàng</a>
                                <a href="cart.php?add=<?php echo $product['id']; ?>&installment=1" class="btn-main btn-outline w-100 py-3 fs-5">Mua trả góp 0%</a>
                            <?php else: ?>
                                <button class="btn-main btn-outline w-100 py-3 fs-5" disabled>Hết hàng</button>
                            <?php endif; ?>
                        </div>

                        <!-- Trust badges -->
                        <div class="row g-4 mt-5">
                            <div class="col-6">
                                <div class="d-flex align-items-center gap-3">
                                    <div class="nav-icon bg-light"><i class="bi bi-shield-check text-primary"></i></div>
                                    <span class="small fw-bold">Bảo hành 12 tháng</span>
                                </div>
                            </div>
                            <div class="col-6">
                                <div class="d-flex align-items-center gap-3">
                                    <div class="nav-icon bg-light"><i class="bi bi-truck text-primary"></i></div>
                                    <span class="small fw-bold">Giao hàng miễn phí</span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Reviews Section -->
            <div class="mt-5 pt-5 border-top">
                <div class="section-title-box text-start mb-5">
                    <span class="section-subtitle">Phản hồi khách hàng</span>
                    <h2 class="display-5 fw-bold">Đánh giá & Nhận xét.</h2>
                </div>

                <div class="row g-5">
                    <div class="col-lg-4">
                        <div class="bg-light p-5 rounded-4 text-center border">
                            <h1 class="display-2 fw-bold mb-0" id="avg-rating">0.0</h1>
                            <div class="text-warning fs-3 my-3" id="star-rating">
                                <i class="bi bi-star"></i><i class="bi bi-star"></i><i class="bi bi-star"></i><i class="bi bi-star"></i><i class="bi bi-star"></i>
                            </div>
                            <p class="text-muted mb-0" id="total-reviews">0 đánh giá</p>
                        </div>
                    </div>

                    <div class="col-lg-8">
                        <div class="card border-0 bg-light rounded-4 mb-5 shadow-sm">
                            <div class="card-body p-4 p-md-5">
                                <h4 class="fw-bold mb-4">Viết đánh giá của bạn</h4>
                                <form id="review-form">
                                    <input type="hidden" id="product_id" value="<?php echo $product['id']; ?>">
                                    <div class="mb-4">
                                        <label class="form-label text-muted fw-bold small">MỨC ĐỘ HÀI LÒNG</label>
                                        <div class="rating-select text-warning fs-2" style="cursor: pointer;">
                                            <i class="bi bi-star rating-star" data-value="1"></i>
                                            <i class="bi bi-star rating-star" data-value="2"></i>
                                            <i class="bi bi-star rating-star" data-value="3"></i>
                                            <i class="bi bi-star rating-star" data-value="4"></i>
                                            <i class="bi bi-star rating-star" data-value="5"></i>
                                        </div>
                                        <input type="hidden" id="rating_val" value="5">
                                    </div>
                                    
                                    <div class="row g-3 mb-3">
                                        <?php if(!isset($_SESSION['user_id']) && !isset($_SESSION['admin_id'])): ?>
                                            <div class="col-md-6">
                                                <input type="text" class="form-control rounded-3 py-3" id="reviewer_name" placeholder="Tên của bạn *" required>
                                            </div>
                                            <div class="col-md-6">
                                                <input type="email" class="form-control rounded-3 py-3" id="reviewer_email" placeholder="Email (không bắt buộc)">
                                            </div>
                                        <?php endif; ?>
                                        <div class="col-12">
                                            <input type="text" class="form-control rounded-3 py-3" id="review_title" placeholder="Tiêu đề đánh giá">
                                        </div>
                                        <div class="col-12">
                                            <textarea class="form-control rounded-3 py-3" id="review_content" rows="4" placeholder="Chia sẻ trải nghiệm của bạn về sản phẩm này *" required></textarea>
                                        </div>
                                        <div class="col-12">
                                            <label class="form-label text-muted fw-bold small">HÌNH ẢNH MINH HỌA</label>
                                            <input type="file" id="review_image" class="form-control rounded-3" accept="image/*">
                                        </div>
                                    </div>
                                    <button type="submit" class="btn-main btn-primary px-5">Gửi đánh giá</button>
                                    <div id="review-msg" class="mt-3"></div>
                                </form>
                            </div>
                        </div>

                        <div id="reviews-list">
                            <div class="text-center py-5"><div class="spinner-border text-primary"></div></div>
                        </div>
                        
                        <div class="text-center mt-5">
                            <button id="load-more-btn" class="btn-main btn-outline d-none">Xem thêm đánh giá</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</main>

<style>
.text-warning, .rating-star.bi-star-fill, #star-rating .bi-star-fill, #star-rating .bi-star-half { color: #FF9500 !important; }
.breadcrumb-item + .breadcrumb-item::before { content: "•"; color: var(--text-muted); }
</style>

<script>
document.addEventListener('DOMContentLoaded', () => {
    const productId = document.getElementById('product_id').value;
    let currentPage = 1;
    const limit = 5;
    
    const stars = document.querySelectorAll('.rating-star');
    const ratingInput = document.getElementById('rating_val');
    
    function updateStars(val) {
        stars.forEach(star => {
            if(parseInt(star.dataset.value) <= val) {
                star.classList.remove('bi-star');
                star.classList.add('bi-star-fill');
            } else {
                star.classList.remove('bi-star-fill');
                star.classList.add('bi-star');
            }
        });
    }
    
    updateStars(5);
    
    stars.forEach(star => {
        star.addEventListener('click', (e) => {
            const val = parseInt(e.target.dataset.value);
            ratingInput.value = val;
            updateStars(val);
        });
    });

    const loadReviews = async (page = 1) => {
        try {
            const res = await fetch(`api/reviews.php?id=${productId}&page=${page}&limit=${limit}`);
            const data = await res.json();
            
            if(data.success) {
                renderReviews(data.reviews, page === 1);
                updateMeta(data.meta);
                
                const loadMoreBtn = document.getElementById('load-more-btn');
                if(data.meta.page < data.meta.total_pages) {
                    loadMoreBtn.classList.remove('d-none');
                    loadMoreBtn.onclick = () => loadReviews(page + 1);
                } else {
                    loadMoreBtn.classList.add('d-none');
                }
            }
        } catch(err) {
            console.error(err);
        }
    };
    
    const updateMeta = (meta) => {
        document.getElementById('avg-rating').innerText = meta.avg_rating.toFixed(1);
        document.getElementById('total-reviews').innerText = `${meta.total} đánh giá`;
        
        let starHtml = '';
        const fullStars = Math.floor(meta.avg_rating);
        const hasHalf = meta.avg_rating - fullStars >= 0.5;
        for(let i=0; i<fullStars; i++) starHtml += '<i class="bi bi-star-fill"></i> ';
        if(hasHalf) starHtml += '<i class="bi bi-star-half"></i> ';
        const emptyStars = 5 - fullStars - (hasHalf ? 1 : 0);
        for(let i=0; i<emptyStars; i++) starHtml += '<i class="bi bi-star"></i> ';
        document.getElementById('star-rating').innerHTML = starHtml;
    };
    
    const renderReviews = (reviews, clear = false) => {
        const list = document.getElementById('reviews-list');
        if(clear) list.innerHTML = '';
        if(reviews.length === 0 && clear) {
            list.innerHTML = '<div class="text-center py-5 border rounded-4 bg-light"><p class="text-muted mb-0">Chưa có đánh giá nào. Hãy là người đầu tiên!</p></div>';
            return;
        }
        
        reviews.forEach(r => {
            let stars = '';
            for(let i=0; i<5; i++) {
                stars += i < r.rating ? '<i class="bi bi-star-fill text-warning"></i> ' : '<i class="bi bi-star text-warning"></i> ';
            }
            
            const html = `
                <div class="py-4 border-bottom">
                    <div class="d-flex align-items-center mb-3">
                        <div class="bg-dark text-white rounded-circle d-flex align-items-center justify-content-center fw-bold me-3" style="width: 44px; height: 44px; font-size: 18px;">
                            ${r.avatar_letter}
                        </div>
                        <div>
                            <h6 class="fw-bold mb-0">${r.reviewer_name} ${r.verified_purchase ? '<span class="ms-2 badge bg-success bg-opacity-10 text-success rounded-pill px-2 py-1" style="font-size: 10px;"><i class="bi bi-patch-check-fill me-1"></i>Đã mua hàng</span>' : ''}</h6>
                            <div class="small text-muted">${stars} <span class="ms-2">/ ${r.date_formatted}</span></div>
                        </div>
                    </div>
                    ${r.title ? `<h6 class="fw-bold mb-2">${r.title}</h6>` : ''}
                    <p class="mb-0 text-secondary" style="line-height: 1.6;">${r.content}</p>
                    ${r.image ? `<div class="mt-3"><img src="assets/images/reviews/${r.image}" class="img-fluid rounded-3 border" style="max-height: 150px; cursor: pointer;" onclick="window.open(this.src)"></div>` : ''}
                </div>
            `;
            list.insertAdjacentHTML('beforeend', html);
        });
    };
    
    document.getElementById('review-form').addEventListener('submit', async(e) => {
        e.preventDefault();
        const msg = document.getElementById('review-msg');
        const btn = e.target.querySelector('button[type="submit"]');
        
        btn.disabled = true;
        msg.innerHTML = '<span class="text-primary small">Đang gửi đánh giá...</span>';
        
        const formData = new FormData();
        formData.append('product_id', parseInt(productId));
        formData.append('rating', parseInt(document.getElementById('rating_val').value));
        formData.append('title', document.getElementById('review_title').value);
        formData.append('content', document.getElementById('review_content').value);
        
        const nameEl = document.getElementById('reviewer_name');
        if(nameEl) formData.append('reviewer_name', nameEl.value);
        const emailEl = document.getElementById('reviewer_email');
        if(emailEl) formData.append('reviewer_email', emailEl.value);
        
        const fileInput = document.getElementById('review_image');
        if(fileInput && fileInput.files.length > 0) {
            formData.append('image', fileInput.files[0]);
        }
        
        try {
            const res = await fetch('api/reviews.php', { method: 'POST', body: formData });
            const data = await res.json();
            if(data.success) {
                msg.innerHTML = `<span class="text-success small fw-bold"><i class="bi bi-check-circle-fill me-1"></i> Đánh giá đã được gửi!</span>`;
                e.target.reset();
                updateStars(5);
                loadReviews(1);
            } else {
                msg.innerHTML = `<span class="text-danger small">${data.error}</span>`;
            }
        } catch(err) {
            msg.innerHTML = `<span class="text-danger small">Lỗi kết nối</span>`;
        } finally {
            btn.disabled = false;
        }
    });

    loadReviews();
});
</script>

<?php include 'includes/footer.php'; ?>
