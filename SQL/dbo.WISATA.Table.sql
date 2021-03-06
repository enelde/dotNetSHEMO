USE [SHEMO]
GO
/****** Object:  Table [dbo].[WISATA]    Script Date: 6/14/2014 8:29:26 PM ******/
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
