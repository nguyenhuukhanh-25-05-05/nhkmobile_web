# BÁO CÁO LỖI GIAO DIỆN & RESPONSIVE (BUG REPORT)

Tài liệu này liệt kê các vấn đề thường gặp và các lỗi tiềm ẩn khi thao tác với thanh điều hướng (Navbar) và giao diện di động của dự án NHK Mobile.

---

## 1. CÁC LỖI NAVBAR KHI THU NHỎ (RESPONSIVE ISSUES) - [ĐÃ XỬ LÝ ✅]

### ✅ Lỗi 1: Tràn biểu tượng trên màn hình siêu nhỏ (Icon Crowding)
- **Mô tả:** Khi xem trên các thiết bị có chiều ngang hẹp.
- **Khắc phục:** Đã ẩn icon Tài khoản trên màn hình < 350px và giảm gap.

### ✅ Lỗi 2: Vỡ khung Navbar do chiều cao cố định (Fixed Height Overflow)
- **Mô tả:** Navbar được thiết lập `height: 54px`.
- **Khắc phục:** Chuyển sang `min-height: 54px`.

### ✅ Lỗi 3: Nút Hamburger bị lệch hoặc khó tương tác
- **Khắc phục:** Căn giữa toàn bộ bằng `navbar-centered-wrapper`.

---

## 2. CÁC LỖI THƯỜNG GẶP KHI SỬA RESPONSIVE - [ĐÃ XỬ LÝ ✅]

### ✅ Lỗi 4: Tràn lề ngang (Horizontal Scroll)
- **Khắc phục:** Thêm `overflow-x: hidden` toàn cục.

### ✅ Lỗi 5: Lớp phủ trang trí chặn tương tác (Pointer Events)
- **Khắc phục:** Thêm `pointer-events: none` cho các lớp gradient.

---

## 3. ĐỀ XUẤT KHẮC PHỤC (RECOMMENDATIONS)

1. **Cho Navbar:** Sử dụng `min-height: 54px` thay vì `height: 54px` để linh hoạt hơn.
2. **Cho Icon Mobile:** Ẩn bớt các icon không quá quan trọng (như icon Tài khoản) vào bên trong Menu Hamburger trên màn hình cực nhỏ (< 320px).
3. **Kiểm tra lề:** Luôn sử dụng thuộc tính `overflow-x: hidden` cho các container lớn để đảm bảo không bị trượt ngang.

---
*Người báo cáo: AI Assistant*
*Ngày: 24/03/2026*
