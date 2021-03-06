create database db_equipos;
go

use db_equipos;
go


------------------------------------------------------------------------------
-----------------Creacion de tablas-------------------------------------------
------------------------------------------------------------------------------


create table TiposDocs (
	cod_tipoDoc int NOT NULL,
	tipo nvarchar (50) NULL,
	constraint PK_TiposDosc primary key (cod_tipoDoc)
	)

create table Piernas (
	cod_piernaHabil int NOT NULL,
	habilidad nvarchar (50) NULL,
	constraint PK_Piernas primary key (cod_piernaHabil)
	)

create table Paises (
	cod_pais int NOT NULL,
	nombre_pais nvarchar (50) NULL,
	constraint PK_Paises primary KEY (cod_pais)
)

create table Provincias (
	cod_provincia int NOT NULL,
	nombre_provincia nvarchar (50) NULL,
	cod_pais int NOT NULL,
	constraint PK_Provincias primary key (cod_provincia),
	constraint FK_Provincias_Paises foreign key (cod_pais) references Paises (cod_pais)
	)

create table Localidades (
	cod_localidad int NOT NULL,
	nombre_localidad nvarchar (50) NULL,
	cod_provincia int NOT NULL,
	constraint PK_Localidades primary key (cod_localidad),
	constraint FK_Localidades_Provincias foreign key (cod_provincia) references Provincias (cod_provincia)
	)

create table Posiciones (
	cod_posicion int NOT NULL,
	posicion nvarchar (50) NULL,
	constraint PK_Posiciones primary key (cod_posicion)
	)

create table TiposCompromisos (
	cod_tipoCompromiso int NOT NULL,
	tipo nvarchar (50) NULL,
	constraint PK_TiposCompromisos primary key (cod_tipoCompromiso)
	)

create table Equipos (
	cod_equipo int NOT NULL,
	cod_localidad int NOT NULL,
	nombre nvarchar (50) NULL,
	fechaAlta datetime NULL,
	fechaBaja datetime NULL,
	constraint PK_Equipos primary key (cod_equipo),
	constraint FK_Equipos_Localidades foreign key (cod_localidad) references Localidades (cod_localidad)
)

create table Personas (
	cod_persona int NOT NULL,
	nombre nvarchar (50) NULL,
	apellido nvarchar (50) NULL,
	cod_tipoDoc int NOT NULL,
	numeroDocumento int NULL,
	fechaNac date NULL,
	cod_piernaHabil int NOT NULL,
	peso numeric (5,2) NOT NULL,
	estatura numeric (5,2) NOT NULL,
	fechaAlta datetime NULL,
	fechaBaja datetime NULL,
	constraint PK_Personas primary key (cod_persona),
	constraint FK_Personas_TiposDocs foreign key (cod_tipoDoc) references TiposDocs (cod_tipoDoc),
	constraint FK_Personas_Piernas foreign key (cod_piernaHabil) references Piernas (cod_piernaHabil)
	)

create table Compromisos (
	cod_compromiso int NOT NULL,
	cod_equipo int NOT NULL,
	cod_tipoCompromiso int NOT NULL,
	comentariosCompromiso nvarchar (250) NULL,
	fechaCompromiso datetime NULL,
	fechaAlta datetime NULL,
	fechaBaja datetime NULL,
	constraint PK_Compromisos primary key (cod_compromiso),
	constraint FK_Compromisos_Equipos foreign key (cod_equipo) references Equipos (cod_equipo),
	constraint FK_Compromisos_TiposCompromisos foreign key (cod_tipoCompromiso) references TiposCompromisos (cod_tipoCompromiso)
	)

create table Equipos_Personas (
	cod_equipoPersona int NOT NULL,
	cod_persona int NOT NULL,
	cod_equipo int NOT NULL,
	cod_posicion int NOT NULL,
	camiseta nvarchar (100) NULL,
	fechaAlta datetime NULL,
	fechaBaja datetime NULL,
	constraint PK_Equipos_Personas primary key (cod_equipoPersona),
	constraint FK_Equipos_Personas_Personas foreign key (cod_persona) references Personas (cod_persona),
	constraint FK_Equipos_Personas_Equipos foreign key (cod_equipo) references Equipos (cod_equipo),
	constraint FK_Equipos_Personas_Posiciones foreign key (cod_posicion) references Posiciones (cod_posicion)
	)

	

