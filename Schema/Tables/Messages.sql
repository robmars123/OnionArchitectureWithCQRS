USE [ForumBoards]
GO

/****** Object:  Table [dbo].[Messages]    Script Date: 5/12/2024 9:14:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Messages](
	[Id] [int] NOT NULL,
	[MessageTextRaw] [varchar](500) NULL,
	[UserId] [int] NOT NULL
) ON [PRIMARY]
GO


