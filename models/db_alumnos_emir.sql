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
	[id_tema] [int] NOT NULL AUTO_INCREMENT,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Temas] PRIMARY KEY CLUSTERED 
(
	[id_tema] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Profesores]    Script Date: 08/14/2019 18:20:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Profesores](
	[legajo] [int] NOT NULL AUTO_INCREMENT,
pasword VARCHAR(50) NOT NULL, 
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[dni] [bigint] NOT NULL,
	[telefono] [varbinary](20) NULL,
	[email] [varbinary](50) NULL,
	[anio_ingreso] [int] NOT NULL,
 CONSTRAINT [PK_Profesores] PRIMARY KEY CLUSTERED 
(
	[legajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Clases_Tema]    Script Date: 08/14/2019 18:20:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clases_Tema](
	[nro_clase] [int] NOT NULL AUTO_INCREMENT,
	[legajo_alumno] [int] NOT NULL,
	[legajo_profesor] [int] NOT NULL,
	[id_tema] [int] NOT NULL,
	[nota] [decimal](8, 2) NULL,
 CONSTRAINT [PK_Clases_tema] PRIMARY KEY CLUSTERED 
(
	[nro_clase] ASC,
	[legajo_alumno] ASC,
	[legajo_profesor] ASC,
	[id_tema] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clases]    Script Date: 08/14/2019 18:20:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clases](
	[nro_clase] [int] NOT NULL AUTO_INCREMENT,
	[legajo_alumno] [int] NOT NULL,
	[legajo_profesor] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[nota] [decimal](8, 2) NOT NULL,
	[observaciones] [varchar](200) NULL,
 CONSTRAINT [PK_Clases_1] PRIMARY KEY CLUSTERED 
(
	[nro_clase] ASC,
	[legajo_alumno] ASC,
	[legajo_profesor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Alumnos]    Script Date: 08/14/2019 18:20:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Alumnos](
	[legajo] [int] NOT NULL AUTO_INCREMENT,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[dni] [bigint] NOT NULL,
	[fecha_nac] [date] NOT NULL,
 CONSTRAINT [PK_Alumnos] PRIMARY KEY CLUSTERED 
(
	[legajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE administradores (
legajo INT AUTO_INCREMENT,
nombre VARCHAR(50) NOT NULL ,
apellido VARCHAR(50) NOT NULL,
mail VARCHAR(50)
CONSTRAINT pk_administradores PRIMARY KEY CLUSTERED (legajo ASC ) 
)
CREATE TABLE Opciones( 
id Int AUTO_INCREMENT ,
nombre VARCHAR(50),
CONSTRAINT pk_opciones PRIMARY KEY CLUSTERED (id ASC)
)
