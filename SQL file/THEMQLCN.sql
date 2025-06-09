USE HeThongQuanLyChanNuoi
GO

-- Tài khoản
INSERT INTO dbo.TaiKhoan(TenDangNhap, TenHienThi, MatKhau, Email, LoaiTaiKhoan) VALUES 
(N'tuank4',N'Minh Tuấn','2326','t@gmail.com','0'),
(N'sangk3',N'Sang Sang','8386','Sa@gmail.com','1'),
(N'khanhVQ',N'Khánh Vũ','1234','KVQ@gmail.com','0'),
(N'LongHH',N'Long Hoàng','4567','Longp@gmail.com','0'),
(N'user01', N'Nguyễn Văn A', 'pass123', N'user01@example.com', 0),
(N'user02', N'Lê Thị B', '123456', N'user02@example.com', 0),
(N'user03', N'Trần Văn C', 'abc123', N'user03@example.com', 0),
(N'user04', N'Phạm Thị D', 'qwerty', N'user04@example.com', 0),
(N'user05', N'Hoàng Văn E', '123abc', N'user05@example.com', 0),
(N'user06', N'Đỗ Thị F', 'password', N'user06@example.com', 0),
(N'user07', N'Nguyễn Văn G', 'pass2025', N'user07@example.com', 0),
(N'user08', N'Trần Thị H', 'matkhau', N'user08@example.com', 0),
(N'user09', N'Lê Văn I', 'mk2025', N'user09@example.com', 0),
(N'user10', N'Phan Thị J', 'lemonade', N'user10@example.com', 0),
(N'admin', N'Admin Chính', 'admin', N'admin01@example.com', 1),
(N'user11', N'Trịnh Văn K', 'secret123', N'user11@example.com', 0),
(N'user12', N'Vũ Thị L', 'mypw456', N'user12@example.com', 0),
(N'user13', N'Bùi Văn M', 'p456', N'user13@example.com', 0),
(N'user14', N'Đặng Thị N', 'n1234', N'user14@example.com', 0);


-- Người dùng
INSERT INTO NguoiDung (IDNguoiDung, HoTen, gioitinh, NgaySinh, CCCD, Diachi, TenDangNhap) VALUES 
('ND001', N'Nguyễn Văn A', N'Nam', '1995-04-10', '012345678901', N'Hà Nội', 'tuank4'),
('ND002', N'Lê Thị B', N'Nữ', '1998-08-25', '012345678902', N'Đà Nẵng', 'sangk3'),
('ND003', N'Trần Văn C', N'Nam', '2000-01-15', '012345678903', N'Hồ Chí Minh', 'khanhVQ'),
('ND004', N'Phạm Thị D', N'Nữ', '1992-11-30', '012345678904', N'Hải Phòng', 'LongHH'),
('ND005', N'Hoàng Văn E', N'Nam', '1994-05-05', '123456789005', N'Cần Thơ', N'user05'),
('ND006', N'Đỗ Thị F', N'Nữ', '1995-06-06', '123456789006', N'Bắc Ninh', N'user06'),
('ND007', N'Nguyễn Văn G', N'Nam', '1996-07-07', '123456789007', N'Nghệ An', N'user07'),
('ND008', N'Trần Thị H', N'Nữ', '1997-08-08', '123456789008', N'Thái Bình', N'user08'),
('ND009', N'Lê Văn I', N'Nam', '1998-09-09', '123456789009', N'Thanh Hóa', N'user09'),
('ND010', N'Phan Thị J', N'Nữ', '1999-10-10', '123456789010', N'Quảng Ninh', N'user10'),
('ND011', N'Admin Chính', N'Nam', '1985-11-11', '123456789011', N'Hà Nội', N'admin'),
('ND012', N'Trịnh Văn K', N'Nam', '1993-12-12', '123456789012', N'Hưng Yên', N'user11'),
('ND013', N'Vũ Thị L', N'Nữ', '1990-01-13', '123456789013', N'Hà Nam', N'user12'),
('ND014', N'Bùi Văn M', N'Nam', '1988-02-14', '123456789014', N'Tuyên Quang', N'user13'),
('ND015', N'Đặng Thị N', N'Nữ', '1991-03-15', '123456789015', N'Lào Cai', N'user14'),
('ND016', N'Nguyễn Văn A', N'Nam', '1990-01-01', '123456789001', N'Hà Nội', N'user01'),
('ND017', N'Lê Thị B', N'Nữ', '1992-02-02', '123456789002', N'Hải Phòng', N'user02'),
('ND018', N'Trần Văn C', N'Nam', '1991-03-03', '123456789003', N'Hồ Chí Minh', N'user03'),
('ND019', N'Phạm Thị D', N'Nữ', '1993-04-04', '123456789004', N'Đà Nẵng', N'user04');

