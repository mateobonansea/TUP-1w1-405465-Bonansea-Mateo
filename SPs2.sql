USE HOTEL_DB
GO
create PROCEDURE [dbo].[SP_MODIFICAR_CLIENTE]
@id int,@nombre varchar(50),@apellido varchar(50),@tdoc int,
@dni varchar(30), @email varchar(100), @tCliente int , @razonSoc varchar(50),@celular varchar(50), @cuil varchar(50)
AS 
BEGIN 
	UPDATE CLIENTES
	SET 
		NOMBRE = @nombre,
		APELLIDO = @apellido,
		TIPO_DOCUMENTO =@tdoc ,
		DNI = @dni, 
		EMAIL = @email ,
		CELULAR = @celular,
		tipo_cliente = @tCliente, 
		Razon_Social = @razonSoc,
		CUIL= @cuil
	WHERE ID = @id
END;
GO

--INSERTAR CLIENTE
create PROCEDURE [dbo].[SP_INSERTAR_CLIENTE]--OkTotal
@nombre varchar(50),@apellido varchar(50),@tdoc int,@cuil varchar(30),
@dni varchar(30), @email varchar(100), @tCliente int , @razonSoc varchar(50),@celular varchar(30)
AS 
BEGIN 
	INSERT INTO CLIENTES(NOMBRE,APELLIDO,TIPO_DOCUMENTO,DNI,CUIL,EMAIL,CELULAR,
	tipo_cliente,Razon_Social)
	VALUES(@nombre,@apellido,@tdoc ,@dni,@cuil, @email ,@celular, @tCliente, @razonSoc)
END;
GO
--BORRAR CLIENTE
ALTER PROCEDURE SP_BORRAR_CLIENTE
    @id INT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Error INT;

    -- Iniciar la transacci�n
    BEGIN TRANSACTION;

    BEGIN TRY
	if exists (select cliente from facturas where cliente = @id) begin
		raiserror('El cliente tiene facturas: ', 16, 1);
		rollback transaction;
		end
		if exists (select cliente from reservas where cliente = @id) begin
		raiserror('El cliente tiene facturas: ', 16, 1);
		rollback transaction;
		end
        -- Eliminar el cliente
        DELETE FROM CLIENTES WHERE ID = @id;

        -- Confirmar la transacci�n
        COMMIT;
    END TRY
    BEGIN CATCH
        -- Obtener el c�digo de error
        SET @Error = ERROR_NUMBER();

		
        -- Deshacer la transacci�n en caso de error
        IF @@TRANCOUNT > 0 
            ROLLBACK;

        -- Puedes registrar el error o lanzar una excepci�n aqu�
        -- SELECT ERROR_MESSAGE() AS ErrorMessage;

        -- Propagar el error al nivel superior
        RAISERROR('Error en SP_BORRAR_CLIENTE: ', 16, 1);
    END CATCH;
END;
GO
--SELECT TIPOCLIENTE
CREATE PROCEDURE SP_CONSULTAR_TIPOCLIENTE--OkTotal

AS 
BEGIN 
	SELECT * FROM TIPOS_CLIENTES
END;
GO
--SELECT TIPODOCUMENTO
CREATE PROCEDURE SP_CONSULTAR_TIPODOCUMENTO--OkTotal

AS 
BEGIN 
	SELECT * FROM TIPO_DOCUMENTOS
END;
GO
--LISTAR CLIENTES

create PROCEDURE [dbo].[SP_LISTA_CLIENTES]--OkApi
AS
BEGIN
    SELECT C.ID 'ID', C.NOMBRE 'Nombre',C.APELLIDO'Apellido',T.TIPO_DOCUMENTO 'Tipo Documento',  t.ID 'IDD', C.DNI 'Numero Documento',
    C.CUIL 'Numero CUIL',C.EMAIL 'Email',C.CELULAR 'Celular',tc.ID 'IDC',TC.Descripcion 'Tipo Cliente',C.Razon_Social 'Razon Social'
    FROM CLIENTES C 
    JOIN TIPO_DOCUMENTOS T ON C.TIPO_DOCUMENTO = T.ID 
    JOIN TIPOS_CLIENTES TC ON C.tipo_cliente = TC.ID
    ORDER BY 1
END
GO
create procedure ps_HabDisponibles @desde date, @hasta date, @hotel int
as
begin
select HABITACION_HOTEL.ID as 'Id_Habitacion',HABITACION_HOTEL.CODIGO as 'Codigo_Habitacion',
HABITACION_HOTEL.CAMA_MAX,HABITACION_HOTEL.TELEFONO,
CATEGORIA_HABITACIONES.ID as 'Id_Categoria',CATEGORIA_HABITACIONES.DESCRIPCION,CATEGORIA_HABITACIONES.PRECIO
from HABITACION_HOTEL
inner join PISOS_HOTEL on PISOS_HOTEL.ID=HABITACION_HOTEL.PISO
inner join HOTELES on PISOS_HOTEL.HOTEL=HOTELES.ID
inner join CATEGORIA_HABITACIONES on HABITACION_HOTEL.CATEGORIA=CATEGORIA_HABITACIONES.ID
where HABITACION_HOTEL.ID not in (
select HABITACION from RESERVA_HABITACIONES 
inner join RESERVAS on RESERVAS.ID=RESERVA_HABITACIONES.RESERVA
where RESERVAS.ESTADO!=3 and
(@desde between INGRESO and SALIDA or @hasta between INGRESO and SALIDA) or 
( INGRESO between @desde and @hasta or SALIDA between @desde and @hasta) 
) and HOTELES.ID=@hotel and HOTELES.HABILITADO=1
end;

GO

create procedure ps_InsertReserva
@cliente int,
@ingreso date,
@salida date,
@empleado int,
@id int output
as
begin
insert into RESERVAS(ESTADO,CLIENTE,INGRESO,SALIDA,FECHA_RESERVA,Empleado)
values (1,@cliente,@ingreso,@salida,GETDATE(),@empleado);
select @id= SCOPE_IDENTITY();
end;

GO

create procedure ps_InsertReservaHabitacion
@reserva int,
@habitacion int,
@monto int
as
begin
insert into RESERVA_HABITACIONES(RESERVA,HABITACION,MONTO_HABITACION)
values (@reserva,@habitacion,@monto);
end;

GO

create procedure ps_InsertReservaCuenta
@reserva int,
@servicio int,
@monto decimal(10,2),
@bonificado bit,
@cantidad int
as
begin
insert into RESERVA_CUENTA(RESERVA,SERVICIO,MONTO,BONIFICADO,CANTIDAD)
values (@reserva,@servicio,@monto,@bonificado,@cantidad);
end;
GO


	CREATE TRIGGER tr_BorrarCliente
	ON dbo.Clientes
	INSTEAD OF DELETE
	AS
	BEGIN
		SET NOCOUNT ON;

		-- Verificar si hay alg�n cliente con reservas o facturas
		IF EXISTS (SELECT 1 FROM deleted d
				   JOIN Reservas r ON d.ID = r.CLIENTE
				   WHERE r.estado = 'Activa')
		BEGIN
			THROW 51000, 'Error: El cliente tiene reservas activas.', 1;
			RETURN;
		END

		IF EXISTS (SELECT 1 FROM deleted d
				   JOIN Facturas f ON d.ID = F.CLIENTE)
		BEGIN
			THROW 51001, 'Error: El cliente tiene facturas.', 1;
			RETURN;
		END

		DELETE FROM dbo.Clientes
		WHERE ID IN (SELECT ID FROM deleted);
	END
	go
