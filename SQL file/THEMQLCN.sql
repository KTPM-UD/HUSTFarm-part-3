INSERT INTO dbo.TaiKhoan(TenDangNhap, TenHienThi, MatKhau, Email, LoaiTaiKhoan)
VALUES (N'tuank4',N'Minh Tuấn','2326','t@gmail.com','0')
INSERT INTO dbo.TaiKhoan(TenDangNhap, TenHienThi, MatKhau, Email, LoaiTaiKhoan)
VALUES (N'sangk3',N'Sang Sang','8386','Sa@gmail.com','1');
INSERT INTO dbo.TaiKhoan(TenDangNhap, TenHienThi, MatKhau, Email, LoaiTaiKhoan)
VALUES (N'khanhVQ',N'Khánh Vũ','1234','KVQ@gmail.com','0');
INSERT INTO dbo.TaiKhoan(TenDangNhap, TenHienThi, MatKhau, Email, LoaiTaiKhoan)
VALUES (N'LongHH',N'Long Hoàng','4567','Longp@gmail.com','0');

INSERT INTO dbo.VatNuoi(IDVatNuoi, loai, tenGiong, tenChuong, gioitinh, ngaySinh, canNang)
VALUES ('BO001', N'Bò', N'Simental', N'A1', N'Đực', '2022-05-01', 250.5);
INSERT INTO dbo.VatNuoi (IDVatNuoi, loai, tenGiong, tenChuong, gioitinh, ngaySinh, canNang)
VALUES ('LON001', N'Lợn', N'Landrace', N'B3', N'Cái', '2023-02-15', 120.0);
INSERT INTO dbo.VatNuoi (IDVatNuoi, loai, tenGiong, tenChuong, gioitinh, ngaySinh, canNang)
VALUES ('GA001', N'Gà', N'Gà Ri', N'C2', N'Đực', '2024-01-10', 2.3);
INSERT INTO dbo.VatNuoi (IDVatNuoi, loai, tenGiong, tenChuong, gioitinh, ngaySinh, canNang)
VALUES ('DE001', N'Dê', N'Bách Thảo', N'D1', N'Cái', '2023-09-20', 35.7);

SELECT * FROM dbo.TaiKhoan WHERE TenDangNhap = N'tuank4' AND MatKhau = N'2326'