create table Usuarios(  
	cod_usuario int NOT NULL,  
	usuario nvarchar(100) NULL,  
	pass nvarchar(50) NULL, 	
	fechaBaja datetime NULL,
	email nvarchar (50) NULL,
	constraint PK_Usuarios primary key (cod_usuario)  
)

------------------------------------------------------------------------------
-------Carga datos elementales------------------------------------------------
------------------------------------------------------------------------------

insert into Piernas(cod_piernaHabil, habilidad)
	 values (1, 'Diestro'),(2, 'Zurdo'), (3, 'Ambidiestro'), (4, 'Inh?bil')


insert into Paises (cod_pais, nombre_pais)
	values (1, 'Argentina')

insert into Provincias (cod_provincia, nombre_provincia, cod_pais)
	values (1, 'C?rdoba', 1),
		   (2, 'Santa Fe', 1)

insert into Localidades (cod_localidad, nombre_localidad, cod_provincia)
				values (1, 'C?rdoba', 1),
					   (2, 'Rosario', 2)

insert into TiposDocs (cod_tipoDoc, tipo)
			values (1, 'DNI'),
				   (2, 'Pasaporte')

insert into TiposCompromisos (cod_tipoCompromiso, tipo)
					values (1, 'Presentaci?n oficial'),
						   (2, 'Partido Liga Nacional'),
						   (3, 'Partido Liga Internacional')


set dateformat dmy;
insert into Personas (cod_persona, nombre, apellido, cod_tipoDoc, numeroDocumento, fechaNac, cod_piernaHabil, peso, estatura, fechaAlta, fechaBaja)
	values (1, 'Esteban', 'Quito', 1, 36459685, '16/08/1990', 2, 73.2, 183, '03/10/2021', null),
		   (2, 'Armando', 'Escandalo', 1, 31847476, '10/06/1986', 3, 83.4, 176, '26/07/2020', null),
		   (3, 'Igor', 'Dito', 1, 40898776, '29/02/2000', 1, 67.1, 188, '12/11/2020', null),
		   (4, 'Aquiles', 'Traigo', 1, 41244863, '02/04/1999', 4, 75.8, 163, '02/02/2021', null),
		   (5, 'Mario', 'Neta', 1, 43976375, '05/03/1997', 3, 81.5, 182, '20/07/2020', '27/07/2020')



INSERT INTO Posiciones (cod_posicion, posicion)
VALUES (1,'Arquero'),
(2,'Defensa Central'),
(3,'Lateral'),
(4,'Mediocampista'),
(5,'Delantero'),
(6,'Entrenador')

exec SP_INSERTAR_EQUIPO 'Altos del aire', 1


--exec SP_INSERTAR_POSICIONES 'Arquero'
--exec SP_INSERTAR_POSICIONES 'Defensor Central'
--exec SP_INSERTAR_POSICIONES 'Defensor Lateral Izquierda'
--exec SP_INSERTAR_POSICIONES 'Defensor Lateral Derecha'
--exec SP_INSERTAR_POSICIONES 'Defensor Central'
--exec SP_INSERTAR_POSICIONES 'Mediocampista 1'
--exec SP_INSERTAR_POSICIONES 'Mediocampista 2'
--exec SP_INSERTAR_POSICIONES 'Mediapunta 1'
--exec SP_INSERTAR_POSICIONES 'Mediapunta 2'
--exec SP_INSERTAR_POSICIONES 'Delantero 1'
--exec SP_INSERTAR_POSICIONES 'Delantero 2'
--exec SP_INSERTAR_POSICIONES 'Entrenador'



exec SP_INSERTAR_EQUIPOS_PERSONAS  1, 1, 12, 'Entrenador'



------------------------------------------------------------------------------
----------------SP_INSERTAR---------------------------------------------------
------------------------------------------------------------------------------

go
create proc SP_INSERTAR_PAIS
@nombre_pais nvarchar (50)
as
begin
declare @cod_pais int
if exists (select * from Paises)
	set @cod_pais = (SELECT max(cod_pais)+1 FROM Paises)
