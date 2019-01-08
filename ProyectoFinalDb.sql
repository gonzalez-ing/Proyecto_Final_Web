CREATE DATABASE ProyectoFinalDb
--DROP DATABASE  ProyectoFinalDb
go
Use ProyectoFinalDb
go
Create Table Usuarios
(
	UsuarioId int primary key identity(1,1),
	Nombre varchar(30),
	Usuario varchar(max),
	Clave varchar(8)
);

insert into Usuarios values('Adrian Gonzalez','Admin','1234')

go
create table Clientes 
(
	ClienteId int primary key identity(1,1),
	Nombre varchar(30),
	Cedula varchar(20),
	Direccion varchar(max),
	Telefono varchar(20),
	Fecha Date

);

go
create table Productos
(
	ProductoId int primary key identity(1,1),
	Nombre varchar(30),
	Descripcion varchar(30),
	Costo decimal,
	Precio decimal,
	Ganancia decimal,
	Inventario decimal,


);

GO
create TABLE EntradaProductos
(
			EntradaId int primary key identity(1,1),
            Fecha date,
            ProductoId int,         
            Cantidad int
               
);

go
create table Facturas
(
	FacturaId int primary key identity(1,1),
    ClienteId int references Clientes(ClienteId),
	Fecha Date,
	Subtotal decimal,
	ITBIS decimal,
	Total decimal

);

go
create table FacturasDetalles
(
	Id int primary key identity(1,1),
	FacturaId int references Facturas(FacturaId),
    ClienteId int references Clientes(ClienteId),
	ProductoId int references Productos(ProductoId),
	Cantidad int,
	Precio decimal,
	Importe decimal

);


select * from Usuarios;
select * from Clientes;
select * from Productos;
select * from EntradaProductos;
select * from Facturas;
select * from FacturasDetalles;