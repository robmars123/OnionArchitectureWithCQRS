USE [ForumBoards]
GO

/****** Object:  Table [dbo].[Posts]    Script Date: 5/19/2024 2:21:58 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Posts]') AND type in (N'U'))
DROP TABLE [dbo].[Posts]
GO

/****** Object:  Table [dbo].[Posts]    Script Date: 5/19/2024 2:21:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Posts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MessageTextRaw] [varchar](500) NULL,
	[UserId] [int] NOT NULL
) ON [PRIMARY]
GO