else
	set @cod_pais = 1

insert into Paises (cod_pais, nombre_pais)
	values (@cod_pais, @nombre_pais)
end
go

go
create proc SP_INSERTAR_PROVINCIA
@nombre_provincia nvarchar (50),
@cod_pais int
as
begin
declare @cod_provincia int

if exists (select * from Provincias)
	set @cod_provincia = (SELECT max(cod_provincia)+1 FROM Provincias)
else
	set @cod_provincia = 1

insert into Provincias(cod_provincia, nombre_provincia, cod_pais)
	values (@cod_provincia, @nombre_provincia, @cod_pais)
end
go

go
create proc SP_INSERTAR_LOCALIDAD
@nombre_localidad nvarchar (50),
@cod_provincia int
as
begin
declare @cod_localidad int
if exists (select * from Localidades)
	set @cod_localidad = (SELECT max(cod_localidad)+1 FROM Localidades)
else
	set @cod_localidad = 1
insert into Localidades(cod_localidad, nombre_localidad, cod_provincia)
	values (@cod_localidad, @nombre_localidad, @cod_provincia)
end
go

go
create proc SP_INSERTAR_TIPO_DOC
@tipoDoc nvarchar (50)
as
begin
declare @cod_tipoDoc int
if exists (select * from TiposDocs)
	set @cod_tipoDoc = (SELECT max(cod_tipoDoc)+1 FROM TiposDocs)
else
	set @cod_tipoDoc = 1
insert into TiposDocs (cod_tipoDoc, tipo)
	values (@cod_tipoDoc, @tipoDoc)
end

go
create proc SP_INSERTAR_POSICIONES
@posicion nvarchar (50)
as
begin
declare @cod_posicion int
if exists (select * from Posiciones)
	set @cod_posicion = (SELECT max(cod_posicion)+1 FROM Posiciones)
else
	set @cod_posicion = 1
insert into TiposDocs (cod_posicion, posicion)
	values (@cod_posicion, @posicion)
end

go
create proc SP_INSERTAR_TIPO_COMPROMISO
@tipo nvarchar (50)
as
begin
declare @cod_tipoCompromiso int
if exists (select * from TiposCompromisos)
	set @cod_tipoCompromiso = (SELECT max(cod_tipoCompromiso)+1 FROM TiposCompromisos)
else
	set @cod_tipoCompromiso = 1
insert into TiposCompromisos (cod_tipoCompromiso, tipo)
	values (@cod_tipoCompromiso, @tipo)
end

go
create proc SP_INSERTAR_EQUIPO
@nombre nvarchar (50),
@localidad int
as
begin
declare @cod_equipo int
if exists (select * from Equipos)
	set  @cod_equipo = (SELECT max(cod_equipo)+1 FROM Equipos)
else
	set @cod_equipo = 1

insert into Equipos (cod_equipo, nombre, cod_localidad, fechaAlta, fechaBaja)
	values (@cod_equipo, @nombre, @localidad, getdate(), null)
end


go
create proc SP_INSERTAR_PERSONA 
@nombre nvarchar (50),
@apellido nvarchar (50),
@cod_tipoDoc int,
@numeroDocumento int,
@fechaNac date,
@piernaHabil int,
@peso numeric (5,2),
@estatura numeric (5,2)
as
begin
declare @cod_persona int
if exists (select * from Personas)
	set  @cod_persona = (SELECT max(cod_persona)+1 FROM Personas)
else
	set @cod_persona = 1
insert into Personas (cod_persona, nombre, apellido, cod_tipoDoc, numeroDocumento, fechaNac, cod_piernaHabil, peso, estatura, fechaAlta, fechaBaja)
	values (@cod_persona, @nombre, @apellido, @cod_tipoDoc, @numeroDocumento, @fechaNac, @piernaHabil, @peso, @estatura, getdate(), null)
end
go


create proc SP_INSERTAR_COMPROMISO 
@cod_equipo int,
@cod_tipoCompromiso int,
@comentariosCompromiso nvarchar (250),
@fechaCompromiso datetime
as
begin
declare @cod_compromiso int
if exists (select * from Compromisos)
	set  @cod_compromiso = (SELECT max(cod_compromiso)+1 FROM Compromisos)
