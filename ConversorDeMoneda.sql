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
Contrasena varchar(50)
)
go

insert into Usuario values ('Prueba' , '1234')
go

Select * from Usuario
go
///PROCEDIMIENTO PARA MOSTRAR USUARIOS
create proc MostrarUsuario
as
select *from Usuario
go

exec MostrarUsuario

///PROCEDIMEINTO PARA INSERTAR USUARIOS
Create proc InsertarUsuario
@UsuarioNombre varchar(50),
@Contrasena varchar(50)
as
INSERT into Usuario (UsuarioNombre, Contrasena)
values (@UsuarioNombre, @Contrasena)
go

exec InsertarUsuario 'Prueba2', '5678'

///PROCEDIMIENTO PARA EDITAR USUARIOS
create proc EditarUsuario
@UsuarioNombre varchar(50),
@Contrasena varchar(50),
@UsuarioID int
as
update Usuario set UsuarioNombre = @UsuarioNombre, Contrasena = @Contrasena
where UsuarioID = @UsuarioID
go

exec EditarUsuario 'Prueba3', '9012', 1

drop proc EditarUsuario

///PROCEDIMIENTO PARA ELIMINAR USUARIOS
create proc EliminarUsuario
@UsuarioID int
as
delete from Usuario where UsuarioID = @UsuarioID
go

exec EliminarUsuario 2
exec MostrarTasaCambio

exec EliminarTasa 10
