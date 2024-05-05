--- Crear la Base de Datos
CREATE DATABASE bdSimulador; 

 --- Utilizar la Base de Datos
USE bdSimulador; 

-- Tabla de Productos
CREATE TABLE tb_producto (
    idProducto INT IDENTITY(1,1) PRIMARY KEY,
    producto VARCHAR(250),
	precio_costo float,
    precio_operativo FLOAT,
    precio_venta FLOAT,
    porcentaje_ganancia FLOAT,
    utilidad FLOAT
);

-- Tabla de Gastos
CREATE TABLE tb_gasto (
    idGasto INT IDENTITY(1,1)  PRIMARY KEY,
	nombreGasto VARCHAR(250),
    monto FLOAT,
    tipoGasto VARCHAR(250)
);

-- Tabla de Escenarios
CREATE TABLE tb_escenarios (
    Escenario INT,
    Hora INT,
	idCliente INT,
    idProducto INT,
);
----CREAR PRODUCTO
CREATE PROCEDURE pCrearProducto(@producto varchar(250), @precio_costo float, @precio_operativo float, 
@precio_venta float,@porcentaje_ganancia float,@utilidad float)
AS BEGIN
    INSERT INTO tb_producto (producto, precio_costo, precio_operativo, precio_venta, porcentaje_ganancia, utilidad)
    VALUES (@producto, @precio_costo, @precio_operativo, @precio_venta,@porcentaje_ganancia ,@utilidad)
END


----CREAR GASTO
CREATE PROCEDURE pCrearGasto(@nombreGasto varchar(250), @monto float, @tipoGasto varchar(250))
AS BEGIN
    INSERT INTO tb_gasto (nombreGasto, monto, tipoGasto)
    VALUES (@nombreGasto, @monto, @tipoGasto)
END

--- INSERTAR REGISTROS INICIALES A LAS TABLAS
INSERT INTO tb_producto(producto, precio_costo, precio_operativo, precio_venta, porcentaje_ganancia, utilidad)
VALUES 
('clavo 1" 1/2 (libra)', 4.5, 5, 7, 0.4, 2),
('martillo 16', 45, 50, 65, 0.3, 15),
('cemento (Saco)', 50, 55, 68, 0.24, 13),
('Hierro de construcción 3/8"', 240, 250, 295, 0.18, 45),
('lamina 6 pies', 26, 30, 45, 0.5, 15),
('clavo de lamina (libra)', 7, 8, 12, 0.5, 4),
('tubo PVC 1/2 "', 16, 20, 25, 0.25, 5),
('tubo PVC 3/4"', 22, 25, 30, 0.2, 5),
('tubo PVC 3"', 50, 55, 70, 0.27, 15),
('tubo PVC 4"', 60, 65, 85, 0.31, 20),
('Pala Trupper', 65, 70, 95, 0.36, 25),
('chapa filips', 90, 95, 115, 0.21, 20),
('Sanitario', 630, 650, 850, 0.31, 200),
('lamina 8 pies', 35, 41, 63, 0.54, 22),
('lamina 10 pies', 45, 50, 70, 0.4, 20),
('Spray corona', 13, 15, 20, 0.33, 5),
('Candado Yale 70mm', 128, 140, 165, 0.18, 25),
('Candado Yale 30 mm', 31, 35, 45, 0.29, 10),
('Disco de lija 120', 7, 8, 12, 0.5, 4),
('Brocha', 2.5, 3, 5, 0.67, 2),
('Formon 1"', 35, 40, 55, 0.38, 15),
('Piocha Trupper', 125, 140, 160, 0.14, 20),
('Aceitera con aplicador 10onz', 50, 60, 75, 0.25, 15),
('Hierro comercial 1/4', 225, 250, 315, 0.26, 65),
('Hacha', 90, 100, 130, 0.3, 30),
('canales', 18, 22, 30, 0.36, 8),
('Cuchara forjada', 64, 68, 85, 0.25, 17),
('Flota de espuma', 16, 20, 28, 0.4, 8),
('Llave de paso 1/2 metal', 21, 25, 38, 0.52, 13),
('machete #20', 20, 24, 35, 0.46, 11),
('Bombilla', 11, 14, 20, 0.43, 6),
('Lima de serrucho', 10, 11, 15, 0.36, 4),
('crayones', 2, 2.5, 4, 0.6, 1.5),
('Rastrillos de metal', 50, 60, 80, 0.33, 20),
('Hilo chapeadora', 15, 19, 25, 0.32, 6),
('lijas de lona 60', 3.5, 5, 8, 0.6, 3),
('lijas de metal 60', 2.5, 3, 5, 0.67, 2),
('pintura volcán para piso', 20, 23, 33, 0.43, 10),
('Metro pretul 8 metros', 30, 32, 45, 0.41, 13),
('pie de cadena', 2.5, 3, 5, 0.67, 2),
('Chapa para ropero', 9.5, 11, 15, 0.36, 4),
('T de 3', 10, 12, 18, 0.5, 6),
('Visagras', 5, 6, 8, 0.33, 2),
('poliducto 3/4 (metro)', 2, 2, 3, 0.5, 1),
('spray colores', 10, 14, 23, 0.64, 9),
('lazo de 1/4 (metro)', 1, 1, 2, 1, 1),
('Naylon (yarda)', 10.5, 12.5, 18, 0.44, 5.5),
('clavo acerado', 0.75, 0.75, 1.25, 0.67, 0.5),
('Chorro 1/2" metal', 31, 36, 45, 0.25, 9),
('chorro 1/2" plástico', 9.5, 11, 15, 0.36, 4),
('Espiga', 4, 4.5, 7, 0.56, 2.5),
('Disco de madera', 31, 35, 45, 0.29, 10),
('Barilla de bomba', 52, 60, 75, 0.25, 15),
('Sinchas', 1.5, 1.5, 2.5, 0.67, 1),
('Malla (yarda)', 8, 10, 13, 0.3, 3),
('Regleta', 21, 24,30,0.25,6),
('Sedaso (yarda)',9.5,11,15,0.36,4),
('Punta trupper',35,40,50,0.25,10),
('Lima',8,9,12,0.33,3),
('Hilo (metros)',0.5,0.5,1,1,0.5),
('Disco de corte',4.5,5,7,0.4,2),
('Grapa',8,9,13,0.44,4)
----------------------

