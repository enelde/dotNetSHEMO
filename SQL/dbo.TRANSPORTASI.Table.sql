USE [SHEMO]
GO
/****** Object:  Table [dbo].[TRANSPORTASI]    Script Date: 6/14/2014 8:29:26 PM ******/
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
