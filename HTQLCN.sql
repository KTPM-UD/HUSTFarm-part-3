CREATE DATABASE HeThongQuanLyChanNuoi
GO
USE HeThongQuanLyChanNuoi
GO

-- 1. Bảng Tài khoản
CREATE TABLE TaiKhoan (
    TenDangNhap NVARCHAR(50) PRIMARY KEY,
    MatKhau VARCHAR(255) NOT NULL DEFAULT 0,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    Type INT DEFAULT 0, --1: admin && 0: user
);

-- 2. Bảng Người Dùng
CREATE TABLE NguoiDung (
    IDNguoiDung INT IDENTITY PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL DEFAULT N'Chưa nhập tên',
    ThongTinLienHe NVARCHAR(200) NOT NULL DEFAULT N'Chưa nhập',
    TenDangNhap NVARCHAR(50) NOT NULL,
	CONSTRAINT FK_NguoiDung_TaiKhoan FOREIGN KEY (TenDangNhap) REFERENCES TaiKhoan(TenDangNhap),
);

-- 3. Bảng Vật nuôi
CREATE TABLE VatNuoi (
    IDVatNuoi INT IDENTITY PRIMARY KEY,
    loai NVARCHAR(100) NOT NULL DEFAULT N'Chưa nhập',
    gioitinh NVARCHAR(30) NOT NULL DEFAULT N'Đực', --Cái || Đực
    ngaySinh DATE NOT NULL,
    canNang FLOAT NOT NULL,
	IDNguoiDung INT NOT NULL, -- Khóa ngoại
);

-- 4. Bảng Sức khỏe
CREATE TABLE SucKhoe (
    IDSucKhoe INT IDENTITY PRIMARY KEY,
    IDVatNuoi INT NOT NULL,
    ngayKiemTra DATE NOT NULL,
    tinhTrang NVARCHAR(200) NOT NULL,
    ghiChu NVARCHAR(MAX),
	CONSTRAINT FK_SucKhoe_VatNuoi FOREIGN KEY (IDVatNuoi) REFERENCES VatNuoi(IDVatNuoi)
);


-- 5. Bảng Kho
CREATE TABLE Kho (
    maKho INT IDENTITY PRIMARY KEY,
    tenKho NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
);

-- 6. Bảng Thức ăn & nước uống
CREATE TABLE ThucAnNuocUong (
    IDThucAn INT IDENTITY PRIMARY KEY,
    ten NVARCHAR(100) NOT NULL,
    loai NVARCHAR(100) NOT NULL,
    soLuong NVARCHAR(100) NOT NULL,
    hanSuDung DATE NOT NULL,
	maKho INT NOT NULL,
	CONSTRAINT FK_ThucAn_Kho FOREIGN KEY (maKho) REFERENCES Kho(maKho),
);
