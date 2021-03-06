CREATE DATABASE Escuela
GO
USE Escuela
GO

create table tgrupo(
numerogrupo	varchar(50)	PRIMARY KEY NOT NULL,
horariogrupo varchar(50) NOT NULL,
semestre varchar(50) NOT NULL,
horacreacion	datetime NOT NULL,
)
select* from tgrupo 
select numerogrupo from tgrupo where semestre = '2019-2'

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
select * from tpersona where dni = '47454745'
select tpersona.dni, tpersona.nombre, tpersona.appat as Apellido_Paterno, tpersona.apmat, tpersona.fecha_nac, talumno.observacion, talumno.interesseguimiento from tpersona inner join talumno on talumno.dni = tpersona.dni

create table talumno(
dni		int PRIMARY KEY NOT NULL,
observacion	varchar(400),
interesseguimiento varchar(200),
horacreacion	datetime NOT NULL,
)
select * from talumno

create table tdocente(
dni		int PRIMARY KEY NOT NULL,
perfil	varchar (20) NOT NULL,
horacreacion	datetime NOT NULL,
)
select * from tdocente

Select tdocente.dni AS DNI, nombre AS Nombre, appat AS Apellido_Paterno, apmat AS Apellido_Materno, telefono AS Telefono, correo AS Correo from tpersona inner join tdocente on tpersona.dni = tdocente.dni where tdocente.dni like '47454745'

create table tcurso(
idcurso		varchar(30) PRIMARY KEY NOT NULL,
nombrecurso varchar(30) NOT NULL,
numerogrupo	varchar(50) FOREIGN KEY references tgrupo NOT NULL,
dni			int FOREIGN KEY references tdocente NOT NULL,
monto		DECIMAL(5,2) NOT NULL,
horariocurso varchar(20)NOT NULL,
horacreacion datetime NOT NULL,
)
select * from tcurso


create table tmatricula(
numerogrupo	varchar(50) FOREIGN KEY references tgrupo NOT NULL,
idcurso		varchar(30)	FOREIGN KEY references tcurso NOT NULL,
dni			int FOREIGN KEY references talumno NOT NULL,
fecha		date NOT NULL,
)

select * from tmatricula

select talumno.dni, tpersona.nombre, tpersona.appat, tpersona.apmat, tpersona.telefono, tmatricula.numerogrupo, tmatricula.idcurso, tpagocurso.cuenta, tpagocurso.monto from talumno inner join tpersona on talumno.dni = tpersona.dni inner join tmatricula on talumno.dni = tmatricula.dni inner join tpagocurso on tpagocurso.dni = talumno.dni where talumno.dni = '46616154'

Select tmatricula.numerogrupo, tmatricula.idcurso from tmatricula inner join talumno on tmatricula.dni = talumno.dni where tmatricula.dni like '46616154'

select * from tgrupo
select * from tpersona
select * from tpagocurso

create table tasistenciaalumno(
dni	int	FOREIGN KEY references talumno NOT NULL,
numerogrupo	varchar(50) FOREIGN KEY references tgrupo NOT NULL,
idcurso		varchar(30) FOREIGN KEY references tcurso NOT NULL,
fecha		date NOT NULL,
)

select * from tasistenciaalumno
select * from tgrupo
select * from tmatricula

select tmatricula.dni, tgrupo.numerogrupo, tmatricula.idcurso from tmatricula inner join tgrupo on tmatricula.numerogrupo = tgrupo.numerogrupo where tgrupo.semestre like '2018-2' and tmatricula.dni like '46616154'
Select tasistenciaalumno.dni AS DNI_Alumno, tgrupo.numerogrupo AS Grupo, idcurso AS Codigo_Curso, fecha AS Fecha from tasistenciaalumno inner join tgrupo on tasistenciaalumno.numerogrupo = tgrupo.numerogrupo where tasistenciaalumno.dni like '46616154'

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
select * from tpagocurso
select * from tcurso 
select * from tmatricula
select monto from tcurso
select tmatricula.numerogrupo AS Grupo, tmatricula.idcurso AS Codigo_Curso, tcurso.nombrecurso AS Nombre_Curso, tcurso.monto AS Costo_Curso, tcurso.monto - SUM(tpagocurso.cuenta) AS Saldo, tpagocurso.fecha AS Fecha_Pagado from tpagocurso inner join tmatricula on tpagocurso.idcurso = tmatricula.idcurso inner join tcurso on tpagocurso.idcurso = tcurso.idcurso where tmatricula.dni like '46616154' group by tmatricula.numerogrupo, tpagocurso.monto, tmatricula.idcurso, tcurso.nombrecurso,tcurso.monto, tpagocurso.fecha