SELECT * FROM tb_producto
SELECT * FROM tb_gasto

----------------------
INSERT INTO tb_gasto (nombreGasto, monto, tipoGasto)
VALUES
('Internet',350,'Fijo'),
('Electricidad',500,'Variable')
----------------------

-- PROCEDIMIENTO PARA GENERAR LOS 3 ESCENARIOS DE LA SIMULACIÓN 
CREATE PROCEDURE InsertarEscenarios
    @horas INT,
    @clientes INT,
    @productos INT
AS
BEGIN
    DECLARE @contadorEscenario INT = 1;

    -- Ciclo para cada escenario
    WHILE @contadorEscenario <= 3
    BEGIN
        DECLARE @contadorHora INT = 1;

        -- Ciclo para cada hora dentro del escenario
        WHILE @contadorHora <= @horas
        BEGIN
             -- Generar un número aleatorio entre 0 y @clientes
            DECLARE @randomClientes INT = CAST(ROUND(RAND() * @clientes, 0) AS INT);

			DECLARE @contadorCliente INT = 0;

            -- Ciclo para cada cliente dentro de la hora
            WHILE @contadorCliente <= @randomClientes
            BEGIN
                -- Generar un número aleatorio entre 1 y @productos para este cliente en esta hora
                DECLARE @randomProductos INT = CAST(ROUND(RAND() * (@productos - 1) + 1, 0) AS INT);

                DECLARE @contadorProducto INT = 1;
                DECLARE @idCliente INT = @contadorCliente;

                -- Ciclo para cada producto dentro del cliente
                WHILE @contadorProducto <= @randomProductos
                BEGIN
                    -- Obtener un idProducto aleatorio entre 1 y el número de productos
                    DECLARE @idProducto INT;
                    WITH RandomizedProducts AS (
                        SELECT idProducto, ROW_NUMBER() OVER (ORDER BY NEWID()) AS RowNum
                        FROM tb_producto
                    )
                    SELECT TOP 1 @idProducto = idProducto 
                    FROM RandomizedProducts 
                    WHERE RowNum = ABS(CHECKSUM(NEWID())) % (SELECT COUNT(*) FROM RandomizedProducts);

                    -- Insertar el registro en la tabla tb_escenarios
                    INSERT INTO tb_escenarios (Escenario, Hora, idCliente, idProducto)
                    VALUES (@contadorEscenario, @contadorHora, @idCliente, @idProducto);

                    SET @contadorProducto = @contadorProducto + 1;
                END;

                SET @contadorCliente = @contadorCliente + 1;
            END;

            SET @contadorHora = @contadorHora + 1;
        END;

        SET @contadorEscenario = @contadorEscenario + 1;
    END;
END;

---------------------
EXEC InsertarEscenarios @horas = 3, @clientes = 4, @productos = 2;
---------------------

---------------------
select * from tb_escenarios;

select * from tb_escenarios where Escenario = 3;
----------------------

--- PROCEDIMIENTO PARA ELIMINAR LOS REGISTROS ANTES DE CREAR NUEVOS ESCENARIOS
CREATE PROCEDURE pEliminarEscenarios
AS
BEGIN
    DELETE FROM tb_escenarios;
