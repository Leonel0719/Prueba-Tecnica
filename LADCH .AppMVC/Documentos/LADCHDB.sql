Use [master]
GO
CREATE DATABASE [LADCHDB]
GO
USE [LADCHDB]
GO

CREATE TABLE [dbo].[Jugadores](
[Id] [int] PRIMARY KEY IDENTITY (1,1) NOT NULL,
[Nombre] [Varchar](100) NOT NULL,
[Posicion] [Varchar](100) NOT NULL,
[Dorsal] [int] NOT NULL
)	