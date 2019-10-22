				CREATE DATABASE bd_alumnos
USE [bd_alumnos]
GO
/****** Object:  Table [dbo].[Temas]    Script Date: 08/14/2019 18:20:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Temas](
	[id_tema] [int] IDENTITY (1,1) PRIMARY KEY ,
	[descripcion] VARCHAR(50) NOT NULL 
	)
 GO
CREATE TABLE [dbo].[Profesores](
	[legajo]  INT IDENTITY (1,1) PRIMARY KEY ,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[dni] [bigint] NOT NULL,
	[telefono] VARBINARY(20) NOT NULL,
	[email] [varbinary](50) NULL,
	pasword VARCHAR(50) NOT NULL, 
[anio_ingreso] [int] NOT NULL
 )
GO
CREATE TABLE [dbo].[Clases_Tema](
	[nro_clase]  INT IDENTITY (1,1),
	[legajo_alumno] [int] NOT NULL,
	[legajo_profesor] [int] NOT NULL,
	[id_tema] [int] NOT NULL,
	[nota] [decimal](8, 2) NOT  NULL,
 CONSTRAINT [PK_Clases_tema] PRIMARY KEY CLUSTERED 
(
	[nro_clase] ASC,
	[legajo_alumno] ASC,
	[legajo_profesor] ASC,
	[id_tema] ASC)
	)
	
GO
CREATE TABLE [dbo].[Clases](
	[nro_clase]  INT IDENTITY (1,1),
	[legajo_alumno] [int] NOT NULL,
	[legajo_profesor] [int] NOT NULL,
	[fecha]  DATE  NOT NULL,
	[nota]  DECIMAL (8) NOT NULL,
	[observaciones] VARCHAR (200) NULL,
 CONSTRAINT [PK_Clases_1] PRIMARY KEY CLUSTERED 
(
	[nro_clase] ASC,
	[legajo_alumno] ASC,
	[legajo_profesor] ASC)
)
	GO
CREATE TABLE [dbo].[Alumnos](
	[legajo] INT IDENTITY (1,1) PRIMARY KEY,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[dni] [bigint] NOT NULL,
	[fecha_nac] [date] NOT NULL,
	[telefono] [varbinary](20) NOT NULL,
	email VARCHAR(50) NOT NULL, 
	password VARCHAR(50) NOT NULL
	)
GO
CREATE TABLE administradores (
legajo INT IDENTITY (1,1) PRIMARY KEY,
nombre VARCHAR(50) NOT NULL ,
apellido VARCHAR(50) NOT NULL,
[dni] [bigint] NOT NULL,
[fecha_nac] [date] NOT NULL,
	[telefono] [varbinary](20) NULL,
[email] VARCHAR(50),
password VARCHAR(50) NOT NULL
)
