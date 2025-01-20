using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormVerPermisosUsuario : Form
    {
        Contexto contexto = Modelo.GContext.ObtenerContexto();
        private Usuario usuario;

        public FormVerPermisosUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FormVerPermisosUsuario_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            contexto.Usuarios.Include(u => u.UsuarioComponentes).ThenInclude(uc => uc.Componente).FirstOrDefault(u => u.Id == usuario.Id);
            dgvPermisosUsuario.DataSource = null;
            if (usuario.UsuarioComponentes != null)
            {
                var permisos = usuario.MostrarPermisoSimple();
                dgvPermisosUsuario.DataSource = permisos;
                dgvPermisosUsuario.Columns["Id"].Visible = false;
                dgvPermisosUsuario.Columns["Nombre"].Width = 520;
            }
        }

        private void iconEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPermisosUsuario.CurrentRow != null)
            {
                var permisoSeleccionado = (Permiso)dgvPermisosUsuario.CurrentRow.DataBoundItem;

                DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el permiso seleccionado del usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    usuario.EliminarPermisoSimple(permisoSeleccionado);

                    var mensaje = Controladora.Controladoras_Seguridad.ControladoraUsuarios.Instancia.Modificar(usuario);

                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un permiso que eliminar");
            }
        }

        private void iconVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
