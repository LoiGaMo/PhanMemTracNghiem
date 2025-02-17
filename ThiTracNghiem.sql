USE [master]
GO
/****** Object:  Database [ThiTracNghiem]    Script Date: 02/12/2023 11:24:27 CH ******/
CREATE DATABASE [ThiTracNghiem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLDSV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLDSV.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLDSV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLDSV_log.ldf' , SIZE = 4672KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ThiTracNghiem] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ThiTracNghiem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ThiTracNghiem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET ARITHABORT OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ThiTracNghiem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ThiTracNghiem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ThiTracNghiem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ThiTracNghiem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ThiTracNghiem] SET  MULTI_USER 
GO
ALTER DATABASE [ThiTracNghiem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ThiTracNghiem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ThiTracNghiem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ThiTracNghiem] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ThiTracNghiem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ThiTracNghiem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ThiTracNghiem', N'ON'
GO
ALTER DATABASE [ThiTracNghiem] SET QUERY_STORE = OFF
GO
USE [ThiTracNghiem]
GO
/****** Object:  Table [dbo].[CAUHOI]    Script Date: 02/12/2023 11:24:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAUHOI](
	[MACH] [nchar](10) NOT NULL,
	[NOIDUNG] [ntext] NULL,
	[DAPAN] [nvarchar](50) NULL,
	[TRINHDO] [nchar](10) NULL,
	[TENMH] [nvarchar](50) NULL,
	[MAGV] [nchar](10) NULL,
	[MALOAI] [nchar](10) NULL,
 CONSTRAINT [PK_CAUHOI] PRIMARY KEY CLUSTERED 
(
	[MACH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETBT]    Script Date: 02/12/2023 11:24:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETBT](
	[MABT] [nchar](10) NOT NULL,
	[MACH] [nchar](10) NOT NULL,
	[CAUDACHON] [nchar](10) NULL,
 CONSTRAINT [PK_CHITIETBT] PRIMARY KEY CLUSTERED 
(
	[MABT] ASC,
	[MACH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHONLUA]    Script Date: 02/12/2023 11:24:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHONLUA](
	[MACHONLUA] [nchar](10) NOT NULL,
	[CAU] [nvarchar](50) NULL,
	[NOIDUNG] [ntext] NULL,
	[MACH] [nchar](10) NULL,
 CONSTRAINT [PK_CHONLUA] PRIMARY KEY CLUSTERED 
(
	[MACHONLUA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANGKYTHI]    Script Date: 02/12/2023 11:24:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANGKYTHI](
	[IDDKT] [nchar](10) NOT NULL,
	[MALOP] [nchar](10) NULL,
	[MAMH] [nchar](10) NULL,
	[LANTHI] [nchar](10) NULL,
	[NGAYTHI] [nchar](10) NULL,
	[TRINHDO] [nchar](10) NULL,
	[SOCAUHOI] [nchar](10) NULL,
	[THOIGIAN] [nchar](10) NULL,
	[MANVPDT] [nchar](10) NULL,
 CONSTRAINT [PK_DANGKYTHI] PRIMARY KEY CLUSTERED 
(
	[IDDKT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIAOVIEN]    Script Date: 02/12/2023 11:24:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIAOVIEN](
	[MAGV] [nchar](10) NOT NULL,
	[HOTENGV] [nvarchar](50) NULL,
	[MAKHOA] [nchar](10) NULL,
	[PASS] [nvarchar](50) NULL,
 CONSTRAINT [PK_GIAOVIEN] PRIMARY KEY CLUSTERED 
(
	[MAGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 02/12/2023 11:24:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOA](
	[MAKHOA] [nchar](10) NOT NULL,
	[TENKHOA] [nvarchar](50) NULL,
 CONSTRAINT [PK_KHOA] PRIMARY KEY CLUSTERED 
(
	[MAKHOA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAICAUHOI]    Script Date: 02/12/2023 11:24:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAICAUHOI](
	[MALOAI] [nchar](10) NOT NULL,
	[TENLOAI] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAICAUHOI] PRIMARY KEY CLUSTERED 
(
	[MALOAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOP]    Script Date: 02/12/2023 11:24:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOP](
	[MALOP] [nchar](10) NOT NULL,
	[TENLOP] [nvarchar](50) NULL,
	[MAKHOA] [nchar](10) NULL,
 CONSTRAINT [PK_LOP] PRIMARY KEY CLUSTERED 
(
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 02/12/2023 11:24:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MAMH] [nchar](10) NOT NULL,
	[TENMH] [nvarchar](50) NULL,
 CONSTRAINT [PK_MONHOC] PRIMARY KEY CLUSTERED 
(
	[MAMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONGDAOTAO]    Script Date: 02/12/2023 11:24:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONGDAOTAO](
	[MANVPDT] [nchar](10) NOT NULL,
	[TENNVPDT] [nvarchar](50) NULL,
 CONSTRAINT [PK_PHONGDAOTAO] PRIMARY KEY CLUSTERED 
(
	[MANVPDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 02/12/2023 11:24:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MASV] [nchar](10) NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[PHAI] [nchar](10) NULL,
	[NGAYSINH] [nchar](10) NULL,
	[MALOP] [nchar](10) NULL,
	[PASS] [nvarchar](50) NULL,
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 02/12/2023 11:24:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[MANGUOIDUNG] [nchar](10) NULL,
	[PASS] [nvarchar](50) NULL,
	[CHUCVU] [nchar](10) NULL,
	[TENDANGNHAP] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THI]    Script Date: 02/12/2023 11:24:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THI](
	[MABT] [nchar](10) NOT NULL,
	[MASV] [nchar](10) NULL,
	[DIEM] [nchar](10) NULL,
	[IDDKT] [nchar](10) NULL,
 CONSTRAINT [PK_THI] PRIMARY KEY CLUSTERED 
(
	[MABT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THONGTINTHI]    Script Date: 02/12/2023 11:24:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THONGTINTHI](
	[MASV] [nchar](10) NOT NULL,
	[TENMH] [nvarchar](50) NOT NULL,
	[LAN1] [bit] NULL,
	[LAN2] [bit] NULL,
 CONSTRAINT [PK_THONGTINTHI] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC,
	[TENMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [DAPAN], [TRINHDO], [TENMH], [MAGV], [MALOAI]) VALUES (N'00        ', N'long lt(int n){
   if(n == 0) return 1;
   else         return (2*lt(n-1);
}
kết quả nào đúng khi thực hiện giải thuật sau :', N'd', N'Đại học   ', N'Cấu trúc dữ liệu', N'gv01      ', N'0         ')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [DAPAN], [TRINHDO], [TENMH], [MAGV], [MALOAI]) VALUES (N'01        ', N'Dấu hiệu nào dưới đây cho biết danh sách liên kết đơn L là rỗng:', N'b', N'Đại học   ', N'Cấu trúc dữ liệu', N'gv01      ', N'0         ')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [DAPAN], [TRINHDO], [TENMH], [MAGV], [MALOAI]) VALUES (N'02        ', N'K?t qu? nào dúng khi th?c hi?n gi?i thu?t sau v?i a[]= {-3, -3, 15, -3}; n= 4; x= -3:
int FindX(int a[], int n, int x){
   int i;
   for (i= n; i>= 1; i--) if (a[i]==x) return (i);
   return (-1);
}', N'c', N'Ð?i h?c   ', N'C?u trúc d? li?u', N'gv01      ', N'0         ')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [DAPAN], [TRINHDO], [TENMH], [MAGV], [MALOAI]) VALUES (N'03        ', N'Thao tác nào dưới đây thực hiện trên hàng đợi (queue):', N'a', N'Đại học   ', N'Cấu trúc dữ liệu', N'gv01      ', N'0         ')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [DAPAN], [TRINHDO], [TENMH], [MAGV], [MALOAI]) VALUES (N'12        ', N'Dấu hiệu nào dưới đây cho biết hàng đợi đã có thao tác thêm và loại bỏ phần tử là rỗng:', N'a', N'Đại học   ', N'Cấu trúc dữ liệu', N'gv01      ', N'0         ')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [DAPAN], [TRINHDO], [TENMH], [MAGV], [MALOAI]) VALUES (N'15        ', N'Thao tác nào dưới đây thực hiện trên ngăn xếp (stack):', N'b', N'Đại học   ', N'Cấu trúc dữ liệu', N'gv01      ', N'0         ')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [DAPAN], [TRINHDO], [TENMH], [MAGV], [MALOAI]) VALUES (N'17        ', N'Nút có khóa lớn nhất trong cây nhị phân tìm kiếm khác rỗng là:', N'd', N'Đại học   ', N'Cấu trúc dữ liệu', N'GV01      ', N'0         ')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [DAPAN], [TRINHDO], [TENMH], [MAGV], [MALOAI]) VALUES (N'18        ', N'Trong phép duyệt cây nhị phân có 24 nút theo thứ tự sau, nút gốc có thứ tự:', N'd', N'Đại học   ', N'Cấu trúc dữ liệu', N'GV01      ', N'0         ')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [DAPAN], [TRINHDO], [TENMH], [MAGV], [MALOAI]) VALUES (N'19        ', N'Nút có khóa nhỏ nhất trong cây nhị phân tìm kiếm khác rỗng là:', N'b', N'Đại học   ', N'Cấu trúc dữ liệu', N'GV01      ', N'0         ')
INSERT [dbo].[CAUHOI] ([MACH], [NOIDUNG], [DAPAN], [TRINHDO], [TENMH], [MAGV], [MALOAI]) VALUES (N'20        ', N'Cây nhị phân khác rỗng là cây:', N'a', N'Đại học   ', N'Cấu trúc dữ liệu', N'gv01      ', N'0         ')
GO
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'11        ', N'00        ', N'a         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'11        ', N'01        ', N'a         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'11        ', N'02        ', N'a         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'11        ', N'03        ', N'a         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'11        ', N'12        ', N'a         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'11        ', N'15        ', N'a         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'11        ', N'17        ', N'a         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'11        ', N'18        ', N'a         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'11        ', N'19        ', N'a         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'11        ', N'20        ', N'a         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'12        ', N'00        ', N'a         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'12        ', N'01        ', N'null      ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'12        ', N'02        ', N'null      ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'12        ', N'03        ', N'null      ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'12        ', N'12        ', N'null      ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'12        ', N'15        ', N'null      ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'12        ', N'17        ', N'null      ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'12        ', N'18        ', N'null      ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'12        ', N'19        ', N'null      ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'12        ', N'20        ', N'null      ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'13        ', N'00        ', N'a         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'13        ', N'01        ', N'b         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'13        ', N'02        ', N'b         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'13        ', N'03        ', N'd         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'13        ', N'12        ', N'b         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'13        ', N'15        ', N'd         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'13        ', N'17        ', N'd         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'13        ', N'18        ', N'd         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'13        ', N'19        ', N'd         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'13        ', N'20        ', N'a         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'14        ', N'00        ', N'a         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'14        ', N'01        ', N'c         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'14        ', N'02        ', N'b         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'14        ', N'03        ', N'a         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'14        ', N'12        ', N'd         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'14        ', N'15        ', N'c         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'14        ', N'17        ', N'b         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'14        ', N'18        ', N'd         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'14        ', N'19        ', N'b         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'14        ', N'20        ', N'a         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'15        ', N'00        ', N'b         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'15        ', N'01        ', N'a         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'15        ', N'02        ', N'd         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'15        ', N'03        ', N'b         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'15        ', N'12        ', N'c         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'15        ', N'15        ', N'a         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'15        ', N'17        ', N'c         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'15        ', N'18        ', N'b         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'15        ', N'19        ', N'd         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'15        ', N'20        ', N'a         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'16        ', N'00        ', N'c         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'16        ', N'01        ', N'b         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'16        ', N'02        ', N'a         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'16        ', N'03        ', N'd         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'16        ', N'12        ', N'b         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'16        ', N'15        ', N'c         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'16        ', N'17        ', N'd         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'16        ', N'18        ', N'a         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'16        ', N'19        ', N'b         ')
INSERT [dbo].[CHITIETBT] ([MABT], [MACH], [CAUDACHON]) VALUES (N'16        ', N'20        ', N'd         ')
GO
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'01        ', N'a', N'( L -> next == NULL )', N'01        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'02        ', N'b', N'( L == NULL )', N'01        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'03        ', N'c', N'( L -> info == NULL )', N'01        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'04        ', N'd', N'( L -> left == NULL )', N'01        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'05        ', N'a', N'lt(12) = 2010', N'00        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'06        ', N'b', N'lt(12) = 1024', N'00        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'08        ', N'c', N'lt(7) = 720', N'00        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'09        ', N'd', N'lt(6) = 64', N'00        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'23        ', N'a', N'1', N'02        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'24        ', N'b', N'2', N'02        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'25        ', N'c', N'4', N'02        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'26        ', N'd', N'3', N'02        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'31        ', N'a', N'Lối trước có giá trị > giá trị của lối sau', N'12        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'32        ', N'b', N'Lối sau nhận giá trị = 0', N'12        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'33        ', N'c', N'l?i tru?c có giá tr? l?n hon giá tr? l?i sau', N'12        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'34        ', N'd', N'l?i tru?c có giá tr? = 0', N'12        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'39        ', N'a', N'Thêm phần tử vào lối sau', N'03        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'40        ', N'b', N'Loại bỏ phần tử ở lối sau', N'03        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'41        ', N'c', N'Thêm phần tử vào lối trước', N'03        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'42        ', N'd', N'Thêm và loại bỏ phần tử tại vị trí bất kỳ', N'03        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'45        ', N'a', N'Thêm phần tử vào vị trí bất kỳ', N'15        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'46        ', N'b', N'Thêm và loại bỏ phần tử luôn', N'15        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'47        ', N'c', N'Loại bỏ phần tử tại vị trí bất kỳ', N'15        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'48        ', N'd', N'Thêm và loại bỏ phần tử có thể', N'15        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'49        ', N'a', N'Nút con bên trái nhất', N'17        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'50        ', N'b', N'Nút gốc', N'17        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'51        ', N'c', N'Tất cả các nút', N'17        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'52        ', N'd', N'Nút con bên phải nhất', N'17        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'53        ', N'a', N'Thứ 1', N'18        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'54        ', N'b', N'Thứ 2', N'18        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'55        ', N'c', N'thứ 23', N'18        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'56        ', N'd', N'thứ 24', N'18        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'57        ', N'a', N'Nút con bên phải nhất', N'19        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'58        ', N'b', N'Nút con bên trái nhất', N'19        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'59        ', N'c', N'Tất cả các nút', N'19        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'60        ', N'd', N'Nút gốc', N'19        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'61        ', N'a', N'Mỗi nút có không quá 2 nút con', N'20        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'62        ', N'b', N'Mỗi nút (trừ nút lá) đều có hai nút con', N'20        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'63        ', N'c', N'Tất cả các nút đều có nút con', N'20        ')
INSERT [dbo].[CHONLUA] ([MACHONLUA], [CAU], [NOIDUNG], [MACH]) VALUES (N'64        ', N'd', N'Tất cả các nút đều có nút cha', N'20        ')
GO
INSERT [dbo].[DANGKYTHI] ([IDDKT], [MALOP], [MAMH], [LANTHI], [NGAYTHI], [TRINHDO], [SOCAUHOI], [THOIGIAN], [MANVPDT]) VALUES (N'11        ', N'D08THA1   ', N'CTDL      ', N'1         ', N'15102023  ', N'0         ', N'10        ', N'10        ', N'PDT01     ')
INSERT [dbo].[DANGKYTHI] ([IDDKT], [MALOP], [MAMH], [LANTHI], [NGAYTHI], [TRINHDO], [SOCAUHOI], [THOIGIAN], [MANVPDT]) VALUES (N'12        ', N'D08THA1   ', N'CTDL      ', N'1         ', N'16102023  ', N'0         ', N'10        ', N'10        ', N'PDT01     ')
INSERT [dbo].[DANGKYTHI] ([IDDKT], [MALOP], [MAMH], [LANTHI], [NGAYTHI], [TRINHDO], [SOCAUHOI], [THOIGIAN], [MANVPDT]) VALUES (N'13        ', N'D08THA1   ', N'CTDL      ', N'1         ', N'16102023  ', N'0         ', N'10        ', N'10        ', N'PDT01     ')
GO
INSERT [dbo].[GIAOVIEN] ([MAGV], [HOTENGV], [MAKHOA], [PASS]) VALUES (N'GV01      ', N'Lưu Nguyễn Kỳ Thư', N'CNTT      ', N'123')
INSERT [dbo].[GIAOVIEN] ([MAGV], [HOTENGV], [MAKHOA], [PASS]) VALUES (N'GV02      ', N'Nguyễn Quang Tấn', N'CNTT      ', N'12')
GO
INSERT [dbo].[KHOA] ([MAKHOA], [TENKHOA]) VALUES (N'CNTT      ', N'CONG NGHE THONG TIN')
INSERT [dbo].[KHOA] ([MAKHOA], [TENKHOA]) VALUES (N'DTVT      ', N'DIEN TU VIEN THONG')
INSERT [dbo].[KHOA] ([MAKHOA], [TENKHOA]) VALUES (N'QTKD      ', N'QUAN TRI KINH DOANH')
GO
INSERT [dbo].[LOAICAUHOI] ([MALOAI], [TENLOAI]) VALUES (N'0         ', N'Chon 1 trong nhieu dap an')
INSERT [dbo].[LOAICAUHOI] ([MALOAI], [TENLOAI]) VALUES (N'1         ', N'Yes No ')
INSERT [dbo].[LOAICAUHOI] ([MALOAI], [TENLOAI]) VALUES (N'2         ', N'Dien vao cho trong')
GO
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKHOA]) VALUES (N'D08THA1   ', N'CONG NGHE THONG TIN', N'CNTT      ')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKHOA]) VALUES (N'D08THA2   ', N'CONG NGHE THONG TIN 2 ', N'CNTT      ')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKHOA]) VALUES (N'D08THA3   ', N'CONG NGHE THONG TIN 3', N'CNTT      ')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKHOA]) VALUES (N'D08THHTTT ', N'HE THONG THONG TIN', N'CNTT      ')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKHOA]) VALUES (N'D08THM    ', N'MANG ', N'CNTT      ')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKHOA]) VALUES (N'D08THPM   ', N'CONG NGHE PHAN MEM', N'CNTT      ')
GO
INSERT [dbo].[MONHOC] ([MAMH], [TENMH]) VALUES (N'CTDL      ', N'Cấu Trúc Dữ Liệu')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH]) VALUES (N'KTLT      ', N'Kỹ Thuật Lập Trình')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH]) VALUES (N'LTA       ', N'Lập Trình Aglet')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH]) VALUES (N'LTC       ', N'Lap trinh C ')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH]) VALUES (N'LTHDT     ', N'Lập Trình Hướng Đối Tượng')
GO
INSERT [dbo].[PHONGDAOTAO] ([MANVPDT], [TENNVPDT]) VALUES (N'PDT01     ', N'NGUYEN VAN A')
GO
INSERT [dbo].[SINHVIEN] ([MASV], [HOTEN], [PHAI], [NGAYSINH], [MALOP], [PASS]) VALUES (N'123       ', N'test', N'nam       ', N'01012010  ', N'd08tha1   ', N'123')
INSERT [dbo].[SINHVIEN] ([MASV], [HOTEN], [PHAI], [NGAYSINH], [MALOP], [PASS]) VALUES (N'408170001 ', N'Pham Dinh Loi', N'Nam       ', N'07071990  ', N'D08THA1   ', N'123')
INSERT [dbo].[SINHVIEN] ([MASV], [HOTEN], [PHAI], [NGAYSINH], [MALOP], [PASS]) VALUES (N'408170002 ', N'Nguyen Trong Binh', N'Nam       ', N'21041990  ', N'D08THA1   ', N'123')
INSERT [dbo].[SINHVIEN] ([MASV], [HOTEN], [PHAI], [NGAYSINH], [MALOP], [PASS]) VALUES (N'408170003 ', N'Nguyen Van Alex', N'Nam       ', N'12041990  ', N'D08THA1   ', N'123')
INSERT [dbo].[SINHVIEN] ([MASV], [HOTEN], [PHAI], [NGAYSINH], [MALOP], [PASS]) VALUES (N'408170004 ', N'Nguyen Thi Duyen', N'Nu        ', N'03071990  ', N'D08THA1   ', N'123')
INSERT [dbo].[SINHVIEN] ([MASV], [HOTEN], [PHAI], [NGAYSINH], [MALOP], [PASS]) VALUES (N'408170005 ', N'Tran Van Hung ', N'Nam       ', N'12081989  ', N'D08THA1   ', N'123')
INSERT [dbo].[SINHVIEN] ([MASV], [HOTEN], [PHAI], [NGAYSINH], [MALOP], [PASS]) VALUES (N'408170006 ', N'Bui Xuan Cuong', N'Nam       ', N'04121990  ', N'D08THA1   ', N'123')
INSERT [dbo].[SINHVIEN] ([MASV], [HOTEN], [PHAI], [NGAYSINH], [MALOP], [PASS]) VALUES (N'408170007 ', N'Ngo hoang Long', N'Nam       ', N'21041990  ', N'D08THA1   ', N'123')
INSERT [dbo].[SINHVIEN] ([MASV], [HOTEN], [PHAI], [NGAYSINH], [MALOP], [PASS]) VALUES (N'408170052 ', N'Vu Ha Tuan Vu', N'Nam       ', N'01012010  ', N'D08THA1   ', N'1')
INSERT [dbo].[SINHVIEN] ([MASV], [HOTEN], [PHAI], [NGAYSINH], [MALOP], [PASS]) VALUES (N'408170077 ', N'Pham nguyen phu khanh', N'Nam       ', N'01011990  ', N'D08THA2   ', N'123')
GO
INSERT [dbo].[TAIKHOAN] ([MANGUOIDUNG], [PASS], [CHUCVU], [TENDANGNHAP]) VALUES (N'GV01      ', N'123', N'GV        ', N'thuln')
INSERT [dbo].[TAIKHOAN] ([MANGUOIDUNG], [PASS], [CHUCVU], [TENDANGNHAP]) VALUES (N'408170001 ', N'12', N'SV        ', N'nguyentruongan')
INSERT [dbo].[TAIKHOAN] ([MANGUOIDUNG], [PASS], [CHUCVU], [TENDANGNHAP]) VALUES (N'test      ', N'1', N'SV        ', N'123')
INSERT [dbo].[TAIKHOAN] ([MANGUOIDUNG], [PASS], [CHUCVU], [TENDANGNHAP]) VALUES (N'408170004 ', N'123', N'SV        ', N'ntduyen')
INSERT [dbo].[TAIKHOAN] ([MANGUOIDUNG], [PASS], [CHUCVU], [TENDANGNHAP]) VALUES (N'408170005 ', N'123', N'SV        ', N'hungtv')
INSERT [dbo].[TAIKHOAN] ([MANGUOIDUNG], [PASS], [CHUCVU], [TENDANGNHAP]) VALUES (N'408170006 ', N'123', N'SV        ', N'bxcuong')
INSERT [dbo].[TAIKHOAN] ([MANGUOIDUNG], [PASS], [CHUCVU], [TENDANGNHAP]) VALUES (N'408170007 ', N'123', N'SV        ', N'nhlong')
INSERT [dbo].[TAIKHOAN] ([MANGUOIDUNG], [PASS], [CHUCVU], [TENDANGNHAP]) VALUES (N'408170077 ', N'123', N'SV        ', N'khanh')
INSERT [dbo].[TAIKHOAN] ([MANGUOIDUNG], [PASS], [CHUCVU], [TENDANGNHAP]) VALUES (N'408170052 ', N'1', N'SV        ', N'tuanvu')
INSERT [dbo].[TAIKHOAN] ([MANGUOIDUNG], [PASS], [CHUCVU], [TENDANGNHAP]) VALUES (N'GV02      ', N'12', N'GV        ', N'tan')
GO
INSERT [dbo].[THI] ([MABT], [MASV], [DIEM], [IDDKT]) VALUES (N'11        ', N'408170001 ', N'3.0       ', N'12        ')
INSERT [dbo].[THI] ([MABT], [MASV], [DIEM], [IDDKT]) VALUES (N'12        ', N'408170004 ', N'0.0       ', N'12        ')
INSERT [dbo].[THI] ([MABT], [MASV], [DIEM], [IDDKT]) VALUES (N'13        ', N'408170052 ', N'4.0       ', N'12        ')
INSERT [dbo].[THI] ([MABT], [MASV], [DIEM], [IDDKT]) VALUES (N'14        ', N'408170007 ', N'4.0       ', N'12        ')
INSERT [dbo].[THI] ([MABT], [MASV], [DIEM], [IDDKT]) VALUES (N'15        ', N'408170005 ', N'1.0       ', N'12        ')
INSERT [dbo].[THI] ([MABT], [MASV], [DIEM], [IDDKT]) VALUES (N'16        ', N'408170006 ', N'3.0       ', N'12        ')
INSERT [dbo].[THI] ([MABT], [MASV], [DIEM], [IDDKT]) VALUES (N'17        ', N'408170052 ', N'0.0       ', N'12        ')
INSERT [dbo].[THI] ([MABT], [MASV], [DIEM], [IDDKT]) VALUES (N'18        ', N'408170052 ', N'1.0       ', N'12        ')
INSERT [dbo].[THI] ([MABT], [MASV], [DIEM], [IDDKT]) VALUES (N'19        ', N'408170052 ', N'0.0       ', N'12        ')
GO
INSERT [dbo].[THONGTINTHI] ([MASV], [TENMH], [LAN1], [LAN2]) VALUES (N'408170001 ', N'CTDL', 1, 0)
INSERT [dbo].[THONGTINTHI] ([MASV], [TENMH], [LAN1], [LAN2]) VALUES (N'408170004 ', N'CTDL', 1, 0)
INSERT [dbo].[THONGTINTHI] ([MASV], [TENMH], [LAN1], [LAN2]) VALUES (N'408170005 ', N'CTDL', 1, 0)
INSERT [dbo].[THONGTINTHI] ([MASV], [TENMH], [LAN1], [LAN2]) VALUES (N'408170006 ', N'CTDL', 1, 0)
INSERT [dbo].[THONGTINTHI] ([MASV], [TENMH], [LAN1], [LAN2]) VALUES (N'408170007 ', N'CTDL', 1, 0)
INSERT [dbo].[THONGTINTHI] ([MASV], [TENMH], [LAN1], [LAN2]) VALUES (N'408170052 ', N'CTDL', 1, 0)
INSERT [dbo].[THONGTINTHI] ([MASV], [TENMH], [LAN1], [LAN2]) VALUES (N'408170077 ', N'LTC', 1, 0)
GO
ALTER TABLE [dbo].[CAUHOI]  WITH CHECK ADD  CONSTRAINT [FK_CAUHOI_GIAOVIEN] FOREIGN KEY([MAGV])
REFERENCES [dbo].[GIAOVIEN] ([MAGV])
GO
ALTER TABLE [dbo].[CAUHOI] CHECK CONSTRAINT [FK_CAUHOI_GIAOVIEN]
GO
ALTER TABLE [dbo].[CAUHOI]  WITH CHECK ADD  CONSTRAINT [FK_CAUHOI_LOAICAUHOI] FOREIGN KEY([MALOAI])
REFERENCES [dbo].[LOAICAUHOI] ([MALOAI])
GO
ALTER TABLE [dbo].[CAUHOI] CHECK CONSTRAINT [FK_CAUHOI_LOAICAUHOI]
GO
ALTER TABLE [dbo].[CHITIETBT]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETBT_CAUHOI] FOREIGN KEY([MACH])
REFERENCES [dbo].[CAUHOI] ([MACH])
GO
ALTER TABLE [dbo].[CHITIETBT] CHECK CONSTRAINT [FK_CHITIETBT_CAUHOI]
GO
ALTER TABLE [dbo].[CHITIETBT]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETBT_THI] FOREIGN KEY([MABT])
REFERENCES [dbo].[THI] ([MABT])
GO
ALTER TABLE [dbo].[CHITIETBT] CHECK CONSTRAINT [FK_CHITIETBT_THI]
GO
ALTER TABLE [dbo].[CHONLUA]  WITH CHECK ADD  CONSTRAINT [FK_CHONLUA_CAUHOI] FOREIGN KEY([MACH])
REFERENCES [dbo].[CAUHOI] ([MACH])
GO
ALTER TABLE [dbo].[CHONLUA] CHECK CONSTRAINT [FK_CHONLUA_CAUHOI]
GO
ALTER TABLE [dbo].[DANGKYTHI]  WITH CHECK ADD  CONSTRAINT [FK_DANGKYTHI_LOP] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
GO
ALTER TABLE [dbo].[DANGKYTHI] CHECK CONSTRAINT [FK_DANGKYTHI_LOP]
GO
ALTER TABLE [dbo].[DANGKYTHI]  WITH CHECK ADD  CONSTRAINT [FK_DANGKYTHI_MONHOC] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
GO
ALTER TABLE [dbo].[DANGKYTHI] CHECK CONSTRAINT [FK_DANGKYTHI_MONHOC]
GO
ALTER TABLE [dbo].[DANGKYTHI]  WITH CHECK ADD  CONSTRAINT [FK_DANGKYTHI_PHONGDAOTAO] FOREIGN KEY([MANVPDT])
REFERENCES [dbo].[PHONGDAOTAO] ([MANVPDT])
GO
ALTER TABLE [dbo].[DANGKYTHI] CHECK CONSTRAINT [FK_DANGKYTHI_PHONGDAOTAO]
GO
ALTER TABLE [dbo].[GIAOVIEN]  WITH CHECK ADD  CONSTRAINT [FK_GIAOVIEN_KHOA] FOREIGN KEY([MAKHOA])
REFERENCES [dbo].[KHOA] ([MAKHOA])
GO
ALTER TABLE [dbo].[GIAOVIEN] CHECK CONSTRAINT [FK_GIAOVIEN_KHOA]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [FK_LOP_KHOA] FOREIGN KEY([MAKHOA])
REFERENCES [dbo].[KHOA] ([MAKHOA])
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [FK_LOP_KHOA]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_LOP] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOP]
GO
ALTER TABLE [dbo].[THI]  WITH CHECK ADD  CONSTRAINT [FK_THI_DANGKYTHI] FOREIGN KEY([IDDKT])
REFERENCES [dbo].[DANGKYTHI] ([IDDKT])
GO
ALTER TABLE [dbo].[THI] CHECK CONSTRAINT [FK_THI_DANGKYTHI]
GO
ALTER TABLE [dbo].[THI]  WITH CHECK ADD  CONSTRAINT [FK_THI_SINHVIEN] FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
GO
ALTER TABLE [dbo].[THI] CHECK CONSTRAINT [FK_THI_SINHVIEN]
GO
USE [master]
GO
ALTER DATABASE [ThiTracNghiem] SET  READ_WRITE 
GO
