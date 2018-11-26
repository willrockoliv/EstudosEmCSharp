USE [Test]
GO
/****** Object:  Table [dbo].[MyPlay]    Script Date: 1/23/2014 1:00:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MyPlay](
	[FileId] [uniqueidentifier] NOT NULL,
	[FileName] [nchar](500) NOT NULL,
	[FileData] [varbinary](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