-- ND001
INSERT INTO dbo.VatNuoi (IDVatNuoi, loai, tenGiong, tenChuong, gioitinh, ngaySinh, canNang, IDNguoiDung, tinhTrangSucKhoe, ghiChu) VALUES 
('HEO003', N'Lợn', N'Landrace', N'H2', N'Cái', '2023-02-15', 120.0, 'ND001', N'Bệnh mức 1', N'Cúm');

-- ND002
INSERT INTO dbo.VatNuoi VALUES 
('BO001', N'Bò', N'Simental', N'B1', N'Đực', '2022-05-01', 250.5,'ND002', N'Tốt', NULL),
('DE001', N'Dê', N'Bách Thảo', N'D1', N'Cái', '2023-09-20', 35.7, 'ND002', N'Tốt', NULL);

-- ND003
INSERT INTO dbo.VatNuoi VALUES 
('GA001', N'Gà', N'Gà Ri', N'G2', N'Đực', '2024-01-10', 2.3, 'ND003', N'Tốt', NULL);

-- ND004
INSERT INTO dbo.VatNuoi VALUES 
('HEO008', N'Heo', N'Heo Yorkshire', N'H1', N'Cái', '2024-01-25', 37.2, 'ND004', N'Bệnh mức 2', N'Viêm da');

-- ND005
INSERT INTO dbo.VatNuoi VALUES 
('HEO009', N'Heo', N'Heo Yorkshire', N'H2', N'Cái', '2024-01-20', 40.0, 'ND005', N'Tốt', NULL);

-- ND006
INSERT INTO dbo.VatNuoi VALUES 
('GA009', N'Gà', N'Gà Lương Phượng', N'G1', N'Đực', '2024-02-14', 2.5, 'ND006', N'Bệnh mức 1', N'Cúm'),
('GA010', N'Gà', N'Gà Mía', N'G1', N'Cái', '2024-01-22', 2.0, 'ND006', N'Bệnh mức 3', N'Ung thư');

-- ND007
INSERT INTO dbo.VatNuoi VALUES 
('VIT011', N'Vịt', N'Vịt Super M', N'V1', N'Đực', '2024-03-10', 2.8, 'ND007', N'Tốt', NULL);

-- ND008
INSERT INTO dbo.VatNuoi VALUES 
('BO012', N'Bò', N'Bò Brahman', N'B2', N'Cái', '2023-09-01', 280.0, 'ND008', N'Bệnh mức 1', N'Viêm da'),
('BO013', N'Bò', N'Bò lai Sind', N'B1', N'Đực', '2023-10-10', 260.0, 'ND008', N'Tốt', NULL);

-- ND009
INSERT INTO dbo.VatNuoi VALUES 
('GA014', N'Gà', N'Gà Tre', N'G2', N'Đực', '2024-03-05', 1.6, 'ND009', N'Đã chết', N'Ung thư');

-- ND010
INSERT INTO dbo.VatNuoi VALUES 
('HEO015', N'Heo', N'Heo Landrace', N'H2', N'Cái', '2024-01-18', 33.5, 'ND010', N'Bệnh mức 2', N'Cúm');

-- ND011
INSERT INTO dbo.VatNuoi VALUES 
('BO016', N'Bò', N'Bò Red Angus', N'B2', N'Đực', '2023-12-01', 320.0, 'ND011', N'Tốt', NULL);

