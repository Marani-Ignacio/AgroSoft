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
    public class ControladoraAuditoriaSalida
    {
        private Contexto contexto = Modelo.GContext.ObtenerContexto();
        private static ControladoraAuditoriaSalida instancia;

        public static ControladoraAuditoriaSalida Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraAuditoriaSalida();
                }
                return instancia;
            }
        }

        public IReadOnlyCollection<AuditoriaSalida> ListarAuditoriasSalidas()
        {
            try
            {
                return contexto.AuditoriasSalidas.Include(a => a.Usuario).Include(a => a.Industria).Include(a => a.Semilla).Include(a => a.Transporte).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Agregar(AuditoriaSalida auditoriaSalida)
        {
            try
            {
                contexto.AuditoriasSalidas.Add(auditoriaSalida);
                contexto.SaveChanges();
                return "Auditoria de Salida registrada con éxito";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al registrar auditoria de salida");
            }
        }

        // Filtros
        public IReadOnlyCollection<AuditoriaSalida> ListarAuditoriasxMasAntiguas()
        {
            try
            {
                return contexto.AuditoriasSalidas.OrderBy(a => a.FechayHora).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaSalida> ListarAuditoriasxMasRecientes()
        {
            try
            {
                return contexto.AuditoriasSalidas.OrderByDescending(a => a.FechayHora).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaSalida> ListarAuditoriasxNombre()
        {
            try
            {
                return contexto.AuditoriasSalidas.OrderBy(a => a.Usuario.Apellido).ThenBy(a => a.Usuario.Nombre).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaSalida> ListarAuditoriasxSemilla()
        {
            try
            {
                return contexto.AuditoriasSalidas.OrderBy(a => a.Semilla.Codigo).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaSalida> ListarAuditoriasxCantidad()
        {
            try
            {
                return contexto.AuditoriasSalidas.OrderByDescending(a => a.Cantidad).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaSalida> ListarAuditoriasxPrecio()
        {
            try
            {
                return contexto.AuditoriasSalidas.OrderByDescending(a => a.PrecioTotal).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaSalida> ListarAuditoriasxFecha(DateTime Fecha)
        {
            try
            {
                return contexto.AuditoriasSalidas.Where(a => a.FechayHora.Date == Fecha.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaSalida> ListarAuditoriasxPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                return contexto.AuditoriasSalidas.Where(a => a.FechayHora.Date >= fechaDesde.Date && a.FechayHora.Date <= fechaHasta.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Búsquedas
        public IReadOnlyCollection<AuditoriaSalida> ListarAuditoriasxDniIngresado(int Dni)
        {
            try
            {
                return contexto.AuditoriasSalidas.Where(a => a.Usuario.Dni == Dni).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaSalida> ListarAuditoriasxDniMasAntigua(int Dni)
        {
            try
            {
                return contexto.AuditoriasSalidas.Where(a => a.Usuario.Dni == Dni).OrderBy(a => a.Fecha).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaSalida> ListarAuditoriasxDniMasReciente(int Dni)
        {
            try
            {
                return contexto.AuditoriasSalidas.Where(a => a.Usuario.Dni == Dni).OrderByDescending(a => a.Fecha).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaSalida> ListarAuditoriasxDniFecha(int Dni, DateTime fecha)
        {
            try
            {
                return contexto.AuditoriasSalidas.Where(a => a.Usuario.Dni == Dni && a.FechayHora.Date == fecha.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaSalida> ListarAuditoriasxDniPeriodo(int Dni, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                return contexto.AuditoriasSalidas.Where(a => a.Usuario.Dni == Dni && a.FechayHora.Date >= fechaInicio.Date && a.FechayHora.Date <= fechaFin.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
