
Create database ConversorDeMoneda
go
use ConversorDeMoneda

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

create proc MostrarTasaCambio
as
select *from TasaCambio
go

Create proc InsertarTasa
@MonedaNombre varchar(50),
@ValorTasa decimal(18,4)
as
INSERT INTO TasaCambio (MonedaNombre, ValorTasa, FechaActualizacion) 
values (@MonedaNombre,@ValorTasa,GETDATE())
go

exec InsertarTasa 'argen', 23
drop proc InsertarTasa

exec MostrarTasaCambio

create proc EditarTasa
@MonedaNombre varchar(50),
@ValorTasa decimal(18,4),
@TasaID int
as
update TasaCambio set MonedaNombre = @MonedaNombre, ValorTasa = @ValorTasa
where TasaID = @TasaID
go

exec EditarTasa 'Podel', 30, 8

create proc EliminarTasa
@TasaID int
as
delete from TasaCambio where TasaID = @TasaID
go

exec MostrarTasaCambio
exec EliminarTasa 10