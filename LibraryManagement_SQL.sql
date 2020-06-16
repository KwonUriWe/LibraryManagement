USE [MYDB1]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 2020-06-16 오후 11:12:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[Isbn] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[Publisher] [varchar](50) NULL,
	[Page] [int] NULL,
	[UserId] [int] NULL,
	[UserName] [varchar](50) NULL,
	[isBorrowed] [bit] NULL,
	[BorrowedAt] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2020-06-16 오후 11:12:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] NULL,
	[Name] [varchar](50) NULL
) ON [PRIMARY]
GO
