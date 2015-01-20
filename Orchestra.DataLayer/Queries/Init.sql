/****** Object:  Table [dbo].[Divisions]    Script Date: 01/20/2015 22:44:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Divisions](
	[DivisionId] [int] IDENTITY(1,1) NOT NULL,
	[Path] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Text] [nvarchar](max) NULL,
	[Priority] [int] NOT NULL,
	[ShowMenu] [bit] NOT NULL,
	[Publish] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Divisions] PRIMARY KEY CLUSTERED 
(
	[DivisionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
