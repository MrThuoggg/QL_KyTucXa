
USE master
GO
CREATE DATABASE QLKyTucXa
GO

USE QLKyTucXa
GO


IF OBJECT_ID('SinhVien', 'U') IS NOT NULL DROP TABLE SinhVien
IF OBJECT_ID('NhanVien', 'U') IS NOT NULL DROP TABLE NhanVien
IF OBJECT_ID('Phong', 'U') IS NOT NULL DROP TABLE Phong
IF OBJECT_ID('TaiKhoan', 'U') IS NOT NULL DROP TABLE TaiKhoan


CREATE TABLE NhanVien (
   MaNV VARCHAR(10) PRIMARY KEY,
   HoTen NVARCHAR(100),
   Cccd VARCHAR(12),
   GioiTinh NVARCHAR(10),
   NgaySinh DATE,
   Email VARCHAR(100),
   Sdt VARCHAR(15)
)


CREATE TABLE Phong (
   MaPhong VARCHAR(10) PRIMARY KEY,
   TenPhong NVARCHAR(50),
   TinhTrang NVARCHAR(50),
   SoLuongSV INT,
   GiaPhong DECIMAL(10,2)
)


CREATE TABLE SinhVien (
   MaSV VARCHAR(10) PRIMARY KEY,
   HoTen NVARCHAR(100),
   NgaySinh DATE,
   GioiTinh NVARCHAR(10),
   Cccd VARCHAR(12),
   Sdt VARCHAR(15),
   DiaChi NVARCHAR(200),
   NganhHoc NVARCHAR(100),
   Email VARCHAR(100),
   MaPhong VARCHAR(10),
   FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
)


CREATE TABLE TaiKhoan (
   TaiKhoan VARCHAR(50) PRIMARY KEY,
   MatKhau VARCHAR(100),
   MaLoai VARCHAR(10),
   TenLoai NVARCHAR(50)
)


INSERT INTO NhanVien (MaNV, HoTen, Cccd, GioiTinh, NgaySinh, Email, Sdt) VALUES 
('NV001', N'Nguyễn Văn An', '123456789012', N'Nam', '1990-01-15', 'an.nguyen@example.com', '0912345678'),
('NV002', N'Trần Thị Bích', '234567890123', N'Nữ', '1992-05-20', 'bich.tran@example.com', '0987654321'),
('NV003', N'Lê Quốc Minh', '345678901234', N'Nam', '1988-03-10', 'minh.le@example.com', '0938765432')


INSERT INTO Phong (MaPhong, TenPhong, TinhTrang, SoLuongSV, GiaPhong) VALUES 
('P101', N'Phòng 101', N'Còn chỗ', 3, 1500000),
('P102', N'Phòng 102', N'Đầy', 4, 1800000),
('P103', N'Phòng 103', N'Còn chỗ', 2, 1200000)


INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, Cccd, Sdt, DiaChi, NganhHoc, Email, MaPhong) VALUES 
('SV001', N'Lê Văn Cường', '2000-03-10', N'Nam', '456789012345', '0901234567', N'Cần Thơ', N'Công nghệ thông tin', 'cuong.le@student.com', 'P101'),
('SV002', N'Trần Thị Diệu', '2001-07-22', N'Nữ', '567890123456', '0912345678', N'Hậu Giang', N'Kế toán', 'dieu.tran@student.com', 'P102'),
('SV003', N'Phạm Minh Hoàng', '2002-01-01', N'Nam', '678901234567', '0923456789', N'Sóc Trăng', N'Quản trị kinh doanh', 'hoang.pham@student.com', 'P103')

INSERT INTO TaiKhoan (TaiKhoan, MatKhau, MaLoai, TenLoai) VALUES 
('admin', 'admin123', 'ADMIN', N'Quản trị viên'),
('nhanvien', 'nhanvien123', 'NV', N'Nhân viên'),
('sv001', 'password123', 'SV', N'Sinh viên')


SELECT * FROM NhanVien
SELECT * FROM Phong
SELECT * FROM SinhVien
SELECT * FROM TaiKhoan