else
	set @cod_compromiso = 1
insert into Compromisos (cod_compromiso, cod_equipo, cod_tipoCompromiso, comentariosCompromiso, fechaCompromiso, fechaAlta, fechaBaja)
	values (@cod_compromiso, @cod_equipo, @cod_tipoCompromiso, @comentariosCompromiso, @fechaCompromiso, getdate(), null)
end
go

create proc SP_INSERTAR_EQUIPOS_PERSONAS 
@cod_persona int,
@cod_equipo int,
@cod_posicion int,
@camiseta nvarchar (100)

as
begin
declare @cod_equipoPersona int
if exists (select * from Equipos_Personas)
	set  @cod_equipoPersona = (SELECT max(cod_equipoPersona)+1 FROM Equipos_Personas)
else
	set @cod_equipoPersona = 1
insert into Equipos_Personas (cod_equipoPersona, cod_persona, cod_equipo,  cod_posicion, camiseta, fechaAlta, fechaBaja)
					values (@cod_equipoPersona, @cod_persona, @cod_equipo, @cod_posicion, @camiseta, getdate(), null)
end
go



------------------------------------------------------------------------------
-----------------SP_CONSULTAR-------------------------------------------------
------------------------------------------------------------------------------

--go
--alter proc SP_CONSULTAR_EQUIPOS_CON_COLUMNAS
--as
--select e.cod_equipo 'codEquipo',
--	e.nombre 'Nombre del Equipo',
--	p.nombre + ' ' + p.apellido as 'Nombre Entrenador',
--	count(*) 'Cantidad de Jugadores',
--	e.fechaAlta 'Fecha de Alta',
--	e.fechaBaja 'Fecha de Baja'
--from Equipos e join Equipos_Personas ep on e.cod_equipo = ep.cod_equipo
--join Personas p on p.cod_persona = ep.cod_persona
--where ep.cod_posicion = 12 and 
--	e.fechaBaja is null
--group by e.nombre ,p.nombre + ' ' + p.apellido , e.fechaAlta, e.cod_equipo, e.fechaBaja
--order by 1
--go


--create proc SP_CONSULTAR_EQUIPOS_CON_COLUMNAS_SINFILTROS
--as
--select e.cod_equipo 'codEquipo',
--	e.nombre 'Nombre del Equipo',
--	p.nombre + ' ' + p.apellido as 'Nombre Entrenador',
--	count(*) 'Cantidad de Jugadores',
--	e.fechaAlta 'Fecha de Alta',
--	e.fechaBaja 'Fecha de Baja'
--from Equipos e join Equipos_Personas ep on e.cod_equipo = ep.cod_equipo
--join Personas p on p.cod_persona = ep.cod_persona
--where ep.cod_posicion = 12	
--group by e.nombre ,p.nombre + ' ' + p.apellido , e.fechaAlta, e.cod_equipo, e.fechaBaja
--order by 1
--go



--create or alter proc SP_CONSULTAR_COMPROMISOS_CON_COLUMNAS
--as
--select e.cod_equipo 'codEquipo',
--	c.cod_compromiso 'codCompromiso',
--	e.nombre 'Nombre del Equipo',
--	tc.tipo 'Tipo de compromiso',
--	c.fechaCompromiso 'Fecha del compromiso',
--	c.fechaBaja 'fechaBaja'
--from Compromisos c
--join TiposCompromisos tc on c.cod_tipoCompromiso = tc.cod_tipoCompromiso
--join Equipos e on e.cod_equipo = c.cod_equipo
--where c.fechaBaja is null and
--	c.fechaCompromiso > getdate()
--order by 5
--go


--create or alter proc SP_CONSULTAR_COMPROMISOS_CON_COLUMNAS_SINFILTRO
--as
--select e.cod_equipo 'codEquipo',
--	c.cod_compromiso 'codCompromiso',
--	e.nombre 'Nombre del Equipo',
--	tc.tipo 'Tipo de compromiso',
--	c.fechaCompromiso 'Fecha del compromiso',
--	c.fechaBaja 'fechaBaja'
--from Compromisos c
--join TiposCompromisos tc on c.cod_tipoCompromiso = tc.cod_tipoCompromiso
--join Equipos e on e.cod_equipo = c.cod_equipo
--order by 5
--go



