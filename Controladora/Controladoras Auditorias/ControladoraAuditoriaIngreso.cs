using Microsoft.EntityFrameworkCore;
using Modelo;
using Modelo.Auditorias;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraAuditoriaIngreso
    {
        private Contexto contexto = Modelo.GContext.ObtenerContexto();
        private static ControladoraAuditoriaIngreso instancia;

        public static ControladoraAuditoriaIngreso Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraAuditoriaIngreso();
                }
                return instancia;
            }
        }

        public IReadOnlyCollection<AuditoriaIngreso> ListarAuditoriasIngresos()
        {
            try
            {
                return contexto.AuditoriasIngresos.Include(a => a.Usuario).Include(a => a.Agricultor).Include(a => a.Semilla).Include(a => a.Transporte).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Agregar(AuditoriaIngreso auditoriaIngreso)
        {
            try
            {
                contexto.AuditoriasIngresos.Add(auditoriaIngreso);
                contexto.SaveChanges();
                return "Auditoria de Ingreso registrada con éxito";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al registrar auditoria de ingreso");
            }
        }

        // Filtros
        public IReadOnlyCollection<AuditoriaIngreso> ListarAuditoriasxMasAntiguas()
        {
            try
            {
                return contexto.AuditoriasIngresos.OrderBy(a => a.FechayHora).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaIngreso> ListarAuditoriasxMasRecientes()
        {
            try
            {
                return contexto.AuditoriasIngresos.OrderByDescending(a => a.FechayHora).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaIngreso> ListarAuditoriasxApellidoyNombre()
        {
            try
            {
                return contexto.AuditoriasIngresos.OrderBy(a => a.Usuario.Apellido).ThenBy(a => a.Usuario.Nombre).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaIngreso> ListarAuditoriasxSemilla()
        {
            try
            {
                return contexto.AuditoriasIngresos.OrderBy(a => a.Semilla.Codigo).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaIngreso> ListarAuditoriasxCantidad()
        {
            try
            {
                return contexto.AuditoriasIngresos.OrderByDescending(a => a.Cantidad).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaIngreso> ListarAuditoriasxPrecio()
        {
            try
            {
                return contexto.AuditoriasIngresos.OrderByDescending(a => a.PrecioTotal).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaIngreso> ListarAuditoriasxFecha(DateTime Fecha)
        {
            try
            {
                return contexto.AuditoriasIngresos.Where(a => a.FechayHora.Date == Fecha.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaIngreso> ListarAuditoriasxPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                return contexto.AuditoriasIngresos.Where(a => a.FechayHora.Date >= fechaDesde.Date && a.FechayHora.Date <= fechaHasta.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Búsquedas
        public IReadOnlyCollection<AuditoriaIngreso> ListarAuditoriasxDniIngresado(int Dni)
        {
            try
            {
                return contexto.AuditoriasIngresos.Where(a => a.Usuario.Dni == Dni).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaIngreso> ListarAuditoriasxDniMasAntigua(int Dni)
        {
            try
            {
                return contexto.AuditoriasIngresos.Where(a => a.Usuario.Dni == Dni).OrderBy(a => a.Fecha).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaIngreso> ListarAuditoriasxDniMasReciente(int Dni)
        {
            try
            {
                return contexto.AuditoriasIngresos.Where(a => a.Usuario.Dni == Dni).OrderByDescending(a => a.Fecha).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaIngreso> ListarAuditoriasxDniFecha(int Dni, DateTime fecha)
        {
            try
            {
                return contexto.AuditoriasIngresos.Where(a => a.Usuario.Dni == Dni && a.FechayHora.Date == fecha.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaIngreso> ListarAuditoriasxDniPeriodo(int Dni, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            { 
                return contexto.AuditoriasIngresos.Where(a => a.Usuario.Dni == Dni && a.FechayHora.Date >= fechaInicio.Date && a.FechayHora.Date <= fechaFin.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
