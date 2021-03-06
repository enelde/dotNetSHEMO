USE [SHEMO]
GO
/****** Object:  Table [dbo].[REKOMENDASI]    Script Date: 6/14/2014 8:29:26 PM ******/
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