create or alter proc SP_CONSULTAR_PERSONAS_CONFILTRO
@nombre nvarchar(50) = NULL,
@apellido nvarchar(50) = NULL,
@fechaDesde datetime = NULL,
@fechaHasta datetime = NULL,
@tipoDoc int = NULL,
@nroDoc int = NULL,
@estaturaDesde numeric(6,2) = NULL,
@estaturaHasta numeric(6,2) = NULL,
@pesoDesde numeric (5,2) = NULL,
@pesoHasta numeric (5,2) = NULL,
@tipoPierna int = NULL,
@baja bit = NULL
as
begin
select * from Personas
where 
	((@fechaDesde is null and @fechaHasta is  null) 
	 OR (fechaNac between @fechaDesde and @fechaHasta))
	 AND(@nombre is null OR (nombre like '%' + @nombre + '%'))
	 AND(@apellido is null OR (apellido like '%' + @apellido + '%'))
	 AND (@tipoDoc is null OR (cod_tipoDoc = @tipoDoc))
	 AND (@nroDoc is null OR (numeroDocumento = @nroDoc))
	 AND (@estaturaDesde is null OR (estatura >= @estaturaDesde))
 	 AND (@estaturaHasta is null OR (estatura <= @estaturaHasta))
	 AND (@pesoDesde is null OR (peso >= @pesoDesde))
 	 AND (@pesoHasta is null OR (peso <= @pesoHasta))
	 AND (@tipoPierna is null OR (cod_piernaHabil = @tipoPierna))
	 AND (@baja is null OR (@baja = 0 and fechaBaja IS NULL) OR (@baja = 1 and fechaBaja IS NOT NULL OR fechaBaja IS NULL))
end
go



go
create proc SP_CONSULTAR_TIPOS_DOC
as
select * from TiposDocs
go

go
create proc SP_CONSULTAR_PIERNAS
as
select * from Piernas
go

create proc SP_CONSULTAR_PAISES
as
select * from Paises
go

go
create proc SP_CONSULTAR_PROVINCIAS
as
select * from Provincias
go

go
create proc SP_CONSULTAR_LOCALIDADES
as
select * from Localidades
go

go
create proc SP_CONSULTAR_POSICIONES
as
select * from Posiciones
go

go
create proc SP_CONSULTAR_TIPOS_COMPROMISOS
as
select * from TiposCompromisos
go

go
create proc SP_CONSULTAR_EQUIPOS_ACTIVOS
as
select * from Equipos
where fechaBaja is null
go

go

create proc SP_CONSULTAR_EQUIPOS
as
select * from Equipos
go


go 

create proc SP_CONSULTAR_EQUIPOS_POR_ID
@codigo int
as
select * 
from Equipos e 
	join Equipos_Personas ep on e.cod_equipo = ep.cod_equipo
	join Personas p on ep.cod_persona = p.cod_persona
where e.cod_equipo = @codigo
go

go
create proc SP_CONSULTAR_PERSONAS_ACTIVAS
as
select * from Personas
where fechaBaja is null
go

create proc SP_CONSULTAR_PERSONAS
as
select * from Personas
go

go
create proc SP_CONSULTAR_COMPROMISOS_FUTUROS_ACTIVOS
as
select * from Compromisos
where fechaBaja is null and fechaCompromiso >= getdate()
go

create proc SP_CONSULTAR_COMPROMISOS
as
select * from Compromisos

go
create proc SP_CONSULTAR_EQUIPOS_PERSONAS_ACTIVOS
as
select * from Equipos_Personas
where fechaBaja is null
go

go
create proc SP_CONSULTAR_EQUIPOS_PERSONAS
as
select * from Equipos_Personas
go

go
create proc SP_CONSULTAR_USUARIOS_ACTIVOS
as
select * from Usuarios
where fechaBaja is null
go

go
create proc SP_CONSULTAR_USUARIOS
as
select * from Usuarios
go
  
