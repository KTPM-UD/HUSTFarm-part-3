USE HeThongQuanLyChanNuoi
GO

INSERT INTO dbo.TaiKhoan(TenDangNhap, TenHienThi, MatKhau, Email, LoaiTaiKhoan)
VALUES (N'tuank4',N'Minh Tuấn','2326','t@gmail.com','0')
INSERT INTO dbo.TaiKhoan(TenDangNhap, TenHienThi, MatKhau, Email, LoaiTaiKhoan)
VALUES (N'sangk3',N'Sang Sang','8386','Sa@gmail.com','1');
INSERT INTO dbo.TaiKhoan(TenDangNhap, TenHienThi, MatKhau, Email, LoaiTaiKhoan)
VALUES (N'khanhVQ',N'Khánh Vũ','1234','KVQ@gmail.com','0');
INSERT INTO dbo.TaiKhoan(TenDangNhap, TenHienThi, MatKhau, Email, LoaiTaiKhoan)
VALUES (N'LongHH',N'Long Hoàng','4567','Longp@gmail.com','0');

-- Người dùng 1
INSERT INTO NguoiDung (IDNguoiDung, HoTen, gioitinh, NgaySinh, CCCD, Diachi, TenDangNhap)
VALUES ('ND001', N'Nguyễn Văn A', N'Nam', '1995-04-10', '012345678901', N'Hà Nội', 'tuank4');
-- Người dùng 2
INSERT INTO NguoiDung (IDNguoiDung, HoTen, gioitinh, NgaySinh, CCCD, Diachi, TenDangNhap)
VALUES ('ND002', N'Lê Thị B', N'Nữ', '1998-08-25', '012345678902', N'Đà Nẵng', 'sangk3');
-- Người dùng 3
INSERT INTO NguoiDung (IDNguoiDung, HoTen, gioitinh, NgaySinh, CCCD, Diachi, TenDangNhap)
VALUES ('ND003', N'Trần Văn C', N'Nam', '2000-01-15', '012345678903', N'Hồ Chí Minh', 'khanhVQ');
-- Người dùng 4
INSERT INTO NguoiDung (IDNguoiDung, HoTen, gioitinh, NgaySinh, CCCD, Diachi, TenDangNhap)
VALUES ('ND004', N'Phạm Thị D', N'Nữ', '1992-11-30', '012345678904', N'Hải Phòng', 'LongHH');

INSERT INTO dbo.VatNuoi(IDVatNuoi, loai, tenGiong, tenChuong, gioitinh, ngaySinh, canNang, IDNguoiDung)
VALUES ('BO001', N'Bò', N'Simental', N'A1', N'Đực', '2022-05-01', 250.5,'ND001');
INSERT INTO dbo.VatNuoi (IDVatNuoi, loai, tenGiong, tenChuong, gioitinh, ngaySinh, canNang, IDNguoiDung)
VALUES ('LON001', N'Lợn', N'Landrace', N'B3', N'Cái', '2023-02-15', 120.0, 'ND001');
INSERT INTO dbo.VatNuoi (IDVatNuoi, loai, tenGiong, tenChuong, gioitinh, ngaySinh, canNang, IDNguoiDung)
VALUES ('GA001', N'Gà', N'Gà Ri', N'C2', N'Đực', '2024-01-10', 2.3, 'ND001');
INSERT INTO dbo.VatNuoi (IDVatNuoi, loai, tenGiong, tenChuong, gioitinh, ngaySinh, canNang, IDNguoiDung)
VALUES ('DE001', N'Dê', N'Bách Thảo', N'D1', N'Cái', '2023-09-20', 35.7, 'ND002');