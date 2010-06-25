
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 06/25/2010 03:07:04
-- Generated from EDMX file: C:\Dev\Thrip\Thrip.Model\Generated\Thrip.Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Thrip];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------C:\Dev\Thrip\Thrip.Model\Generated\Thrip.Model.edmx.sql

IF OBJECT_ID(N'[dbo].[FK_SessionScheduledSession]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ScheduledSessions] DROP CONSTRAINT [FK_SessionScheduledSession];
GO
IF OBJECT_ID(N'[dbo].[FK_TimeSlotScheduledSession]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ScheduledSessions] DROP CONSTRAINT [FK_TimeSlotScheduledSession];
GO
IF OBJECT_ID(N'[dbo].[FK_LocationScheduledSession]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ScheduledSessions] DROP CONSTRAINT [FK_LocationScheduledSession];
GO
IF OBJECT_ID(N'[dbo].[FK_ConferenceSession_Conference]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConferenceSession] DROP CONSTRAINT [FK_ConferenceSession_Conference];
GO
IF OBJECT_ID(N'[dbo].[FK_ConferenceSession_Session]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConferenceSession] DROP CONSTRAINT [FK_ConferenceSession_Session];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonItinerary]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Itineraries] DROP CONSTRAINT [FK_PersonItinerary];
GO
IF OBJECT_ID(N'[dbo].[FK_ItineraryScheduledSession_Itinerary]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItineraryScheduledSession] DROP CONSTRAINT [FK_ItineraryScheduledSession_Itinerary];
GO
IF OBJECT_ID(N'[dbo].[FK_ItineraryScheduledSession_ScheduledSession]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItineraryScheduledSession] DROP CONSTRAINT [FK_ItineraryScheduledSession_ScheduledSession];
GO
IF OBJECT_ID(N'[dbo].[FK_FacilitatorSession_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FacilitatorSession] DROP CONSTRAINT [FK_FacilitatorSession_Person];
GO
IF OBJECT_ID(N'[dbo].[FK_FacilitatorSession_Session]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FacilitatorSession] DROP CONSTRAINT [FK_FacilitatorSession_Session];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonSessionBookmarks_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonSessionBookmarks] DROP CONSTRAINT [FK_PersonSessionBookmarks_Person];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonSessionBookmarks_Session]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonSessionBookmarks] DROP CONSTRAINT [FK_PersonSessionBookmarks_Session];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[People]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People];
GO
IF OBJECT_ID(N'[dbo].[Conferences]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Conferences];
GO
IF OBJECT_ID(N'[dbo].[Sessions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sessions];
GO
IF OBJECT_ID(N'[dbo].[Locations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Locations];
GO
IF OBJECT_ID(N'[dbo].[TimeSlots]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TimeSlots];
GO
IF OBJECT_ID(N'[dbo].[ScheduledSessions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ScheduledSessions];
GO
IF OBJECT_ID(N'[dbo].[Itineraries]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Itineraries];
GO
IF OBJECT_ID(N'[dbo].[ConferenceSession]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConferenceSession];
GO
IF OBJECT_ID(N'[dbo].[ItineraryScheduledSession]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItineraryScheduledSession];
GO
IF OBJECT_ID(N'[dbo].[FacilitatorSession]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FacilitatorSession];
GO
IF OBJECT_ID(N'[dbo].[PersonSessionBookmarks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonSessionBookmarks];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [Id] uniqueidentifier  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Conferences'
CREATE TABLE [dbo].[Conferences] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [URL] nvarchar(max)  NOT NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NOT NULL
);
GO

-- Creating table 'Sessions'
CREATE TABLE [dbo].[Sessions] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Tags] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TimeSlots'
CREATE TABLE [dbo].[TimeSlots] (
    [Id] uniqueidentifier  NOT NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ScheduledSessions'
CREATE TABLE [dbo].[ScheduledSessions] (
    [Id] uniqueidentifier  NOT NULL,
    [SessionId] uniqueidentifier  NOT NULL,
    [TimeSlotId] uniqueidentifier  NOT NULL,
    [LocationId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Itineraries'
CREATE TABLE [dbo].[Itineraries] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Person_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'ConferenceSession'
CREATE TABLE [dbo].[ConferenceSession] (
    [Conferences_Id] uniqueidentifier  NOT NULL,
    [Sessions_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'ItineraryScheduledSession'
CREATE TABLE [dbo].[ItineraryScheduledSession] (
    [Itineraries_Id] uniqueidentifier  NOT NULL,
    [ScheduledSessions_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'FacilitatorSession'
CREATE TABLE [dbo].[FacilitatorSession] (
    [Facilitators_Id] uniqueidentifier  NOT NULL,
    [Sessions_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'PersonSessionBookmarks'
CREATE TABLE [dbo].[PersonSessionBookmarks] (
    [People_Id] uniqueidentifier  NOT NULL,
    [SessionBookmarks_Id] uniqueidentifier  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Conferences'
ALTER TABLE [dbo].[Conferences]
ADD CONSTRAINT [PK_Conferences]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sessions'
ALTER TABLE [dbo].[Sessions]
ADD CONSTRAINT [PK_Sessions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [PK_Locations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TimeSlots'
ALTER TABLE [dbo].[TimeSlots]
ADD CONSTRAINT [PK_TimeSlots]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ScheduledSessions'
ALTER TABLE [dbo].[ScheduledSessions]
ADD CONSTRAINT [PK_ScheduledSessions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Itineraries'
ALTER TABLE [dbo].[Itineraries]
ADD CONSTRAINT [PK_Itineraries]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Conferences_Id], [Sessions_Id] in table 'ConferenceSession'
ALTER TABLE [dbo].[ConferenceSession]
ADD CONSTRAINT [PK_ConferenceSession]
    PRIMARY KEY NONCLUSTERED ([Conferences_Id], [Sessions_Id] ASC);
GO

-- Creating primary key on [Itineraries_Id], [ScheduledSessions_Id] in table 'ItineraryScheduledSession'
ALTER TABLE [dbo].[ItineraryScheduledSession]
ADD CONSTRAINT [PK_ItineraryScheduledSession]
    PRIMARY KEY NONCLUSTERED ([Itineraries_Id], [ScheduledSessions_Id] ASC);
GO

-- Creating primary key on [Facilitators_Id], [Sessions_Id] in table 'FacilitatorSession'
ALTER TABLE [dbo].[FacilitatorSession]
ADD CONSTRAINT [PK_FacilitatorSession]
    PRIMARY KEY NONCLUSTERED ([Facilitators_Id], [Sessions_Id] ASC);
GO

-- Creating primary key on [People_Id], [SessionBookmarks_Id] in table 'PersonSessionBookmarks'
ALTER TABLE [dbo].[PersonSessionBookmarks]
ADD CONSTRAINT [PK_PersonSessionBookmarks]
    PRIMARY KEY NONCLUSTERED ([People_Id], [SessionBookmarks_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SessionId] in table 'ScheduledSessions'
ALTER TABLE [dbo].[ScheduledSessions]
ADD CONSTRAINT [FK_SessionScheduledSession]
    FOREIGN KEY ([SessionId])
    REFERENCES [dbo].[Sessions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SessionScheduledSession'
CREATE INDEX [IX_FK_SessionScheduledSession]
ON [dbo].[ScheduledSessions]
    ([SessionId]);
GO

-- Creating foreign key on [TimeSlotId] in table 'ScheduledSessions'
ALTER TABLE [dbo].[ScheduledSessions]
ADD CONSTRAINT [FK_TimeSlotScheduledSession]
    FOREIGN KEY ([TimeSlotId])
    REFERENCES [dbo].[TimeSlots]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TimeSlotScheduledSession'
CREATE INDEX [IX_FK_TimeSlotScheduledSession]
ON [dbo].[ScheduledSessions]
    ([TimeSlotId]);
GO

-- Creating foreign key on [LocationId] in table 'ScheduledSessions'
ALTER TABLE [dbo].[ScheduledSessions]
ADD CONSTRAINT [FK_LocationScheduledSession]
    FOREIGN KEY ([LocationId])
    REFERENCES [dbo].[Locations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LocationScheduledSession'
CREATE INDEX [IX_FK_LocationScheduledSession]
ON [dbo].[ScheduledSessions]
    ([LocationId]);
GO

-- Creating foreign key on [Conferences_Id] in table 'ConferenceSession'
ALTER TABLE [dbo].[ConferenceSession]
ADD CONSTRAINT [FK_ConferenceSession_Conference]
    FOREIGN KEY ([Conferences_Id])
    REFERENCES [dbo].[Conferences]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Sessions_Id] in table 'ConferenceSession'
ALTER TABLE [dbo].[ConferenceSession]
ADD CONSTRAINT [FK_ConferenceSession_Session]
    FOREIGN KEY ([Sessions_Id])
    REFERENCES [dbo].[Sessions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ConferenceSession_Session'
CREATE INDEX [IX_FK_ConferenceSession_Session]
ON [dbo].[ConferenceSession]
    ([Sessions_Id]);
GO

-- Creating foreign key on [Person_Id] in table 'Itineraries'
ALTER TABLE [dbo].[Itineraries]
ADD CONSTRAINT [FK_PersonItinerary]
    FOREIGN KEY ([Person_Id])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonItinerary'
CREATE INDEX [IX_FK_PersonItinerary]
ON [dbo].[Itineraries]
    ([Person_Id]);
GO

-- Creating foreign key on [Itineraries_Id] in table 'ItineraryScheduledSession'
ALTER TABLE [dbo].[ItineraryScheduledSession]
ADD CONSTRAINT [FK_ItineraryScheduledSession_Itinerary]
    FOREIGN KEY ([Itineraries_Id])
    REFERENCES [dbo].[Itineraries]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ScheduledSessions_Id] in table 'ItineraryScheduledSession'
ALTER TABLE [dbo].[ItineraryScheduledSession]
ADD CONSTRAINT [FK_ItineraryScheduledSession_ScheduledSession]
    FOREIGN KEY ([ScheduledSessions_Id])
    REFERENCES [dbo].[ScheduledSessions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ItineraryScheduledSession_ScheduledSession'
CREATE INDEX [IX_FK_ItineraryScheduledSession_ScheduledSession]
ON [dbo].[ItineraryScheduledSession]
    ([ScheduledSessions_Id]);
GO

-- Creating foreign key on [Facilitators_Id] in table 'FacilitatorSession'
ALTER TABLE [dbo].[FacilitatorSession]
ADD CONSTRAINT [FK_FacilitatorSession_Person]
    FOREIGN KEY ([Facilitators_Id])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Sessions_Id] in table 'FacilitatorSession'
ALTER TABLE [dbo].[FacilitatorSession]
ADD CONSTRAINT [FK_FacilitatorSession_Session]
    FOREIGN KEY ([Sessions_Id])
    REFERENCES [dbo].[Sessions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FacilitatorSession_Session'
CREATE INDEX [IX_FK_FacilitatorSession_Session]
ON [dbo].[FacilitatorSession]
    ([Sessions_Id]);
GO

-- Creating foreign key on [People_Id] in table 'PersonSessionBookmarks'
ALTER TABLE [dbo].[PersonSessionBookmarks]
ADD CONSTRAINT [FK_PersonSessionBookmarks_Person]
    FOREIGN KEY ([People_Id])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [SessionBookmarks_Id] in table 'PersonSessionBookmarks'
ALTER TABLE [dbo].[PersonSessionBookmarks]
ADD CONSTRAINT [FK_PersonSessionBookmarks_Session]
    FOREIGN KEY ([SessionBookmarks_Id])
    REFERENCES [dbo].[Sessions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonSessionBookmarks_Session'
CREATE INDEX [IX_FK_PersonSessionBookmarks_Session]
ON [dbo].[PersonSessionBookmarks]
    ([SessionBookmarks_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------