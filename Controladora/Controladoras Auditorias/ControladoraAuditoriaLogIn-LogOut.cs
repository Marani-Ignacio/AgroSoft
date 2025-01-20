using Modelo.Auditorias;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Controladora
{
    public class ControladoraAuditoriaLogIn_LogOut
    {
        private Contexto contexto = Modelo.GContext.ObtenerContexto();
        private static ControladoraAuditoriaLogIn_LogOut instancia;

        public static ControladoraAuditoriaLogIn_LogOut Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraAuditoriaLogIn_LogOut();
                }
                return instancia;
            }
        }

        public IReadOnlyCollection<AuditoriaLogInLogOut> ListarAuditoriasLogInLogOut()
        {
            try
            {
                return contexto.AuditoriasLogInLogOut.Include(u => u.Usuario).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Agregar(AuditoriaLogInLogOut auditoriaLogInLogOut)
        {
            try
            {
                contexto.AuditoriasLogInLogOut.Add(auditoriaLogInLogOut);
                contexto.SaveChanges();
                return "Auditoria de LogIn-LogOut registrada con éxito";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al registrar auditoria de LogIn-LogOut");
            }
        }

        // Filtros
        public IReadOnlyCollection<AuditoriaLogInLogOut> ListarAuditoriasxMasAntiguas()
        {
            try
            {
                return contexto.AuditoriasLogInLogOut.OrderBy(a => a.FechayHora).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaLogInLogOut> ListarAuditoriasxMasRecientes()
        {
            try
            {
                return contexto.AuditoriasLogInLogOut.OrderByDescending(a => a.FechayHora).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaLogInLogOut> ListarAuditoriasxApellidoyNombre()
        {
            try
            {
                return contexto.AuditoriasLogInLogOut.OrderBy(a => a.Usuario.Apellido).ThenBy(a => a.Usuario.Nombre).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaLogInLogOut> ListarAuditoriasxFecha(DateTime Fecha)
        {
            try
            {
                return contexto.AuditoriasLogInLogOut.Where(a => a.FechayHora.Date == Fecha.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaLogInLogOut> ListarAuditoriasxPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                return contexto.AuditoriasLogInLogOut.Where(a => a.FechayHora.Date >= fechaDesde.Date && a.FechayHora.Date <= fechaHasta.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Búsquedas
        public IReadOnlyCollection<AuditoriaLogInLogOut> ListarAuditoriasxDniIngresado(int Dni)
        {
            try
            {
                return contexto.AuditoriasLogInLogOut.Where(a => a.Usuario.Dni == Dni).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaLogInLogOut> ListarAuditoriasxDniMasAntigua(int Dni)
        {
            try
            {
                return contexto.AuditoriasLogInLogOut.Where(a => a.Usuario.Dni == Dni).OrderBy(a => a.FechayHora).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaLogInLogOut> ListarAuditoriasxDniMasReciente(int Dni)
        {
            try
            {
                return contexto.AuditoriasLogInLogOut.Where(a => a.Usuario.Dni == Dni).OrderByDescending(a => a.FechayHora).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaLogInLogOut> ListarAuditoriasxDniFecha(int Dni, DateTime fecha)
        {
            try
            {
                return contexto.AuditoriasLogInLogOut.Where(a => a.Usuario.Dni == Dni && a.FechayHora.Date == fecha.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<AuditoriaLogInLogOut> ListarAuditoriasxDniPeriodo(int Dni, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                return contexto.AuditoriasLogInLogOut.Where(a => a.Usuario.Dni == Dni && a.FechayHora.Date >= fechaInicio.Date && a.FechayHora.Date <= fechaFin.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
