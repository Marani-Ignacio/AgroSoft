﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modelo;

#nullable disable

namespace Modelo.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20241112110737_Final")]
    partial class Final
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Modelo.AuditoriaLogInLogOut", b =>
                {
                    b.Property<int>("AuditoriaLogInLogOutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuditoriaLogInLogOutID"));

                    b.Property<DateTime>("FechayHora")
                        .HasColumnType("datetime2");

                    b.Property<string>("TipoAuditoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("AuditoriaLogInLogOutID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("AuditoriasLogInLogOut");
                });

            modelBuilder.Entity("Modelo.Auditorias.AuditoriaIngreso", b =>
                {
                    b.Property<int>("AuditoriaIngresoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuditoriaIngresoID"));

                    b.Property<int>("AgricultorID")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechayHora")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PrecioTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SemillaID")
                        .HasColumnType("int");

                    b.Property<string>("TipoAuditoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TransporteID")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("AuditoriaIngresoID");

                    b.HasIndex("AgricultorID");

                    b.HasIndex("SemillaID");

                    b.HasIndex("TransporteID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("AuditoriasIngresos");
                });

            modelBuilder.Entity("Modelo.Auditorias.AuditoriaSalida", b =>
                {
                    b.Property<int>("AuditoriaSalidaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuditoriaSalidaID"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechayHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("IndustriaID")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SemillaID")
                        .HasColumnType("int");

                    b.Property<string>("TipoAuditoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TransporteID")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("AuditoriaSalidaID");

                    b.HasIndex("IndustriaID");

                    b.HasIndex("SemillaID");

                    b.HasIndex("TransporteID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("AuditoriasSalidas");
                });

            modelBuilder.Entity("Modelo.Auditorias.AuditoriaVenta", b =>
                {
                    b.Property<int>("AuditoriaVentaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuditoriaVentaID"));

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechayHora")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PrecioTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TipoAuditoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("AuditoriaVentaID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("AuditoriasVentas");
                });

            modelBuilder.Entity("Modelo.Componente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoComponente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Componente");

                    b.HasDiscriminator<string>("TipoComponente").HasValue("Componente");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Modelo.Entidades.Agricultor", b =>
                {
                    b.Property<int>("AgricultorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AgricultorID"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dni")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NroCuit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Telefono")
                        .HasColumnType("bigint");

                    b.HasKey("AgricultorID");

                    b.ToTable("Agricultores");
                });

            modelBuilder.Entity("Modelo.Entidades.Cliente", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteID"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodPostal")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dni")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NroCuit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Telefono")
                        .HasColumnType("bigint");

                    b.HasKey("ClienteID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Modelo.Entidades.DetalleVenta", b =>
                {
                    b.Property<int>("DetalleVentaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetalleVentaID"));

                    b.Property<int?>("AuditoriaVentaID")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioParcial")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductoID")
                        .HasColumnType("int");

                    b.Property<int?>("VentaID")
                        .HasColumnType("int");

                    b.HasKey("DetalleVentaID");

                    b.HasIndex("AuditoriaVentaID");

                    b.HasIndex("ProductoID");

                    b.HasIndex("VentaID");

                    b.ToTable("DetalleVenta");
                });

            modelBuilder.Entity("Modelo.Entidades.Industria", b =>
                {
                    b.Property<int>("IndustriaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IndustriaID"));

                    b.Property<string>("Cuil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Telefono")
                        .HasColumnType("bigint");

                    b.HasKey("IndustriaID");

                    b.ToTable("Industrias");
                });

            modelBuilder.Entity("Modelo.Entidades.Ingreso", b =>
                {
                    b.Property<int>("IngresoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngresoID"));

                    b.Property<int>("AgricultorID")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PrecioTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SemillaID")
                        .HasColumnType("int");

                    b.Property<int>("TransporteID")
                        .HasColumnType("int");

                    b.HasKey("IngresoID");

                    b.HasIndex("AgricultorID");

                    b.HasIndex("SemillaID");

                    b.HasIndex("TransporteID");

                    b.ToTable("Ingresos");
                });

            modelBuilder.Entity("Modelo.Entidades.Producto", b =>
                {
                    b.Property<int>("ProductoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductoID"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecioUnidad")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ProductoID");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Modelo.Entidades.Salida", b =>
                {
                    b.Property<int>("SalidaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalidaID"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IndustriaID")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SemillaID")
                        .HasColumnType("int");

                    b.Property<int>("TransporteID")
                        .HasColumnType("int");

                    b.HasKey("SalidaID");

                    b.HasIndex("IndustriaID");

                    b.HasIndex("SemillaID");

                    b.HasIndex("TransporteID");

                    b.ToTable("Salidas");
                });

            modelBuilder.Entity("Modelo.Entidades.Semilla", b =>
                {
                    b.Property<int>("SemillaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SemillaID"));

                    b.Property<long>("Cantidad")
                        .HasColumnType("bigint");

                    b.Property<string>("Clase")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecioToneladaCompra")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrecioToneladaVenta")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SemillaID");

                    b.ToTable("Semillas");
                });

            modelBuilder.Entity("Modelo.Entidades.Transporte", b =>
                {
                    b.Property<int>("TransporteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransporteID"));

                    b.Property<int?>("AgricultorID")
                        .HasColumnType("int");

                    b.Property<int?>("IndustriaID")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tara")
                        .HasColumnType("int");

                    b.HasKey("TransporteID");

                    b.HasIndex("AgricultorID");

                    b.HasIndex("IndustriaID");

                    b.ToTable("Transportes");
                });

            modelBuilder.Entity("Modelo.Entidades.Venta", b =>
                {
                    b.Property<int>("VentaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VentaID"));

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PrecioTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("VentaID");

                    b.HasIndex("ClienteID");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("Modelo.Seguridad.GrupoPermisos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GrupoId")
                        .HasColumnType("int");

                    b.Property<int>("PermisoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GrupoId");

                    b.HasIndex("PermisoId");

                    b.ToTable("GrupoPermisos");
                });

            modelBuilder.Entity("Modelo.Seguridad.UsuarioComponentes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ComponenteId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComponenteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("UsuarioComponentes");
                });

            modelBuilder.Entity("Modelo.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dni")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Modelo.Grupo", b =>
                {
                    b.HasBaseType("Modelo.Componente");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Grupo");
                });

            modelBuilder.Entity("Modelo.Permiso", b =>
                {
                    b.HasBaseType("Modelo.Componente");

                    b.HasDiscriminator().HasValue("Permiso");
                });

            modelBuilder.Entity("Modelo.AuditoriaLogInLogOut", b =>
                {
                    b.HasOne("Modelo.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Modelo.Auditorias.AuditoriaIngreso", b =>
                {
                    b.HasOne("Modelo.Entidades.Agricultor", "Agricultor")
                        .WithMany()
                        .HasForeignKey("AgricultorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Semilla", "Semilla")
                        .WithMany()
                        .HasForeignKey("SemillaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Transporte", "Transporte")
                        .WithMany()
                        .HasForeignKey("TransporteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agricultor");

                    b.Navigation("Semilla");

                    b.Navigation("Transporte");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Modelo.Auditorias.AuditoriaSalida", b =>
                {
                    b.HasOne("Modelo.Entidades.Industria", "Industria")
                        .WithMany()
                        .HasForeignKey("IndustriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Semilla", "Semilla")
                        .WithMany()
                        .HasForeignKey("SemillaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Transporte", "Transporte")
                        .WithMany()
                        .HasForeignKey("TransporteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Industria");

                    b.Navigation("Semilla");

                    b.Navigation("Transporte");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Modelo.Auditorias.AuditoriaVenta", b =>
                {
                    b.HasOne("Modelo.Entidades.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Modelo.Entidades.DetalleVenta", b =>
                {
                    b.HasOne("Modelo.Auditorias.AuditoriaVenta", null)
                        .WithMany("DetallesVenta")
                        .HasForeignKey("AuditoriaVentaID");

                    b.HasOne("Modelo.Entidades.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Venta", null)
                        .WithMany("DetallesVenta")
                        .HasForeignKey("VentaID");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Modelo.Entidades.Ingreso", b =>
                {
                    b.HasOne("Modelo.Entidades.Agricultor", "Agricultor")
                        .WithMany()
                        .HasForeignKey("AgricultorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Semilla", "Semilla")
                        .WithMany()
                        .HasForeignKey("SemillaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Transporte", "Transporte")
                        .WithMany()
                        .HasForeignKey("TransporteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agricultor");

                    b.Navigation("Semilla");

                    b.Navigation("Transporte");
                });

            modelBuilder.Entity("Modelo.Entidades.Salida", b =>
                {
                    b.HasOne("Modelo.Entidades.Industria", "Industria")
                        .WithMany()
                        .HasForeignKey("IndustriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Semilla", "Semilla")
                        .WithMany()
                        .HasForeignKey("SemillaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Transporte", "Transporte")
                        .WithMany()
                        .HasForeignKey("TransporteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Industria");

                    b.Navigation("Semilla");

                    b.Navigation("Transporte");
                });

            modelBuilder.Entity("Modelo.Entidades.Transporte", b =>
                {
                    b.HasOne("Modelo.Entidades.Agricultor", null)
                        .WithMany("Transportes")
                        .HasForeignKey("AgricultorID");

                    b.HasOne("Modelo.Entidades.Industria", null)
                        .WithMany("Transportes")
                        .HasForeignKey("IndustriaID");
                });

            modelBuilder.Entity("Modelo.Entidades.Venta", b =>
                {
                    b.HasOne("Modelo.Entidades.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Modelo.Seguridad.GrupoPermisos", b =>
                {
                    b.HasOne("Modelo.Grupo", "Grupo")
                        .WithMany("GrupoPermisos")
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Permiso", "Permiso")
                        .WithMany()
                        .HasForeignKey("PermisoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Grupo");

                    b.Navigation("Permiso");
                });

            modelBuilder.Entity("Modelo.Seguridad.UsuarioComponentes", b =>
                {
                    b.HasOne("Modelo.Componente", "Componente")
                        .WithMany()
                        .HasForeignKey("ComponenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Usuario", "Usuario")
                        .WithMany("UsuarioComponentes")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Componente");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Modelo.Auditorias.AuditoriaVenta", b =>
                {
                    b.Navigation("DetallesVenta");
                });

            modelBuilder.Entity("Modelo.Entidades.Agricultor", b =>
                {
                    b.Navigation("Transportes");
                });

            modelBuilder.Entity("Modelo.Entidades.Industria", b =>
                {
                    b.Navigation("Transportes");
                });

            modelBuilder.Entity("Modelo.Entidades.Venta", b =>
                {
                    b.Navigation("DetallesVenta");
                });

            modelBuilder.Entity("Modelo.Usuario", b =>
                {
                    b.Navigation("UsuarioComponentes");
                });

            modelBuilder.Entity("Modelo.Grupo", b =>
                {
                    b.Navigation("GrupoPermisos");
                });
#pragma warning restore 612, 618
        }
    }
}
