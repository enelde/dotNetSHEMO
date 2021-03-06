USE [SHEMO]
GO
/****** Object:  Table [dbo].[EVENT]    Script Date: 6/14/2014 8:29:26 PM ******/
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
