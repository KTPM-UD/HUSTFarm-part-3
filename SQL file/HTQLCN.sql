CREATE DATABASE HeThongQuanLyChanNuoi
GO
USE HeThongQuanLyChanNuoi
GO

-- 1. Bảng Tài khoản
CREATE TABLE TaiKhoan (
    TenDangNhap NVARCHAR(50) PRIMARY KEY,
	TenHienThi NVARCHAR(50) NOT NULL DEFAULT 'NotNamedUser',
    MatKhau VARCHAR(255) NOT NULL DEFAULT N'0',
    Email NVARCHAR(100) UNIQUE NOT NULL,
    LoaiTaiKhoan INT DEFAULT 0 --1: admin && 0: user
);

-- 2. Bảng Người Dùng
CREATE TABLE NguoiDung (
    IDNguoiDung VARCHAR(10) NOT NULL PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL DEFAULT N'Chưa nhập tên',
	gioitinh NVARCHAR(30) NOT NULL CHECK (gioitinh IN(N'Nam',N'Nữ')),
	NgaySinh DATE NOT NULL,
	CCCD VARCHAR(50) NOT NULL,
    Diachi NVARCHAR(100) NOT NULL DEFAULT N'Chưa nhập',
    TenDangNhap NVARCHAR(50) NOT NULL,
	CONSTRAINT FK_NguoiDung_TaiKhoan FOREIGN KEY (TenDangNhap) REFERENCES TaiKhoan(TenDangNhap) ON UPDATE CASCADE,
);

-- 3. Bảng Vật nuôi
CREATE TABLE VatNuoi (
    IDVatNuoi VARCHAR(10) NOT NULL PRIMARY KEY,
    loai NVARCHAR(100) NOT NULL DEFAULT N'Chưa nhập',
	tenGiong NVARCHAR(100) NOT NULL,
	tenChuong NVARCHAR(30) NOT NULL DEFAULT N'A1',
    gioitinh NVARCHAR(30) NOT NULL DEFAULT N'Đực' CHECK (gioitinh IN(N'Cái',N'Đực')), --Cái || Đực
    ngaySinh DATE NOT NULL,
    canNang FLOAT NOT NULL CHECK (canNang > 0),
	IDNguoiDung VARCHAR(10) NULL, -- Khóa ngoại
	CONSTRAINT FK_VatNuoi_NguoiDung FOREIGN KEY (IDNguoiDung) REFERENCES NguoiDung(IDNguoiDung) ON UPDATE CASCADE,
);

-- 4. Bảng Sức khỏe
CREATE TABLE SucKhoe (
    IDSucKhoe INT IDENTITY PRIMARY KEY,
    IDVatNuoi VARCHAR(10) NOT NULL,
    ngayKiemTra DATE NOT NULL,
    tinhTrang NVARCHAR(200) NOT NULL,
    ghiChu NVARCHAR(MAX),
	CONSTRAINT FK_SucKhoe_VatNuoi FOREIGN KEY (IDVatNuoi) REFERENCES VatNuoi(IDVatNuoi) ON UPDATE CASCADE,
);

-- 5. Bảng Kho
CREATE TABLE Kho (
    maKho INT IDENTITY PRIMARY KEY,
    tenKho NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
);

-- 6. Bảng Thức ăn & nước uống
CREATE TABLE ThucAnNuocUong (
    IDThucAn INT NOT NULL PRIMARY KEY,
    ten NVARCHAR(100) NOT NULL,
    loai NVARCHAR(100) NOT NULL,
    soLuong INT NOT NULL CHECK (soLuong >= 0),
    hanSuDung DATE NOT NULL,
	maKho INT NOT NULL,
	CONSTRAINT FK_ThucAn_Kho FOREIGN KEY (maKho) REFERENCES Kho(maKho) ON UPDATE CASCADE,
);

-- 7. Bảng phân phối thức ăn
CREATE TABLE PhanPhoiThucAn (
	ID INT IDENTITY PRIMARY KEY,
    IDThucAn INT NOT NULL,
    IDVatNuoi VARCHAR(10) NOT NULL,
    ngay DATE NOT NULL,
    soLuong FLOAT NOT NULL CHECK (soLuong > 0), --donvi kg
	CONSTRAINT FK_PhanPhoiThucAn_ThucAnNuocUong FOREIGN KEY (IDThucAn) REFERENCES ThucAnNuocUong(IDThucAn) ON DELETE CASCADE,
	CONSTRAINT FK_PhanPhoiThucAn_VatNuoi FOREIGN KEY (IDVatNuoi) REFERENCES VatNuoi(IDVatNuoi) ON DELETE CASCADE,
);

GO
CREATE PROCEDURE USP_GetAccountByUserName
@tenDangNhap NVARCHAR(50)
AS
BEGIN
SELECT TenHienThi, Email FROM dbo.TaiKhoan WHERE TenDangNhap = @tenDangNhap
END

GO
CREATE PROCEDURE USP_GetLivestockByID
@IDVatNuoi NVARCHAR(50)
AS
BEGIN
SELECT * FROM dbo.VatNuoi WHERE IDVatNuoi = @IDVatNuoi
END

GO
CREATE PROCEDURE USP_Login
@tenDangNhap NVARCHAR(50), @matKhau VARCHAR(255)
AS
BEGIN
SELECT * FROM dbo.TaiKhoan tk 
JOIN dbo.NguoiDung nd ON tk.TenDangNhap = nd.TenDangNhap
WHERE tk.TenDangNhap = @tenDangNhap AND tk.MatKhau = @matKhau
END

GO
CREATE PROCEDURE USP_TongVatNuoi
@idNguoiDung NVARCHAR(50)
AS
BEGIN
SELECT COUNT(*) AS TongVatNuoi 
FROM VatNuoi
WHERE IDNguoiDung = @idNguoiDung
END
