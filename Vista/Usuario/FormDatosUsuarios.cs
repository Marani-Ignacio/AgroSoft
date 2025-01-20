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
    public partial class FormDatosUsuarios : Form
    {
        private Usuario usuario;
        public FormDatosUsuarios(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FormDatosUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void iconModificar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtClave.Enabled = true;
            txtNuevaClave.Enabled = true;
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;

            txtDni.Text = usuario.Dni.ToString();
            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            txtClave.Text = string.Empty;
            txtNuevaClave.Text = string.Empty;
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el Nombre correctamente");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Ingrese el Apellido correctamente");
                return false;
            }

            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            string mensaje = ControladoraUsuarios.Instancia.ValidarClave(usuario.Dni, txtClave.Text);

            if (mensaje != "Validación exitosa")
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;

            if (string.IsNullOrWhiteSpace(txtNuevaClave.Text) || txtNuevaClave.Text.Length < 4)
            {
                MessageBox.Show("Ingrese la Nueva Contraseña correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            usuario.Clave = txtNuevaClave.Text;
            mensaje = ControladoraUsuarios.Instancia.ModificarClaveUsuario(usuario);
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Cancelar();
            ActualizarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        public void Cancelar()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDni.Enabled = false;
            txtClave.Enabled = false;
            txtNuevaClave.Enabled = false;
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;

            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDni.Text = string.Empty;
            txtClave.Text = string.Empty;
            txtNuevaClave.Text = string.Empty;
        }

        public void ActualizarDatos()
        {
            lblNombre.Text = "Nombre: " + usuario.Nombre;
            lblApellido.Text = "Apellido: " + usuario.Apellido;
            lblDni.Text = "Dni: " + usuario.Dni.ToString();
            lblClave.Text = "Clave: *****";

            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDni.Enabled = false;
            txtClave.Enabled = false;
            txtNuevaClave.Enabled = false;
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
        }
    }
}
