# User Stories – Quản lý CLB

## Vai trò
- **Sinh viên**
- **Chủ nhiệm**
- **Quản trị viên**

## Sinh viên

**US01:** Tôi muốn xem danh sách CLB để chọn CLB phù hợp.
1. Hiển thị tên, mô tả và số thành viên của từng CLB.
2. Có thể tìm kiếm CLB theo tên.

**US02:** Tôi muốn đăng ký tham gia CLB để trở thành thành viên.
1. Đơn đăng ký có trạng thái ban đầu là "Chờ duyệt".
2. Không cho đăng ký trùng nếu đã là thành viên.

**US03:** Tôi muốn xem lịch sự kiện để sắp xếp thời gian tham gia.
1. Hiển thị tên, thời gian và địa điểm sự kiện.
2. Sắp xếp sự kiện theo thời gian gần nhất.

## Chủ nhiệm

**US04:** Tôi muốn duyệt đơn đăng ký để kiểm soát thành viên.
1. Xem được danh sách đơn "Chờ duyệt".
2. Khi duyệt, sinh viên trở thành thành viên chính thức.

**US05:** Tôi muốn tạo sự kiện để tổ chức hoạt động cho CLB.
1. Bắt buộc nhập tên, thời gian, địa điểm.
2. Thời gian bắt đầu phải sau thời điểm hiện tại.

**US06:** Tôi muốn điểm danh thành viên để thống kê mức độ tham gia.
1. Chỉ điểm danh được thành viên đã đăng ký sự kiện.
2. Lưu trạng thái "Có mặt" hoặc "Vắng".

##   Quản trị viên

**US07:** Tôi muốn xem báo cáo hoạt động để giám sát CLB.
1. Báo cáo gồm số thành viên và số sự kiện đã tổ chức.
2. Xem được tỷ lệ tham gia của từng sự kiện.

**US08:** Tôi muốn phê duyệt sự kiện để đảm bảo đúng quy định.
1. Sự kiện mới có trạng thái "Chờ phê duyệt".
2. Có thể phê duyệt hoặc từ chối kèm lý do.