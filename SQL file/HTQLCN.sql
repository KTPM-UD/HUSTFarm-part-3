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
	CONSTRAINT FK_NguoiDung_TaiKhoan FOREIGN KEY (TenDangNhap) REFERENCES TaiKhoan(TenDangNhap) ON UPDATE CASCADE
);

-- 3. Bảng chuồng
CREATE TABLE Chuong (
    tenChuong NVARCHAR(30) NOT NULL PRIMARY KEY,
    chuThich NVARCHAR(100) NOT NULL
);

-- 4. Bảng Vật nuôi
CREATE TABLE VatNuoi (
    IDVatNuoi VARCHAR(10) NOT NULL PRIMARY KEY,
    loai NVARCHAR(100) NOT NULL DEFAULT N'Chưa nhập',
	tenGiong NVARCHAR(100) NOT NULL,
	tenChuong NVARCHAR(30) NULL,
    gioitinh NVARCHAR(30) NOT NULL DEFAULT N'Đực' CHECK (gioitinh IN(N'Cái',N'Đực')),
    ngaySinh DATE NOT NULL,
    canNang FLOAT NOT NULL CHECK (canNang > 0),
	IDNguoiDung VARCHAR(10) NULL,
    tinhTrangSucKhoe NVARCHAR(30) NOT NULL,
    ghiChu NVARCHAR(100) NULL,
	CONSTRAINT FK_VatNuoi_NguoiDung FOREIGN KEY (IDNguoiDung) REFERENCES NguoiDung(IDNguoiDung) ON UPDATE CASCADE ON DELETE SET NULL,
    CONSTRAINT FK_VatNuoi_tenChuong FOREIGN KEY (tenChuong) REFERENCES Chuong(tenChuong) ON UPDATE CASCADE ON DELETE SET NULL
);

-- 5. Bảng Kho
CREATE TABLE Kho (
    maKho INT IDENTITY PRIMARY KEY,
    tenKho NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
);

-- 6. Bảng Thức ăn & nước uống
CREATE TABLE ThucAnNuocUong (
    IDThucAn NVARCHAR(50) NOT NULL PRIMARY KEY,
    ten NVARCHAR(100) NOT NULL,
    loai NVARCHAR(100) NOT NULL,
    soLuong INT NOT NULL CHECK (soLuong >= 0),
    donVi NVARCHAR(10),
    hanSuDung DATE NOT NULL,
	maKho INT NULL,
	CONSTRAINT FK_ThucAn_Kho FOREIGN KEY (maKho) REFERENCES Kho(maKho) ON UPDATE CASCADE ON DELETE SET NULL
);

-- 7. Bảng phân phối thức ăn
CREATE TABLE PhanPhoiThucAn (
    ID INT IDENTITY PRIMARY KEY,
    IDThucAn NVARCHAR(50) NULL,
    soLuong INT NOT NULL CHECK (soLuong >= 0),
    tenChuong NVARCHAR(30) NULL,
    NgayPhanPhoi DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_PhanPhoiThucAn_ThucAn FOREIGN KEY (IDThucAn) REFERENCES ThucAnNuocUong(IDThucAn) ON UPDATE CASCADE ON DELETE SET NULL,
    CONSTRAINT FK_PhanPhoiThucAn_Chuong FOREIGN KEY (tenChuong) REFERENCES Chuong(tenChuong) ON UPDATE CASCADE ON DELETE SET NULL,
);
GO

CREATE PROCEDURE USP_GetAccountByUserID
    @IDNguoiDung VARCHAR(10)
AS
BEGIN
    SELECT 
        TK.TenDangNhap, TK.TenHienThi, TK.Email, TK.LoaiTaiKhoan,
        ND.IDNguoiDung, ND.HoTen, ND.gioitinh, ND.NgaySinh, ND.CCCD, ND.Diachi, TK.MatKhau
    FROM TaiKhoan TK
    JOIN NguoiDung ND ON TK.TenDangNhap = ND.TenDangNhap
    WHERE ND.IDNguoiDung = @IDNguoiDung
END
GO

CREATE PROCEDURE USP_GetLivestockByID
@IDVatNuoi NVARCHAR(50)
AS
BEGIN
    SELECT * FROM dbo.VatNuoi WHERE IDVatNuoi = @IDVatNuoi
END
GO

CREATE PROCEDURE USP_GetThucAnByIDorName
@keyword NVARCHAR(100)
AS
BEGIN
    SELECT 
        IDThucAn AS [Mã Thức Ăn],
        ten AS [Tên],
        loai AS [Loại],
        soLuong AS [Số Lượng],
        donVi AS [Đơn Vị],
        hanSuDung AS [Hạn Sử Dụng],
        maKho AS [Mã Kho]
    FROM 
        ThucAnNuocUong
    WHERE 
        IDThucAn LIKE '%' + @keyword + '%'
        OR ten LIKE '%' + @keyword + '%'
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
GO

SELECT ID, IDThucAn, soLuong, tenChuong, NgayPhanPhoi
FROM PhanPhoiThucAn
ORDER BY NgayPhanPhoi DESC;