Select tmatricula.numerogrupo AS Grupo, tmatricula.idcurso AS Codigo_Curso, tcurso.nombrecurso AS Nombre_curso, tcurso.monto AS Costo_Curso, tcurso.monto - tpagocurso.cuenta AS SALDO from tmatricula inner join talumno on tmatricula.dni = talumno.dni inner join tpagocurso on tpagocurso.dni = tmatricula.dni inner join tcurso on tmatricula.idcurso = tcurso.idcurso where talumno.dni like '46616154'


select monto  from tpagocurso group by monto
Select tmatricula.numerogrupo AS Grupo, tmatricula.idcurso AS Codigo_Curso, tcurso.nombrecurso AS Nombre_curso, tcurso.monto AS Costo_Curso, tpagocurso.cuenta AS Cuenta, tpagocurso.fecha AS Fecha, tcurso.monto - tpagocurso.cuenta AS SALDO, SUM(tpagocurso.cuenta) AS Pagado from tmatricula  inner join talumno on tmatricula.dni = talumno.dni inner join tpagocurso on tpagocurso.dni = tmatricula.dni inner join tcurso on tmatricula.idcurso = tcurso.idcurso where talumno.dni like '46616154'
select sum(tpagocurso.cuenta) - avg(tcurso.monto)As cuenta from tpagocurso inner join tcurso on tpagocurso.idcurso = tcurso.idcurso where tpagocurso.dni like '46616154' group by cuenta


Select tcurso.nombrecurso AS Nombre_curso, tcurso.monto AS Costo_Curso, tpagocurso.cuenta AS Cuenta, tcurso.monto - tpagocurso.cuenta AS SALDO, SUM(tpagocurso.cuenta) AS Pagado from tmatricula  inner join tpagocurso on tpagocurso.dni = tmatricula.dni inner join tcurso on tmatricula.idcurso = tcurso.idcurso where talumno.dni like '46616154'
select * from tcurso
select * from tasistenciaalumno
Select tasistenciaalumno.dni AS DNI_Alumno, tasistenciaalumno.numerogrupo AS Grupo, tasistenciaalumno.idcurso AS Codigo_Curso, tcurso.nombrecurso AS Nombre_Curso,tcurso.horariocurso AS horario, tasistenciaalumno.fecha AS Fecha from tasistenciaalumno inner join tcurso on tasistenciaalumno.idcurso = tcurso.idcurso inner join tgrupo on tcurso.numerogrupo = tgrupo.numerogrupo where tasistenciaalumno.dni like '46616154' and tgrupo.semestre like '2018-2' order by tasistenciaalumno.fecha


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
select * from tpagodocente

create table tusuarios(
dni		int PRIMARY KEY NOT NULL,
usuario		varchar(20) NOT NULL,
clave		varchar(20)	NOT NULL,
)
select * from tusuarios


select * from tmatricula
select * from talumno
select * from tcurso
select * from tpagocurso
select * from tdocente
select * from tpagocurso
Select tmatricula.numerogrupo, tmatricula.idcurso, tcurso.nombrecurso, tcurso.monto, tcurso.monto - tpagocurso.cuenta  AS SALDO from tmatricula inner join talumno on tmatricula.dni = talumno.dni inner join tpagocurso on tpagocurso.dni = tmatricula.dni inner join tcurso on tmatricula.idcurso = tcurso.idcurso where talumno.dni like '46616154'

Select tpersona.dni, tpersona.nombre, tpersona.appat, tpersona.apmat, tpersona.fecha_nac, tpersona.telefono, tpersona.correo, tpersona.direccion from tpersona where tpersona.dni like '46616154'

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