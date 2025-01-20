using Controladora.Controladoras_Seguridad;
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
    public partial class FormGestionarPermisosUsuario : Form
    {
        Contexto contexto = Modelo.GContext.ObtenerContexto();
        private Usuario usuario;

        public FormGestionarPermisosUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FormGestionarPermisosUsuario_Load(object sender, EventArgs e)
        {
            cbPermisos.Items.Clear();

            var permisos = contexto.Permisos.ToList();
            foreach (var permiso in permisos)
            {
                cbPermisos.Items.Add(permiso);
            }
        }

        private bool ValidarDatos()
        {
            if (cbPermisos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un permiso");
                return false;
            }

            return true;
        }

        private void iconAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            Permiso permiso = contexto.Permisos.FirstOrDefault(p => p.Nombre == cbPermisos.Text);

            if (permiso != null)
            {
                usuario.AgregarPermisoSimple(permiso);

                var mensaje = ControladoraUsuarios.Instancia.Modificar(usuario);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Permiso no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void iconCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
