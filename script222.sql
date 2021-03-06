USE [master]
GO
/****** Object:  Database [QLDSV]    Script Date: 3/22/2021 4:00:56 PM ******/
CREATE DATABASE [QLDSV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLDSV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLDSV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLDSV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLDSV_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLDSV] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLDSV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLDSV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLDSV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLDSV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLDSV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLDSV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLDSV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLDSV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLDSV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLDSV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLDSV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLDSV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLDSV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLDSV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLDSV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLDSV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLDSV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLDSV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLDSV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLDSV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLDSV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLDSV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLDSV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLDSV] SET RECOVERY FULL 
GO
ALTER DATABASE [QLDSV] SET  MULTI_USER 
GO
ALTER DATABASE [QLDSV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLDSV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLDSV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLDSV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLDSV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLDSV] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLDSV', N'ON'
GO
ALTER DATABASE [QLDSV] SET QUERY_STORE = OFF
GO
USE [QLDSV]
GO
/****** Object:  Table [dbo].[tblMon]    Script Date: 3/22/2021 4:00:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMon](
	[MaMon] [nvarchar](100) NOT NULL,
	[TenMon] [nvarchar](100) NOT NULL,
	[Sotinchi] [int] NULL,
	[MaKhoa] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLopTinChi]    Script Date: 3/22/2021 4:00:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLopTinChi](
	[MaLopTC] [nvarchar](100) NOT NULL,
	[MaMon] [nvarchar](100) NOT NULL,
	[MaGV] [nvarchar](100) NOT NULL,
	[Sotinlythuyet] [int] NULL,
	[Sotinthuchanh] [int] NULL,
	[Maki] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLopTC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[tenloptheoma]    Script Date: 3/22/2021 4:00:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[tenloptheoma] AS
SELECT  TenMon , tblLopTinChi.MaLopTC
from tblMon ,tblLopTinChi 
where tblLopTinChi.MaMon = tblMon.MaMon
group by  tblLopTinChi.MaLopTC , TenMon
GO
/****** Object:  Table [dbo].[tblSinhVien]    Script Date: 3/22/2021 4:00:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSinhVien](
	[MaSV] [nvarchar](100) NOT NULL,
	[NameSV] [nvarchar](100) NOT NULL,
	[NgaySinhSV] [datetime] NULL,
	[GioiTinhSV] [nvarchar](100) NULL,
	[DiachiSV] [nvarchar](max) NULL,
	[SodienthoaiSV] [nvarchar](100) NULL,
	[EmailSV] [nvarchar](100) NULL,
	[MaLopHCh] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLopHanhChinh]    Script Date: 3/22/2021 4:00:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLopHanhChinh](
	[MaLopHC] [nvarchar](100) NOT NULL,
	[MaGVCM] [nvarchar](100) NOT NULL,
	[MaKhoa] [nvarchar](100) NOT NULL,
	[namNhaphoc] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLopHC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBangDiem]    Script Date: 3/22/2021 4:00:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBangDiem](
	[MaLopTC] [nvarchar](100) NOT NULL,
	[MaSV] [nvarchar](100) NOT NULL,
	[DiemChuyencan] [float] NULL,
	[Diemgiuaky] [float] NULL,
	[Diemthi] [float] NULL,
	[DiemTB] [float] NULL,
 CONSTRAINT [PK__tblBangD__9769A990A80EA9AD] PRIMARY KEY CLUSTERED 
(
	[MaLopTC] ASC,
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[diemloptc]    Script Date: 3/22/2021 4:00:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[diemloptc]
as
select tblLopTinChi.MaLopTC , tblSinhVien.MaSV , tblSinhVien.NameSV ,tblLopHanhChinh.MaLopHC ,
tblBangDiem.DiemChuyencan ,tblBangDiem.Diemgiuaky,tblBangDiem.Diemthi
from tblLopTinChi,tblBangDiem,tblSinhVien,tblLopHanhChinh
where tblLopTinChi.MaLopTC=tblBangDiem.MaLopTC and tblBangDiem.MaSV=tblSinhVien.MaSV and tblSinhVien.MaLopHCh=tblLopHanhChinh.MaLopHC 
GO
/****** Object:  Table [dbo].[kihoc]    Script Date: 3/22/2021 4:00:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kihoc](
	[Maki] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[namhoc] [int] NOT NULL,
 CONSTRAINT [PK_kihoc] PRIMARY KEY CLUSTERED 
(
	[Maki] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGiangVien]    Script Date: 3/22/2021 4:00:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGiangVien](
	[MaGV] [nvarchar](100) NOT NULL,
	[NameGV] [nvarchar](100) NOT NULL,
	[NgaySinhGV] [datetime] NULL,
	[GioiTinhGV] [nvarchar](100) NULL,
	[DiaChiGV] [nvarchar](100) NULL,
	[SDTGV] [nvarchar](100) NULL,
	[emailGV] [nvarchar](100) NULL,
	[hocviGV] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[danhsachlopTC]    Script Date: 3/22/2021 4:00:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[danhsachlopTC]
as
select tblLopTinChi.MaLopTC , tblMon.TenMon, COUNT(tblBangDiem.MaSV) as soluongsv , tblGiangVien.NameGV ,kihoc.Name ,kihoc.namhoc
from tblLopTinChi
left join tblMon ON tblLopTinChi.MaMon=tblMon.MaMon
left join tblBangDiem ON tblBangDiem.MaLopTC=tblLopTinChi.MaLopTC
left join tblGiangVien ON tblGiangVien.MaGV=tblLopTinChi.MaGV
left join kihoc ON tblLopTinChi.Maki=kihoc.Maki
group by tblLopTinChi.MaLopTC, tblMon.TenMon, tblGiangVien.NameGV ,kihoc.Name,kihoc.namhoc
GO
/****** Object:  Table [dbo].[Account]    Script Date: 3/22/2021 4:00:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[userName] [nvarchar](100) NOT NULL,
	[passWord] [nvarchar](100) NOT NULL,
	[Type] [int] NULL,
 CONSTRAINT [PK_acount] PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhoa]    Script Date: 3/22/2021 4:00:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhoa](
	[MaKhoa] [nvarchar](100) NOT NULL,
	[TenKhoa] [nvarchar](100) NULL,
	[DiaChiKhoa] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([userName], [passWord], [Type]) VALUES (N'1', N'1', 1)
INSERT [dbo].[Account] ([userName], [passWord], [Type]) VALUES (N'admin', N'admin', 1)
INSERT [dbo].[Account] ([userName], [passWord], [Type]) VALUES (N'thang99hn', N'thang123', 1)
GO
INSERT [dbo].[kihoc] ([Maki], [Name], [namhoc]) VALUES (N'2019K1', N'Kỳ 1', 2019)
INSERT [dbo].[kihoc] ([Maki], [Name], [namhoc]) VALUES (N'2019K2', N'Kỳ 2', 2019)
INSERT [dbo].[kihoc] ([Maki], [Name], [namhoc]) VALUES (N'2019K3', N'Kỳ 3', 2019)
INSERT [dbo].[kihoc] ([Maki], [Name], [namhoc]) VALUES (N'2020K1', N'Kỳ 1', 2020)
INSERT [dbo].[kihoc] ([Maki], [Name], [namhoc]) VALUES (N'2020K2', N'Kỳ 2', 2020)
INSERT [dbo].[kihoc] ([Maki], [Name], [namhoc]) VALUES (N'2020K3', N'Kỳ 3', 2020)
GO
INSERT [dbo].[tblBangDiem] ([MaLopTC], [MaSV], [DiemChuyencan], [Diemgiuaky], [Diemthi], [DiemTB]) VALUES (N'TC001', N'SV01', 1, 4, 4, 3.7)
INSERT [dbo].[tblBangDiem] ([MaLopTC], [MaSV], [DiemChuyencan], [Diemgiuaky], [Diemthi], [DiemTB]) VALUES (N'TC001', N'SV02', 5, 4, 4, 4.1)
INSERT [dbo].[tblBangDiem] ([MaLopTC], [MaSV], [DiemChuyencan], [Diemgiuaky], [Diemthi], [DiemTB]) VALUES (N'TC001', N'SV03', 5, 5, 5.6, 5.42)
INSERT [dbo].[tblBangDiem] ([MaLopTC], [MaSV], [DiemChuyencan], [Diemgiuaky], [Diemthi], [DiemTB]) VALUES (N'TC001', N'SV04', 8, 7.5, 5, 5.8)
INSERT [dbo].[tblBangDiem] ([MaLopTC], [MaSV], [DiemChuyencan], [Diemgiuaky], [Diemthi], [DiemTB]) VALUES (N'TC001', N'SV05', 5, 5, 8, 7.1)
INSERT [dbo].[tblBangDiem] ([MaLopTC], [MaSV], [DiemChuyencan], [Diemgiuaky], [Diemthi], [DiemTB]) VALUES (N'TC001', N'SV06', 0, 8, 2.6, 3.42)
INSERT [dbo].[tblBangDiem] ([MaLopTC], [MaSV], [DiemChuyencan], [Diemgiuaky], [Diemthi], [DiemTB]) VALUES (N'TC002', N'SV01', 0, NULL, NULL, NULL)
INSERT [dbo].[tblBangDiem] ([MaLopTC], [MaSV], [DiemChuyencan], [Diemgiuaky], [Diemthi], [DiemTB]) VALUES (N'TC002', N'SV02', 6, 6, 8, 7.4)
INSERT [dbo].[tblBangDiem] ([MaLopTC], [MaSV], [DiemChuyencan], [Diemgiuaky], [Diemthi], [DiemTB]) VALUES (N'TC002', N'SV03', 0, 0, 0, 0)
INSERT [dbo].[tblBangDiem] ([MaLopTC], [MaSV], [DiemChuyencan], [Diemgiuaky], [Diemthi], [DiemTB]) VALUES (N'TC002', N'SV04', 6, 5, 6, 5.8)
INSERT [dbo].[tblBangDiem] ([MaLopTC], [MaSV], [DiemChuyencan], [Diemgiuaky], [Diemthi], [DiemTB]) VALUES (N'TC002', N'SV06', NULL, NULL, NULL, NULL)
INSERT [dbo].[tblBangDiem] ([MaLopTC], [MaSV], [DiemChuyencan], [Diemgiuaky], [Diemthi], [DiemTB]) VALUES (N'TC004', N'SV01', NULL, NULL, NULL, NULL)
INSERT [dbo].[tblBangDiem] ([MaLopTC], [MaSV], [DiemChuyencan], [Diemgiuaky], [Diemthi], [DiemTB]) VALUES (N'TC007', N'SV01', NULL, NULL, NULL, NULL)
INSERT [dbo].[tblBangDiem] ([MaLopTC], [MaSV], [DiemChuyencan], [Diemgiuaky], [Diemthi], [DiemTB]) VALUES (N'TC007', N'SV02', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[tblGiangVien] ([MaGV], [NameGV], [NgaySinhGV], [GioiTinhGV], [DiaChiGV], [SDTGV], [emailGV], [hocviGV]) VALUES (N'GV01', N'Nguyễn Hữu Thắng', CAST(N'1989-07-23T00:00:00.000' AS DateTime), N'Nam', N'Hà Nội', N'0974997905', NULL, N'Thạc Sĩ')
INSERT [dbo].[tblGiangVien] ([MaGV], [NameGV], [NgaySinhGV], [GioiTinhGV], [DiaChiGV], [SDTGV], [emailGV], [hocviGV]) VALUES (N'GV02', N'Doãn Quang Anh', CAST(N'1979-08-07T00:00:00.000' AS DateTime), N'Nữ', N'Đà Nẵng', N'0975855486', NULL, N'Thạc Sĩ')
INSERT [dbo].[tblGiangVien] ([MaGV], [NameGV], [NgaySinhGV], [GioiTinhGV], [DiaChiGV], [SDTGV], [emailGV], [hocviGV]) VALUES (N'GV03', N'Trần Khánh Duy', CAST(N'1975-05-05T00:00:00.000' AS DateTime), N'Nam', N'TPHCM', N'75555', NULL, N'Thạc Sĩ')
INSERT [dbo].[tblGiangVien] ([MaGV], [NameGV], [NgaySinhGV], [GioiTinhGV], [DiaChiGV], [SDTGV], [emailGV], [hocviGV]) VALUES (N'GV04', N'Nguyễn Văn Trần', CAST(N'1979-05-05T00:00:00.000' AS DateTime), N'Nữ', N'Hải Dương', N'0852486522', NULL, N'Thạc Sĩ')
INSERT [dbo].[tblGiangVien] ([MaGV], [NameGV], [NgaySinhGV], [GioiTinhGV], [DiaChiGV], [SDTGV], [emailGV], [hocviGV]) VALUES (N'GV05', N'Tạ Thị Thu Huyền', CAST(N'1980-02-02T00:00:00.000' AS DateTime), N'Nữ', N'Hà Nội', N'0425162555', NULL, N'Thạc Sĩ')
INSERT [dbo].[tblGiangVien] ([MaGV], [NameGV], [NgaySinhGV], [GioiTinhGV], [DiaChiGV], [SDTGV], [emailGV], [hocviGV]) VALUES (N'GV06', N'Trần Quang Khải', CAST(N'1980-01-23T00:00:00.000' AS DateTime), N'Nam', N'Hà Nội', N'0255455222', NULL, N'Thạc Sĩ')
INSERT [dbo].[tblGiangVien] ([MaGV], [NameGV], [NgaySinhGV], [GioiTinhGV], [DiaChiGV], [SDTGV], [emailGV], [hocviGV]) VALUES (N'GV07', N'Đào Thị Hằng', CAST(N'1988-05-05T00:00:00.000' AS DateTime), N'Nữ', N'Hà Nội', N'0225524552', NULL, N'Thạc Sĩ')
INSERT [dbo].[tblGiangVien] ([MaGV], [NameGV], [NgaySinhGV], [GioiTinhGV], [DiaChiGV], [SDTGV], [emailGV], [hocviGV]) VALUES (N'GV08', N'Trần Đức Bo', CAST(N'1989-02-01T00:00:00.000' AS DateTime), N'Nam', N'Hà Nội', N'0555785575', NULL, N'Thạc Sĩ')
INSERT [dbo].[tblGiangVien] ([MaGV], [NameGV], [NgaySinhGV], [GioiTinhGV], [DiaChiGV], [SDTGV], [emailGV], [hocviGV]) VALUES (N'GV09', N'Nguyễn Thị Thu ', CAST(N'1989-05-05T00:00:00.000' AS DateTime), N'Nữ', N'Hà Nội', N'0255245632', NULL, N'Thạc Sĩ')
INSERT [dbo].[tblGiangVien] ([MaGV], [NameGV], [NgaySinhGV], [GioiTinhGV], [DiaChiGV], [SDTGV], [emailGV], [hocviGV]) VALUES (N'GV10', N'Trần Văn Kẹo', CAST(N'1989-05-05T00:00:00.000' AS DateTime), N'Nam', N'Hà Nam', N'0252562559', NULL, N'Thạc Sĩ')
GO
INSERT [dbo].[tblKhoa] ([MaKhoa], [TenKhoa], [DiaChiKhoa]) VALUES (N'CNSH', N'Công nghệ Sinh Học', N'Hà Nội')
INSERT [dbo].[tblKhoa] ([MaKhoa], [TenKhoa], [DiaChiKhoa]) VALUES (N'CNTT', N'Công Nghệ Thông Tin', N'Hà Nội')
INSERT [dbo].[tblKhoa] ([MaKhoa], [TenKhoa], [DiaChiKhoa]) VALUES (N'DL', N'Khoa Du Lịch', NULL)
INSERT [dbo].[tblKhoa] ([MaKhoa], [TenKhoa], [DiaChiKhoa]) VALUES (N'KT', N'Khoa Kiến Trúc', NULL)
INSERT [dbo].[tblKhoa] ([MaKhoa], [TenKhoa], [DiaChiKhoa]) VALUES (N'MKTA', N'Khoa Tiếng Anh', N'Hà Nội')
INSERT [dbo].[tblKhoa] ([MaKhoa], [TenKhoa], [DiaChiKhoa]) VALUES (N'MKTQ', N'Khoa Tiếng Trung', N'Hà Nội')
INSERT [dbo].[tblKhoa] ([MaKhoa], [TenKhoa], [DiaChiKhoa]) VALUES (N'TCNH', N'Khoa Tài Chính Ngân Hàng', NULL)
GO
INSERT [dbo].[tblLopHanhChinh] ([MaLopHC], [MaGVCM], [MaKhoa], [namNhaphoc]) VALUES (N'1710A01', N'GV01', N'CNTT', N'2017')
INSERT [dbo].[tblLopHanhChinh] ([MaLopHC], [MaGVCM], [MaKhoa], [namNhaphoc]) VALUES (N'1710A02', N'GV02', N'CNTT', N'2017')
INSERT [dbo].[tblLopHanhChinh] ([MaLopHC], [MaGVCM], [MaKhoa], [namNhaphoc]) VALUES (N'1710A03', N'GV01', N'CNTT', N'2017')
INSERT [dbo].[tblLopHanhChinh] ([MaLopHC], [MaGVCM], [MaKhoa], [namNhaphoc]) VALUES (N'1710A04', N'GV02', N'CNTT', N'2017')
INSERT [dbo].[tblLopHanhChinh] ([MaLopHC], [MaGVCM], [MaKhoa], [namNhaphoc]) VALUES (N'1810A06', N'GV03', N'CNSH', N'2018')
INSERT [dbo].[tblLopHanhChinh] ([MaLopHC], [MaGVCM], [MaKhoa], [namNhaphoc]) VALUES (N'1810A07', N'GV04', N'CNSH', N'2018')
INSERT [dbo].[tblLopHanhChinh] ([MaLopHC], [MaGVCM], [MaKhoa], [namNhaphoc]) VALUES (N'1810A08', N'GV03', N'CNSH', N'2018')
INSERT [dbo].[tblLopHanhChinh] ([MaLopHC], [MaGVCM], [MaKhoa], [namNhaphoc]) VALUES (N'1810A09', N'GV04', N'CNSH', N'2018')
INSERT [dbo].[tblLopHanhChinh] ([MaLopHC], [MaGVCM], [MaKhoa], [namNhaphoc]) VALUES (N'1910A10', N'GV05', N'DL', N'2019')
INSERT [dbo].[tblLopHanhChinh] ([MaLopHC], [MaGVCM], [MaKhoa], [namNhaphoc]) VALUES (N'1910A11', N'GV06', N'DL', N'2019')
INSERT [dbo].[tblLopHanhChinh] ([MaLopHC], [MaGVCM], [MaKhoa], [namNhaphoc]) VALUES (N'1910A12', N'GV05', N'DL', N'2019')
INSERT [dbo].[tblLopHanhChinh] ([MaLopHC], [MaGVCM], [MaKhoa], [namNhaphoc]) VALUES (N'1910A13', N'GV07', N'KT', N'2019')
INSERT [dbo].[tblLopHanhChinh] ([MaLopHC], [MaGVCM], [MaKhoa], [namNhaphoc]) VALUES (N'1910A14', N'GV08', N'KT', N'2019')
INSERT [dbo].[tblLopHanhChinh] ([MaLopHC], [MaGVCM], [MaKhoa], [namNhaphoc]) VALUES (N'1910A15', N'GV07', N'KT', N'2019')
INSERT [dbo].[tblLopHanhChinh] ([MaLopHC], [MaGVCM], [MaKhoa], [namNhaphoc]) VALUES (N'2010A16', N'GV09', N'MKTA', N'2020')
INSERT [dbo].[tblLopHanhChinh] ([MaLopHC], [MaGVCM], [MaKhoa], [namNhaphoc]) VALUES (N'2010A17', N'GV10', N'MKTA', N'2020')
INSERT [dbo].[tblLopHanhChinh] ([MaLopHC], [MaGVCM], [MaKhoa], [namNhaphoc]) VALUES (N'2010A18', N'GV09', N'MkTA', N'2020')
GO
INSERT [dbo].[tblLopTinChi] ([MaLopTC], [MaMon], [MaGV], [Sotinlythuyet], [Sotinthuchanh], [Maki]) VALUES (N'TC001', N'M001', N'GV01', 3, 0, N'2019K1')
INSERT [dbo].[tblLopTinChi] ([MaLopTC], [MaMon], [MaGV], [Sotinlythuyet], [Sotinthuchanh], [Maki]) VALUES (N'TC002', N'M002', N'GV03', 3, 0, N'2019K1')
INSERT [dbo].[tblLopTinChi] ([MaLopTC], [MaMon], [MaGV], [Sotinlythuyet], [Sotinthuchanh], [Maki]) VALUES (N'TC003', N'M003', N'GV02', 3, 0, N'2019K1')
INSERT [dbo].[tblLopTinChi] ([MaLopTC], [MaMon], [MaGV], [Sotinlythuyet], [Sotinthuchanh], [Maki]) VALUES (N'TC004', N'M004', N'GV02', 3, 0, N'2019K1')
INSERT [dbo].[tblLopTinChi] ([MaLopTC], [MaMon], [MaGV], [Sotinlythuyet], [Sotinthuchanh], [Maki]) VALUES (N'TC005', N'M005', N'GV03', 3, 0, N'2019K1')
INSERT [dbo].[tblLopTinChi] ([MaLopTC], [MaMon], [MaGV], [Sotinlythuyet], [Sotinthuchanh], [Maki]) VALUES (N'TC006', N'M006', N'GV01', 2, 2, N'2019K2')
INSERT [dbo].[tblLopTinChi] ([MaLopTC], [MaMon], [MaGV], [Sotinlythuyet], [Sotinthuchanh], [Maki]) VALUES (N'TC007', N'M001', N'GV01', 3, 0, N'2020K1')
INSERT [dbo].[tblLopTinChi] ([MaLopTC], [MaMon], [MaGV], [Sotinlythuyet], [Sotinthuchanh], [Maki]) VALUES (N'TC008', N'M001', N'GV01', NULL, NULL, N'2020K1')
GO
INSERT [dbo].[tblMon] ([MaMon], [TenMon], [Sotinchi], [MaKhoa]) VALUES (N'M001', N'Tin Học Đại Cương', 3, N'CNTT')
INSERT [dbo].[tblMon] ([MaMon], [TenMon], [Sotinchi], [MaKhoa]) VALUES (N'M002', N'Giải Tích', 3, N'CNTT')
INSERT [dbo].[tblMon] ([MaMon], [TenMon], [Sotinchi], [MaKhoa]) VALUES (N'M003', N'Kỹ Thuật Điện Tử Số', 3, N'CNTT')
INSERT [dbo].[tblMon] ([MaMon], [TenMon], [Sotinchi], [MaKhoa]) VALUES (N'M004', N'Tiếng Anh Cơ Bản 1', 3, N'CNTT')
INSERT [dbo].[tblMon] ([MaMon], [TenMon], [Sotinchi], [MaKhoa]) VALUES (N'M005', N'Kiến Trúc Máy Tính', 3, N'CNTT')
INSERT [dbo].[tblMon] ([MaMon], [TenMon], [Sotinchi], [MaKhoa]) VALUES (N'M006', N'Giải Tích2', 3, N'CNTT')
GO
INSERT [dbo].[tblSinhVien] ([MaSV], [NameSV], [NgaySinhSV], [GioiTinhSV], [DiachiSV], [SodienthoaiSV], [EmailSV], [MaLopHCh]) VALUES (N'SV01', N'Nguyễn Văn A', CAST(N'1999-07-07T00:00:00.000' AS DateTime), N'Nam', N'Hà Nội', N'0974997497', N'huuthang.nguyen.@gmail.com', N'1710A01')
INSERT [dbo].[tblSinhVien] ([MaSV], [NameSV], [NgaySinhSV], [GioiTinhSV], [DiachiSV], [SodienthoaiSV], [EmailSV], [MaLopHCh]) VALUES (N'SV02', N'Trần Văn B', CAST(N'1999-05-05T00:00:00.000' AS DateTime), N'Nữ', N'Hà Nội', N'0', N'0', N'1710A01')
INSERT [dbo].[tblSinhVien] ([MaSV], [NameSV], [NgaySinhSV], [GioiTinhSV], [DiachiSV], [SodienthoaiSV], [EmailSV], [MaLopHCh]) VALUES (N'SV03', N'Nguyễn Thị C', CAST(N'1999-02-02T00:00:00.000' AS DateTime), N'Nữ', N'Hà Nội', N'0974997025', N'huthang@gmail.com', N'1710A01')
INSERT [dbo].[tblSinhVien] ([MaSV], [NameSV], [NgaySinhSV], [GioiTinhSV], [DiachiSV], [SodienthoaiSV], [EmailSV], [MaLopHCh]) VALUES (N'SV04', N'Bùi Văn D', CAST(N'1999-06-06T00:00:00.000' AS DateTime), N'Nam', N'Hà Nội', N'0552255', N'huuthang.nguhen986@gmail.com', N'1710A01')
INSERT [dbo].[tblSinhVien] ([MaSV], [NameSV], [NgaySinhSV], [GioiTinhSV], [DiachiSV], [SodienthoaiSV], [EmailSV], [MaLopHCh]) VALUES (N'SV05', N'Trần Đức E', CAST(N'1999-09-13T00:00:00.000' AS DateTime), N'Nam', N'0', N'0', N'0', N'1710A01')
INSERT [dbo].[tblSinhVien] ([MaSV], [NameSV], [NgaySinhSV], [GioiTinhSV], [DiachiSV], [SodienthoaiSV], [EmailSV], [MaLopHCh]) VALUES (N'SV06', N'Tạ Thị F', CAST(N'1999-02-02T00:00:00.000' AS DateTime), N'Nữ', N'Hà Nội', N'052145252', N'0', N'1710A02')
INSERT [dbo].[tblSinhVien] ([MaSV], [NameSV], [NgaySinhSV], [GioiTinhSV], [DiachiSV], [SodienthoaiSV], [EmailSV], [MaLopHCh]) VALUES (N'SV07', N'Nguyễn Hữu G', CAST(N'1999-05-05T00:00:00.000' AS DateTime), N'Nam', N'Hà Nội', N'0', N'0', N'1710A02')
INSERT [dbo].[tblSinhVien] ([MaSV], [NameSV], [NgaySinhSV], [GioiTinhSV], [DiachiSV], [SodienthoaiSV], [EmailSV], [MaLopHCh]) VALUES (N'SV08', N'Cao Thị H', CAST(N'1999-02-02T00:00:00.000' AS DateTime), N'Nữ', N'Hà Nội', N'02566585', N'0', N'1710A02')
INSERT [dbo].[tblSinhVien] ([MaSV], [NameSV], [NgaySinhSV], [GioiTinhSV], [DiachiSV], [SodienthoaiSV], [EmailSV], [MaLopHCh]) VALUES (N'SV09', N'Đào Thị I', CAST(N'1999-09-09T00:00:00.000' AS DateTime), N'Nữ', N'Hà Nội', N'0254521486', N'Skinny1102@gmail.com', N'1710A02')
INSERT [dbo].[tblSinhVien] ([MaSV], [NameSV], [NgaySinhSV], [GioiTinhSV], [DiachiSV], [SodienthoaiSV], [EmailSV], [MaLopHCh]) VALUES (N'SV10', N'Vương Đình K', CAST(N'1999-07-07T00:00:00.000' AS DateTime), N'Nam', N'Hà Nội', N'25621451452', N'0', N'1710A02')
INSERT [dbo].[tblSinhVien] ([MaSV], [NameSV], [NgaySinhSV], [GioiTinhSV], [DiachiSV], [SodienthoaiSV], [EmailSV], [MaLopHCh]) VALUES (N'SV11', N'Nguyễn Hồng L', CAST(N'1999-05-05T00:00:00.000' AS DateTime), N'Nam', N'Hà Nội', N'0974997025', N'thang.nguyen.986@gmail.com', N'1710A01')
INSERT [dbo].[tblSinhVien] ([MaSV], [NameSV], [NgaySinhSV], [GioiTinhSV], [DiachiSV], [SodienthoaiSV], [EmailSV], [MaLopHCh]) VALUES (N'SV12', N'Nguyễn hữu thắng', CAST(N'1999-06-06T00:00:00.000' AS DateTime), N'Nam', N'Hà Nội', N'097455', N'huuthang@gmail,com', N'1710A02')
GO
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [DF_acount_Type]  DEFAULT ((1)) FOR [Type]
GO
ALTER TABLE [dbo].[tblBangDiem]  WITH CHECK ADD  CONSTRAINT [FK_tblBangDiem_tblLopTinChi] FOREIGN KEY([MaLopTC])
REFERENCES [dbo].[tblLopTinChi] ([MaLopTC])
GO
ALTER TABLE [dbo].[tblBangDiem] CHECK CONSTRAINT [FK_tblBangDiem_tblLopTinChi]
GO
ALTER TABLE [dbo].[tblBangDiem]  WITH CHECK ADD  CONSTRAINT [FK_tblBangDiem_tblSinhVien] FOREIGN KEY([MaSV])
REFERENCES [dbo].[tblSinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[tblBangDiem] CHECK CONSTRAINT [FK_tblBangDiem_tblSinhVien]
GO
ALTER TABLE [dbo].[tblLopHanhChinh]  WITH CHECK ADD  CONSTRAINT [FK_tblLopHanhChinh_tblGiangVien] FOREIGN KEY([MaGVCM])
REFERENCES [dbo].[tblGiangVien] ([MaGV])
GO
ALTER TABLE [dbo].[tblLopHanhChinh] CHECK CONSTRAINT [FK_tblLopHanhChinh_tblGiangVien]
GO
ALTER TABLE [dbo].[tblLopHanhChinh]  WITH CHECK ADD  CONSTRAINT [FK_tblLopHanhChinh_tblKhoa] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[tblKhoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[tblLopHanhChinh] CHECK CONSTRAINT [FK_tblLopHanhChinh_tblKhoa]
GO
ALTER TABLE [dbo].[tblLopTinChi]  WITH CHECK ADD  CONSTRAINT [FK_tblLopTinChi_tblGiangVien] FOREIGN KEY([MaGV])
REFERENCES [dbo].[tblGiangVien] ([MaGV])
GO
ALTER TABLE [dbo].[tblLopTinChi] CHECK CONSTRAINT [FK_tblLopTinChi_tblGiangVien]
GO
ALTER TABLE [dbo].[tblLopTinChi]  WITH CHECK ADD  CONSTRAINT [FK_tblLopTinChi_tblMon] FOREIGN KEY([MaMon])
REFERENCES [dbo].[tblMon] ([MaMon])
GO
ALTER TABLE [dbo].[tblLopTinChi] CHECK CONSTRAINT [FK_tblLopTinChi_tblMon]
GO
ALTER TABLE [dbo].[tblMon]  WITH CHECK ADD  CONSTRAINT [FK_tblMon_tblKhoa] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[tblKhoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[tblMon] CHECK CONSTRAINT [FK_tblMon_tblKhoa]
GO
ALTER TABLE [dbo].[tblSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_tblSinhVien_tblLopHanhChinh] FOREIGN KEY([MaLopHCh])
REFERENCES [dbo].[tblLopHanhChinh] ([MaLopHC])
GO
ALTER TABLE [dbo].[tblSinhVien] CHECK CONSTRAINT [FK_tblSinhVien_tblLopHanhChinh]
GO
/****** Object:  StoredProcedure [dbo].[addlop]    Script Date: 3/22/2021 4:00:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[addlop]
@masv nvarchar(50),
@ltc nvarchar(50)
as
begin
insert into  tblBangDiem(MaLopTC,MaSV)
values (@ltc,@masv)
end
GO
/****** Object:  StoredProcedure [dbo].[dssvlopm]    Script Date: 3/22/2021 4:00:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[dssvlopm]
@maloptc nvarchar(50)
as
begin

select tblSinhVien.MaSV , tblSinhVien.NameSV,tblSinhVien.MaLopHCh,tblSinhVien.GioiTinhSV ,tblSinhVien.NgaySinhSV
from tblSinhVien,tblBangDiem,tblLopTinChi
where tblSinhVien.MaSV=tblBangDiem.MaSV and tblBangDiem.MaLopTC=tblLopTinChi.MaLopTC and tblLopTinChi.MaLopTC=@maloptc
group by tblSinhVien.MaSV , tblSinhVien.NameSV,tblSinhVien.MaLopHCh,tblSinhVien.GioiTinhSV ,tblSinhVien.NgaySinhSV
end
GO
/****** Object:  StoredProcedure [dbo].[selectAcount]    Script Date: 3/22/2021 4:00:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selectAcount]
@taikhoan nvarchar(100),
@matkhau nvarchar(100)
as
begin
	SELECT *from Account where userName = @taikhoan and  passWord=  @matkhau

end
GO
/****** Object:  StoredProcedure [dbo].[themmon]    Script Date: 3/22/2021 4:00:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[themmon]
@malop nvarchar(50),
@tenmon nvarchar(50),
@tengiangvien nvarchar(50),
@tenki nvarchar(50),
@namhoc int 
as
begin
declare @mamon nvarchar(50), @magiangvien nvarchar(50),@maki nvarchar(50)
set @mamon=(select tblMon.MaMon from tblMon where @tenmon=tblMon.TenMon)
set @magiangvien=(select tblGiangVien.MaGV from tblGiangVien where @tengiangvien=tblGiangVien.NameGV )
set  @maki=(select kihoc.Maki from kihoc where kihoc.Name=@tenki and kihoc.namhoc=@namhoc)
insert into tblLopTinChi(MaLopTC,MaMon,MaGV,Maki )
values (@malop,@mamon,@magiangvien,@maki)
end
GO
USE [master]
GO
ALTER DATABASE [QLDSV] SET  READ_WRITE 
GO


CREATE proc [dbo].[dsSVlopHC]
(@malop nvarchar(50))
as
begin
	select tblSinhVien.MaSV, tblSinhVien.NameSV,tblSinhVien.NgaySinhSV,tblSinhVien.GioiTinhSV,tblSinhVien.DiachiSV,tblSinhVien.SodienthoaiSV,tblSinhVien.EmailSV,tblSinhVien.MaLopHCh,tblGiangVien.NameGV
	from tblSinhVien,tblGiangVien ,tblLopHanhChinh
	where tblSinhVien.MaLopHCh=tblLopHanhChinh.MaLopHC and tblLopHanhChinh.MaGVCM=tblGiangVien.MaGV and tblSinhVien.MaLopHCh=@malop
end

CREATE proc [dbo].[dsSVlopTC]
@maloptc nvarchar(50)
as
begin
 select tblSinhVien.MaSV ,tblSinhVien.NameSV,tblSinhVien.NgaySinhSV,tblSinhVien.GioiTinhSV,tblSinhVien.MaLopHch,
 tblBangDiem.DiemChuyencan,tblBangDiem.Diemgiuaky,tblBangDiem.Diemthi,tblBangDiem.DiemTB,tblBangDiem.MaLopTC,tblMon.TenMon,tblMon.SotinChi,tblGiangVien.NameGV
 from tblSinhVien,tblBangDiem,tblMon,tblLopTinChi,tblGiangVien
 where tblLopTinChi.MaLopTC=@maloptc and tblBangDiem.MaLopTC=tblLopTinChi.MaLopTC and tblLopTinChi.MaMon=tblMon.MaMon and tblSinhVien.MaSV =tblBangDiem.MaSV and
 tblGiangVien.MaGV=tblLopTinChi.MaGV
end