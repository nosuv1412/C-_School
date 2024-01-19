create database QLKhachHang
use QLKhachHang
create table DATHANG(
	MaKH int not null primary key,
	Hoten nvarchar(30),
	Gioitinh bit,
	Loaiphong nvarchar(1000),
	Sophongthue int
)