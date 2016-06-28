use QL_Ban_Hang
Go

insert into Khach_Hang(MaKH, TenKH, email, SDT, DiaChi)
values ('KH001', N'Hoàng Tr?n Thu Qu?c Van', 'vanhttqps02812@fpt.edu.vn', '0984494898', N'TP HCM'),
		('KH002', N'Nguy?n N? Thanh Trang', 'thanhtrang@gmail.com', '0987487304', N'56 Nguy?n Ki?m, Gò V?p'),
		('KH003', N'Luu Ng?c Giàu', 'luungocgiau@gmail.com', '0987654321', N'124 Nam Kì Kh?i Nghia, Qu?n 3'),
		('KH004', N'Tr?n Van Tèo', 'vanteo@gmail.com', '0123456784', N'H32/23 C?ng Hòa, Tân Bình'),
		('KH005', N'Nguy?n Th? Thom', 'thithom@gmail.com', '0123456785', N'657 Tru?ng Chinh, Qu?n Tân Bình')

insert into Hoa_Don(MaHD, MaKH, NgayLapHD)
values ('HD001', 'KH002', '20161202'),
		('HD002', 'KH001', '20160102'),
		('HD003', 'KH004', '20160902'),
		('HD004', 'KH005', '20160405'),
		('HD005', 'KH003', '20160302')

insert into Loai_San_Pham(MaLoaiSP, TenLoaiSP)
values ('Mo', N'Mobile'),
		('La', N'Laptop'),
		('LK', N'Linh ki?n')

insert into San_Pham(MaSP, TenSP, MaLoai, DVT, Gia, MoTa)
values ('SP001', N'SAMSUNG S7', 'Mo','Cái', 10000000, N'Còn'),
		('SP002', N'CHROME BOOK ', 'La','Cái', 20000000, N'Còn'),
		('SP003', N'MI BAND', 'LK','Cái', 340000, N'Còn'),
		('SP004', N'MACBOOK PRO', 'La','Cái', 32000000, N'Còn'),
		('SP005', N'IPHONE 6S+', 'Mo','Cái', 21000000, N'Còn')

	
insert into Chi_TIet_Hoa_Don(MaHD, MaSP, SoLuong)
values ('HD001', 'SP003', 1),
		('HD002', 'SP002', 1),
		('HD003', 'SP005', 1),
		('HD004', 'SP001', 1),
		('HD005', 'SP004', 1)