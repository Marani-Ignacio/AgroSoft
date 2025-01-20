using Microsoft.EntityFrameworkCore;
using Modelo;
using Modelo.Auditorias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraAuditoriaVenta
    {
        private Contexto contexto = Modelo.GContext.ObtenerContexto();
        private static ControladoraAuditoriaVenta instancia;

        public static ControladoraAuditoriaVenta Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraAuditoriaVenta();
                }
                return instancia;
            }
        }

        public IReadOnlyCollection<AuditoriaVenta> ListarAuditoriasVentas()
        {
            try
            {
                return contexto.AuditoriasVentas.Include(a => a.Usuario).Include(a => a.Cliente).Include(a => a.DetallesVenta).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Agregar(AuditoriaVenta auditoriaVenta)
        {
            try
            {
                contexto.AuditoriasVentas.Add(auditoriaVenta);
                contexto.SaveChanges();
                return "Auditoria de Venta registrada con éxito";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al registrar auditoria de venta");
            }
        }

        // Filtros
        public IReadOnlyCollection<AuditoriaVenta> ListarAuditoriasxMasAntiguas()
        {
            try
            {
                return contexto.AuditoriasVentas.OrderBy(a => a.FechayHora).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaVenta> ListarAuditoriasxMasRecientes()
        {
            try
            {
                return contexto.AuditoriasVentas.OrderByDescending(a => a.FechayHora).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaVenta> ListarAuditoriasxApellidoyNombre()
        {
            try
            {
                return contexto.AuditoriasVentas.OrderBy(a => a.Usuario.Apellido).ThenBy(a => a.Usuario.Nombre).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaVenta> ListarAuditoriasxPrecio()
        {
            try
            {
                return contexto.AuditoriasVentas.OrderByDescending(a => a.PrecioTotal).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaVenta> ListarAuditoriasxFecha(DateTime Fecha)
        {
            try
            {
                return contexto.AuditoriasVentas.Where(a => a.FechayHora.Date == Fecha.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaVenta> ListarAuditoriasxPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                return contexto.AuditoriasVentas.Where(a => a.FechayHora.Date >= fechaDesde.Date && a.FechayHora.Date <= fechaHasta.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Búsquedas
        public IReadOnlyCollection<AuditoriaVenta> ListarAuditoriasxDniIngresado(int Dni)
        {
            try
            {
                return contexto.AuditoriasVentas.Where(a => a.Usuario.Dni == Dni).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaVenta> ListarAuditoriasxDniMasAntigua(int Dni)
        {
            try
            {
                return contexto.AuditoriasVentas.Where(a => a.Usuario.Dni == Dni).OrderBy(a => a.FechayHora).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaVenta> ListarAuditoriasxDniMasReciente(int Dni)
        {
            try
            {
                return contexto.AuditoriasVentas.Where(a => a.Usuario.Dni == Dni).OrderByDescending(a => a.FechayHora).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaVenta> ListarAuditoriasxDniFecha(int Dni, DateTime fecha)
        {
            try
            {
                return contexto.AuditoriasVentas.Where(a => a.Usuario.Dni == Dni && a.FechayHora.Date == fecha.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaVenta> ListarAuditoriasxDniPeriodo(int Dni, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                return contexto.AuditoriasVentas.Where(a => a.Usuario.Dni == Dni && a.FechayHora.Date >= fechaInicio.Date && a.FechayHora.Date <= fechaFin.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
