
-- Insertar en la tabla Agricultores
INSERT INTO Agricultores (Apellido, Nombre, Dni, NroCuit, Direccion, Telefono) VALUES
('Armani', 'Franco', 42000000, '20-42000000-0', 'Casilda', 3464631503),
('Borja', 'Miguel', 45000000, '20-45000000-3', 'Buenos Aires', 3464123456),
('Perez', 'Enzo', 25000000, '20-25000000-7', 'Rosario', 3464876543),
('Alvarez', 'Julian', 41000000, '20-41000000-6', 'Cordoba', 3415456654),
('Fernandez', 'Enzo', 40000000, '20-40000000-5', 'Buenos Aires', 3425478965);
select * from Agricultores

-- Insertar en la tabla Industrias
INSERT INTO Industrias (Cuil, Nombre, Direccion, Telefono) VALUES
('20-12345678-9', 'Aceitera Santa Clara', 'Santa Clara', 3464678987),
('20-98765432-1', 'Molinera Gutierrez', 'Los Molinos', 3464123334),
('20-12320998-7', 'Molinera Moailine', 'Pujato', 3464198237),
('20-11111111-8', 'Aceitera Los Nogales', 'Los Nogales', 3464111234);
select * from Industrias

-- Insertar en la tabla Consumidores
INSERT INTO Clientes (Dni, Nombre, Apellido, Direccion, Telefono, CodPostal, NroCuit) VALUES
(12345678, 'Juan', 'Perez', 'Santiago 1212', 3456789012, 2000, '20-12345678-9'),
(87654321, 'María', 'López', 'Cordoba 321', 3456789013, 2001, '27-87654321-0'),
(23456789, 'Carlos', 'García', 'Santa Fe 345', 3456789014, 2002, '23-23456789-7'),
(98765432, 'Laura', 'Martínez', 'Alvear 101', 3456789015, 2003, '27-98765432-1'),
(34567890, 'Roberto', 'Hernández', 'Mitre 2202', 3456789016, 2004, '20-34567890-2');
select * from Clientes

-- Insertar en la tabla Transportes
INSERT INTO Transportes (Patente, Marca, Modelo, Tara) VALUES
('AA 070 B3', 'Mercedes-Benz', 'Actros', 34000),
('AB 563 A1', 'Mercedes-Benz', 'Arocs', 29000),
('AA 000 AA', 'Scania', 'Serie R', 30000);
select * from Transportes

-- Insertar en la tabla Semillas
INSERT INTO Semillas (Codigo, Nombre, Clase, Cantidad, PrecioToneladaCompra, PrecioToneladaVenta) VALUES
('S01', 'Soja', 'Intacta', 2000000, 120000, 150000),
('M01', 'Maíz', 'Segunda', 1000000, 100000, 120000),
('C01', 'Cebada', 'Primera', 500000, 75000, 100000);
select * from Semillas

-- Insertar en la tabla Productos
INSERT INTO Productos (Codigo, Nombre, Marca, Stock, PrecioUnidad) VALUES
('HAR01', 'Harina de Trigo', 'AFA', 1000, 1000),
('HAR02', 'Harina de Maíz', 'AFA', 800, 1200),
('HAR03', 'Harina Integral', 'AFA', 600, 1500),
('ACE01', 'Aceite de Soja', 'AFA', 1500, 800),
('ACE02', 'Aceite de Maíz', 'AFA', 1500, 1000);
select * from Productos

-- Insertar en la tabla Ingresos
INSERT INTO Ingresos (Codigo, Fecha, PrecioTotal, AgricultorID, SemillaID, TransporteID, Cantidad) VALUES
(1, '2024-01-15', 240000, 1, 1, 1, 2000),
(2, '2024-01-28', 375000, 3, 3, 2, 5000),
(3, '2024-02-04', 1000000, 2, 2, 3, 10000),
(4, '2024-02-04', 2000000, 2, 2, 2, 20000),
(5, '2024-02-04', 1800000, 2, 1, 2, 15000);
select * from Ingresos

-- Insertar en la tabla Salidas
INSERT INTO Salidas (Codigo, Fecha, PrecioTotal, IndustriaID, SemillaID, TransporteID, Cantidad) VALUES
(1, '2024-01-14', 150000, 1, 1, 1, 1000),
(2, '2024-01-24', 450000, 4, 1, 1, 3000),
(3, '2024-02-06', 600000, 2, 2, 2, 5000),
(4, '2024-02-06', 1000000, 2, 3, 3, 10000),
(5, '2024-02-06', 2000000, 3, 3, 3, 20000);
select * from Salidas