using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class Final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agricultores",
                columns: table => new
                {
                    AgricultorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<int>(type: "int", nullable: false),
                    NroCuit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agricultores", x => x.AgricultorID);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dni = table.Column<int>(type: "int", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NroCuit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodPostal = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteID);
                });

            migrationBuilder.CreateTable(
                name: "Componente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoComponente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Componente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Industrias",
                columns: table => new
                {
                    IndustriaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cuil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industrias", x => x.IndustriaID);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    PrecioUnidad = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoID);
                });

            migrationBuilder.CreateTable(
                name: "Semillas",
                columns: table => new
                {
                    SemillaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clase = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cantidad = table.Column<long>(type: "bigint", nullable: false),
                    PrecioToneladaCompra = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecioToneladaVenta = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semillas", x => x.SemillaID);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<int>(type: "int", nullable: false),
                    Clave = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    VentaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClienteID = table.Column<int>(type: "int", nullable: false),
                    PrecioTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.VentaID);
                    table.ForeignKey(
                        name: "FK_Ventas_Clientes_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Clientes",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GrupoPermisos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrupoId = table.Column<int>(type: "int", nullable: false),
                    PermisoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoPermisos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GrupoPermisos_Componente_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Componente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrupoPermisos_Componente_PermisoId",
                        column: x => x.PermisoId,
                        principalTable: "Componente",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Transportes",
                columns: table => new
                {
                    TransporteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tara = table.Column<int>(type: "int", nullable: false),
                    AgricultorID = table.Column<int>(type: "int", nullable: true),
                    IndustriaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transportes", x => x.TransporteID);
                    table.ForeignKey(
                        name: "FK_Transportes_Agricultores_AgricultorID",
                        column: x => x.AgricultorID,
                        principalTable: "Agricultores",
                        principalColumn: "AgricultorID");
                    table.ForeignKey(
                        name: "FK_Transportes_Industrias_IndustriaID",
                        column: x => x.IndustriaID,
                        principalTable: "Industrias",
                        principalColumn: "IndustriaID");
                });

            migrationBuilder.CreateTable(
                name: "AuditoriasLogInLogOut",
                columns: table => new
                {
                    AuditoriaLogInLogOutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioID = table.Column<int>(type: "int", nullable: false),
                    TipoAuditoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechayHora = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditoriasLogInLogOut", x => x.AuditoriaLogInLogOutID);
                    table.ForeignKey(
                        name: "FK_AuditoriasLogInLogOut_Usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuditoriasVentas",
                columns: table => new
                {
                    AuditoriaVentaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioID = table.Column<int>(type: "int", nullable: false),
                    TipoAuditoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechayHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClienteID = table.Column<int>(type: "int", nullable: false),
                    PrecioTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditoriasVentas", x => x.AuditoriaVentaID);
                    table.ForeignKey(
                        name: "FK_AuditoriasVentas_Clientes_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Clientes",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuditoriasVentas_Usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioComponentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    ComponenteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioComponentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioComponentes_Componente_ComponenteId",
                        column: x => x.ComponenteId,
                        principalTable: "Componente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioComponentes_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuditoriasIngresos",
                columns: table => new
                {
                    AuditoriaIngresoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioID = table.Column<int>(type: "int", nullable: false),
                    TipoAuditoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechayHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AgricultorID = table.Column<int>(type: "int", nullable: false),
                    SemillaID = table.Column<int>(type: "int", nullable: false),
                    TransporteID = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    PrecioTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditoriasIngresos", x => x.AuditoriaIngresoID);
                    table.ForeignKey(
                        name: "FK_AuditoriasIngresos_Agricultores_AgricultorID",
                        column: x => x.AgricultorID,
                        principalTable: "Agricultores",
                        principalColumn: "AgricultorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuditoriasIngresos_Semillas_SemillaID",
                        column: x => x.SemillaID,
                        principalTable: "Semillas",
                        principalColumn: "SemillaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuditoriasIngresos_Transportes_TransporteID",
                        column: x => x.TransporteID,
                        principalTable: "Transportes",
                        principalColumn: "TransporteID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuditoriasIngresos_Usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuditoriasSalidas",
                columns: table => new
                {
                    AuditoriaSalidaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioID = table.Column<int>(type: "int", nullable: false),
                    TipoAuditoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechayHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IndustriaID = table.Column<int>(type: "int", nullable: false),
                    SemillaID = table.Column<int>(type: "int", nullable: false),
                    TransporteID = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    PrecioTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditoriasSalidas", x => x.AuditoriaSalidaID);
                    table.ForeignKey(
                        name: "FK_AuditoriasSalidas_Industrias_IndustriaID",
                        column: x => x.IndustriaID,
                        principalTable: "Industrias",
                        principalColumn: "IndustriaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuditoriasSalidas_Semillas_SemillaID",
                        column: x => x.SemillaID,
                        principalTable: "Semillas",
                        principalColumn: "SemillaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuditoriasSalidas_Transportes_TransporteID",
                        column: x => x.TransporteID,
                        principalTable: "Transportes",
                        principalColumn: "TransporteID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuditoriasSalidas_Usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingresos",
                columns: table => new
                {
                    IngresoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgricultorID = table.Column<int>(type: "int", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SemillaID = table.Column<int>(type: "int", nullable: false),
                    TransporteID = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    PrecioTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingresos", x => x.IngresoID);
                    table.ForeignKey(
                        name: "FK_Ingresos_Agricultores_AgricultorID",
                        column: x => x.AgricultorID,
                        principalTable: "Agricultores",
                        principalColumn: "AgricultorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ingresos_Semillas_SemillaID",
                        column: x => x.SemillaID,
                        principalTable: "Semillas",
                        principalColumn: "SemillaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ingresos_Transportes_TransporteID",
                        column: x => x.TransporteID,
                        principalTable: "Transportes",
                        principalColumn: "TransporteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Salidas",
                columns: table => new
                {
                    SalidaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndustriaID = table.Column<int>(type: "int", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SemillaID = table.Column<int>(type: "int", nullable: false),
                    TransporteID = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    PrecioTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salidas", x => x.SalidaID);
                    table.ForeignKey(
                        name: "FK_Salidas_Industrias_IndustriaID",
                        column: x => x.IndustriaID,
                        principalTable: "Industrias",
                        principalColumn: "IndustriaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Salidas_Semillas_SemillaID",
                        column: x => x.SemillaID,
                        principalTable: "Semillas",
                        principalColumn: "SemillaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Salidas_Transportes_TransporteID",
                        column: x => x.TransporteID,
                        principalTable: "Transportes",
                        principalColumn: "TransporteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleVenta",
                columns: table => new
                {
                    DetalleVentaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductoID = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    PrecioParcial = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AuditoriaVentaID = table.Column<int>(type: "int", nullable: true),
                    VentaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleVenta", x => x.DetalleVentaID);
                    table.ForeignKey(
                        name: "FK_DetalleVenta_AuditoriasVentas_AuditoriaVentaID",
                        column: x => x.AuditoriaVentaID,
                        principalTable: "AuditoriasVentas",
                        principalColumn: "AuditoriaVentaID");
                    table.ForeignKey(
                        name: "FK_DetalleVenta_Productos_ProductoID",
                        column: x => x.ProductoID,
                        principalTable: "Productos",
                        principalColumn: "ProductoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleVenta_Ventas_VentaID",
                        column: x => x.VentaID,
                        principalTable: "Ventas",
                        principalColumn: "VentaID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriasIngresos_AgricultorID",
                table: "AuditoriasIngresos",
                column: "AgricultorID");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriasIngresos_SemillaID",
                table: "AuditoriasIngresos",
                column: "SemillaID");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriasIngresos_TransporteID",
                table: "AuditoriasIngresos",
                column: "TransporteID");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriasIngresos_UsuarioID",
                table: "AuditoriasIngresos",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriasLogInLogOut_UsuarioID",
                table: "AuditoriasLogInLogOut",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriasSalidas_IndustriaID",
                table: "AuditoriasSalidas",
                column: "IndustriaID");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriasSalidas_SemillaID",
                table: "AuditoriasSalidas",
                column: "SemillaID");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriasSalidas_TransporteID",
                table: "AuditoriasSalidas",
                column: "TransporteID");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriasSalidas_UsuarioID",
                table: "AuditoriasSalidas",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriasVentas_ClienteID",
                table: "AuditoriasVentas",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriasVentas_UsuarioID",
                table: "AuditoriasVentas",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_AuditoriaVentaID",
                table: "DetalleVenta",
                column: "AuditoriaVentaID");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_ProductoID",
                table: "DetalleVenta",
                column: "ProductoID");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_VentaID",
                table: "DetalleVenta",
                column: "VentaID");

            migrationBuilder.CreateIndex(
                name: "IX_GrupoPermisos_GrupoId",
                table: "GrupoPermisos",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_GrupoPermisos_PermisoId",
                table: "GrupoPermisos",
                column: "PermisoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingresos_AgricultorID",
                table: "Ingresos",
                column: "AgricultorID");

            migrationBuilder.CreateIndex(
                name: "IX_Ingresos_SemillaID",
                table: "Ingresos",
                column: "SemillaID");

            migrationBuilder.CreateIndex(
                name: "IX_Ingresos_TransporteID",
                table: "Ingresos",
                column: "TransporteID");

            migrationBuilder.CreateIndex(
                name: "IX_Salidas_IndustriaID",
                table: "Salidas",
                column: "IndustriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Salidas_SemillaID",
                table: "Salidas",
                column: "SemillaID");

            migrationBuilder.CreateIndex(
                name: "IX_Salidas_TransporteID",
                table: "Salidas",
                column: "TransporteID");

            migrationBuilder.CreateIndex(
                name: "IX_Transportes_AgricultorID",
                table: "Transportes",
                column: "AgricultorID");

            migrationBuilder.CreateIndex(
                name: "IX_Transportes_IndustriaID",
                table: "Transportes",
                column: "IndustriaID");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioComponentes_ComponenteId",
                table: "UsuarioComponentes",
                column: "ComponenteId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioComponentes_UsuarioId",
                table: "UsuarioComponentes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ClienteID",
                table: "Ventas",
                column: "ClienteID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditoriasIngresos");

            migrationBuilder.DropTable(
                name: "AuditoriasLogInLogOut");

            migrationBuilder.DropTable(
                name: "AuditoriasSalidas");

            migrationBuilder.DropTable(
                name: "DetalleVenta");

            migrationBuilder.DropTable(
                name: "GrupoPermisos");

            migrationBuilder.DropTable(
                name: "Ingresos");

            migrationBuilder.DropTable(
                name: "Salidas");

            migrationBuilder.DropTable(
                name: "UsuarioComponentes");

            migrationBuilder.DropTable(
                name: "AuditoriasVentas");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Semillas");

            migrationBuilder.DropTable(
                name: "Transportes");

            migrationBuilder.DropTable(
                name: "Componente");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Agricultores");

            migrationBuilder.DropTable(
                name: "Industrias");
        }
    }
}
