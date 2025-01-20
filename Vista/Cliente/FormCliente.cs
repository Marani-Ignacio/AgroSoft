using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormCliente : Form
    {
        private Cliente cliente;
        private bool modificar = false;

        public FormCliente()
        {
            InitializeComponent();
        }

        public FormCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            modificar = true;
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                this.Text = "Modificar";
                txtDni.Enabled = false;
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtDni.Text = cliente.Dni.ToString();
                txtCuit.Text = cliente.NroCuit;
                txtDireccion.Text = cliente.Direccion;
                txtCodPostal.Text = cliente.CodPostal.ToString();
                txtTelefono.Text = cliente.Telefono.ToString();
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

            int CodPostal;
            if (!int.TryParse(txtCodPostal.Text, out CodPostal))
            {
                MessageBox.Show("Ingrese el Código Postal correctamente");
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
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Dni = Convert.ToInt32(txtDni.Text);
                cliente.NroCuit = txtCuit.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.CodPostal = Convert.ToInt32(txtCodPostal.Text);
                cliente.Telefono = Convert.ToInt64(txtTelefono.Text);

                var mensaje = Controladora.ControladoraClientes.Instancia.Modificar(cliente);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var cliente = new Cliente()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Dni = Convert.ToInt32(txtDni.Text),
                    NroCuit = txtCuit.Text,
                    Direccion = txtDireccion.Text,
                    CodPostal = Convert.ToInt32(txtCodPostal.Text),
                    Telefono = Convert.ToInt64(txtTelefono.Text),
                };

                var mensaje = Controladora.ControladoraClientes.Instancia.Agregar(cliente);
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
