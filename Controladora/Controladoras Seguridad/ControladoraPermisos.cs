using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora.Controladoras_Seguridad
{
    public class ControladoraPermisos
    {
        private Contexto contexto = GContext.ObtenerContexto();
        private static ControladoraPermisos instancia;

        public static ControladoraPermisos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraPermisos();
                }
                return instancia;
            }
        }

        public IReadOnlyCollection<Permiso> ListarPermisos()
        {
            try
            {
                return contexto.Permisos.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        
    }
}
