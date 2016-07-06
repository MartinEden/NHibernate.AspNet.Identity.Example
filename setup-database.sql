CREATE DATABASE [NHibernate.AspNet.Identity.Example]
GO

USE [NHibernate.AspNet.Identity.Example];
CREATE TABLE [User] (
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [UserName] [nvarchar] (255) NULL,
    [PasswordHash] [nvarchar](255) NOT NULL DEFAULT (''),
    PRIMARY KEY CLUSTERED ([Id] ASC)
)