go
create proc SP_CONSULTAR_EQUIPOS_LOCALIDAD
as
BEGIN
select e.nombre 'Equipo', l.nombre_localidad 'Localidad', pr.nombre_provincia 'Provincia', p.nombre_pais 'Pais'
from Equipos e join Localidades l on e.cod_localidad = l.cod_localidad
join Provincias pr on pr.cod_provincia = l.cod_provincia
join Paises p on p.cod_pais = pr.cod_pais
END
go


go 
create procedure SP_HABILIDADES_PERSONAS
AS
BEGIN
select p.habilidad 'Habilidad', count(pe.cod_persona) 'Cantidad'
from personas pe join piernas p on p.cod_piernaHabil = pe.cod_piernaHabil
group by p.habilidad
END
go

exec SP_HABILIDADES_PERSONAS;

create procedure SP_DASHBOARD
@resEquipos int output         ,
@resEquiposAct int output	   ,
@resJugadores    int output	   ,
@resJugadoresAct int output	   ,
@resComprom		 int output	   ,
@resCompromAct	 int output
as
begin
set @resEquipos = ( select count(cod_equipo)     'Cantidad Equipos' from Equipos																			 )
set @resEquiposAct = ( select count(cod_equipo)     'Cantidad Equipos Activos' from Equipos where fechaBaja is null											 )
set @resJugadores = ( select count(cod_persona)    'Cantidad Jugadores' from Personas																		 )
set @resJugadoresAct = ( select count(cod_persona)    'Cantidad Jugadores Activos' from Personas where fechaBaja is null									 )
set @resComprom	= ( select count(cod_compromiso) 'Cantidad Compromisos' from Compromisos																	 )
set @resCompromAct = ( select count(cod_compromiso) 'Cantidad Compromisos Futuros' from Compromisos where fechaBaja is null and fechaCompromiso >= getdate() )
end

------------------------------------------------------------------------------
------------SP_BAJA-----------------------------------------------------------
------------------------------------------------------------------------------
go
create proc SP_BAJA_COMPROMISO_POREQUIPO
@codigo int
as
begin
update Compromisos
set fechaBaja = GETDATE()
where cod_equipo=@codigo
end
go

create proc SP_BAJA_PERSONA
@codigo int
as
begin
update Personas
set fechaBaja = GETDATE()
where cod_persona=@codigo


end

go

create proc SP_BAJA_EQUIPO
@codigo int
as
begin
update Equipos
set fechaBaja = GETDATE()
where cod_equipo=@codigo

end

go

create proc SP_BAJA_COMPROMISO
@codigo int
as
begin
update Compromisos
set fechaBaja = GETDATE()
where cod_compromiso=@codigo
end

go

create proc SP_BAJA_EQUIPO_PERSONA_PORDETALLE
@codigo int
as
begin
update Equipos_Personas
set fechaBaja = GETDATE()
where cod_equipoPersona=@codigo
end

go

create proc SP_BAJA_EQUIPO_PERSONA_POREQUIPO
@codigo int
as
begin
update Equipos_Personas
set fechaBaja = GETDATE()
where cod_equipo=@codigo
end

go

create proc SP_BAJA_EQUIPO_PERSONA_PORPERSONA
@codigo int
as
begin
update Equipos_Personas
set fechaBaja = GETDATE()
where cod_persona=@codigo
end

------------------------------------------------------------------------------
------------SP_EDITAR---------------------------------------------------------
------------------------------------------------------------------------------
go
create or alter proc SP_EDITAR_PERSONA
@codigo int,
@nombre nvarchar (50),
@apellido nvarchar (50),
@cod_tipoDoc int,
@numeroDocumento int,
@fechaNac date,
@piernaHabil int,
@peso numeric (5,2),
@estatura numeric (5,2),
@fechaAlta datetime,
@fechaBaja datetime = NULL
as
begin
update Personas
set nombre = @nombre, 
	apellido = @apellido, 
	cod_tipoDoc = @cod_tipoDoc, 
	numeroDocumento = @numeroDocumento, 
	fechaNac = @fechaNac, 
	cod_piernaHabil = @piernaHabil, 
	peso = @peso, 
	estatura = @estatura,
	fechaAlta = @fechaAlta,
	fechaBaja = @fechaBaja
