using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Modelo.Auditorias;
using Modelo.Entidades;
using Modelo.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Contexto : DbContext
    {
        //Entidades
        public DbSet<Agricultor> Agricultores { get; set; }
        public DbSet<Industria> Industrias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Transporte> Transportes { get; set; }
        public DbSet<Semilla> Semillas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Ingreso> Ingresos { get; set; }
        public DbSet<Salida> Salidas { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        //Seguridad
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Permiso> Permisos { get; set; }

        //Auditorias
        public DbSet<AuditoriaIngreso> AuditoriasIngresos { get; set; }
        public DbSet<AuditoriaSalida> AuditoriasSalidas { get; set; }
        public DbSet<AuditoriaVenta> AuditoriasVentas { get; set; }
        public DbSet<AuditoriaLogInLogOut> AuditoriasLogInLogOut { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("Appsettings.json").Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection")).EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Componente>().HasDiscriminator<string>("TipoComponente").HasValue<Permiso>("Permiso").HasValue<Grupo>("Grupo");

            modelBuilder.Entity<UsuarioComponentes>().HasOne(uc => uc.Usuario).WithMany(u => u.UsuarioComponentes).HasForeignKey(uc => uc.UsuarioId);
            modelBuilder.Entity<UsuarioComponentes>().HasOne(uc => uc.Componente).WithMany().HasForeignKey(uc => uc.ComponenteId);

            modelBuilder.Entity<Grupo>().HasMany(g => g.GrupoPermisos).WithOne(gp => gp.Grupo).HasForeignKey(gp => gp.GrupoId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<GrupoPermisos>().HasOne(ga => ga.Permiso).WithMany().HasForeignKey(ga => ga.PermisoId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
