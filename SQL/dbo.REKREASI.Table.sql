USE [SHEMO]
GO
/****** Object:  Table [dbo].[REKREASI]    Script Date: 6/14/2014 8:29:26 PM ******/
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
