using Modelo.Entidades;
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
    public partial class FormAgricultor : Form
    {
        private Agricultor agricultor;
        private bool modificar = false;

        public FormAgricultor()
        {
            InitializeComponent();
        }

        public FormAgricultor(Agricultor agricultor)
        {
            InitializeComponent();
            this.agricultor = agricultor;
            modificar = true;
        }

        private void FormAgricultor_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                this.Text = "Modificar";
                txtDni.Enabled = false;
                txtNombre.Text = agricultor.Nombre;
                txtApellido.Text = agricultor.Apellido;
                txtDni.Text = agricultor.Dni.ToString();
                txtCuit.Text = agricultor.NroCuit;
                txtDireccion.Text = agricultor.Direccion;
                txtTelefono.Text = agricultor.Telefono.ToString();
            }
            else
            {
                this.Text = "Agregar";
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

            int DNI;
            if (!int.TryParse(txtDni.Text, out DNI))
            {
                MessageBox.Show("Ingrese el DNI correctamente");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCuit.Text))
            {
                MessageBox.Show("Ingrese el CUIT correctamente");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Ingrese la Dirección correctamente");
                return false;
            }

            long Telefono;
            if (!long.TryParse(txtTelefono.Text, out Telefono))
            {
                MessageBox.Show("Ingrese el Teléfono correctamente");
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
                agricultor.Nombre = txtNombre.Text;
                agricultor.Apellido = txtApellido.Text;
                agricultor.Dni = Convert.ToInt32(txtDni.Text);
                agricultor.NroCuit = txtCuit.Text;
                agricultor.Direccion = txtDireccion.Text;
                agricultor.Telefono = Convert.ToInt64(txtTelefono.Text);

                var mensaje = Controladora.ControladoraAgricultores.Instancia.Modificar(agricultor);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var agricultor = new Agricultor()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Dni = Convert.ToInt32(txtDni.Text),
                    NroCuit = txtCuit.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = Convert.ToInt64(txtTelefono.Text),
                };

                var mensaje = Controladora.ControladoraAgricultores.Instancia.Agregar(agricultor);
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
