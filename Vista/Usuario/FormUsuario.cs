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
    public partial class FormUsuario : Form
    {
        private Usuario usuario;
        private bool modificar = false;

        public FormUsuario()
        {
            InitializeComponent();
        }

        public FormUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            modificar = true;
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                this.Text = "Modificar Usuario";
                txtDni.Text = usuario.Dni.ToString();
                txtDni.Enabled = false;
                txtClave.Text = usuario.Clave;
                txtClave.Enabled = false;
                txtNombre.Text = usuario.Nombre;
                txtApellido.Text = usuario.Apellido;
            }
            else
            {
                this.Text = "Agregar Usuario";
            }
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

            int Dni;
            if (!int.TryParse(txtDni.Text, out Dni))
            {
                MessageBox.Show("Ingrese el Dni correctamente");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Ingrese la contraseña correctamente");
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

            if (modificar)
            {
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;
                //usuario.Clave = txtClave.Text;

                var mensaje = ControladoraUsuarios.Instancia.Modificar(usuario);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var usuario = new Usuario()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Dni = int.Parse(txtDni.Text),
                    Clave = txtClave.Text,
                };

                var mensaje = ControladoraUsuarios.Instancia.Agregar(usuario);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }

        private void iconCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}
