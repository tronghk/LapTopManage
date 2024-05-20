create database QuanLyBanLapTop
GO
CREATE TABLE [dbo].[Tbl_ChiTietHoaDon](
	[quantityProduct] [int] NULL,
	[unitPrice] [float] NULL,
	[intoMoney] [float] NULL,
	[moneyDown] [float] NULL,
	[idProduct] [nvarchar](50) NOT NULL,
	[idBill] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idProduct] ASC,
	[idBill] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_ChiTietKhuyenMai]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_ChiTietKhuyenMai](
	[discount] [float] NULL,
	[status] [nvarchar](50) NULL,
	[idProduct] [nvarchar](50) NOT NULL,
	[idPromotion] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idProduct] ASC,
	[idPromotion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_ChiTietNhapKho]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_ChiTietNhapKho](
	[idReceipt] [int] NOT NULL,
	[quantityRequest] [int] NULL,
	[quantityActual] [int] NULL,
	[unitPrice] [float] NULL,
	[intoMoney] [float] NULL,
	[idProduct] [nvarchar](50) NOT NULL,
 CONSTRAINT [pk_ProductRe] PRIMARY KEY CLUSTERED 
(
	[idReceipt] ASC,
	[idProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_ChiTietPhieuYcNhapHang]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_ChiTietPhieuYcNhapHang](
	[idProduct] [nvarchar](50) NOT NULL,
	[idCoupon] [int] NOT NULL,
	[quantityImport] [int] NULL,
	[unitPrice] [float] NULL,
	[intoMoney] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[idProduct] ASC,
	[idCoupon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_DanhMucLapTop]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_DanhMucLapTop](
	[idTypeProduct] [int] NOT NULL,
	[nameTypeProduct] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tbl_LoaiSP] PRIMARY KEY CLUSTERED 
(
	[idTypeProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_HangSP]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_HangSP](
	[idManufactutre] [int] NOT NULL,
	[nameManufactutre] [nvarchar](max) NULL,
 CONSTRAINT [PK_Tbl_HangSP] PRIMARY KEY CLUSTERED 
(
	[idManufactutre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_HoaDon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_HoaDon](
	[idBill] [int] NOT NULL,
	[dateBill] [date] NULL,
	[sumPay] [float] NULL,
	[typePay] [nvarchar](50) NULL,
	[discountMoney] [float] NULL,
	[pay] [float] NULL,
	[status] [nvarchar](max) NULL,
	[idEmployee] [nvarchar](50) NOT NULL,
	[idCustomer] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tbl_Bill] PRIMARY KEY CLUSTERED 
(
	[idBill] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_KhachHang]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_KhachHang](
	[idCustomer] [nvarchar](50) NOT NULL,
	[nameCustomer] [nvarchar](50) NULL,
	[address] [nvarchar](max) NULL,
	[phoneNumber] [nvarchar](10) NULL,
	[email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tbl_KhachHang] PRIMARY KEY CLUSTERED 
(
	[idCustomer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_KhuyenMai]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_KhuyenMai](
	[idPromotion] [int] NOT NULL,
	[namePromotions] [nvarchar](max) NULL,
	[status] [nvarchar](50) NULL,
	[startDay] [date] NULL,
	[endDay] [date] NULL,
 CONSTRAINT [PK_Tbl_KhuyenMai] PRIMARY KEY CLUSTERED 
(
	[idPromotion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_NhaCungCap]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_NhaCungCap](
	[idSupplier] [nvarchar](50) NOT NULL,
	[nameSupplier] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tbl_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[idSupplier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_NhanVien]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_NhanVien](
	[idEmployee] [nvarchar](50) NOT NULL,
	[nameEmployee] [nvarchar](50) NULL,
	[serviceEmployee] [nvarchar](50) NULL,
	[birthday] [date] NULL,
	[phoneNumber] [nchar](10) NULL,
	[salaryEmployee] [float] NULL,
	[totalSales] [float] NULL,
	[quantityBillPay] [int] NULL,
	[idUser] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tbl_NhanVien] PRIMARY KEY CLUSTERED 
(
	[idEmployee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_PhieuNhapKho]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_PhieuNhapKho](
	[idReceipt] [int] NOT NULL,
	[idSupplier] [nvarchar](50) NOT NULL,
	[dateReceipt] [date] NULL,
	[sumPay] [float] NULL,
 CONSTRAINT [Pk_id] PRIMARY KEY CLUSTERED 
(
	[idReceipt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_PhieuYeuCauNhapHang]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_PhieuYeuCauNhapHang](
	[idCoupon] [int] NOT NULL,
	[dateAdded] [date] NULL,
	[intoMoney] [float] NULL,
	[idSupplier] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tbl_PhieuNhapHang] PRIMARY KEY CLUSTERED 
(
	[idCoupon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Quyen]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Quyen](
	[idQuyen] [int] NOT NULL,
	[nameAuth] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tbl_Quyen] PRIMARY KEY CLUSTERED 
(
	[idQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_SanPham]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_SanPham](
	[idProduct] [nvarchar](50) NOT NULL,
	[nameProduct] [nvarchar](max) NULL,
	[unitPrice] [float] NOT NULL,
	[quantityProduct] [int] NOT NULL,
	[statusProduct] [nvarchar](max) NULL,
	[idTypeProduct] [int] NOT NULL,
	[idManufactutre] [int] NOT NULL,
	[image] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Tbl_SanPham] PRIMARY KEY CLUSTERED 
(
	[idProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_TaiKhoan]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_TaiKhoan](
	[idUser] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](100) NULL,
	[idQuyen] [int] NOT NULL,
 CONSTRAINT [PK_Tbl_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tbl_ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [fk_bill] FOREIGN KEY([idBill])
REFERENCES [dbo].[Tbl_HoaDon] ([idBill])
GO
ALTER TABLE [dbo].[Tbl_ChiTietHoaDon] CHECK CONSTRAINT [fk_bill]
GO
ALTER TABLE [dbo].[Tbl_ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [fk_ProductLapTop] FOREIGN KEY([idProduct])
REFERENCES [dbo].[Tbl_SanPham] ([idProduct])
GO
ALTER TABLE [dbo].[Tbl_ChiTietHoaDon] CHECK CONSTRAINT [fk_ProductLapTop]
GO
ALTER TABLE [dbo].[Tbl_ChiTietKhuyenMai]  WITH CHECK ADD  CONSTRAINT [fk_ProductPromotion] FOREIGN KEY([idProduct])
REFERENCES [dbo].[Tbl_SanPham] ([idProduct])
GO
ALTER TABLE [dbo].[Tbl_ChiTietKhuyenMai] CHECK CONSTRAINT [fk_ProductPromotion]
GO
ALTER TABLE [dbo].[Tbl_ChiTietKhuyenMai]  WITH CHECK ADD  CONSTRAINT [fk_Promotion] FOREIGN KEY([idPromotion])
REFERENCES [dbo].[Tbl_KhuyenMai] ([idPromotion])
GO
ALTER TABLE [dbo].[Tbl_ChiTietKhuyenMai] CHECK CONSTRAINT [fk_Promotion]
GO
ALTER TABLE [dbo].[Tbl_ChiTietNhapKho]  WITH CHECK ADD  CONSTRAINT [fk_idProduct] FOREIGN KEY([idProduct])
REFERENCES [dbo].[Tbl_SanPham] ([idProduct])
GO
ALTER TABLE [dbo].[Tbl_ChiTietNhapKho] CHECK CONSTRAINT [fk_idProduct]
GO
ALTER TABLE [dbo].[Tbl_ChiTietNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapKho] FOREIGN KEY([idReceipt])
REFERENCES [dbo].[Tbl_PhieuNhapKho] ([idReceipt])
GO
ALTER TABLE [dbo].[Tbl_ChiTietNhapKho] CHECK CONSTRAINT [FK_PhieuNhapKho]
GO
ALTER TABLE [dbo].[Tbl_ChiTietPhieuYcNhapHang]  WITH CHECK ADD  CONSTRAINT [fk_Coupon] FOREIGN KEY([idCoupon])
REFERENCES [dbo].[Tbl_PhieuYeuCauNhapHang] ([idCoupon])
GO
ALTER TABLE [dbo].[Tbl_ChiTietPhieuYcNhapHang] CHECK CONSTRAINT [fk_Coupon]
GO
ALTER TABLE [dbo].[Tbl_ChiTietPhieuYcNhapHang]  WITH CHECK ADD  CONSTRAINT [fk_Product] FOREIGN KEY([idProduct])
REFERENCES [dbo].[Tbl_SanPham] ([idProduct])
GO
ALTER TABLE [dbo].[Tbl_ChiTietPhieuYcNhapHang] CHECK CONSTRAINT [fk_Product]
GO
ALTER TABLE [dbo].[Tbl_HoaDon]  WITH CHECK ADD  CONSTRAINT [fk_KhachHangBill] FOREIGN KEY([idCustomer])
REFERENCES [dbo].[Tbl_KhachHang] ([idCustomer])
GO
ALTER TABLE [dbo].[Tbl_HoaDon] CHECK CONSTRAINT [fk_KhachHangBill]
GO
ALTER TABLE [dbo].[Tbl_HoaDon]  WITH CHECK ADD  CONSTRAINT [fk_NhanVienBill] FOREIGN KEY([idEmployee])
REFERENCES [dbo].[Tbl_NhanVien] ([idEmployee])
GO
ALTER TABLE [dbo].[Tbl_HoaDon] CHECK CONSTRAINT [fk_NhanVienBill]
GO
ALTER TABLE [dbo].[Tbl_NhanVien]  WITH CHECK ADD  CONSTRAINT [fk_keyUser] FOREIGN KEY([idUser])
REFERENCES [dbo].[Tbl_TaiKhoan] ([idUser])
GO
ALTER TABLE [dbo].[Tbl_NhanVien] CHECK CONSTRAINT [fk_keyUser]
GO
ALTER TABLE [dbo].[Tbl_PhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [PK_NhaCungCap] FOREIGN KEY([idSupplier])
REFERENCES [dbo].[Tbl_NhaCungCap] ([idSupplier])
GO
ALTER TABLE [dbo].[Tbl_PhieuNhapKho] CHECK CONSTRAINT [PK_NhaCungCap]
GO
ALTER TABLE [dbo].[Tbl_PhieuYeuCauNhapHang]  WITH CHECK ADD  CONSTRAINT [fk_NhapHang] FOREIGN KEY([idSupplier])
REFERENCES [dbo].[Tbl_NhaCungCap] ([idSupplier])
GO
ALTER TABLE [dbo].[Tbl_PhieuYeuCauNhapHang] CHECK CONSTRAINT [fk_NhapHang]
GO
ALTER TABLE [dbo].[Tbl_SanPham]  WITH CHECK ADD  CONSTRAINT [fk_ManufacturerProduct] FOREIGN KEY([idManufactutre])
REFERENCES [dbo].[Tbl_HangSP] ([idManufactutre])
GO
ALTER TABLE [dbo].[Tbl_SanPham] CHECK CONSTRAINT [fk_ManufacturerProduct]
GO
ALTER TABLE [dbo].[Tbl_SanPham]  WITH CHECK ADD  CONSTRAINT [fk_TypeProductProduct] FOREIGN KEY([idTypeProduct])
REFERENCES [dbo].[Tbl_DanhMucLapTop] ([idTypeProduct])
GO
ALTER TABLE [dbo].[Tbl_SanPham] CHECK CONSTRAINT [fk_TypeProductProduct]
GO
ALTER TABLE [dbo].[Tbl_TaiKhoan]  WITH CHECK ADD  CONSTRAINT [fk_QuyenID] FOREIGN KEY([idQuyen])
REFERENCES [dbo].[Tbl_Quyen] ([idQuyen])
GO
ALTER TABLE [dbo].[Tbl_TaiKhoan] CHECK CONSTRAINT [fk_QuyenID]
GO
/****** Object:  StoredProcedure [dbo].[Proc_addCoupon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc		[dbo].[Proc_addCoupon]
@idCoupon int,
@dateAdded date,
@intoMoney float,
@idSupplier nvarchar(50)
as
begin
insert into Tbl_PhieuYeuCauNhapHang(idCoupon, dateAdded, intoMoney,idSupplier)
values (@idCoupon, @dateAdded, @intoMoney, @idSupplier)
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_addChiTietHoaDon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_addChiTietHoaDon]

@quantityProduct int,
@unitPrice float,
@intoMoney float,
@moneyDown float,
@idProduct nvarchar(50),
@idBill int

as 
begin
insert into [dbo].[Tbl_ChiTietHoaDon](quantityProduct, unitPrice,intoMoney,moneyDown, idProduct, idBill)
 values (@quantityProduct, @unitPrice, @intoMoney,@moneyDown, @idProduct,@idBill)
 end

GO
/****** Object:  StoredProcedure [dbo].[Proc_addChiTietKhuyenMai]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_addChiTietKhuyenMai]

@discount float,
@status nvarchar(50),
@idProduct nvarchar(50),
@idPromotion int

as 
begin
insert into [dbo].[Tbl_ChiTietKhuyenMai](discount, status, idProduct, idPromotion)
 values (@discount, @status, @idProduct, @idPromotion)
 end


GO
/****** Object:  StoredProcedure [dbo].[Proc_addDetailCoupon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc		[dbo].[Proc_addDetailCoupon]
@quantityImport int,
@unitPrice float,
@intoMoney float,
@idCoupon int,
@idProduct nvarchar(50)
as
begin
insert into Tbl_ChiTietPhieuYcNhapHang(quantityImport,unitPrice, intoMoney, idCoupon , idProduct)
values (@quantityImport,@unitPrice, @intoMoney, @idCoupon , @idProduct)
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_addDetailReceipt]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Proc_addDetailReceipt]
/* tạo biến trùng tên với biến trong code */
@idReceipt int,
@idCoupon int,
@quantityRequest int,
@quantityActual INT,
@unitPrice FLOAT,
@intoMoney FLOAT
as
BEGIN 
/* câu lệnh SELECT */
INSERT INTO dbo.Tbl_ChiTietNhapKho
VALUES (@idReceipt, @idCoupon, @quantityRequest, @quantityActual, @unitPrice, @intoMoney)
END 

GO
/****** Object:  StoredProcedure [dbo].[Proc_addEmployee]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_addEmployee]

@idEmployee nvarchar(50),
@nameEmployee nvarchar(50),
@serviceEmployee nvarchar(50),
@phoneNumber nvarchar(50),
@salaryEmployee float,
@totalSales float,
@quantityBillPay int,
@idUser nvarchar(50),
@birthday date
as
begin
insert into Tbl_NhanVien(idEmployee, nameEmployee, serviceEmployee, phoneNumber, salaryEmployee, totalSales, quantityBillPay, idUser, birthday)
values (@idEmployee, @nameEmployee, @serviceEmployee, @phoneNumber, @salaryEmployee, @totalSales, @quantityBillPay, @idUser, @birthday)
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_addHoaDon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_addHoaDon]
@idBill int,
@dateBill date,
@sumPay float,
@typePay nvarchar(50),
@discountMoney float,
@pay float ,
@status nvarchar(50),
@idEmployee nvarchar(50),
@idCustomer nvarchar(50)
as 
begin
insert into [dbo].[Tbl_HoaDon](idBill, dateBill, sumPay, typePay, discountMoney, pay, status, idEmployee, idCustomer)
 values (@idBill, @dateBill,@sumPay, @typePay, @discountMoney, @pay, @status, @idEmployee, @idCustomer)
 end

GO
/****** Object:  StoredProcedure [dbo].[Proc_addKhachHang]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_addKhachHang]
@idCustomer nvarchar(50),
@nameCustomer nvarchar(50),
@address nvarchar(max),
@phoneNumber nvarchar(10),
@email nvarchar(50)

as 
begin
insert into [dbo].[Tbl_KhachHang](idCustomer, nameCustomer, address, phoneNumber, email)
 values (@idCustomer, @nameCustomer,@address, @phoneNumber, @email)
 end

GO
/****** Object:  StoredProcedure [dbo].[Proc_addKhuyenMai]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_addKhuyenMai]

@idPromotion int,
@namePromotion nvarchar(max),
@status nvarchar(50),
@startDay date,
@endDay date

as 
begin
insert into [dbo].[Tbl_KhuyenMai](idPromotion, namePromotions, status, startDay,endDay)
 values (@idPromotion, @namePromotion, @status, @startDay, @endDay)
 end



GO
/****** Object:  StoredProcedure [dbo].[Proc_addManufacture]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_addManufacture]
@id int,
@name nvarchar(50)
as
begin
insert into Tbl_HangSP(idManufactutre, nameManufactutre)
values (@id, @name)
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_addQuyen]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_addQuyen]
@id int,
@name nvarchar(50)
as
begin
insert into Tbl_Quyen(idQuyen, nameAuth)
values (@id, @name)
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_addReceipt]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_addReceipt]
/* tạo biến trùng tên với biến trong code */
@idReceipt int,
@idSupplier NVARCHAR(50),
@dateReceipt date,
@sumPay float

/* @dateReceipt DATE,
@sumPay FLOAT */
as
BEGIN 
/* câu lệnh SELECT */
INSERT INTO dbo.Tbl_PhieuNhapKho (idReceipt, idSupplier, dateReceipt,sumPay)
VALUES (@idReceipt, @idSupplier, @dateReceipt, @sumPay)
END 
GO
/****** Object:  StoredProcedure [dbo].[Proc_addSupplier]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Proc_addSupplier]
/* tạo biến trùng tên với biến trong code */
@idSupplier NVARCHAR(50),
@nameSupplier NVARCHAR(50)
as
BEGIN 
/* câu lệnh SELECT */
INSERT INTO dbo.Tbl_NhaCungCap (idSupplier,nameSupplier)
VALUES (@idSupplier, @nameSupplier)
END 

GO
/****** Object:  StoredProcedure [dbo].[Proc_addTypeProduct]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
create proc [dbo].[Proc_addTypeProduct]
@id int,
@name nvarchar(50)
as 
begin
	insert into [dbo].[Tbl_DanhMucLapTop] (idTypeProduct, nameTypeProduct)
	values (@id, @name)
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteCoupon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_deleteCoupon]

@idCoupon int
as
begin

delete from Tbl_PhieuYeuCauNhapHang
WHERE idCoupon = @idCoupon
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteChiTietHoaDon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_deleteChiTietHoaDon]

@idProduct nvarchar(50),
@idBill int

as 
begin 
delete from [dbo].[Tbl_ChiTietHoaDon] 
WHERE idProduct =@idProduct and idProduct = @idProduct
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteChiTietKhuyenMai]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_deleteChiTietKhuyenMai]

@idProduct nvarchar(50),
@idPromotion int

as 
begin 
delete from [dbo].[Tbl_ChiTietKhuyenMai] 
WHERE idPromotion =@idPromotion and idProduct = @idProduct
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteDetailCoupon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_deleteDetailCoupon]

@idProduct nvarchar(50),
@idCoupon int
as
begin

delete from Tbl_ChiTietPhieuYcNhapHang
WHERE idCoupon = @idCoupon and idProduct = @idProduct
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteDetailReceipt]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_deleteDetailReceipt]
/* tạo biến trùng tên với biến trong code */
@idReceipt INT,
@idCoupon INT
as
BEGIN 
DELETE FROM dbo.Tbl_ChiTietNhapKho WHERE idReceipt = @idReceipt 
END 

GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteEmployee]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_deleteEmployee]
@idEmployee nvarchar(50)
as
begin
delete from Tbl_NhanVien
WHERE idEmployee = @idEmployee
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteHoaDon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_deleteHoaDon]
@idBill int
as
begin
	delete from Tbl_HoaDon
	where idBill=@idBill
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteKhachHang]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_deleteKhachHang]
@idCustomer nvarchar(50)
as
begin
	delete from Tbl_KhachHang
	where idCustomer=@idCustomer
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteKhuyenMai]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_deleteKhuyenMai]
@idPromotion int
as 
begin
  delete from [dbo].[Tbl_KhuyenMai] where idPromotion=@idPromotion
 end
GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteManufacture]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_deleteManufacture]
@id int
as
begin
delete from Tbl_HangSP
WHERE idManufactutre = @id
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteQuyen]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_deleteQuyen]
@id int
as
begin

