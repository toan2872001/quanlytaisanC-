USE [master]
GO
/****** Object:  Database [QLTS]    Script Date: 21/07/2020 8:56:16 PM ******/
CREATE DATABASE [QLTS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLTS', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QLTS.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLTS_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QLTS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLTS] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLTS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLTS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLTS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLTS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLTS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLTS] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLTS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLTS] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLTS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLTS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLTS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLTS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLTS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLTS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLTS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLTS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLTS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLTS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLTS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLTS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLTS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLTS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLTS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLTS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLTS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLTS] SET  MULTI_USER 
GO
ALTER DATABASE [QLTS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLTS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLTS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLTS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QLTS]
GO
/****** Object:  Table [dbo].[BOPHAN]    Script Date: 21/07/2020 8:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BOPHAN](
	[MaBP] [varchar](10) NOT NULL,
	[TenBP] [nvarchar](50) NULL,
	[ChucNang] [nvarchar](100) NULL,
 CONSTRAINT [PK_BOPHAN] PRIMARY KEY CLUSTERED 
(
	[MaBP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CONGCU]    Script Date: 21/07/2020 8:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CONGCU](
	[MaCC] [varchar](10) NOT NULL,
	[TenCC] [nvarchar](50) NULL,
	[DVT] [nvarchar](20) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[NgayNhap] [datetime] NULL,
	[MaXuatXu] [varchar](10) NULL,
	[MaNguon] [varchar](10) NULL,
	[MaBP] [varchar](10) NULL,
	[TinhTrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_CONGCU] PRIMARY KEY CLUSTERED 
(
	[MaCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAITAISAN]    Script Date: 21/07/2020 8:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAITAISAN](
	[MaLoai] [varchar](10) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[KhauHao] [int] NULL,
 CONSTRAINT [PK_LOAITAISAN] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 21/07/2020 8:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[TaiKhoan] [varchar](10) NOT NULL,
	[MatKhau] [varchar](20) NOT NULL,
	[PhanQuyen] [varchar](20) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[ChucVu] [nvarchar](50) NULL,
	[DienThoai] [varchar](12) NULL,
 CONSTRAINT [PK_NGUOIDUNG] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC,
	[MatKhau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGUONQUY]    Script Date: 21/07/2020 8:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGUONQUY](
	[MaNguon] [varchar](10) NOT NULL,
	[TenNguon] [nvarchar](50) NULL,
 CONSTRAINT [PK_NGUONQUY] PRIMARY KEY CLUSTERED 
(
	[MaNguon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TAISAN]    Script Date: 21/07/2020 8:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAISAN](
	[MaTS] [varchar](10) NOT NULL,
	[TenTS] [nvarchar](50) NULL,
	[DVT] [nvarchar](20) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[NgayNhap] [datetime] NULL,
	[MaLoai] [varchar](10) NULL,
	[MaXuatXu] [varchar](10) NULL,
	[MaNguon] [varchar](10) NULL,
	[MaBP] [varchar](10) NULL,
	[MucKH] [int] NULL,
	[TinhTrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_TAISAN] PRIMARY KEY CLUSTERED 
(
	[MaTS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THANHLYCC]    Script Date: 21/07/2020 8:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THANHLYCC](
	[MaCC] [varchar](10) NOT NULL,
	[TenCC] [nvarchar](50) NULL,
	[DVT] [nvarchar](20) NULL,
	[SoLuong] [int] NULL,
	[MaXuatXu] [varchar](10) NULL,
	[MaNguon] [varchar](10) NULL,
	[MaBP] [varchar](10) NULL,
	[TinhTrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_THANHLYCC] PRIMARY KEY CLUSTERED 
(
	[MaCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THANHLYTS]    Script Date: 21/07/2020 8:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THANHLYTS](
	[MaTS] [varchar](10) NOT NULL,
	[TenTS] [nvarchar](10) NULL,
	[DVT] [nvarchar](20) NULL,
	[SoLuong] [int] NULL,
	[MaLoai] [varchar](10) NULL,
	[MaXuatXu] [varchar](10) NULL,
	[MaNguon] [varchar](10) NULL,
	[MaBP] [varchar](10) NULL,
	[MucKH] [int] NULL,
	[TinhTrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_THANHLYTS] PRIMARY KEY CLUSTERED 
(
	[MaTS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[XUATXU]    Script Date: 21/07/2020 8:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[XUATXU](
	[MaXuatXu] [varchar](10) NOT NULL,
	[NoiXuatXu] [nvarchar](50) NULL,
 CONSTRAINT [PK_XUATXU] PRIMARY KEY CLUSTERED 
(
	[MaXuatXu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP], [ChucNang]) VALUES (N'BP001', N'Ban Giám Hiệu', N'Quản lý chung')
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP], [ChucNang]) VALUES (N'BP002', N'Văn phòng', N'Hồ sơ sổ sách')
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP], [ChucNang]) VALUES (N'BP003', N'Thư viện', N'Phục vụ đọc')
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP], [ChucNang]) VALUES (N'BP004', N'Thiết bị', N'Phục vụ đồ dùng')
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP], [ChucNang]) VALUES (N'BP005', N'Thực hành', N'Phục vụ thực hành, thí nghiệm')
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP], [ChucNang]) VALUES (N'BP006', N'Phòng giáo viên', N'Nghỉ ngơi, chờ')
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP], [ChucNang]) VALUES (N'BP007', N'Phòng học', N'Dạy và học')
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP], [ChucNang]) VALUES (N'BP008', N'Y tế học dường', N'Chăm sóc sức khỏe')
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP], [ChucNang]) VALUES (N'BP009', N'Bảo vệ', N'Bảo quản tài sản nhà trường')
INSERT [dbo].[BOPHAN] ([MaBP], [TenBP], [ChucNang]) VALUES (N'BP010', N'Tin học', N'Công nghệ thông tin')
INSERT [dbo].[CONGCU] ([MaCC], [TenCC], [DVT], [SoLuong], [DonGia], [NgayNhap], [MaXuatXu], [MaNguon], [MaBP], [TinhTrang]) VALUES (N'CC001', N'Quạt hơi nước', N'Cái', 3, 3500000, CAST(0x0000ABBC00000000 AS DateTime), N'XX001', N'N001', N'BP001', N'Đang sử dụng')
INSERT [dbo].[CONGCU] ([MaCC], [TenCC], [DVT], [SoLuong], [DonGia], [NgayNhap], [MaXuatXu], [MaNguon], [MaBP], [TinhTrang]) VALUES (N'CC002', N'Máy lọc nước', N'Cái', 1, 3500000, CAST(0x0000AB3500000000 AS DateTime), N'XX002', N'N002', N'BP003', N'Đang sử dụng')
INSERT [dbo].[CONGCU] ([MaCC], [TenCC], [DVT], [SoLuong], [DonGia], [NgayNhap], [MaXuatXu], [MaNguon], [MaBP], [TinhTrang]) VALUES (N'CC003', N'Máy in', N'Cái', 1, 4000000, CAST(0x0000AC4C00000000 AS DateTime), N'XX001', N'N002', N'BP001', N'Đang sử dụng')
INSERT [dbo].[CONGCU] ([MaCC], [TenCC], [DVT], [SoLuong], [DonGia], [NgayNhap], [MaXuatXu], [MaNguon], [MaBP], [TinhTrang]) VALUES (N'CC004', N'Máy quạt', N'Cái', 5, 450000, CAST(0x0000ABD400000000 AS DateTime), N'XX002', N'N001', N'BP002', N'Đang sử dụng')
INSERT [dbo].[CONGCU] ([MaCC], [TenCC], [DVT], [SoLuong], [DonGia], [NgayNhap], [MaXuatXu], [MaNguon], [MaBP], [TinhTrang]) VALUES (N'CC005', N'Thùng chứa nước', N'Cái', 1, 1500000, CAST(0x00008D3F00000000 AS DateTime), N'XX002', N'N004', N'BP005', N'Hư hỏng')
INSERT [dbo].[CONGCU] ([MaCC], [TenCC], [DVT], [SoLuong], [DonGia], [NgayNhap], [MaXuatXu], [MaNguon], [MaBP], [TinhTrang]) VALUES (N'CC006', N'Loa BH304H', N'Cái', 1, 2450000, CAST(0x0000924000000000 AS DateTime), N'XX004', N'N003', N'BP003', N'Hư hỏng')
INSERT [dbo].[CONGCU] ([MaCC], [TenCC], [DVT], [SoLuong], [DonGia], [NgayNhap], [MaXuatXu], [MaNguon], [MaBP], [TinhTrang]) VALUES (N'CC007', N'Máy in brother 2250 ', N'Cái', 1, 3460000, CAST(0x000097F100000000 AS DateTime), N'XX003', N'N003', N'BP004', N'Hư hỏng')
INSERT [dbo].[CONGCU] ([MaCC], [TenCC], [DVT], [SoLuong], [DonGia], [NgayNhap], [MaXuatXu], [MaNguon], [MaBP], [TinhTrang]) VALUES (N'CC008', N'Quạt trần', N'Cái', 10, 630000, CAST(0x000096A300000000 AS DateTime), N'XX002', N'N002', N'BP004', N'Hư hỏng')
INSERT [dbo].[LOAITAISAN] ([MaLoai], [TenLoai], [KhauHao]) VALUES (N'L001', N'Tài sản hữu hình điện tử', 20)
INSERT [dbo].[LOAITAISAN] ([MaLoai], [TenLoai], [KhauHao]) VALUES (N'L002', N'Tài sản hữu hình gia dụng', 10)
INSERT [dbo].[LOAITAISAN] ([MaLoai], [TenLoai], [KhauHao]) VALUES (N'L003', N'Tài sản vô hình hữu hạn', 20)
INSERT [dbo].[LOAITAISAN] ([MaLoai], [TenLoai], [KhauHao]) VALUES (N'L004', N'Tài sản vô hình vô hạn', 0)
INSERT [dbo].[LOAITAISAN] ([MaLoai], [TenLoai], [KhauHao]) VALUES (N'L005', N'Tài sản khác', 0)
INSERT [dbo].[NGUOIDUNG] ([TaiKhoan], [MatKhau], [PhanQuyen], [HoTen], [NgaySinh], [ChucVu], [DienThoai]) VALUES (N'admin', N'admin', N'admin', N'Administrator', CAST(0x0000AB3500000000 AS DateTime), N'Quản trị', N'02733821407')
INSERT [dbo].[NGUOIDUNG] ([TaiKhoan], [MatKhau], [PhanQuyen], [HoTen], [NgaySinh], [ChucVu], [DienThoai]) VALUES (N'thanhvinh', N'123456', N'user', N'Nguyễn Thanh Vinh', CAST(0x00007F3600000000 AS DateTime), N'Kế toán', N'0122458796')
INSERT [dbo].[NGUOIDUNG] ([TaiKhoan], [MatKhau], [PhanQuyen], [HoTen], [NgaySinh], [ChucVu], [DienThoai]) VALUES (N'vinhphu', N'123456', N'user', N'Trương Vĩnh Phú', CAST(0x0000768800000000 AS DateTime), N'Giáo viên', N'0907903197')
INSERT [dbo].[NGUONQUY] ([MaNguon], [TenNguon]) VALUES (N'N001', N'Ngân sách tỉnh')
INSERT [dbo].[NGUONQUY] ([MaNguon], [TenNguon]) VALUES (N'N002', N'Ngân sách huyện')
INSERT [dbo].[NGUONQUY] ([MaNguon], [TenNguon]) VALUES (N'N003', N'Ngân sách trường')
INSERT [dbo].[NGUONQUY] ([MaNguon], [TenNguon]) VALUES (N'N004', N'Học phí')
INSERT [dbo].[NGUONQUY] ([MaNguon], [TenNguon]) VALUES (N'N005', N'Căn tin')
INSERT [dbo].[NGUONQUY] ([MaNguon], [TenNguon]) VALUES (N'N006', N'Chăm sóc sức khỏe ban đầu')
INSERT [dbo].[NGUONQUY] ([MaNguon], [TenNguon]) VALUES (N'N007', N'Xã hội hóa')
INSERT [dbo].[NGUONQUY] ([MaNguon], [TenNguon]) VALUES (N'N008', N'Nguồn khác')
INSERT [dbo].[TAISAN] ([MaTS], [TenTS], [DVT], [SoLuong], [DonGia], [NgayNhap], [MaLoai], [MaXuatXu], [MaNguon], [MaBP], [MucKH], [TinhTrang]) VALUES (N'TS001', N'Tivi 61 inch LG', N'Cái', 2, 9500000, CAST(0x0000AB3500000000 AS DateTime), N'L002', N'XX002', N'N002', N'BP002', 0, N'Đang sử dụng')
INSERT [dbo].[TAISAN] ([MaTS], [TenTS], [DVT], [SoLuong], [DonGia], [NgayNhap], [MaLoai], [MaXuatXu], [MaNguon], [MaBP], [MucKH], [TinhTrang]) VALUES (N'TS002', N'Tivi 40 inch', N'Cái', 1, 5500000, CAST(0x0000ABCF00000000 AS DateTime), N'L001', N'XX001', N'N001', N'BP001', 0, N'Đang sử dụng')
INSERT [dbo].[TAISAN] ([MaTS], [TenTS], [DVT], [SoLuong], [DonGia], [NgayNhap], [MaLoai], [MaXuatXu], [MaNguon], [MaBP], [MucKH], [TinhTrang]) VALUES (N'TS003', N'Tủ lạnh', N'Cái', 1, 6500000, CAST(0x0000AB7200000000 AS DateTime), N'L002', N'XX003', N'N008', N'BP002', 10, N'Đang sử dụng')
INSERT [dbo].[TAISAN] ([MaTS], [TenTS], [DVT], [SoLuong], [DonGia], [NgayNhap], [MaLoai], [MaXuatXu], [MaNguon], [MaBP], [MucKH], [TinhTrang]) VALUES (N'TS004', N'Máy vi tính', N'Bộ', 24, 11500000, CAST(0x0000A43700000000 AS DateTime), N'L001', N'XX002', N'N001', N'BP005', 30, N'Đang sử dụng')
INSERT [dbo].[TAISAN] ([MaTS], [TenTS], [DVT], [SoLuong], [DonGia], [NgayNhap], [MaLoai], [MaXuatXu], [MaNguon], [MaBP], [MucKH], [TinhTrang]) VALUES (N'TS005', N'Máy phát điện', N'Cái', 1, 9800000, CAST(0x00009F7000000000 AS DateTime), N'L002', N'XX001', N'N001', N'BP003', 60, N'Đang sử dụng')
INSERT [dbo].[TAISAN] ([MaTS], [TenTS], [DVT], [SoLuong], [DonGia], [NgayNhap], [MaLoai], [MaXuatXu], [MaNguon], [MaBP], [MucKH], [TinhTrang]) VALUES (N'TS006', N'Máy chiếu 3D', N'Cái', 1, 12400000, CAST(0x00009B2F00000000 AS DateTime), N'L001', N'XX002', N'N003', N'BP004', 100, N'Hư hỏng')
INSERT [dbo].[TAISAN] ([MaTS], [TenTS], [DVT], [SoLuong], [DonGia], [NgayNhap], [MaLoai], [MaXuatXu], [MaNguon], [MaBP], [MucKH], [TinhTrang]) VALUES (N'TS007', N'Phần mềm kế toán Misa', N'Cái', 1, 15000000, CAST(0x00009FCB00000000 AS DateTime), N'L004', N'XX001', N'N002', N'BP001', 0, N'Đang sử dụng')
INSERT [dbo].[TAISAN] ([MaTS], [TenTS], [DVT], [SoLuong], [DonGia], [NgayNhap], [MaLoai], [MaXuatXu], [MaNguon], [MaBP], [MucKH], [TinhTrang]) VALUES (N'TS008', N'Máy lạnh', N'Cái', 2, 15600000, CAST(0x0000AB5A00000000 AS DateTime), N'L002', N'XX002', N'N002', N'BP005', 0, N'Đang sử dụng')
INSERT [dbo].[THANHLYCC] ([MaCC], [TenCC], [DVT], [SoLuong], [MaXuatXu], [MaNguon], [MaBP], [TinhTrang]) VALUES (N'CC004', N'Máy quạt', N'Cái', 5, N'XX002', N'N001', N'BP002', N'Chờ thanh lý')
INSERT [dbo].[THANHLYTS] ([MaTS], [TenTS], [DVT], [SoLuong], [MaLoai], [MaXuatXu], [MaNguon], [MaBP], [MucKH], [TinhTrang]) VALUES (N'TS008', N'Máy lạnh', N'Cái', 2, N'L002', N'XX002', N'N002', N'BP005', 0, N'Chờ thanh lý')
INSERT [dbo].[XUATXU] ([MaXuatXu], [NoiXuatXu]) VALUES (N'XX001', N'Việt Nam')
INSERT [dbo].[XUATXU] ([MaXuatXu], [NoiXuatXu]) VALUES (N'XX002', N'Trung Quốc')
INSERT [dbo].[XUATXU] ([MaXuatXu], [NoiXuatXu]) VALUES (N'XX003', N'Đài Loan')
INSERT [dbo].[XUATXU] ([MaXuatXu], [NoiXuatXu]) VALUES (N'XX004', N'Hàn Quốc')
INSERT [dbo].[XUATXU] ([MaXuatXu], [NoiXuatXu]) VALUES (N'XX005', N'Hoa Kỳ')
INSERT [dbo].[XUATXU] ([MaXuatXu], [NoiXuatXu]) VALUES (N'XX006', N'Ấn Độ')
ALTER TABLE [dbo].[CONGCU]  WITH CHECK ADD  CONSTRAINT [FK_CONGCU_BOPHAN] FOREIGN KEY([MaBP])
REFERENCES [dbo].[BOPHAN] ([MaBP])
GO
ALTER TABLE [dbo].[CONGCU] CHECK CONSTRAINT [FK_CONGCU_BOPHAN]
GO
ALTER TABLE [dbo].[CONGCU]  WITH CHECK ADD  CONSTRAINT [FK_CONGCU_NGUONQUY] FOREIGN KEY([MaNguon])
REFERENCES [dbo].[NGUONQUY] ([MaNguon])
GO
ALTER TABLE [dbo].[CONGCU] CHECK CONSTRAINT [FK_CONGCU_NGUONQUY]
GO
ALTER TABLE [dbo].[CONGCU]  WITH CHECK ADD  CONSTRAINT [FK_CONGCU_XUATXU] FOREIGN KEY([MaXuatXu])
REFERENCES [dbo].[XUATXU] ([MaXuatXu])
GO
ALTER TABLE [dbo].[CONGCU] CHECK CONSTRAINT [FK_CONGCU_XUATXU]
GO
ALTER TABLE [dbo].[TAISAN]  WITH CHECK ADD  CONSTRAINT [FK_TAISAN_BOPHAN] FOREIGN KEY([MaBP])
REFERENCES [dbo].[BOPHAN] ([MaBP])
GO
ALTER TABLE [dbo].[TAISAN] CHECK CONSTRAINT [FK_TAISAN_BOPHAN]
GO
ALTER TABLE [dbo].[TAISAN]  WITH CHECK ADD  CONSTRAINT [FK_TAISAN_LOAITAISAN] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LOAITAISAN] ([MaLoai])
GO
ALTER TABLE [dbo].[TAISAN] CHECK CONSTRAINT [FK_TAISAN_LOAITAISAN]
GO
ALTER TABLE [dbo].[TAISAN]  WITH CHECK ADD  CONSTRAINT [FK_TAISAN_NGUONQUY] FOREIGN KEY([MaNguon])
REFERENCES [dbo].[NGUONQUY] ([MaNguon])
GO
ALTER TABLE [dbo].[TAISAN] CHECK CONSTRAINT [FK_TAISAN_NGUONQUY]
GO
ALTER TABLE [dbo].[TAISAN]  WITH CHECK ADD  CONSTRAINT [FK_TAISAN_XUATXU] FOREIGN KEY([MaXuatXu])
REFERENCES [dbo].[XUATXU] ([MaXuatXu])
GO
ALTER TABLE [dbo].[TAISAN] CHECK CONSTRAINT [FK_TAISAN_XUATXU]
GO
ALTER TABLE [dbo].[THANHLYCC]  WITH CHECK ADD  CONSTRAINT [FK_THANHLYCC_CONGCU] FOREIGN KEY([MaCC])
REFERENCES [dbo].[CONGCU] ([MaCC])
GO
ALTER TABLE [dbo].[THANHLYCC] CHECK CONSTRAINT [FK_THANHLYCC_CONGCU]
GO
ALTER TABLE [dbo].[THANHLYTS]  WITH CHECK ADD  CONSTRAINT [FK_THANHLYTS_TAISAN] FOREIGN KEY([MaTS])
REFERENCES [dbo].[TAISAN] ([MaTS])
GO
ALTER TABLE [dbo].[THANHLYTS] CHECK CONSTRAINT [FK_THANHLYTS_TAISAN]
GO
USE [master]
GO
ALTER DATABASE [QLTS] SET  READ_WRITE 
GO
