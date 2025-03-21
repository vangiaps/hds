create database QuanLyPhongTro;
use QuanLyPhongTro;

create table PhongTro (
	MaPhong int primary key identity(1,1),
	TenPhong nvarchar(50),
	LoaiPhong nvarchar(50),
	DonGia money,
	TrangThai nvarchar(50)
	);

create table Khach (
	MaKhach int primary key identity(1,1),
	HoTen nvarchar(50),
	CMND_CCCD nvarchar(50),
	SDT nvarchar(50),
	DiaChi nvarchar(100)
	);

create table HopDongThue (
	MaHopDong int primary key identity(1,1),
	MaKhach int foreign key references Khach(MaKhach),
	MaPhong int foreign key references PhongTro(MaPhong),
	NgayBatDau date,
	NgayKetThuc date,
	TienCoc money
	);

create table HoaDon (
	MaHoaDon int primary key identity(1,1),
	MaPhong int foreign key references PhongTro(MaPhong),
	NgayLap date,
	TienPhong money,
	TienDien money,
	TienNuoc money,
	TienDV money,
	TongTien as (TienPhong + TienDien + TienNuoc + TienDV) persisted,
	TrangThaiThanhToan nvarchar(50)
	);

CREATE TABLE NguoiDung (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) UNIQUE NOT NULL,
    Password NVARCHAR(255) NOT NULL,
);

insert into NguoiDung (Username, Password)
values ('admin', 'admin234');

INSERT INTO PhongTro (TenPhong, LoaiPhong, DonGia, TrangThai) VALUES
(N'Phòng 101', N'Cao cấp', 5000000, N'Trống'),
(N'Phòng 102', N'Thường', 3000000, N'Đã thuê'),
(N'Phòng 103', N'Thường', 3500000, N'Trống'),
(N'Phòng 104', N'Cao cấp', 5500000, N'Đã thuê'),
(N'Phòng 105', N'Thường', 3200000, N'Trống');

INSERT INTO Khach (HoTen, CMND_CCCD, SDT, DiaChi) VALUES
(N'Nguyễn Văn A', '123456789', '0987654321', N'Hà Nội'),
(N'Trần Thị B', '987654321', '0912345678', N'Hồ Chí Minh'),
(N'Lê Văn C', '456789123', '0909090909', N'Đà Nẵng'),
(N'Phạm Thị D', '789123456', '0923456789', N'Cần Thơ'),
(N'Hoàng Văn E', '321654987', '0969696969', N'Hải Phòng');

INSERT INTO HopDongThue (MaKhach, MaPhong, NgayBatDau, NgayKetThuc, TienCoc) VALUES
(1, 2, '2024-01-01', '2025-01-01', 3000000),
(2, 4, '2024-02-15', '2025-02-15', 5500000),
(3, 1, '2024-03-01', '2025-03-01', 5000000),
(4, 5, '2024-04-10', '2025-04-10', 3200000),
(5, 3, '2024-05-20', '2025-05-20', 3500000);

INSERT INTO HoaDon (MaPhong, NgayLap, TienPhong, TienDien, TienNuoc, TienDV, TrangThaiThanhToan) VALUES
(2, '2024-03-01', 3000000, 500000, 300000, 200000, N'Đã thanh toán'),
(4, '2024-03-01', 5500000, 700000, 400000, 300000, N'Chưa thanh toán'),
(1, '2024-03-01', 5000000, 600000, 350000, 250000, N'Đã thanh toán'),
(5, '2024-03-01', 3200000, 450000, 280000, 150000, N'Chưa thanh toán'),
(3, '2024-03-01', 3500000, 550000, 320000, 180000, N'Đã thanh toán');

