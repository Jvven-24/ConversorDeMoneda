Create database ConversorDeMoneda
go
use ConversorDeMoneda

///TABLA DE TASAS DE CAMBIO
Create table TasaCambio
(
TasaID int identity(1,1) primary key,
MonedaNombre varchar(50),
ValorTasa decimal(18,4),
FechaActualizacion datetime not null
)

insert into TasaCambio
values 
('(USD) Dolar', 60, GETDATE()),
('(EUR) Euro', 71.23, GETDATE()),
('(GBP) Libra Esterlina', 81.08, GETDATE()),
('(JPY) Yen Japonés', 0.38, GETDATE()),
('(MXN) Peso Mexicano', 3.50, GETDATE())

select * from TasaCambio

///PROCEDIMIENTO PARA MOSTRAR TASAS DE CAMBIO
create proc MostrarTasaCambio
as
select *from TasaCambio
go

exec MostrarTasaCambio

///PROCEDIMIENTO PARA INSERTAR TASAS DE CAMBIO
Create proc InsertarTasa
@MonedaNombre varchar(50),
@ValorTasa decimal(18,4)
as
INSERT INTO TasaCambio (MonedaNombre, ValorTasa, FechaActualizacion) 
values (@MonedaNombre,@ValorTasa,GETDATE())
go

exec InsertarTasa 'argen', 23
drop proc InsertarTasa


///PROCEDIMIENTO PARA EDITAR TASAS DE CAMBIO
create proc EditarTasa
@MonedaNombre varchar(50),
@ValorTasa decimal(18,4),
@TasaID int
as
update TasaCambio set MonedaNombre = @MonedaNombre, ValorTasa = @ValorTasa
where TasaID = @TasaID
go

exec EditarTasa 'Podel', 30, 8

///PROCEDIMIENTO PARA ELIMINAR TASAS DE CAMBIO
create proc EliminarTasa
@TasaID int
as
delete from TasaCambio where TasaID = @TasaID
go

exec EliminarTasa 10


///TABLA DE USUARIO
create Table Usuario
(
UsuarioID int identity(1,1) primary key,
UsuarioNombre varchar(50),
Rol varchar(50)
)
go

insert into Usuario values ('JUAN' , 'Gerente')
go

drop table Usuario
Select * from Usuario
go
///PROCEDIMIENTO PARA MOSTRAR USUARIOS
create proc MostrarUsuario
as
select *from Usuario
go

drop proc MostrarUsuario
exec MostrarUsuario

///PROCEDIMEINTO PARA INSERTAR USUARIOS
Create proc InsertarUsuario
@UsuarioNombre varchar(50),
@Rol varchar(50)
as
INSERT into Usuario (UsuarioNombre, Rol)
values (@UsuarioNombre, @Rol)
go

drop proc InsertarUsuario
exec InsertarUsuario 'Prueba2', 'Rol'

///PROCEDIMIENTO PARA EDITAR USUARIOS
create proc EditarUsuario
@UsuarioNombre varchar(50),
@Rol varchar(50),
@UsuarioID int
as
update Usuario set UsuarioNombre = @UsuarioNombre, Rol = @Rol
where UsuarioID = @UsuarioID
go

exec EditarUsuario 'Prueba3', 'Gerente', 1

drop proc EditarUsuario

///PROCEDIMIENTO PARA ELIMINAR USUARIOS
create proc EliminarUsuario
@UsuarioID int
as
delete from Usuario where UsuarioID = @UsuarioID
go

exec EliminarUsuario 2

exec mostrarUsuario


///Tabla de conversion 
create table Conversion
(
ConversionID int identity(1,1) primary key,
UsuarioID int Foreign key references Usuario(UsuarioID),
TasaID int Foreign key references TasaCambio(TasaID),
MontoOrigen decimal(18,4),
MontoConvertido decimal(18,4),
FechaConversion datetime DEFAULT GETDATE()
)

drop table Conversion

///Procedimiento Mostrar conversion
Create proc MostrarConversion
as
select  * from Conversion
go

exec MostrarConversion

///Procedimiento para insertar conversion
create proc InsertarConversion
@UsuarioID int,
@TasaID int,
@MontoOrigen decimal(18,4),
@MontoConvertido decimal(18,4)
as
INSERT into Conversion (UsuarioID, TasaID, MontoOrigen, MontoConvertido)
values (@UsuarioID, @TasaID, @MontoOrigen, @MontoConvertido)
go



