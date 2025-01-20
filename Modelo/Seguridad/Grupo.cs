using DocumentFormat.OpenXml.InkML;
using Modelo.Entidades;
using Modelo.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Grupo : Componente
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public List<GrupoPermisos> GrupoPermisos { get; set; } = new List<GrupoPermisos>();

        public override string ToString()
        {
            return $"{Nombre}";
        }

        public override void Agregar(Componente componente)
        {
            var permiso = componente as Permiso;
            if (permiso != null)
            {
                if (!GrupoPermisos.Any(gp => gp.PermisoId == permiso.Id))
                {
                    GrupoPermisos.Add(new GrupoPermisos { PermisoId = permiso.Id, Permiso = permiso });
                }
            }
        }

        public override void Eliminar(Componente componente)
        {
            var permiso = componente as Permiso;
            if (permiso != null)
            {
                var permisoAsociado = GrupoPermisos.FirstOrDefault(gp => gp.PermisoId == permiso.Id);
                if (permisoAsociado != null)
                {
                    GrupoPermisos.Remove(permisoAsociado);
                }
            }
        }

        public virtual List<Componente> Mostrar()
        {
            return GrupoPermisos.Select(gp => (Componente)gp.Permiso).ToList();
        }
    }
}
