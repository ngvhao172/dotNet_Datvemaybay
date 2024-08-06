# dotNet_Datvemaybay
PROJECT SỬ DỤNG C# với Entity Framework để hỗ trợ lưu trữ dữ liệu dưới dạng Model First, dữ liệu được lưu trong SQL SERVER
--
## DESIGN PATTERS
  - PROJECT áp dụng các patterns phổ biến như SINGLETON, TEMPLATE METHOD, STRATEGY, FACADE, DECORATOR, ...
## DEPENDENCY INJECTION
 - PROJECT áp dụng DI trong các patterns để giảm sự phụ thuộc, tăng khả năng mở rộng, nâng cấp

## CHỨC NĂNG (FEATURES)
- CLIENT
   + Được triển khai dưới dạng SERVER SIDE
   + Đặt vé khứ hồi hoặc một chiều.
   + Mua suất ăn và hành lý.    
   + Chọn ngày và địa điểm đi và đến.
   + Lựa chọn hãng hàng không mong muốn.
   + Thanh toán bằng thẻ Credit, VNPAY, Momo, ...
   + Tra cứu lại các vé đã mua bằng mã Booking hoặc mã vé.
   + Quản lý tài khoản cá nhân, chỉnh sửa thông tin cá nhân.
   + Sau khi đặt vé, gửi email thông báo cho người dùng.
   + 
- ADMIN
  + ĐƯỢC TRIỂN KHAI DƯỚI DẠNG CLIENT SIDE
  + Quản lý các chuyến bay
  + Quản lý các hãng bay
  + Quản lý các điểm sân bay
  + Quản lý người dùng
  + Thống kê doanh thu

## PROJECT ÁP DỤNG AUTHORIZATION (POLICY) VÀ AUTHENTICATION (CLAIMS BASE) ĐỂ XÁC THƯC VÀ PHÂN QUYỀN NGƯỜI DÙNG.

