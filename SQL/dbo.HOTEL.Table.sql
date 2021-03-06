USE [SHEMO]
GO
/****** Object:  Table [dbo].[HOTEL]    Script Date: 6/14/2014 8:29:26 PM ******/
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
