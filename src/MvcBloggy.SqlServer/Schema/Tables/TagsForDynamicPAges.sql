﻿CREATE TABLE [dbo].[TagsForDynamicPages] (
	[Key] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID(),
	[DynamicPageKey] UNIQUEIDENTIFIER NOT NULL,
	[TagKey] UNIQUEIDENTIFIER NOT NULL,
	CONSTRAINT [PK_TagsForDynamicPages] PRIMARY KEY ([Key])
);