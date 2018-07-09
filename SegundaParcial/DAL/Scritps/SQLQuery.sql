Create DataBase SegundoParcialDb
go
use SegundoParcialDb
go
CREATE TABLE Vehiculos
(
	VehiculoId int primary key identity(1,1),
	Descripcion varchar(50),
	Mantenimiento int
);

CREATE TABLE Articulos
(
	ArticuloId int primary key identity(1,1),
	Descripcion varchar(50),
	Costo int,
	Ganancia int,
	Precio int,
	Inventario int

);

CREATE TABLE Mantenimientos
(
	MantenimientoId int primary key identity(1,1),
	Costo int,
	Fecha DateTime
);

CREATE TABLE Talleres
(
	TallerId int primary key identity(1,1),
	Nombre varchar(50),
);
