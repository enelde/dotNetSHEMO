USE [master]
GO
/****** Object:  Database [SHEMO]    Script Date: 6/14/2014 8:04:14 PM ******/
CREATE DATABASE [SHEMO]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SHEMO', FILENAME = N'C:\Users\enelde\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\v11.0\SHEMO.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SHEMO_log', FILENAME = N'C:\Users\enelde\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\v11.0\SHEMO.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SHEMO] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SHEMO].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SHEMO] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [SHEMO] SET ANSI_NULLS ON 
GO
ALTER DATABASE [SHEMO] SET ANSI_PADDING ON 
GO
ALTER DATABASE [SHEMO] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [SHEMO] SET ARITHABORT ON 
GO
ALTER DATABASE [SHEMO] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SHEMO] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SHEMO] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SHEMO] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SHEMO] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SHEMO] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [SHEMO] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [SHEMO] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SHEMO] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [SHEMO] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SHEMO] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SHEMO] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SHEMO] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SHEMO] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SHEMO] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SHEMO] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SHEMO] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SHEMO] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SHEMO] SET RECOVERY FULL 
GO
ALTER DATABASE [SHEMO] SET  MULTI_USER 
GO
ALTER DATABASE [SHEMO] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SHEMO] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SHEMO] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SHEMO] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [SHEMO]
GO
/****** Object:  Table [dbo].[EVENT]    Script Date: 6/14/2014 8:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EVENT](
	[ID_Event] [int] NOT NULL,
	[Nama_Event] [varchar](20) NULL,
	[Tanggal_Mulai] [date] NULL,
	[Tanggal_Selesai] [date] NULL,
	[Lokasi_Event] [varchar](100) NULL,
	[Latitude_event] [varchar](50) NULL,
	[Longitude_event] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Event] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
/****** Object:  Table [dbo].[HOTEL]    Script Date: 6/14/2014 8:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOTEL](
	[ID_Hotel] [int] NOT NULL,
	[Nama_Hotel] [varchar](20) NULL,
	[Alamat_Hotel] [varchar](100) NULL,
	[Telpon_Hotel] [varchar](15) NULL,
	[Foto_Hotel] [image] NULL,
	[Website_Hotel] [varchar](20) NULL,
	[Bintang_Hotel] [int] NULL,
	[Latitude_Hotel] [varchar](50) NULL,
	[Longitude_Hotel] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Hotel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
/****** Object:  Table [dbo].[KATEGORI_REKREASI]    Script Date: 6/14/2014 8:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KATEGORI_REKREASI](
	[ID_Kategori_Rekreasi] [int] NOT NULL,
	[Kategori_Rekreasi] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Kategori_Rekreasi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
/****** Object:  Table [dbo].[KATEGORI_RESTORAN]    Script Date: 6/14/2014 8:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KATEGORI_RESTORAN](
	[ID_Kategori_Restoran] [int] NOT NULL,
	[Kategori_Restoran] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Kategori_Restoran] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
/****** Object:  Table [dbo].[KATEGORI_TRASPORTASI]    Script Date: 6/14/2014 8:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KATEGORI_TRASPORTASI](
	[ID_Kategori_Transportasi] [int] NOT NULL,
	[Kategori_Transportasi] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Kategori_Transportasi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
/****** Object:  Table [dbo].[KATEGORI_WISATA]    Script Date: 6/14/2014 8:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KATEGORI_WISATA](
	[ID_Kategori_Wisata] [int] NOT NULL,
	[Kategori_Wisata] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Kategori_Wisata] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
/****** Object:  Table [dbo].[PROFILE]    Script Date: 6/14/2014 8:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PROFILE](
	[ID_Profile] [int] NOT NULL,
	[Nama_Profile] [varchar](30) NOT NULL,
	[Foto_Profile] [image] NULL,
	[Deskripsi_Profile] [varchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Profile] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
/****** Object:  Table [dbo].[REKOMENDASI]    Script Date: 6/14/2014 8:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[REKOMENDASI](
	[ID_Rekomendasi] [int] NOT NULL,
	[Nama_Wisata_Rekomendasi] [varchar](20) NOT NULL,
	[Alamat_Wisata_Rekomendasi] [varchar](50) NOT NULL,
	[Telpon_Wisata_Rekomendasi] [varchar](15) NOT NULL,
	[Latitude_Wisata_Rekomendasi] [varchar](30) NULL,
	[Longitude_Wisata_Rekomendasi] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Rekomendasi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
/****** Object:  Table [dbo].[REKREASI]    Script Date: 6/14/2014 8:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[REKREASI](
	[ID_Rekreasi] [int] NOT NULL,
	[ID_Kategori_Rekreasi] [int] NULL,
	[Nama_Rekreasi] [varchar](50) NULL,
	[Alamat_Rekreasi] [varchar](50) NULL,
	[Telpon_Rekreasi] [varchar](15) NULL,
	[Foto_Rekreasi] [image] NULL,
	[Latitude_Rekreasi] [varchar](30) NULL,
	[Longitude_Rekreasi] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Rekreasi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
/****** Object:  Table [dbo].[RESTORAN]    Script Date: 6/14/2014 8:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RESTORAN](
	[ID_Restoran] [int] NOT NULL,
	[ID_Kategori_Restoran] [int] NOT NULL,
	[Nama_Restoran] [varchar](20) NOT NULL,
	[Alamat_Restoran] [varchar](100) NOT NULL,
	[Telpon_Restoran] [varchar](15) NULL,
	[Foto_Restoran] [image] NULL,
	[Latitude_Restoran] [varchar](30) NULL,
	[Longitude_Restoran] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Restoran] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
/****** Object:  Table [dbo].[TAKSI]    Script Date: 6/14/2014 8:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAKSI](
	[ID_Taksi] [int] NOT NULL,
	[Nama_Taksi] [varchar](20) NULL,
	[Telpon_Taksi] [varchar](15) NULL,
	[Minimum_Price] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Taksi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
/****** Object:  Table [dbo].[TRANSPORTASI]    Script Date: 6/14/2014 8:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TRANSPORTASI](
	[ID_Transportasi] [int] NOT NULL,
	[Nama_Transportasi] [varchar](30) NOT NULL,
	[Rute_Asal] [varchar](50) NULL,
	[Rute_Tujuan] [varchar](50) NULL,
	[Price] [money] NOT NULL,
	[ID_Kategori_Transportasi] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Transportasi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
/****** Object:  Table [dbo].[WISATA]    Script Date: 6/14/2014 8:04:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[WISATA](
	[ID_Wisata] [int] NOT NULL,
	[ID_Kategori_Wisata] [int] NOT NULL,
	[Nama_Wisata] [varchar](50) NOT NULL,
	[Alamat_Wisata] [varchar](50) NOT NULL,
	[Telpon_Wisata] [varchar](15) NULL,
	[Foto_Wisata] [image] NULL,
	[Deskripsi_Wisata] [varchar](100) NULL,
	[Latitude_Wisata] [varchar](30) NULL,
	[Longitude_Wisata] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Wisata] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
USE [master]
GO
ALTER DATABASE [SHEMO] SET  READ_WRITE 
GO