-- ND012
INSERT INTO dbo.VatNuoi VALUES 
('VIT017', N'Vịt', N'Vịt cỏ', N'V2', N'Cái', '2024-02-28', 2.3, 'ND012', N'Bệnh mức 3', N'Viêm da'),
('VIT018', N'Vịt', N'Vịt siêu trứng', N'V2', N'Cái', '2024-03-02', 2.6, 'ND012', N'Tốt', NULL);

-- ND013
INSERT INTO dbo.VatNuoi VALUES 
('GA019', N'Gà', N'Gà Hồ', N'G1', N'Đực', '2024-01-25', 3.0, 'ND013', N'Bệnh mức 1', N'Cúm');

-- ND014
INSERT INTO dbo.VatNuoi VALUES 
('HEO020', N'Heo', N'Heo Duroc', N'H1', N'Đực', '2024-02-05', 42.0, 'ND014', N'Tốt', NULL);

-- ND015
INSERT INTO dbo.VatNuoi VALUES 
('VIT021', N'Vịt', N'Vịt Super M', N'V1', N'Cái', '2024-03-01', 3.2, 'ND015', N'Bệnh mức 2', N'Ung thư'),
('GA022', N'Gà', N'Gà Đông Tảo', N'G2', N'Cái', '2024-03-15', 2.9, 'ND015', N'Tốt', NULL);

-- ND016
INSERT INTO dbo.VatNuoi VALUES 
('HEO001', N'Heo', N'Heo Landrace', N'H2', N'Đực', '2024-01-01', 35.5, 'ND016', N'Bệnh mức 1', N'Viêm da');

-- ND017
INSERT INTO dbo.VatNuoi VALUES 
('GA002', N'Gà', N'Gà Ri', N'G1', N'Cái', '2024-02-15', 2.1, 'ND017', N'Tốt', NULL),
('GA003', N'Gà', N'Gà Đông Tảo', N'G2', N'Đực', '2024-03-01', 2.8, 'ND017', N'Bệnh mức 3', N'Ung thư');

-- ND018
INSERT INTO dbo.VatNuoi VALUES 
('VIT004', N'Vịt', N'Vịt Super M', N'V2', N'Cái', '2024-01-10', 3.0, 'ND018', N'Tốt', NULL);

-- ND019
INSERT INTO dbo.VatNuoi VALUES 
('BO005', N'Bò', N'Bò Simental', N'B1', N'Đực', '2023-12-25', 250.0, 'ND019', N'Bệnh mức 1', N'Cúm'),
('BO006', N'Bò', N'Bò lai Sind', N'B2', N'Cái', '2024-02-10', 180.0, 'ND019', N'Tốt', NULL),
('BO007', N'Bò', N'Bò Charolais', N'B2', N'Cái', '2023-11-15', 300.0, 'ND019', N'Đã chết', N'Ung thư');



 --Kho
INSERT INTO dbo.Kho (tenKho) VALUES 
(N'Kho Thức Ăn'),
(N'Kho Nước Uống'),
(N'Kho Thuốc');
--Thức ăn
INSERT INTO dbo.ThucAnNuocUong (IDThucAn, ten, loai, soLuong, donVi, hanSuDung, maKho) VALUES
('TA001', N'Hạt Ngũ Cốc', N'Thức ăn', 243, N'kg', '2026-12-25', 1),
('NU001', N'Nước máy', N'Nước uống', 2000, N'lít', '2025-12-25', 2);
INSERT INTO dbo.Chuong (tenChuong, chuThich) VALUES
(N'B1', N'Chuồng bò số 1'),
(N'B2', N'Chuồng bò số 2'),
(N'D1', N'Chuồng dê số 1'),
(N'G1', N'Chuồng gà số 1'),
(N'G2', N'Chuồng gà số 2'),
(N'H1', N'Chuồng heo số 1'),
(N'H2', N'Chuồng heo số 2'),
(N'V1', N'Chuồng vịt số 1'),
(N'V2', N'Chuồng vịt số 2'),
(N'Z0', N'Chuồng động vật không xác định');
 