END;
----------------------

----------------------
exec pEliminarEscenarios;
------------------------

--- PROCEDIMIENTO PARA OBTENER EL ESCENARIO N
CREATE PROCEDURE getEscenario
    @escenario INT,
    @servicio INT
AS
BEGIN
    SELECT 
        e.Hora,
        COUNT(DISTINCT CASE WHEN e.idCliente != 0 THEN e.idCliente END) AS [Cantidad de Clientes],
        @servicio AS [Tiempo de Servicio],
        SUM(CASE WHEN e.idCliente != 0 THEN p.utilidad ELSE 0 END) AS Ganancia
    FROM 
        tb_escenarios e
    INNER JOIN 
        tb_producto p ON e.idProducto = p.idProducto
    WHERE 
        e.Escenario = @escenario
    GROUP BY 
        e.Hora;
END;
----------------------

--- PROCEDIMIENTO PARA OBTENER LA HORA N DEL ESCENARIO N
ALTER PROCEDURE getHora
    @escenario INT,
    @hora INT,
    @clientes INT
AS
BEGIN
    -- Verificar que el número de clientes sea mayor a 0
    IF @clientes <= 0
    BEGIN
        -- Si no hay clientes, retornar una tabla vacía
        SELECT 
            NULL AS [No],
            NULL AS [Cantidad de Productos],
            NULL AS [Total Costo],
            NULL AS [Total Venta],
            NULL AS [Utilidad]
        WHERE 1 = 0; -- Condición que siempre es falsa para retornar una tabla vacía
    END
    ELSE
    BEGIN
        DECLARE @i INT = 1;
        
        -- Variable para almacenar los resultados
        DECLARE @Results TABLE (
            [No] INT,
            [Cantidad de Productos] INT,
            [Total Costo] FLOAT,
            [Total Venta] FLOAT,
            Utilidad FLOAT
        );

        -- Insertar valores en la tabla de resultados
        WHILE @i <= @clientes
        BEGIN
            INSERT INTO @Results ([No], [Cantidad de Productos], [Total Costo], [Total Venta], Utilidad)
            SELECT 
                @i AS [No],
                COUNT(es.idProducto) AS [Cantidad de Productos],
                SUM(p.precio_costo) AS [Total Costo],
                SUM(p.precio_venta) AS [Total Venta],
                SUM(p.utilidad) AS Utilidad
            FROM 
                tb_escenarios es
            INNER JOIN 
                tb_producto p ON es.idProducto = p.idProducto
            WHERE 
                es.Escenario = @escenario
                AND es.Hora = @hora
                AND es.idCliente = @i;

            SET @i = @i + 1;
        END;

        -- Seleccionar resultados de la tabla de resultados
        SELECT * FROM @Results;
    END
END;
----------------------

--- PROCEDIMIENTO PARA OBTENER LOS PRODUCTOS ASOCIADOS A UN CLIENTE
CREATE PROCEDURE getProductCustomer
    @escenario INT,
    @hora INT,
    @idCliente INT
AS
BEGIN
    SELECT 
        ROW_NUMBER() OVER (ORDER BY p.idProducto) AS [No],
        p.producto AS Producto,
        p.precio_costo AS [Precio Costo],
        p.precio_venta AS [Precio Venta],
        p.utilidad AS Utilidad
    FROM 
        tb_escenarios e
    INNER JOIN 
        tb_producto p ON e.idProducto = p.idProducto
    WHERE 
        e.Escenario = @escenario
        AND e.Hora = @hora
        AND e.idCliente = @idCliente;
END;
----------------------

----------------------
select * from tb_escenarios where Escenario = 2;
EXEC getEscenario @escenario = 1, @servicio = 4;
EXEC getHora @escenario = 2, @hora = 2, @clientes = 4;
EXEC getProductCustomer @escenario = 2, @hora = 2, @idCliente = 3;
----------------------

--- FUNCIÓN PARA OBTENER EL TOTAL DE LOS GASTOS
CREATE FUNCTION getMontoTotal()
RETURNS FLOAT
AS
BEGIN
    DECLARE @suma FLOAT;
    SELECT @suma = SUM(monto) FROM tb_gasto;
    RETURN @suma;
END;
----------------------

----------------------
SELECT dbo.getMontoTotal() AS SumaTotalGastos;
----------------------

--- PROCEDIMIENTO PARA OBTENER LOS REGISTROS DE UN PRODUCTO POR SU ID
CREATE PROCEDURE getProductById
    @idProducto INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        idProducto,
        producto,
        precio_costo,
        precio_operativo,
        precio_venta,
        porcentaje_ganancia,
		utilidad
    FROM 
        tb_producto
    WHERE 
        idProducto = @idProducto;
END;
----------------------
