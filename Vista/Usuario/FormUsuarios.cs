using Controladora.Controladoras_Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;


namespace Vista
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        public void ActualizarGrilla()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = ControladoraUsuarios.Instancia.ListarUsuarios();
            DgvConfig();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void iconAgregar_Click(object sender, EventArgs e)
        {
            var formUsuario = new FormUsuario();
            formUsuario.ShowDialog();
            ActualizarGrilla();
        }

        private void iconModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                var usuarioSeleccionado = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                var formCategoria = new FormUsuario(usuarioSeleccionado);
                formCategoria.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario que modificar");
            }
        }

        private void iconEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                var usuarioSeleccionado = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Confima que desea eliminar el usuario seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    var mensaje = ControladoraUsuarios.Instancia.Eliminar(usuarioSeleccionado);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario que eliminar");
            }
        }

        public void DgvConfig()
        {
            dgvUsuarios.Columns["Id"].Visible = false;
            dgvUsuarios.Columns["Clave"].Visible = false;
            dgvUsuarios.Columns["Nombre"].Width = 342;
            dgvUsuarios.Columns["Apellido"].Width = 342;
            dgvUsuarios.Columns["Dni"].Width = 342;
        }

        private void iconAgregarGrupos_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                var usuarioSeleccionado = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                var formGestionarGruposUsuario = new FormGestionarGruposUsuario(usuarioSeleccionado);
                formGestionarGruposUsuario.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario para agregarle un grupo");
            }
        }

        private void iconVerGrupos_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                var usuarioSeleccionado = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                var formVerGruposUsuario = new FormVerGruposUsuario(usuarioSeleccionado);
                formVerGruposUsuario.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario para ver sus grupos");
            }
        }

        private void iconAgregarPermisos_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                var usuarioSeleccionado = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                var formGestionarPermisosUsuario = new FormGestionarPermisosUsuario(usuarioSeleccionado);
                formGestionarPermisosUsuario.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario para agregar permiso");
            }
        }

        private void iconVerPermisos_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                var usuarioSeleccionado = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                var formVerPermisosUsuario = new FormVerPermisosUsuario(usuarioSeleccionado);
                formVerPermisosUsuario.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario para ver permisos");
            }
        }
    }
}
