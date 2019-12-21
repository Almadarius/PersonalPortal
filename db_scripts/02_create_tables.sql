USE [PersonalPortal]
GO

/*
Drop the tables and their constraints in order to avoid referential 
integrity errors
*/

DROP TABLE IF EXISTS [dbo].[Platform]
GO

DROP TABLE IF EXISTS [dbo].[ResourceCategory]
GO

DROP TABLE IF EXISTS [dbo].[ResourceType]
GO

--Drop the foreign key constraints from Resource
ALTER TABLE IF EXISTS [dbo].[Resource] DROP CONSTRAINT IF EXISTS [FK_Resource_ResourceType]
GO

ALTER TABLE IF EXISTS [dbo].[Resource] DROP CONSTRAINT IF EXISTS [FK_Resource_ResourceCategory]
GO

ALTER TABLE IF EXISTS [dbo].[Resource] DROP CONSTRAINT IF EXISTS [FK_Resource_Platform]
GO

DROP TABLE IF EXISTS [dbo].[Resource]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE TABLE [dbo].[Platform](
	[PlatformId] [uniqueidentifier] NOT NULL,
	[PlatformBaseUrl] [varchar](100) NOT NULL,
	[PlatformName] [varchar](50) NOT NULL,
	[PlatformDescription] [varchar](100) NULL,
 CONSTRAINT [PK_Platform] PRIMARY KEY CLUSTERED 
(
	[PlatformId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[ResourceCategory](
	[ResourceCategoryId] [uniqueidentifier] NOT NULL,
	[ResourceCategoryName] [varchar](50) NOT NULL,
	[ResourceCategoryDescription] [varchar](200) NULL,
 CONSTRAINT [PK_ResourceCategory] PRIMARY KEY CLUSTERED 
(
	[ResourceCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ResourceType](
	[ResourceTypeId] [uniqueidentifier] NOT NULL,
	[ResourceTypeName] [varchar](50) NOT NULL,
	[ResourceTypeDescription] [varchar](100) NULL,
 CONSTRAINT [PK_ResourceType] PRIMARY KEY CLUSTERED 
(
	[ResourceTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



/****** Object:  Table [dbo].[Resource]    Script Date: 19/12/2019 08:43:07 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Resource](
	[ResourceId] [uniqueidentifier] NOT NULL,
	[ResourceTypeId] [uniqueidentifier] NOT NULL,
	[ResourceCategoryId] [uniqueidentifier] NOT NULL,
	[PlatformId] [uniqueidentifier] NOT NULL,
	[ResourceName] [varchar](100) NOT NULL,
	[ResourceAltText] [varchar](200) NULL,
	[ResourceUrl] [varchar](500) NOT NULL,
	[ResourceDescription] [varchar](500) NOT NULL,
	[OpenTab] [bit] NOT NULL,
 CONSTRAINT [PK_Resource] PRIMARY KEY CLUSTERED 
(
	[ResourceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Resource]  WITH CHECK ADD  CONSTRAINT [FK_Resource_Platform] FOREIGN KEY([PlatformId])
REFERENCES [dbo].[Platform] ([PlatformId])
GO

ALTER TABLE [dbo].[Resource] CHECK CONSTRAINT [FK_Resource_Platform]
GO

ALTER TABLE [dbo].[Resource]  WITH CHECK ADD  CONSTRAINT [FK_Resource_ResourceCategory] FOREIGN KEY([ResourceCategoryId])
REFERENCES [dbo].[ResourceCategory] ([ResourceCategoryId])
GO

ALTER TABLE [dbo].[Resource] CHECK CONSTRAINT [FK_Resource_ResourceCategory]
GO

ALTER TABLE [dbo].[Resource]  WITH CHECK ADD  CONSTRAINT [FK_Resource_ResourceType] FOREIGN KEY([ResourceTypeId])
REFERENCES [dbo].[ResourceType] ([ResourceTypeId])
GO

ALTER TABLE [dbo].[Resource] CHECK CONSTRAINT [FK_Resource_ResourceType]
GO