USE [PqnLesson11Dbs]
GO
/****** Object:  Table [dbo].[pqntaikhoan]    Script Date: 7/1/2024 6:41:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pqntaikhoan](
	[PqnId] [int] NOT NULL,
	[PqnUseName] [nvarchar](50) NULL,
	[PqnPassword] [nvarchar](50) NULL,
	[PqnFullName] [nvarchar](50) NULL,
	[PqnAge] [int] NULL,
	[PqnEmail] [nvarchar](50) NULL,
	[PqnPhone] [nvarchar](50) NULL,
	[PqnStatus] [bit] NULL,
 CONSTRAINT [PK_pqntaikhoan] PRIMARY KEY CLUSTERED 
(
	[PqnId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[pqntaikhoan] ([PqnId], [PqnUseName], [PqnPassword], [PqnFullName], [PqnAge], [PqnEmail], [PqnPhone], [PqnStatus]) VALUES (115, N'PhamQuangnNhat', N'123456a@', N'Phạm Quang Nhất', 20, N'phamquangnhatdz2105@gmail.com', N'0817842585', 1)
GO
