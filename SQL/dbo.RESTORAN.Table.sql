USE [SHEMO]
GO
/****** Object:  Table [dbo].[RESTORAN]    Script Date: 6/14/2014 8:29:26 PM ******/
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
