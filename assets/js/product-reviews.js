/**
 * NHK MOBILE - PRODUCT REVIEWS HANDLER (JS Separation v1.0)
 * Handles star rating selection, fetching reviews via AJAX, and form submission.
 */

document.addEventListener('DOMContentLoaded', () => {
    const productIdEl = document.getElementById('product_id');
    if (!productIdEl) return;
    
    const productId = productIdEl.value;
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
    
    // Initial state
    if (ratingInput) updateStars(parseInt(ratingInput.value) || 5);
    
    stars.forEach(star => {
        star.addEventListener('click', (e) => {
            const val = parseInt(e.target.dataset.value);
            if (ratingInput) ratingInput.value = val;
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
                if (loadMoreBtn) {
                    if(data.meta.page < data.meta.total_pages) {
                        loadMoreBtn.classList.remove('d-none');
                        loadMoreBtn.onclick = () => loadReviews(page + 1);
                    } else {
                        loadMoreBtn.classList.add('d-none');
                    }
                }
            }
        } catch(err) {
            console.error("Lỗi tải đánh giá:", err);
        }
    };
    
    const updateMeta = (meta) => {
        const avgEl = document.getElementById('avg-rating');
        const totalEl = document.getElementById('total-reviews');
        const starRatingEl = document.getElementById('star-rating');

        if (avgEl) avgEl.innerText = meta.avg_rating.toFixed(1);
        if (totalEl) totalEl.innerText = `${meta.total} đánh giá`;
        
        if (starRatingEl) {
            let starHtml = '';
            const fullStars = Math.floor(meta.avg_rating);
            const hasHalf = meta.avg_rating - fullStars >= 0.5;
            for(let i=0; i<fullStars; i++) starHtml += '<i class="bi bi-star-fill"></i> ';
            if(hasHalf) starHtml += '<i class="bi bi-star-half"></i> ';
            const emptyStars = 5 - fullStars - (hasHalf ? 1 : 0);
            for(let i=0; i<emptyStars; i++) starHtml += '<i class="bi bi-star"></i> ';
            starRatingEl.innerHTML = starHtml;
        }
    };
    
    const renderReviews = (reviews, clear = false) => {
        const list = document.getElementById('reviews-list');
        if (!list) return;

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
    
    const reviewForm = document.getElementById('review-form');
    if (reviewForm) {
        reviewForm.addEventListener('submit', async(e) => {
            e.preventDefault();
            const msg = document.getElementById('review-msg');
            const btn = e.target.querySelector('button[type="submit"]');
            
            if (btn) btn.disabled = true;
            if (msg) msg.innerHTML = '<span class="text-primary small">Đang gửi đánh giá...</span>';
            
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
                    if (msg) msg.innerHTML = `<span class="text-success small fw-bold"><i class="bi bi-check-circle-fill me-1"></i> Đánh giá đã được gửi!</span>`;
                    e.target.reset();
                    updateStars(5);
                    loadReviews(1);
                } else {
                    if (msg) msg.innerHTML = `<span class="text-danger small">${data.error}</span>`;
                }
            } catch(err) {
                if (msg) msg.innerHTML = `<span class="text-danger small">Lỗi kết nối</span>`;
            } finally {
                if (btn) btn.disabled = false;
            }
        });
    }

    // Load initial reviews
    loadReviews();
});
