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
    public partial class FormProducto : Form
    {
        private Producto producto;
        private bool modificar = false;

        public FormProducto()
        {
            InitializeComponent();
        }

        public FormProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            modificar = true;
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                this.Text = "Modificar";
                txtCodigo.Enabled = false;
                txtCodigo.Text = producto.Codigo;
                txtNombre.Text = producto.Nombre;
                txtMarca.Text = producto.Marca;
                txtStock.Text = producto.Stock.ToString();
                txtPrecio.Text = producto.PrecioUnidad.ToString();
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
                MessageBox.Show("Ingrese el Código correctamente");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el Nombre correctamente");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("Ingrese el Marca correctamente");
                return false;
            }

            int Stock;
            if (!int.TryParse(txtStock.Text, out Stock))
            {
                MessageBox.Show("Ingrese el Stock correctamente");
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
                producto.Codigo = txtCodigo.Text;
                producto.Nombre = txtNombre.Text;
                producto.Marca = txtMarca.Text;
                producto.Stock =  Convert.ToInt32(txtStock.Text);
                producto.PrecioUnidad = Convert.ToDecimal(txtPrecio.Text);

                var mensaje = Controladora.ControladoraProductos.Instancia.Modificar(producto);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var producto = new Producto()
                {
                    Codigo = txtCodigo.Text,
                    Nombre = txtNombre.Text,
                    Marca = txtMarca.Text,
                    Stock = Convert.ToInt32(txtStock.Text),
                    PrecioUnidad = Convert.ToDecimal(txtPrecio.Text),
            };

                var mensaje = Controladora.ControladoraProductos.Instancia.Agregar(producto);
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
