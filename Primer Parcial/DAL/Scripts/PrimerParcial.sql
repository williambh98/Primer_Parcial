CREATE DATABASE PrimerPc
GO
USE PrimerPc
GO

CREATE TABLE Articulos
(
ID int primary key identity,
Cantidad int,
Precio Decimal,
Nombre varchar (30),
fechaVencimiento DateTime,

);