CREATE DATABASE Escuela
GO
USE Escuela
GO

create table tgrupo(
numerogrupo	varchar(50)	PRIMARY KEY NOT NULL,
horariogrupo varchar(50) NOT NULL,
)
select* from tgrupo

create table tpersona(
dni		int PRIMARY KEY NOT NULL,
nombre	varchar(50) NOT NULL,
appat	varchar(50) NOT NULL,
apmat	varchar(50)	NOT NULL,
fecha_nac	date NOT NULL,
telefono	int NOT NULL,
correo	varchar(50) NOT NULL,
direccion varchar(50) NOT NULL,
)
select * from tpersona

create table talumno(
dni		int PRIMARY KEY NOT NULL,
observacion	varchar(400),
interesseguimiento varchar(200),
)
select * from talumno

create table tdocente(
dni		int PRIMARY KEY NOT NULL,
perfil	varchar (20) NOT NULL,
)
select * from tdocente

create table tcurso(
idcurso		varchar(30) PRIMARY KEY NOT NULL,
nombrecurso varchar(30) NOT NULL,
numerogrupo	varchar(50) FOREIGN KEY references tgrupo NOT NULL,
dni			int FOREIGN KEY references tdocente NOT NULL,
)
select * from tcurso

create table tmatricula(
numerogrupo	varchar(50) FOREIGN KEY references tgrupo NOT NULL,
idcurso		varchar(30)	FOREIGN KEY references tcurso NOT NULL,
dni			int FOREIGN KEY references talumno NOT NULL,
)
select * from tmatricula

create table tasistenciaalumno(
dni	int	FOREIGN KEY references talumno NOT NULL,
numerogrupo	varchar(50) FOREIGN KEY references tgrupo NOT NULL,
idcurso		varchar(30) FOREIGN KEY references tcurso NOT NULL,
fecha		date NOT NULL,
)
select * from tasistenciaalumno

create table tpagocurso(
idpago	varchar(20) PRIMARY KEY NOT NULL,
numerogrupo	varchar(50) FOREIGN KEY references tgrupo NOT NULL,
idcurso	varchar(30)	FOREIGN KEY references tcurso NOT NULL,
dni		int FOREIGN KEY references talumno NOT NULL,
monto	DECIMAL(5,2) NOT NULL,
cuenta	DECIMAL(5,2) NOT NULL,
fecha	date NOT NULL,
nrorecibo	VARCHAR(20) NOT NULL,
estado	varchar(50),
observacion varchar(150),
)

create table tpagodocente(
idpago	varchar(20) PRIMARY KEY NOT NULL,
numerogrupo	varchar(50) FOREIGN KEY references tgrupo NOT NULL,
idcurso	varchar(30)	FOREIGN KEY references tcurso NOT NULL,
dni		int FOREIGN KEY references tdocente NOT NULL,
monto	DECIMAL(5,2) NOT NULL,
fecha	date NOT NULL,
nrorecibo	VARCHAR(20) NOT NULL,
estado	varchar(50),
observacion varchar(150),
)
GO

create table tusuarios(
dni		int PRIMARY KEY NOT NULL,
usuario		varchar(20) NOT NULL,
clave		varchar(20)	NOT NULL,
)



go
select * from tpersona
select * from alumnos

CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Contraseña] varchar(50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Alumnos]    Script Date: 01/15/2013 22:30:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE Alumnos(
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Direccion] [text] NULL,
	[Fecha_nacimiento] [date] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO



select * from usuarios