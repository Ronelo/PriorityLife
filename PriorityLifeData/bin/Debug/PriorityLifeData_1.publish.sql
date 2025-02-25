﻿/*
Deployment script for PriorityLife

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "PriorityLife"
:setvar DefaultFilePrefix "PriorityLife"
:setvar DefaultDataPath ""
:setvar DefaultLogPath ""

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
PRINT N'Creating [dbo].[Team]...';


GO
CREATE TABLE [dbo].[Team] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [TeamManager] INT           NOT NULL,
    [TeamName]    VARCHAR (MAX) NOT NULL,
    [Active]      BIT           NOT NULL,
    [AddedBy]     VARCHAR (MAX) NOT NULL,
    [AddedDate]   DATETIME2 (7) NOT NULL,
    [UpdatedBy]   VARCHAR (MAX) NULL,
    [UpdatedDate] DATETIME2 (7) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[TeamDetails]...';


GO
CREATE TABLE [dbo].[TeamDetails] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [TeamId]       INT           NOT NULL,
    [TeamMemberId] INT           NOT NULL,
    [Activate]     BIT           NOT NULL,
    [AddedBy]      VARCHAR (MAX) NOT NULL,
    [AddedDate]    DATETIME2 (7) NOT NULL,
    [UpdatedBy]    VARCHAR (MAX) NULL,
    [UpdatedDate]  DATETIME2 (7) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating unnamed constraint on [dbo].[Team]...';


GO
ALTER TABLE [dbo].[Team]
    ADD DEFAULT 1 FOR [Active];


GO
PRINT N'Creating unnamed constraint on [dbo].[Team]...';


GO
ALTER TABLE [dbo].[Team]
    ADD DEFAULT (getutcdate()) FOR [AddedDate];


GO
PRINT N'Creating unnamed constraint on [dbo].[Team]...';


GO
ALTER TABLE [dbo].[Team]
    ADD DEFAULT (getutcdate()) FOR [UpdatedDate];


GO
PRINT N'Creating unnamed constraint on [dbo].[TeamDetails]...';


GO
ALTER TABLE [dbo].[TeamDetails]
    ADD DEFAULT 1 FOR [Activate];


GO
PRINT N'Creating unnamed constraint on [dbo].[TeamDetails]...';


GO
ALTER TABLE [dbo].[TeamDetails]
    ADD DEFAULT (getutcdate()) FOR [AddedDate];


GO
PRINT N'Creating unnamed constraint on [dbo].[TeamDetails]...';


GO
ALTER TABLE [dbo].[TeamDetails]
    ADD DEFAULT (getutcdate()) FOR [UpdatedDate];


GO
PRINT N'Creating [dbo].[FK_TeamManagerSalespersonId]...';


GO
ALTER TABLE [dbo].[Team] WITH NOCHECK
    ADD CONSTRAINT [FK_TeamManagerSalespersonId] FOREIGN KEY ([TeamManager]) REFERENCES [dbo].[Salesperson] ([Id]);


GO
PRINT N'Creating [dbo].[FK_TeamId]...';


GO
ALTER TABLE [dbo].[TeamDetails] WITH NOCHECK
    ADD CONSTRAINT [FK_TeamId] FOREIGN KEY ([TeamId]) REFERENCES [dbo].[Team] ([Id]);


GO
PRINT N'Creating [dbo].[FK_TeamMemberId]...';


GO
ALTER TABLE [dbo].[TeamDetails] WITH NOCHECK
    ADD CONSTRAINT [FK_TeamMemberId] FOREIGN KEY ([TeamMemberId]) REFERENCES [dbo].[Salesperson] ([Id]);


GO
