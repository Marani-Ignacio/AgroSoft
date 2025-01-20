using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Seguridad
{
    public class GrupoPermisos
    {
        public int Id { get; set; }
        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }
        public int PermisoId { get; set; }
        public Permiso Permiso { get; set; }
    }
}
