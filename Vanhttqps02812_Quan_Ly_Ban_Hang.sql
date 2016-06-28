
-- tables
-- Table: Chi_Tiet_Hoa_Don
CREATE TABLE Chi_Tiet_Hoa_Don (
    MaHD varchar(5)  NOT NULL,
    MaSP varchar(5)  NOT NULL,
    SoLuong int  NOT NULL,
    CONSTRAINT Chi_Tiet_Hoa_Don_pk PRIMARY KEY  (MaHD,MaSP)
);

-- Table: Hoa_Don
CREATE TABLE Hoa_Don (
    MaHD varchar(5)  NOT NULL,
    MaKH varchar(5)  NOT NULL,
    NgayLapHD date  NOT NULL,
    CONSTRAINT Hoa_Don_pk PRIMARY KEY  (MaHD)
);

-- Table: Khach_Hang
CREATE TABLE Khach_Hang (
    MaKH varchar(5)  NOT NULL,
    TenKH nvarchar(50)  NOT NULL,
    Email varchar(50)  NOT NULL,
    SDT varchar(11)  NOT NULL,
    DiaChi nvarchar(100)  NOT NULL,
    CONSTRAINT Khach_Hang_pk PRIMARY KEY  (MaKH)
);

-- Table: Loai_San_Pham
CREATE TABLE Loai_San_Pham (
    MaLoai varchar(5)  NOT NULL,
    TenLoai nvarchar(50)  NOT NULL,
    CONSTRAINT Loai_San_Pham_pk PRIMARY KEY  (MaLoai)
);

-- Table: San_Pham
CREATE TABLE San_Pham (
    MaSP varchar(5)  NOT NULL,
	TenSP nvarchar(50)  NOT NULL,
    MaLoai varchar(5)  NOT NULL,
    Gia decimal(12,0)  NOT NULL,
    MoTa nvarchar(50)  NOT NULL,
    CONSTRAINT San_Pham_pk PRIMARY KEY  (MaSP)
);

-- foreign keys
-- Reference: Chi_Tiet_Hoa_Don_Hoa_Don (table: Chi_Tiet_Hoa_Don)
ALTER TABLE Chi_Tiet_Hoa_Don ADD CONSTRAINT Chi_Tiet_Hoa_Don_Hoa_Don
    FOREIGN KEY (MaHD)
    REFERENCES Hoa_Don (MaHD);

-- Reference: Chi_Tiet_Hoa_Don_San_Pham (table: Chi_Tiet_Hoa_Don)
ALTER TABLE Chi_Tiet_Hoa_Don ADD CONSTRAINT Chi_Tiet_Hoa_Don_San_Pham
    FOREIGN KEY (MaSP)
    REFERENCES San_Pham (MaSP);

-- Reference: Hoa_Don_Khach_Hang (table: Hoa_Don)
ALTER TABLE Hoa_Don ADD CONSTRAINT Hoa_Don_Khach_Hang
    FOREIGN KEY (MaKH)
    REFERENCES Khach_Hang (MaKH);

-- Reference: San_Pham_Loai_San_Pham (table: San_Pham)
ALTER TABLE San_Pham ADD CONSTRAINT San_Pham_Loai_San_Pham
    FOREIGN KEY (MaLoai)
    REFERENCES Loai_San_Pham (MaLoai);

-- End of file.

