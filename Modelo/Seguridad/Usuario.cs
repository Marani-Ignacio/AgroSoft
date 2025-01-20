using Modelo.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string Clave { get; set; }
        public List<UsuarioComponentes> UsuarioComponentes { get; set; } = new List<UsuarioComponentes>();

        public override string ToString()
        {
            return $"{Apellido} {Nombre}";
        }

        public bool TienePermiso(string permisoNombre)
        {
            foreach (var permisoUsuario in UsuarioComponentes)
            {
                if (permisoUsuario.Componente is Permiso permiso && permiso.Nombre == permisoNombre)
                {
                    return true;
                }

                if (permisoUsuario.Componente is Grupo grupo)
                {
                    if (grupo.GrupoPermisos != null)
                    {
                        foreach (var grupoPermiso in grupo.GrupoPermisos)
                        {
                            if (grupoPermiso.Permiso != null && grupoPermiso.Permiso.Nombre == permisoNombre)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public void AgregarPermisoSimple(Componente componente)
        {
            if (!UsuarioComponentes.Any(uc => uc.ComponenteId == componente.Id && uc.Componente is Permiso))
            {
                UsuarioComponentes.Add(new UsuarioComponentes
                {
                    UsuarioId = this.Id,
                    ComponenteId = componente.Id,
                    Componente = componente
                });
            }
        }

        public void AgregarPermisoCompuesto(Componente componente)
        {
            if (!UsuarioComponentes.Any(uc => uc.ComponenteId == componente.Id && uc.Componente is Grupo))
            {
                UsuarioComponentes.Add(new UsuarioComponentes
                {
                    UsuarioId = this.Id,
                    ComponenteId = componente.Id,
                    Componente = componente
                });
            }
        }

        public void EliminarPermisoSimple(Componente componente)
        {
            var usuarioComponente = UsuarioComponentes.FirstOrDefault(uc => uc.ComponenteId == componente.Id && uc.Componente is Permiso);

            if (usuarioComponente != null)
            {
                UsuarioComponentes.Remove(usuarioComponente);
            }
        }

        public void EliminarPermisoCompuesto(Componente componente)
        {
            var usuarioComponente = UsuarioComponentes.FirstOrDefault(uc => uc.ComponenteId == componente.Id && uc.Componente is Grupo);

            if (usuarioComponente != null)
            {
                UsuarioComponentes.Remove(usuarioComponente);
            }
        }

        public List<Permiso> MostrarPermisoSimple()
        {
            return UsuarioComponentes.Where(uc => uc.Componente is Permiso).Select(uc => (Permiso)uc.Componente).ToList();
        }

        public List<Grupo> MostrarPermisoCompuesto()
        {
            return UsuarioComponentes.Where(uc => uc.Componente is Grupo).Select(uc => (Grupo)uc.Componente).ToList();
        }
    }
}