delete from Tbl_Quyen
WHERE idQuyen = @id
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteReceipt]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_deleteReceipt]
/* tạo biến trùng tên với biến trong code */
@idReceipt int
as
BEGIN 
DELETE FROM dbo.Tbl_PhieuNhapKho WHERE idReceipt = @idReceipt
END 

GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteSupplier]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_deleteSupplier]
/* tạo biến trùng tên với biến trong code */
@idSupplier NVARCHAR(50)
as
BEGIN 
DELETE FROM dbo.Tbl_NhaCungCap WHERE idSupplier = @idSupplier
END 

GO
/****** Object:  StoredProcedure [dbo].[Proc_deleteTypeProduct]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_deleteTypeProduct]
@id int
as
begin
	delete from Tbl_DanhMucLapTop
WHERE idTypeProduct = @id
end
GO
/****** Object:  StoredProcedure [dbo].[proc_login]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_login]
@user nvarchar(50),
@pass nvarchar(50)
as
begin
select * from Tbl_TaiKhoan where UserName = @user and Password = @pass
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_updateCoupon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_updateCoupon]
@idCoupon int,
@dateAdded date,
@intoMoney float,
@idSupplier nvarchar(50)
as
begin

UPDATE Tbl_PhieuYeuCauNhapHang
SET dateAdded = @dateAdded,  intoMoney = @intoMoney, idSupplier = @idSupplier
WHERE idCoupon = @idCoupon
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_updateChiTietHoaDon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_updateChiTietHoaDon]

@quantityProduct int,
@unitPrice float,
@intoMoney float,
@moneyDown float,
@idProduct nvarchar(50),
@idBill int

as 
begin
UPDATE [dbo].[Tbl_ChiTietHoaDon]
SET  quantityProduct=@quantityProduct, unitPrice=@unitPrice, intoMoney=@intoMoney, moneyDown=@moneyDown
WHERE idBill =@idBill and idProduct = @idProduct
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_updateChiTietKhuyenMai]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_updateChiTietKhuyenMai]

@discount float,
@status nvarchar(50),
@idProduct nvarchar(50),
@idPromotion int

as 
begin
UPDATE [dbo].[Tbl_ChiTietKhuyenMai]
SET  discount=@discount, status = @status
WHERE idPromotion =@idPromotion and idProduct = @idProduct
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_updateDetailCoupon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_updateDetailCoupon]

@quantityImport int,
@unitPrice float,
@intoMoney float,
@idCoupon int,
@idProduct nvarchar(50)
as
begin

UPDATE Tbl_ChiTietPhieuYcNhapHang
SET quantityImport = @quantityImport,  unitPrice = @unitPrice, intoMoney = @intoMoney
WHERE idCoupon = @idCoupon and idProduct = @idProduct
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_updateDetailReceipt]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_updateDetailReceipt]
/* tạo biến trùng tên với biến trong code */
@idReceipt int,
@idCoupon int,
@quantityRequest int,
@quantityActual INT,
@unitPrice FLOAT,
@intoMoney FLOAT
as
BEGIN 
UPDATE dbo.Tbl_ChiTietNhapKho
SET idReceipt = @idReceipt , quantityRequest = @quantityRequest, quantityActual = @quantityActual, unitPrice = @unitPrice, intoMoney = @intoMoney
WHERE idReceipt = @idReceipt
END
GO
/****** Object:  StoredProcedure [dbo].[Proc_updateEmployee]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_updateEmployee]
@idEmployee nvarchar(50),
@nameEmployee nvarchar(50),
@serviceEmployee nvarchar(50),
@phoneNumber nvarchar(50),
@salaryEmployee float,
@totalSales float,
@quantityBillPay int,
@idUser nvarchar(50),
@birthday date
as
begin
UPDATE Tbl_NhanVien
SET nameEmployee = @nameEmployee, serviceEmployee = @serviceEmployee, phoneNumber = @phoneNumber, salaryEmployee = @salaryEmployee, totalSales = @totalSales, quantityBillPay = @quantityBillPay, idUser = @idUser, birthday = @birthday
WHERE idEmployee = @idEmployee
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_updateHoaDon]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_updateHoaDon]
@idBill int,
@dateBill date,
@sumPay float,
@typePay nvarchar(50),
@discountMoney float,
@pay float ,
@status nvarchar(50),
@idEmployee nvarchar(50),
@idCustomer nvarchar(50)

as
begin
	UPDATE tbl_HoaDon
	SET  dateBill=@dateBill, sumPay=@sumPay, 
		typePay=@typePay, discountMoney=@discountMoney, pay=@pay, 
		status=@status, idEmployee=@idEmployee, idCustomer=@idCustomer
	WHERE idBill = @idBill
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_updateKhachHang]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_updateKhachHang]
@idCustomer nvarchar(50),
@nameCustomer nvarchar(50),
@address nvarchar(max),
@phoneNumber nvarchar(10),
@email nvarchar(50)

as
begin
	UPDATE tbl_KhachHang
	SET nameCustomer=@nameCustomer, address=@address, 
		phoneNumber=@phoneNumber, email=@email
	WHERE idCustomer = @idCustomer
end

GO
/****** Object:  StoredProcedure [dbo].[Proc_updateKhuyenMai]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_updateKhuyenMai]

@idPromotion int,
@namePromotion nvarchar(max),
@status nvarchar(50),
@startDay date,
@endDay date

as 
begin
UPDATE [dbo].[Tbl_KhuyenMai]
SET  namePromotions= @namePromotion, status = @status, startDay= @startDay, endDay=@endDay
WHERE idPromotion =@idPromotion
 end

GO
/****** Object:  StoredProcedure [dbo].[Proc_updateManufacture]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_updateManufacture]
@id int,
@name nvarchar(50)
as
begin
UPDATE Tbl_HangSP
SET idManufactutre=@id, nameManufactutre = @name
WHERE idManufactutre = @id
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_updateQuyen]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Proc_updateQuyen]
@id int,
@name nvarchar(50)
as
begin

UPDATE Tbl_Quyen
SET nameAuth = @name
WHERE idQuyen = @id
end
GO
/****** Object:  StoredProcedure [dbo].[Proc_updateReceipt]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_updateReceipt]
/* tạo biến trùng tên với biến trong code */
@idReceipt int,
@idSupplier NVARCHAR(50),
@dateReceipt date,
@sumPay float
as
BEGIN 
UPDATE dbo.Tbl_PhieuNhapKho
SET idSupplier = @idSupplier , dateReceipt = @dateReceipt, sumPay = @sumPay
WHERE idReceipt = @idReceipt
END
GO
/****** Object:  StoredProcedure [dbo].[Proc_updateSupplier]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_updateSupplier]
/* tạo biến trùng tên với biến trong code */
@idSupplier NVARCHAR(50),
@nameSupplier NVARCHAR(50)
as
BEGIN 
UPDATE dbo.Tbl_NhaCungCap
SET nameSupplier = @nameSupplier
WHERE idSupplier = @idSupplier
END
GO
/****** Object:  StoredProcedure [dbo].[Proc_updateTypeProduct]    Script Date: 10/25/2022 8:28:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Proc_updateTypeProduct]
@id int,
@name nvarchar(50)
as
begin
	UPDATE Tbl_DanhMucLapTop
	SET idTypeProduct=@id, nameTypeProduct=@name
	WHERE idTypeProduct = @id
end
GO
USE [master]
GO
ALTER DATABASE [QuanLyBanLapTop] SET  READ_WRITE 
GO



INSERT INTO Tbl_HangSP VALUES
(4001, N'Asus'),
(4002, N'Acer'),
(4003, N'Apple'),
(4004, N'Dell'),
(4005, N'Lenovo')

---   2) Danh mục laptop   ---
INSERT INTO Tbl_DanhMucLapTop VALUES
(5001, N'Laptop gaming'),
(5002, N'Ultrabook mỏng nhẹ'),
(5003, N'Laptop văn phòng')



---	  4) Sản phẩm   ----
INSERT INTO Tbl_SanPham VALUES
('SP001', N'Tuf Gaming F15 2022', 21000000,  16, N'Còn hàng', 5001, 4001, ''),
('SP002', N'Laptop Acer Swift 3', 22000000,  5, N'Còn hàng', 5002, 4002, ''),
('SP003', N'Laptop Dell Precision 5510', 23000000,  5, N'Còn hàng', 5003, 4004, ''),
('SP004', N'Tuf Gaming A15 2022', 24000000,  5, N'Còn hàng', 5001, 4001, ''),
('SP005', N'Macbook Pro M2', 25000000,  5, N'Còn hàng', 5002, 4003, ''),
('SP006', N'Laptop Asus TUF Gaming F15', 27899000,  5, N'Còn hàng', 5001, 4001, ''),
('SP007', N'Laptop Asus ROG Flow X13', 33990000,  5, N'Còn hàng', 5001, 4001, ''),
('SP008', N'Laptop ASUS ROG Strix SCAR 17 SE G733CX-LL6789W', 102900000 ,  5, N'Còn hàng', 5001, 4001, ''),
('SP009', N'Laptop Acer Gaming Aspire 7 A715-42G-R4XX NH.QAYSV.008', 14690000,  5, N'Còn hàng', 5001, 4002, ''),
('SP010', N'Laptop Gaming Acer Nitro 5 Eagle AN515-57-54MV NH.QENSV.003', 19990000,  5, N'Còn hàng', 5001, 4002, ''),
('SP011', N'Laptop Acer Predator Helios 300 PH315-55-76KG NH.QGPSV.001', 40990000,  5, N'Còn hàng', 5001, 4002, ''),
('SP012', N'Laptop Asus ROG Zephyrus M16 GU603ZX-K8025W', 94990000,  5, N'Còn hàng', 5001, 4001, ''),
('SP013', N'Laptop ASUS ROG Zephyrus G15 GA503RM-LN006W', 40690000,  5, N'Còn hàng', 5001, 4001, ''),
('SP014', N'Laptop Asus ROG Strix G15 G513RC-HN090W', 25990000,  5, N'Còn hàng', 5001, 4001, ''),
('SP015', N'Laptop Dell G15 5511 70283449', 22590000,  5, N'Còn hàng', 5001, 4004, ''),
('SP016', N'Laptop Dell G15 5515C P105F004CGR', 18590000,  5, N'Còn hàng', 5001, 4004, ''),
('SP017', N'Laptop Dell G15 5515D P105F004DGR', 20690000,  5, N'Còn hàng', 5001, 4004, ''),
('SP018', N'Laptop Lenovo IdeaPad Gaming 3 15IAH7 82S9006YVN', 26190000,  5, N'Còn hàng', 5001, 4005, ''),
('SP019', N'Laptop Lenovo Legion 5 15IAH7H 82RB0048VN', 38990000,  5, N'Còn hàng', 5001, 4005, ''),
('SP020', N'Laptop Lenovo Legion 5 Pro 16IAH7H 82RG008SVN', 43990000,  5, N'Còn hàng', 5001, 4005, ''),
('SP021', N'Laptop Asus ZenBook 14 UX425EA-KI839W', 18990000,  5, N'Còn hàng', 5002, 4001, ''),
('SP022', N'Laptop Asus ExpertBook B9400CEA-KC0773T', 29990000,  5, N'Còn hàng', 5002, 4001, ''),
('SP023', N'Laptop Asus Zenbook 14 Flip OLED UP5401ZA-KN101W', 31690000,  5, N'Còn hàng', 5002, 4001, ''),
('SP024', N'Laptop Acer Aspire 3 A315-56-58EG NX.HS5SV.00J', 10999000,  5, N'Còn hàng', 5002, 4002, ''),
('SP025', N'Laptop Acer Aspire 5 A514-55-5954 NX.K5BSV.001', 16990000,  5, N'Còn hàng', 5002, 4002, ''),
('SP026', N'Laptop Acer Swift 3 SF314-512-56QN NX.K0FSV.002', 22990000,  5, N'Còn hàng', 5002, 4002, ''),
('SP027', N'Laptop Apple MacBook Pro M2 2022 13.3 inch MNEH3SA/A Space Grey', 29990000,  5, N'Còn hàng', 5002, 4003, ''),
('SP028', N'Laptop Apple Macbook Air 13.6 inch MLY13SA/A STARLIGHT (Apple M2)', 29550000,  5, N'Còn hàng', 5002, 4003, ''),
('SP029', N'Laptop Apple Macbook Air 13.6 inch MLXW3SA/A Xám (Apple M2)', 29550000,  5, N'Còn hàng', 5002, 4003, ''),
('SP030', N'Laptop Dell Vostro 14 3400 YX51W6', 16790000,  5, N'Còn hàng', 5002, 4004, ''),
('SP031', N'Laptop Dell Inspiron 16 5620 P1WKN', 20790000,  5, N'Còn hàng', 5002, 4004, ''),
('SP032', N'Laptop Dell Inspiron 14 7420 1YT85', 32290000,  5, N'Còn hàng', 5002, 4004, ''),
('SP033', N'Laptop Lenovo ThinkPad X13 Gen 3 21BN00AJVA', 30890000,  5, N'Còn hàng', 5002, 4005, ''),
('SP034', N'Laptop Lenovo IdeaPad 5 15IAL7 82SF006LVN', 18390000,  5, N'Còn hàng', 5002, 4005, ''),
('SP035', N'Laptop Lenovo ThinkBook 14 G2 ITL 20VD00Y0VN', 14990000,  5, N'Còn hàng', 5002, 4005, ''),
('SP036', N'Laptop Asus ZenBook 14 UX425EA-KI839W', 18999000,  5, N'Còn hàng', 5003, 4001, ''),
('SP037', N'Laptop Asus ExpertBook B9400CEA-KC0773T', 29990000,  5, N'Còn hàng', 5003, 4001, ''),
('SP038', N'Laptop Asus Vivobook 14X A1403ZA-LY072W', 14490000,  5, N'Còn hàng', 5003, 4001, ''),
('SP039', N'Laptop Acer Gaming Aspire 7 A715-42G-R4XX NH.QAYSV.008', 14690000,  5, N'Còn hàng', 5003, 4002, ''),
('SP040', N'Laptop Acer Aspire 3 A315-56-58EG NX.HS5SV.00J', 10999000,  5, N'Còn hàng', 5003, 4002, ''),
('SP041', N'Laptop Acer Swift 3 SF314-43-R4X3 NX.AB1SV.004', 18690000,  5, N'Còn hàng', 5003, 4002, ''),
('SP042', N'Laptop Acer Aspire 3 A315-58G-50S4 NX.ADUSV.001', 14690000,  5, N'Còn hàng', 5003, 4002, ''),
('SP043', N'Laptop Acer Aspire 3 A315-56-38B1 NX.HS5SV.00G', 9290000,  5, N'Còn hàng', 5003, 4002, ''),
('SP044', N'Laptop Acer Aspire 5 A515-57-52Y2 NX.K3KSV.003', 16990000,  5, N'Còn hàng', 5003, 4002, ''),
('SP045', N'Laptop Dell Latitude 3420 42LT342001', 10990000,  5, N'Còn hàng', 5003, 4004, ''),
('SP046', N'Laptop Dell Vostro 14 3400 YX51W5', 16790000,  5, N'Còn hàng', 5003, 4004, ''),
('SP047', N'Laptop Dell Vostro 3400 V4I7015W1', 22390000,  5, N'Còn hàng', 5003, 4004, ''),
('SP048', N'Laptop Lenovo V14 G2 ITL 82KA00RTVN', 8990000,  5, N'Còn hàng', 5003, 4005, ''),
('SP049', N'Laptop Lenovo ThinkBook 14 G2 ITL 20VD00Y0VN', 14990000,  5, N'Còn hàng', 5003, 4005, ''),
('SP050', N'Laptop Lenovo ThinkBook 14 G2 ITL 20VD00Y3VN', 17690000,  5, N'Còn hàng', 5003, 4005, '')

---   5) Khách hàng   ---
INSERT INTO Tbl_KhachHang VALUES 

('', N'', N'', '', '')

---   6) Dữ liệu bảng quyền   ---
INSERT INTO Tbl_Quyen VALUES
(7001, 'Admin'),
(7002, 'Employee')

---   7) Dữ liệu bảng tài khoản   ---
INSERT INTO Tbl_TaiKhoan VALUES 
('admin', N'admin', '1234', 7001),
('staff', N'staff', '1234', 7002)


---	  8) Dữ liệu bảng nhân viên   ---
INSERT INTO Tbl_NhanVien VALUES
('admin', N'Nguyễn Hữu Trọng', N'Quản lý', '05/05/2002', '0157823578', 100000000, 0, 0, 'admin'),
('', N'', N'Quản lý', '05/05/2002', '0157823578', 100000000, 0, 0, 'admin')


---   11) Khuyến mãi   ---
INSERT INTO Tbl_KhuyenMai VALUES
(2001, N'Chúc mừng năm mới 2022', N'Hết khuyến mãi', '2022-01-01', '2022-03-03'),
(2002, N'Mừng lễ 30/4', N'Hết khuyến mãi', '2022-04-25', '2022-05-05'),
(2003, N'Back to School', N'Đang khuyến mãi', '2022-08-25', '2022-09-25'),
(2004, N'Merry Chirstmas', N'Sắp khuyến mãi', '2022-12-20', '2022-12-28')

---   12) Dữ liệu bảng chi tiết khuyến mãi
INSERT INTO Tbl_ChiTietKhuyenMai VALUES
(1, N'Hết khuyến mãi', 'SP001', 2001),
(2, N'Hết khuyến mãi', 'SP002', 2001),
(3, N'Hết khuyến mãi', 'SP003', 2002),
(4, N'Đang khuyến mãi', 'SP004', 2003),
(5, N'Hết khuyến mãi', 'SP005', 2004)

---   13) Nhà cung cấp   ---
INSERT INTO Tbl_NhaCungCap VALUES
('ASUS', N'Asus'),
('ACER', N'Acer'),
('APPLE', N'Apple'),
('DELL', N'Dell'),
('LENOVO', N'Lenovo')
