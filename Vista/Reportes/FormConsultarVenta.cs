using Modelo.Auditorias;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormConsultarVenta : Form
    {
        private Venta venta;
        private AuditoriaVenta auditoriaVenta;
        private string origen;

        public FormConsultarVenta(Venta venta)
        {
            InitializeComponent();
            this.venta = venta;
            origen = "reporte venta";
        }

        public FormConsultarVenta(AuditoriaVenta auditoriaVenta)
        {
            InitializeComponent();
            this.auditoriaVenta = auditoriaVenta;
            origen = "auditoria venta";
        }

        private void FormConsultarVenta_Load(object sender, EventArgs e)
        {
            if (origen == "reporte venta")
            {
                txtCodigo.Text = venta.Codigo.ToString();
                txtTotal.Text = venta.PrecioTotal.ToString();
                txtFecha.Text = venta.Fecha.ToString("dd/MM/yyyy");

                txtApellido.Text = venta.Cliente.Apellido;
                txtNombre.Text = venta.Cliente.Nombre;
                txtDni.Text = venta.Cliente.Dni.ToString();
                txtCuit.Text = venta.Cliente.NroCuit;
                txtDireccion.Text = venta.Cliente.Direccion;
                txtTelefono.Text = venta.Cliente.Telefono.ToString();

                dgvProductos.DataSource = null;
                List<DetalleVenta> productos = new List<DetalleVenta>();

                foreach (var producto in venta.DetallesVenta)
                {
                    productos.Add(producto);
                }

                Controladora.ControladoraProductos.Instancia.ListarProductos();
                dgvProductos.DataSource = productos.ToList();
            }
            else if (origen == "auditoria venta")
            {
                txtCodigo.Text = auditoriaVenta.Codigo.ToString();
                txtTotal.Text = auditoriaVenta.PrecioTotal.ToString();
                txtFecha.Text = auditoriaVenta.Fecha.ToString("dd/MM/yyyy");

                txtApellido.Text = auditoriaVenta.Cliente.Apellido;
                txtNombre.Text = auditoriaVenta.Cliente.Nombre;
                txtDni.Text = auditoriaVenta.Cliente.Dni.ToString();
                txtCuit.Text = auditoriaVenta.Cliente.NroCuit;
                txtDireccion.Text = auditoriaVenta.Cliente.Direccion;
                txtTelefono.Text = auditoriaVenta.Cliente.Telefono.ToString();

                dgvProductos.DataSource = null;
                List<DetalleVenta> productos = new List<DetalleVenta>();

                foreach (var producto in auditoriaVenta.DetallesVenta)
                {
                    productos.Add(producto);
                }

                Controladora.ControladoraProductos.Instancia.ListarProductos();
                dgvProductos.DataSource = productos.ToList();
            }
            DgvConfig();
        }

        public void DgvConfig()
        {
            dgvProductos.Columns["DetalleVentaID"].Visible = false;
            dgvProductos.Columns["ProductoID"].Visible = false;

            dgvProductos.Columns["Producto"].Width = 240;
            dgvProductos.Columns["Producto"].DisplayIndex = 0;

            dgvProductos.Columns["Cantidad"].Width = 60;
            dgvProductos.Columns["Cantidad"].DisplayIndex = 1;

            dgvProductos.Columns["PrecioParcial"].Width = 100;
            dgvProductos.Columns["PrecioParcial"].DisplayIndex = 2;
        }
    }
}
