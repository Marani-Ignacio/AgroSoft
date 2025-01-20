using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Xml.Linq;
using Modelo.Entidades;

namespace Controladora.Controladoras_Seguridad
{
    public class ControladoraUsuarios
    {
        private Contexto contexto = GContext.ObtenerContexto();
        private static ControladoraUsuarios instancia;

        public static ControladoraUsuarios Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraUsuarios();
                }
                return instancia;
            }
        }

        public IReadOnlyCollection<Usuario> ListarUsuarios()
        {
            try
            {
                return contexto.Usuarios.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Agregar(Usuario usuario)
        {
            try
            {
                var usuarioExistente = contexto.Usuarios.FirstOrDefault(u => u.Dni == usuario.Dni);
                if (usuarioExistente == null)
                {
                    usuario.Clave = CalcularHash(usuario.Clave);
                    contexto.Usuarios.Add(usuario);
                    contexto.SaveChanges();
                    return "Usuario agregado con éxito";
                }
                else
                {
                    return "Ya existe el usuario ingresado";
                }
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al agregar usuario");
            }
        }

        public string Eliminar(Usuario usuario)
        {
            try
            {
                var usuarioExistente = contexto.Usuarios.FirstOrDefault(u => u.Dni == usuario.Dni);
                if (usuarioExistente != null)
                {
                    contexto.Usuarios.Remove(usuario);
                    contexto.SaveChanges();
                    return "Usuario eliminado con éxito";
                }
                else
                {
                    return "No existe usuario que eliminar";
                }
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al eliminar usuario");
            }
        }

        public string Modificar(Usuario usuario)
        {
            try
            {
                var usuarioExistente = contexto.Usuarios.FirstOrDefault(u => u.Dni == usuario.Dni);
                if (usuarioExistente != null)
                {
                    contexto.Usuarios.Update(usuario);
                    contexto.SaveChanges();
                    return "Usuario modificado con éxito";
                }
                return "No existe usuario que modificar";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al modificar usuario");
            }
        }

        public string ModificarClaveUsuario(Usuario usuario)
        {
            try
            {
                var usuarioExistente = contexto.Usuarios.FirstOrDefault(u => u.Dni == usuario.Dni);
                if (usuarioExistente != null)
                {
                    if (!string.IsNullOrWhiteSpace(usuario.Clave) && usuarioExistente.Clave != CalcularHash(usuario.Clave))
                    {
                        usuarioExistente.Clave = CalcularHash(usuario.Clave);
                    }

                    usuarioExistente.Nombre = usuario.Nombre;
                    usuarioExistente.Apellido = usuario.Apellido;

                    contexto.Usuarios.Update(usuarioExistente);
                    contexto.SaveChanges();
                    return "Propiedades y contraseña del usuario modificadas con éxito";
                }
                else
                {
                    return "No existe usuario que modificar";
                }
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al modificar usuario");
            }
        }

        public Usuario Autenticar(int dni, string contraseña)
        {
            var contexto = Modelo.GContext.ObtenerContexto();

            string hashContraseña = CalcularHash(contraseña);

            var usuario = contexto.Usuarios.Include(u => u.UsuarioComponentes).ThenInclude(uc => uc.Componente).Include(u => u.UsuarioComponentes).ThenInclude(uc => uc.Componente).ThenInclude(c => (c as Grupo).GrupoPermisos).ThenInclude(gp => gp.Permiso).FirstOrDefault(u => u.Dni == dni && u.Clave == hashContraseña);

            return usuario;
        }
        

        public string ValidarClave(int dni, string claveActual)
        {
            string hashClaveActual = CalcularHash(claveActual);
            var usuarioExistente = contexto.Usuarios.FirstOrDefault(u => u.Dni == dni && u.Clave == hashClaveActual);
            if (usuarioExistente != null)
            {
                return "Validación exitosa";
            }
            else
            {
                return "La contraseña actual no es correcta";
            }
        }


        private string CalcularHash(string contraseña)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(contraseña));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