where cod_persona=@codigo
end
go
go
create or alter proc SP_EDITAR_EQUIPO
@codigo int, 
@nombre nvarchar (50),
@loc int,
@fechaAlta datetime, 
@fechaBaja datetime = NULL
as
begin
update Equipos
set nombre = @nombre,
	fechaAlta = @fechaAlta,
	fechaBaja = @fechaBaja
where cod_equipo = @codigo
end
go
create or alter proc SP_EDITAR_COMPROMISO
@codigo int,
@cod_equipo int,
@cod_tipoCompromiso int,
@comentariosCompromiso nvarchar (250),
@fechaCompromiso datetime,
@fechaAlta datetime,
@fechaBaja datetime = NULL
as
begin
update Compromisos
set cod_equipo = @cod_equipo, 
	cod_tipoCompromiso = @cod_tipoCompromiso, 
	comentariosCompromiso = @comentariosCompromiso, 
	fechaCompromiso = @fechaCompromiso, 
	fechaAlta = @fechaAlta, 
	fechaBaja = @fechaBaja
where cod_compromiso=@codigo
end
go


create or alter proc SP_EDITAR_EQUIPO_PERSONA_PORDETALLE
@codigo int,
@cod_persona int,
@cod_equipo int,
@cod_posicion int,
@camiseta nvarchar (100),
@fechaAlta datetime,
@fechaBaja datetime = NULL
as
begin
update Equipos_Personas
set cod_persona = @cod_persona, 
	cod_equipo = @cod_equipo,  
	cod_posicion = @cod_posicion, 
	camiseta = @camiseta, 
	fechaAlta = @fechaAlta, 
	fechaBaja = @fechaBaja
where cod_equipoPersona=@codigo
end

go

create or alter proc SP_EDITAR_USUARIO
@codigo int, 
@nombre nvarchar (100), 
@pass nvarchar (50),
@fechaBaja datetime  = NULL
as
begin
update Usuarios
set usuario = @nombre,
	pass = @pass,
	fechaBaja = @fechaBaja
where cod_usuario = @codigo
end

go
create proc SP_EDITAR_PAIS
@codigo int,
@nombre nvarchar (50)
as
begin
update Paises
set nombre_pais = @nombre
where cod_pais = @codigo
end


go
create proc SP_EDITAR_PROVINCIA
@codigo int,
@nombre nvarchar (50)
as
begin
update Provincias
set nombre_provincia = @nombre
where cod_provincia = @codigo
end


go
create proc SP_EDITAR_LOCALIDAD
@codigo int,
@nombre nvarchar (50)
as
begin
update Localidades 
set nombre_localidad = @nombre
where cod_localidad = @codigo
end


go
create proc SP_EDITAR_TIPO_COMPROMISO
@codigo int,
@nombre nvarchar (50)
as
begin
update TiposCompromisos 
set tipo = @nombre
where cod_tipoCompromiso = @codigo
end


go
create proc SP_EDITAR_TIPO_DOCUMENTOS
@codigo int,
@nombre nvarchar (50)
as
begin
update TiposDocs 
set tipo = @nombre
where cod_tipoDoc = @codigo
end

exec SP_EDITAR_TIPO_DOCUMENTOS 1, 'D.N.I.'

go
create proc SP_EDITAR_POSICION
@codigo int,
@nombre nvarchar (50)
as
begin
update Posiciones 
set posicion = @nombre
where cod_posicion = @codigo
go

------------------------------------------------------------------------------
------------LogIn---------------------------------------------------------
------------------------------------------------------------------------------

go
create proc SP_INSERTAR_USUARIO
@usuario nvarchar (100),
@pass nvarchar (50),
@email nvarchar (50)
as
begin
declare @cod_usuario int
if exists (select * from Usuarios)
	set @cod_usuario = (SELECT max(cod_usuario)+1 FROM Usuarios)
else
	set @cod_usuario = 1
insert into Usuarios (cod_usuario, usuario, pass,email)
	values (@cod_usuario, @usuario, @pass, @email)
end
go

go
create proc [dbo].[SP_CONSULTAR_USUARIOS_LOGIN]
@user nvarchar(100),
@pass nvarchar(50)
as
select * from Usuarios
where usuario = @user and pass = @pass

GO
create proc [dbo].[SP_RECOVERY_PASSWORD]
@email nvarchar(50)
as
select * from Usuarios
where email = @email