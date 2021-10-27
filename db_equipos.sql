create database db_equipos;
go

use db_equipos;
go

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
	constraint PK_Usuarios primary key (cod_usuario)  
)


go
create proc SP_INSERTAR_PAIS
@nombre_pais nvarchar (50)
as
begin
declare @cod_pais int
set @cod_pais = (SELECT count(cod_pais)+1 FROM Paises)
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
set @cod_provincia = (SELECT count(cod_provincia)+1 FROM Provincias)
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
set @cod_localidad = (SELECT count(cod_provincia)+1 FROM Localidades)
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
set @cod_tipoDoc = (SELECT count(cod_tipoDoc)+1 FROM TiposDocs)
insert into TiposDocs (cod_tipoDoc, tipo)
	values (@cod_tipoDoc, @tipoDoc)
end

go
create proc SP_INSERTAR_POSICIONES
@posicion nvarchar (50)
as
begin
declare @cod_posicion int
set @cod_posicion = (SELECT count(cod_posicion)+1 FROM Posiciones)
insert into TiposDocs (cod_tipoDoc, tipo)
	values (@cod_posicion, @posicion)
end

go
create proc SP_INSERTAR_TIPO_COMPROMISO
@tipo nvarchar (50)
as
begin
declare @cod_tipoCompromiso int
set @cod_tipoCompromiso = (SELECT count(cod_tipoCompromiso)+1 FROM TiposCompromisos)
insert into TiposCompromisos (cod_tipoCompromiso, tipo)
	values (@cod_tipoCompromiso, @tipo)
end

go
create proc SP_INSERTAR_EQUIPO
@nombre nvarchar (50)
as
begin
declare @cod_equipo int
set  @cod_equipo = (SELECT count(cod_equipo)+1 FROM Equipos)

insert into Equipos (cod_equipo, nombre, fechaAlta, fechaBaja)
	values (@cod_equipo, @nombre, getdate(), null)
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
set  @cod_persona = (SELECT count(cod_persona)+1 FROM Personas)

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
set  @cod_compromiso = (SELECT count(cod_compromiso)+1 FROM Compromisos)

insert into Compromisos (cod_compromiso, cod_equipo, cod_tipoCompromiso, comentariosCompromiso, fechaCompromiso, fechaAlta, fechaBaja)
	values (@cod_compromiso, @cod_equipo, @cod_tipoCompromiso, @comentariosCompromiso, @fechaCompromiso, getdate(), null)
end
go

create proc SP_INSERTAR_EQUIPOS_PERSONAS 
@cod_persona int,
@cod_equipo int,
@cod_posicion int,
@camiseta nvarchar (100)
--@fechaNac date
as
begin
declare @cod_equipoPersona int
set  @cod_equipoPersona = (SELECT count(cod_equipoPersona)+1 FROM Equipos_Personas)

insert into Equipos_Personas (cod_equipoPersona, cod_persona, cod_equipo,  cod_posicion, camiseta, fechaAlta, fechaBaja)
					values (@cod_equipoPersona, @cod_persona, @cod_equipo, @cod_posicion, @camiseta, getdate(), null)
end
go


go
create proc SP_INSERTAR_USUARIO
@usuario nvarchar (100),
@pass nvarchar (50)
as
begin
declare @cod_usuario int
set @cod_usuario = (SELECT count(cod_usuario)+1 FROM Usuarios)
insert into Usuarios (cod_usuario, usuario, pass)
	values (@cod_usuario, @usuario, @pass)
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
create proc SP_CONSULTAR_PERSONAS_ACTIVAS
as
select * from Personas
where fechaBaja is null
go

go
create proc SP_CONSULTAR_COMPROMISOS_FUTUROS_ACTIVOS
as
select * from Compromisos
where fechaBaja is null and fechaCompromiso >= getdate()
go

go
create proc SP_CONSULTAR_EQUIPOS_PERSONAS_ACTIVOS
as
select * from Equipos_Personas
where fechaBaja is null
go

go
create proc SP_CONSULTAR_USUARIOS_ACTIVOS
as
select * from Usuarios
where fechaBaja is null
go


insert into Piernas(cod_piernaHabil, habilidad)
	 values (1, 'Diestro'),(2, 'Zurdo'), (3, 'Ambidiestro'), (4, 'Inhábil')
			