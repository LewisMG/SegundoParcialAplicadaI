Create DataBase SegundoParcialDb
go
use SegundoParcialDb
go
create table Vehiculos
(
	VehiculoId int primary key(),
	Descripcion varchar(30),
	Mantenimiento float,
);

sp_columns Vehiculos

insert into Vehiculos (VehiculoId, Descripcion, Mantenimiento)
  values (1,'Toyota Corolla 2005 Le',0);
insert into Vehiculos (VehiculoId, Descripcion, Mantenimiento)
  values (2,'Honda Crv 2015 Touring',0);