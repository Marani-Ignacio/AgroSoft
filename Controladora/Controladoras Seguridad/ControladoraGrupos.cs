using DocumentFormat.OpenXml.InkML;
using Microsoft.EntityFrameworkCore;
using Modelo;
using Modelo.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora.Controladoras_Seguridad
{
    public class ControladoraGrupos
    {
        private Contexto contexto = GContext.ObtenerContexto();
        private static ControladoraGrupos instancia;

        public static ControladoraGrupos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraGrupos();
                }
                return instancia;
            }
        }

        public IReadOnlyCollection<Grupo> ListarGrupos()
        {
            try
            {
                return contexto.Grupos.Where(g => g is Grupo).Select
                    (g => new Grupo
                    {
                        Id = g.Id,
                        Nombre = g.Nombre,
                        Descripcion = g.Descripcion,
                        GrupoPermisos = g.GrupoPermisos
                    })
                    .ToList();
            }
            catch (Exception)
            {
                throw new Exception("Error al listar los grupos");
            }
        }


        public string Agregar(Grupo grupo)
        {
            try
            {
                var grupoExistente = contexto.Grupos.FirstOrDefault(g => g.Nombre == grupo.Nombre);
                if (grupoExistente == null)
                {
                    if (grupo.GrupoPermisos == null)
                    {
                        grupo.GrupoPermisos = new List<GrupoPermisos>();
                    }

                    contexto.Grupos.Add(grupo);
                    contexto.SaveChanges();
                    return "Grupo agregado con éxito";
                }
                else
                {
                    return "Ya existe el grupo ingresado";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error desconocido al agregar grupo: " + ex.Message);
            }
        }

        public string Modificar(Grupo grupo)
        {
            try
            {
                var grupoExistente = contexto.Grupos.Include(g => g.GrupoPermisos).FirstOrDefault(g => g.Id == grupo.Id);

                if (grupoExistente != null)
                {
                    grupoExistente.Descripcion = grupo.Descripcion;

                    if (grupoExistente.GrupoPermisos == null)
                    {
                        grupoExistente.GrupoPermisos = new List<GrupoPermisos>();
                    }

                    if (grupo.GrupoPermisos == null)
                    {
                        grupo.GrupoPermisos = new List<GrupoPermisos>();
                    }

                    var permisosExistentes = grupoExistente.GrupoPermisos.ToList();
                    foreach (var permiso in permisosExistentes)
                    {
                        if (!grupo.GrupoPermisos.Any(gp => gp.PermisoId == permiso.PermisoId))
                        {
                            grupoExistente.GrupoPermisos.Remove(permiso);
                        }
                    }

                    foreach (var permiso in grupo.GrupoPermisos)
                    {
                        if (!grupoExistente.GrupoPermisos.Any(gp => gp.PermisoId == permiso.PermisoId))
                        {
                            grupoExistente.GrupoPermisos.Add(permiso);
                        }
                    }

                    contexto.SaveChanges();
                    return "Grupo modificado con éxito";
                }
                else
                {
                    return "No existe grupo que modificar";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error desconocido al modificar grupo: " + ex.Message);
            }
        }

        public string Eliminar(Grupo grupo)
        {
            try
            {
                var grupoExistente = contexto.Grupos.Include(g => g.GrupoPermisos).FirstOrDefault(g => g.Nombre == grupo.Nombre);

                if (grupoExistente != null)
                {
                    contexto.Grupos.Remove(grupoExistente);
                    contexto.SaveChanges();
                    return "Grupo eliminado con éxito";
                }
                else
                {
                    return "No existe grupo que eliminar";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error desconocido al eliminar grupo: " + ex.Message);
            }
        }

    }
}
