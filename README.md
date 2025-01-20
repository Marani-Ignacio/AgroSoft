# AgroSoft
Este proyecto corresponde a la tesis de la carrera Analista en Sistemas Informaticos de la Universidad Abierta Interamericana (UAI). El software está desarrollado como parte de las materias de Ingeniería de Software y Trabajo de Diploma.

## Descripción del sistema
El Sistema de Registro de Ingresos / Salidas de cereal y Venta de productos elaborados, denominado AgroSoft, es una aplicación desarrollada en C# utilizando Windows Forms.

### Requerimientos funcionales
- Gestión de Usuarios
- Gestión de Permisos
- Gestión de Agricultores
- Gestión de Industrias
- Gestión de Semillas
- Gestión de Transportes
- Gestión de Registros de Ingreso de Cereal
- Gestión de Registros de Salida de Cereal
- Gestión de Clientes
- Gestión de Productos
- Gestión de Ventas
- Gestión de Reportes
- Gestión de Auditorias

### Arquitectura
Se ha utilizado la arquitectura de capas para el desarollo del sistem.
Modelo - Vista - Controladora

### Patrones utilizados
- Singleton: Gestión de la conexión a la base de datos.
- Composite: Módulo de permisos para asignar permisos simples o grupos de permisos a los usuarios.
- Decorator: Gestión de exportación de comporbantes y cartas de porte.
