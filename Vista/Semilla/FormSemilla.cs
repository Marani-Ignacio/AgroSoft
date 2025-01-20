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
    public partial class FormSemilla : Form
    {
        private Semilla semilla;
        private bool modificar = false;

        public FormSemilla()
        {
            InitializeComponent();
        }

        public FormSemilla(Semilla semilla)
        {
            InitializeComponent();
            this.semilla = semilla;
            modificar = true;
        }

        private void FormSemilla_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                this.Text = "Modificar";
                txtCodigo.Enabled = false;
                txtCodigo.Text = semilla.Codigo;
                txtNombre.Text = semilla.Nombre;
                txtClase.Text = semilla.Clase;
                txtCantidad.Text = semilla.Cantidad.ToString();
                txtPrecioxToneladaCompra.Text = semilla.PrecioToneladaCompra.ToString();
                txtPrecioxToneladaVenta.Text = semilla.PrecioToneladaVenta.ToString();
            }
            else
            {
                this.Text = "Agregar";
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Ingrese el Codigo correctamente");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el Nombre correctamente");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtClase.Text))
            {
                MessageBox.Show("Ingrese la Clase correctamente");
                return false;
            }

            int Cantidad;
            if (!int.TryParse(txtCantidad.Text, out Cantidad))
            {
                MessageBox.Show("Ingrese la Cantidad correctamente");
                return false;
            }

            decimal PrecioxTonelada;
            if (!decimal.TryParse(txtPrecioxToneladaCompra.Text, out PrecioxTonelada))
            {
                MessageBox.Show("Ingrese el Precio correctamente");
                return false;
            }

            decimal PrecioUnidad;
            if (!decimal.TryParse(txtPrecioxToneladaCompra.Text, out PrecioUnidad))
            {
                MessageBox.Show("Ingrese el Precio correctamente");
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
                semilla.Codigo = txtCodigo.Text.ToUpper();
                semilla.Nombre = txtNombre.Text;
                semilla.Clase = txtClase.Text;
                semilla.Cantidad = Convert.ToInt32(txtCantidad.Text);
                semilla.PrecioToneladaCompra = Convert.ToDecimal(txtPrecioxToneladaCompra.Text);
                semilla.PrecioToneladaVenta = Convert.ToDecimal(txtPrecioxToneladaVenta.Text);

                var mensaje = Controladora.ControladoraSemillas.Instancia.Modificar(semilla);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var semilla = new Semilla()
                {
                    Codigo = txtCodigo.Text.ToUpper(),
                    Nombre = txtNombre.Text,
                    Clase = txtClase.Text,
                    Cantidad = Convert.ToInt32(txtCantidad.Text),
                    PrecioToneladaCompra = Convert.ToDecimal(txtPrecioxToneladaCompra.Text),
                    PrecioToneladaVenta = Convert.ToDecimal(txtPrecioxToneladaVenta.Text),
                };

                var mensaje = Controladora.ControladoraSemillas.Instancia.Agregar(semilla);
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
