    <footer class="footer">
        <div class="container footer-trust-badges">
            <div class="trust-badge">
                <i class="bi bi-truck"></i>
                <div class="trust-badge-text">
                    <span class="trust-badge-title">Giao hàng miễn phí</span>
                    <span class="trust-badge-desc">Cho đơn hàng từ 5tr</span>
                </div>
            </div>
            <div class="trust-badge">
                <i class="bi bi-shield-check"></i>
                <div class="trust-badge-text">
                    <span class="trust-badge-title">Bảo hành 12 tháng</span>
                    <span class="trust-badge-desc">Chính hãng 100%</span>
                </div>
            </div>
            <div class="trust-badge">
                <i class="bi bi-credit-card"></i>
                <div class="trust-badge-text">
                    <span class="trust-badge-title">Trả góp 0%</span>
                    <span class="trust-badge-desc">Thủ tục đơn giản</span>
                </div>
            </div>
            <div class="trust-badge">
                <i class="bi bi-arrow-repeat"></i>
                <div class="trust-badge-text">
                    <span class="trust-badge-title">Đổi trả 30 ngày</span>
                    <span class="trust-badge-desc">Nếu có lỗi phần cứng</span>
                </div>
            </div>
        </div>

        <div class="container footer-links-grid">
            <div class="row text-md-center">
                <div class="col-md-4 footer-col">
                    <h6>DÒNG SẢN PHẨM</h6>
                    <ul>
                        <li><a href="<?php echo $basePath; ?>product.php">iPhone 15 Series</a></li>
                        <li><a href="#">Samsung Galaxy S24</a></li>
                        <li><a href="#">Xiaomi 14 Ultra</a></li>
                        <li><a href="#">Oppo Find X7</a></li>
                    </ul>
                </div>
                <div class="col-md-4 footer-col">
                    <h6>HỖ TRỢ KHÁCH HÀNG</h6>
                    <ul>
                        <li><a href="<?php echo $basePath; ?>warranty.php">Chính sách bảo hành</a></li>
                        <li><a href="#">Chính sách đổi trả</a></li>
                        <li><a href="#">Giao hàng & Thanh toán</a></li>
                    </ul>
                </div>
                <div class="col-md-4 footer-col">
                    <h6>THÔNG TIN LIÊN HỆ</h6>
                    <ul>
                        <li><a href="tel:0333427187">Hotline: 0333 427 187</a></li>
                        <li><a href="#">Địa chỉ: 123 Cầu Giấy, Hà Nội</a></li>
                        <li><a href="#">Email: support@nhkmobile.vn</a></li>
                    </ul>
                </div>
            </div>
        </div>

        <div class="container footer-bottom">
            <div class="footer-bottom-info">
                <div>© 2026 NHK Mobile. Bảo lưu mọi quyền.</div>
            </div>
            <div class="footer-socials">
                <a href="https://www.facebook.com/nguyen.huu.khanh.250505" target="_blank"><i class="bi bi-facebook"></i></a>
                <a href="https://www.instagram.com/nguyenhuukhanh1893/" target="_blank"><i class="bi bi-instagram"></i></a>
                <a href="https://www.tiktok.com/@nguyenhuukhanh_0?lang=vi-VN" target="_blank"><i class="bi bi-tiktok"></i></a>
            </div>
        </div>
    </footer>

    <!-- Floating Contact Widget CSS -->
    <style>
    .floating-widget{position:fixed;right:0;top:70%;transform:translateY(-50%);z-index:9999;display:flex;align-items:center;transition:transform 0.5s cubic-bezier(0.4,0,0.2,1);}
    .floating-widget:not(.active){transform:translate(100%,-50%);}
    @media (max-width:768px){.floating-widget{top:auto;bottom:100px;transform:none;}.floating-widget:not(.active){transform:translate(100%,0);}.widget-toggle{left:-40px;width:40px;height:48px;font-size:32px;background:rgba(255,255,255,0.8);backdrop-filter:blur(5px);border-radius:10px 0 0 10px;}.widget-menu{padding:8px;border-radius:15px 0 0 15px;}}
    .widget-toggle{background:transparent;color:#ff3b30;width:60px;height:60px;border:none;cursor:pointer;display:flex;align-items:center;justify-content:center;font-size:48px;position:absolute;left:-48px;box-shadow:none;transition:all 0.3s ease;}
    .widget-toggle:hover{color:#d70015;transform:scale(1.1);}
    .toggle-icon{transition:transform 0.5s ease;}
    .floating-widget.active .toggle-icon{transform:rotate(180deg);}
    .widget-menu{background:rgba(255,255,255,0.9);backdrop-filter:blur(15px);-webkit-backdrop-filter:blur(15px);border:none;border-radius:20px 0 0 20px;padding:12px 12px 20px 12px;display:flex;flex-direction:column;gap:8px;box-shadow:-10px 0 30px rgba(0,0,0,0.1);visibility:hidden;transition:visibility 0.4s;}
    .floating-widget.active .widget-menu{visibility:visible;}
    .widget-item{display:flex;flex-direction:column;align-items:center;justify-content:center;width:64px;height:64px;border-radius:12px;text-decoration:none;color:#1d1d1f;transition:all 0.3s ease;gap:4px;}
    .widget-item span{font-size:10px;font-weight:600;}
    .widget-item:hover{text-decoration:none;}
    .widget-item.phone:hover{background:#f0f0f0;color:#34c759;}
    .widget-item.zalo:hover{background:#eef6ff;color:#0068ff;}
    .widget-item.ai:hover{background:#fdf2f2;color:#ff3b30;}
    </style>

    <!-- Floating Contact Widget -->
    <div class="floating-widget" id="contactWidget">
        <button class="widget-toggle" aria-label="Toggle Menu" onclick="document.getElementById('contactWidget').classList.toggle('active')">
            <span class="toggle-icon">‹</span>
        </button>
        <div class="widget-menu">
            <a href="https://www.google.com/maps/place/53+Võ+Văn+Ngân,+Linh+Chiểu,+Thủ+Đức,+Hồ+Chí+Minh" target="_blank" class="widget-item phone" title="Vị trí">
                <i class="bi bi-geo-alt-fill fs-3 text-danger"></i>
                <span>Vị trí</span>
            </a>
            <a href="https://zalo.me/0333427187" target="_blank" class="widget-item zalo" title="Zalo Chat">
                <img src="<?php echo isset($basePath) ? $basePath : ''; ?>assets/images/zalo.jpg" alt="Zalo" class="widget-img" style="width: 30px; object-fit: contain;">
                <span>Zalo</span>
            </a>
            <a href="#" class="widget-item ai" title="AI Chat" onclick="alert('Tính năng AI Chat đang được phát triển!')">
                <i class="bi bi-robot fs-3 text-primary"></i>
                <span class="text-primary">AI Chat</span>
            </a>
        </div>
    </div>

    <!-- Bootstrap 5 JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>

    <!-- Search Overlay -->
    <?php include __DIR__ . '/search_overlay.php'; ?>
    <script src="<?php echo isset($basePath) ? $basePath : ''; ?>assets/js/search-overlay.js"></script>
</body>
</html>
