1. Vị trí CreateClub từ dòng 35 đến 64 vi phạm nguyên  tắc SRP: Một method làm liên tiếp 4 việc: kiểm tra hượp lệ, gửi thông báo
    Hậu quả: sửa một việc phải mở cả một method, test validate kéo theo việc ghi và in

2. Vị trí file.appendAlltext các dòng 48, 79, 94, 11 vi phạm DIP: 4 method khác nhau đều gọi thẳng appendaalltext không qua interface
    Hậu quả: không ghi