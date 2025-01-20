INSERT INTO Usuarios (Nombre, Apellido, Dni, Clave) VALUES	
('Ignacio', 'Marani', 12345678, '0ffe1abd1a08215353c233d6e009613e95eec4253832a761af28ff37ac5a150c'),
('Santiago', 'Marani', 11111111, 'f6e0a1e2ac41945a9aa7ff8a8aaa0cebc12a3bcc981a929ad5cf810a090e11ae');



--PERMISOS SIMPLES

INSERT INTO Componente (Nombre, TipoComponente) VALUES 
('Todos los permisos', 'Permiso'),
('Gestionar Usuarios', 'Permiso'),
('Gestionar Grupos', 'Permiso'),
('Gestionar Auditorias', 'Permiso'),
('Gestionar Ingresos', 'Permiso'),
('Gestionar Agricultores', 'Permiso'),
('Gestionar Transportes Ingreso', 'Permiso'),
('Gestionar Salidas', 'Permiso'),
('Gestionar Industrias', 'Permiso'),
('Gestionar Transportes Salida', 'Permiso'),
('Gestionar Semillas', 'Permiso'),
('Gestionar Clientes', 'Permiso'),
('Gestionar Productos', 'Permiso'),
('Gestionar Ventas', 'Permiso'),
('Gestionar Reportes Ingreso', 'Permiso'),
('Gestionar Reportes Salida', 'Permiso'),
('Gestionar Reportes Venta', 'Permiso'),
('Gestionar Datos Personales', 'Permiso');


INSERT INTO UsuarioComponentes (UsuarioId, ComponenteId)
VALUES (1, 1);


--PERMISOS COMPUESTOS

INSERT INTO Componente (Nombre, TipoComponente, Descripcion) VALUES 
('Gestión de Seguridad', 'Grupo', 'Contiene permisos de gestión de usuarios, gestión de grupos y gestión de auditorias'),
('Gestión de Ingresos', 'Grupo', 'Contiene permisos de gestión de ingresos, gestión de agricultores y gestión de transportes'),
('Gestión de Salidas', 'Grupo', 'Contiene permisos de gestión de salidas, gestión de industrias y gestión de transportes'),
('Gestión de Semillas', 'Grupo', 'Contiene permisos de gestión de semillas'),
('Gestión de Productos', 'Grupo', 'Contiene permisos de gestión de productos'),
('Gestión de Ventas', 'Grupo', 'Contiene permisos de gestión de ventas, gestión de clientes y gestión de productos'),
('Gestión de Reportes', 'Grupo', 'Contiene permisos de gestión de reportes'),
('Gestión de Datos', 'Grupo', 'Contiene permisos de gestión de datos personales');

DECLARE @AccionAdministradorId INT = (SELECT Id FROM Componente WHERE Nombre = 'Todos los permisos');

DECLARE @AccionUsuariosId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestionar Usuarios');
DECLARE @AccionGruposId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestionar Grupos');
DECLARE @AccionAuditoriaId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestionar Auditorias');

DECLARE @AccionIngresosId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestionar Ingresos');
DECLARE @AccionAgricultoresId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestionar Agricultores');
DECLARE @AccionTransportesIngresoId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestionar Transportes Ingreso');

DECLARE @AccionSalidasId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestionar Salidas');
DECLARE @AccionIndustriasId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestionar Industrias');
DECLARE @AccionTransportesSalidaId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestionar Transportes Salida');

DECLARE @AccionSemillasId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestionar Semillas');

DECLARE @AccionVentasId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestionar Ventas');
DECLARE @AccionClientesId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestionar Clientes');
DECLARE @AccionProductosId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestionar Productos');

DECLARE @AccionReportesIngresoId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestionar Reportes Ingreso');
DECLARE @AccionReportesSalidaId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestionar Reportes Salida');
DECLARE @AccionReportesVentaId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestionar Reportes Venta');
DECLARE @AccionDatosPersonalesId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestionar Datos Personales');

DECLARE @GrupoSeguridadId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestión de Seguridad');
DECLARE @GrupoIngresosId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestión de Ingresos');
DECLARE @GrupoSalidasId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestión de Salidas');
DECLARE @GrupoSemillasId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestión de Semillas');
DECLARE @GrupoProductosId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestión de Productos');
DECLARE @GrupoVentasId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestión de Ventas');
DECLARE @GrupoReportesId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestión de Reportes');
DECLARE @GrupoDatosId INT = (SELECT Id FROM Componente WHERE Nombre = 'Gestión de Datos');


INSERT INTO GrupoPermisos (GrupoId, PermisoId) VALUES 
(@GrupoSeguridadId, @AccionUsuariosId),
(@GrupoSeguridadId, @AccionGruposId),
(@GrupoSeguridadId, @AccionAuditoriaId),

(@GrupoIngresosId, @AccionIngresosId),
(@GrupoIngresosId, @AccionAgricultoresId),
(@GrupoIngresosId, @AccionTransportesIngresoId),
(@GrupoIngresosId, @AccionReportesIngresoId),

(@GrupoSalidasId, @AccionSalidasId),
(@GrupoSalidasId, @AccionIndustriasId),
(@GrupoSalidasId, @AccionTransportesSalidaId),
(@GrupoSalidasId, @AccionReportesSalidaId),

(@GrupoSemillasId, @AccionSemillasId),

(@GrupoProductosId, @AccionProductosId),

(@GrupoVentasId, @AccionVentasId),
(@GrupoVentasId, @AccionClientesId),
(@GrupoVentasId, @AccionProductosId),
(@GrupoVentasId, @AccionReportesVentaId),

(@GrupoReportesId, @AccionReportesIngresoId),
(@GrupoReportesId, @AccionReportesSalidaId),
(@GrupoReportesId, @AccionReportesVentaId),

(@GrupoDatosId, @AccionDatosPersonalesId);


INSERT INTO UsuarioComponentes (UsuarioId, ComponenteId)
VALUES (2, 20);

select * from UsuarioComponentes
