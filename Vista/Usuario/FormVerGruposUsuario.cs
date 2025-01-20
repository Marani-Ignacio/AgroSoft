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
    public partial class FormVerGruposUsuario : Form
    {
        Contexto contexto = Modelo.GContext.ObtenerContexto();
        private Usuario usuario;

        public FormVerGruposUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FormVerGruposUsuario_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            contexto.Usuarios.Include(u => u.UsuarioComponentes).ThenInclude(uc => uc.Componente).FirstOrDefault(u => u.Id == usuario.Id);
            dgvGruposUsuario.DataSource = null;
            if (usuario.UsuarioComponentes != null)
            {
                var permisos = usuario.MostrarPermisoCompuesto();
                dgvGruposUsuario.DataSource = permisos;
                dgvGruposUsuario.Columns["Id"].Visible = false;

                dgvGruposUsuario.Columns["Nombre"].DisplayIndex = 0;
                dgvGruposUsuario.Columns["Nombre"].Width = 120;

                dgvGruposUsuario.Columns["Descripcion"].DisplayIndex = 1;
                dgvGruposUsuario.Columns["Descripcion"].Width = 400;
            }
        }

        private void iconEliminar_Click(object sender, EventArgs e)
        {
            if (dgvGruposUsuario.CurrentRow != null)
            {
                var grupoSeleccionado = (Grupo)dgvGruposUsuario.CurrentRow.DataBoundItem;

                DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el permiso seleccionado del usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    usuario.EliminarPermisoCompuesto(grupoSeleccionado);

                    var mensaje = Controladora.Controladoras_Seguridad.ControladoraUsuarios.Instancia.Modificar(usuario);

                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un grupo que eliminar");
            }
        }

        private void iconVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
