USE [SHEMO]
GO
/****** Object:  Table [dbo].[KATEGORI_RESTORAN]    Script Date: 6/14/2014 8:29:26 PM ******/
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
