using DocumentFormat.OpenXml.InkML;
using Modelo;
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
    public partial class FormReporteVenta : Form
    {
        public FormReporteVenta()
        {
            InitializeComponent();
            CargarFiltros();
            cbFiltroConfig();
            ActualizarGrilla();
        }

        private void FormReporteVenta_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            cbFiltro.Text = "Todos";
            cbBusqueda.Text = "...";
        }

        public void ActualizarGrilla()
        {
            dgvRegistrosVenta.DataSource = null;
            dgvRegistrosVenta.DataSource = Controladora.ControladoraVentas.Instancia.ListarVentas();
            DgvConfig();
        }

        private void iconFiltro_Click(object sender, EventArgs e)
        {
            if (cbFiltro.Text == "Todos")
            {
                dgvRegistrosVenta.DataSource = null;
                dgvRegistrosVenta.DataSource = Controladora.ControladoraVentas.Instancia.ListarVentas();

            }
            else if (cbFiltro.Text == "Más antiguo")
            {
                dgvRegistrosVenta.DataSource = null;
                dgvRegistrosVenta.DataSource = Controladora.ControladoraVentas.Instancia.ListarVentasxMasAntiguas();

            }
            else if (cbFiltro.Text == "Más reciente")
            {
                dgvRegistrosVenta.DataSource = null;
                dgvRegistrosVenta.DataSource = Controladora.ControladoraVentas.Instancia.ListarVentasxMasRecientes();

            }
            else if (cbFiltro.Text == "Fecha")
            {
                DateTime fecha = dtpHasta.Value;
                dgvRegistrosVenta.DataSource = null;
                dgvRegistrosVenta.DataSource = Controladora.ControladoraVentas.Instancia.ListarVentasxFecha(fecha);

            }
            else if (cbFiltro.Text == "Periodo")
            {
                DateTime fechaDesde = dtpDesde.Value;
                DateTime fechaHasta = dtpHasta.Value;
                if (fechaDesde > fechaHasta)
                {
                    MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.", "Error de Fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvRegistrosVenta.DataSource = null;
                dgvRegistrosVenta.DataSource = Controladora.ControladoraVentas.Instancia.ListarVentasxPeriodo(fechaDesde, fechaHasta);

            }
            else if (cbFiltro.Text == "Apellido y Nombre")
            {
                dgvRegistrosVenta.DataSource = null;
                dgvRegistrosVenta.DataSource = Controladora.ControladoraVentas.Instancia.ListarVentasxApellidoyNombre();

            }
            else if (cbFiltro.Text == "Precio total")
            {
                dgvRegistrosVenta.DataSource = null;
                dgvRegistrosVenta.DataSource = Controladora.ControladoraVentas.Instancia.ListarVentasxPrecio();

            }
            else
            {
                MessageBox.Show("Debes seleccionar un tipo de filtro");
                return;
            }
            DgvConfig();
        }

        private void iconBusqueda_Click(object sender, EventArgs e)
        {
            Contexto contexto = Modelo.GContext.ObtenerContexto();

            if (cbBusqueda.Text == "Número de venta")
            {
                int NroVenta;
                if (!int.TryParse(txtDatos.Text, out NroVenta))
                {
                    MessageBox.Show("Ingrese el Nro de venta correctamente");
                    return;
                }

                Venta venta = contexto.Ventas.FirstOrDefault(v => v.Codigo == NroVenta);

                if (venta == null)
                {
                    MessageBox.Show("No existe una venta con el Nro de venta ingresado");
                    return;
                }

                dgvRegistrosVenta.DataSource = null;
                dgvRegistrosVenta.DataSource = Controladora.ControladoraVentas.Instancia.ListarVentasxNroDeVenta(NroVenta);

            }

            else if (cbBusqueda.Text == "Dni" && cbFiltro.Text == "Todos")
            {
                ClienteExistente();
                int DNI = Convert.ToInt32(txtDatos.Text);

                dgvRegistrosVenta.DataSource = null;
                dgvRegistrosVenta.DataSource = Controladora.ControladoraVentas.Instancia.ListarVentasxDniIngresado(DNI);

            }

            else if (cbBusqueda.Text == "Dni" && cbFiltro.Text == "Más antiguo")
            {
                ClienteExistente();
                int DNI = Convert.ToInt32(txtDatos.Text);

                dgvRegistrosVenta.DataSource = null;
                dgvRegistrosVenta.DataSource = Controladora.ControladoraVentas.Instancia.ListarVentasxDniMasAntiguo(DNI);
            }

            else if (cbBusqueda.Text == "Dni" && cbFiltro.Text == "Más reciente")
            {
                ClienteExistente();
                int DNI = Convert.ToInt32(txtDatos.Text);
                dgvRegistrosVenta.DataSource = null;
                dgvRegistrosVenta.DataSource = Controladora.ControladoraVentas.Instancia.ListarVentasxDniMasReciente(DNI);
            }

            else if (cbBusqueda.Text == "Dni" && cbFiltro.Text == "Fecha")
            {
                ClienteExistente();
                int DNI = Convert.ToInt32(txtDatos.Text);

                DateTime fecha = dtpHasta.Value;

                dgvRegistrosVenta.DataSource = null;
                dgvRegistrosVenta.DataSource = Controladora.ControladoraVentas.Instancia.ListarVentasxDniFecha(DNI, fecha);
            }

            else if (cbBusqueda.Text == "Dni" && cbFiltro.Text == "Periodo")
            {
                ClienteExistente();
                int DNI = Convert.ToInt32(txtDatos.Text);

                DateTime fechaDesde = dtpDesde.Value;
                DateTime fechaHasta = dtpHasta.Value;
                if (fechaDesde > fechaHasta)
                {
                    MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.", "Error de Fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvRegistrosVenta.DataSource = null;
                dgvRegistrosVenta.DataSource = Controladora.ControladoraVentas.Instancia.ListarVentasxDniPeriodo(DNI, fechaDesde, fechaHasta);
            }
            else
            {
                MessageBox.Show("Debes seleccionar un tipo de busqueda");
                return;
            }
            DgvConfig();
        }

        public void ClienteExistente()
        {
            Contexto contexto = Modelo.GContext.ObtenerContexto();

            int DNI;
            if (!int.TryParse(txtDatos.Text, out DNI))
            {
                MessageBox.Show("Ingrese el DNI correctamente");
                return;
            }

            Cliente cliente = contexto.Clientes.FirstOrDefault(c => c.Dni == DNI);

            if (cliente == null)
            {
                MessageBox.Show("No existe un cliente con el Dni ingresado");
                return;
            }
        }

        private void iconLimpiar_Click(object sender, EventArgs e)
        {
            cbFiltro.Text = "Todos";
            cbBusqueda.Text = "...";
            cbFiltroConfig();
            ActualizarGrilla();
        }

        public void CargarFiltros()
        {
            cbFiltro.Items.Clear();
            cbFiltro.Items.Add("Todos");
            cbFiltro.Items.Add("Más antiguo");
            cbFiltro.Items.Add("Más reciente");
            cbFiltro.Items.Add("Fecha");
            cbFiltro.Items.Add("Periodo");
            cbFiltro.Items.Add("Apellido y Nombre");
            cbFiltro.Items.Add("Precio total");


            cbBusqueda.Items.Clear();
            cbBusqueda.Items.Add("...");
            cbBusqueda.Items.Add("Número de venta");
            cbBusqueda.Items.Add("Dni");
        }

        public void cbFiltroConfig()
        {
            if (cbFiltro.Text == "Fecha")
            {
                lblFechaHasta.Visible = true;
                lblFechaHasta.Text = "Fecha:";
                dtpHasta.Visible = true;
                lblFechaDesde.Visible = false;
                dtpDesde.Visible = false;
            }
            else if (cbFiltro.Text == "Periodo")
            {
                lblFechaHasta.Visible = true;
                lblFechaHasta.Text = "Hasta:";
                dtpHasta.Visible = true;
                lblFechaDesde.Visible = true;
                lblFechaDesde.Text = "Desde:";
                dtpDesde.Visible = true;
            }
            else
            {
                lblFechaHasta.Visible = false;
                dtpHasta.Visible = false;
                lblFechaDesde.Visible = false;
                dtpDesde.Visible = false;
            }
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFiltroConfig();
        }

        private void cbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBusqueda.Text == "...")
            {
                cbFiltro.Items.Clear();
                cbFiltro.Items.Add("Todos");
                cbFiltro.Items.Add("Más antiguo");
                cbFiltro.Items.Add("Más reciente");
                cbFiltro.Items.Add("Fecha");
                cbFiltro.Items.Add("Periodo");
                cbFiltro.Items.Add("Apellido y Nombre");
                cbFiltro.Items.Add("Precio total");

                cbFiltro.Text = "Todos";
                cbFiltro.Enabled = true;
                txtDatos.Text = string.Empty;
            }
            else if (cbBusqueda.Text == "Número de ingreso")
            {
                cbFiltro.Text = "Todos";
                cbFiltro.Enabled = false;
                txtDatos.Text = string.Empty;
            }
            else
            {
                cbFiltro.Items.Clear();
                cbFiltro.Items.Add("Todos");
                cbFiltro.Items.Add("Más antiguo");
                cbFiltro.Items.Add("Más reciente");
                cbFiltro.Items.Add("Fecha");
                cbFiltro.Items.Add("Periodo");

                cbFiltro.Text = "Todos";
                cbFiltro.Enabled = true;
                txtDatos.Text = string.Empty;
            }
            cbFiltroConfig();
        }

        public void DgvConfig()
        {
            dgvRegistrosVenta.Columns["VentaID"].Visible = false;
            dgvRegistrosVenta.Columns["ClienteID"].Visible = false;

            dgvRegistrosVenta.Columns["Codigo"].DisplayIndex = 0;
            dgvRegistrosVenta.Columns["Codigo"].Width = 257;

            dgvRegistrosVenta.Columns["Fecha"].DisplayIndex = 1;
            dgvRegistrosVenta.Columns["Fecha"].Width = 257;

            dgvRegistrosVenta.Columns["Cliente"].DisplayIndex = 2;
            dgvRegistrosVenta.Columns["Cliente"].Width = 257;

            dgvRegistrosVenta.Columns["PrecioTotal"].DisplayIndex = 3;
            dgvRegistrosVenta.Columns["PrecioTotal"].Width = 257;
        }

        private void iconConsultarRegistro_Click(object sender, EventArgs e)
        {
            if (dgvRegistrosVenta.CurrentRow != null)
            {
                var ventaSeleccionada = (Venta)dgvRegistrosVenta.CurrentRow.DataBoundItem;
                var formConsultarVenta = new FormConsultarVenta(ventaSeleccionada);
                formConsultarVenta.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una venta que consultar");
            }
        }

        private void iconGrafico_Click(object sender, EventArgs e)
        {
            var formGrafico = new FormGraficoReporteVenta();
            formGrafico.ShowDialog();
        }
    }
}
