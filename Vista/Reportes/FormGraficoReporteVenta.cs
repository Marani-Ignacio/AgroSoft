using FastReport.DataVisualization.Charting;
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
    public partial class FormGraficoReporteVenta : Form
    {
        public FormGraficoReporteVenta()
        {
            InitializeComponent();
            CargarFiltros();
            cbFiltroConfig();
            ActualizarGraficos();
        }

        private void FormGraficoReporteVenta_Load(object sender, EventArgs e)
        {
            ActualizarGraficos();
        }

        public void ActualizarGraficos()
        {
            var ventas = Controladora.ControladoraVentas.Instancia.ListarVentas().ToList();
            CrearGraficos(ventas);
            cbFiltro.Text = "Todos";
        }

        private void iconFiltro_Click(object sender, EventArgs e)
        {
            var ventas = new List<Venta>();
            if (cbFiltro.Text == "Todos")
            {
                ventas = Controladora.ControladoraVentas.Instancia.ListarVentas().ToList();
            }
            else if (cbFiltro.Text == "Fecha")
            {
                DateTime fecha = dtpHasta.Value;
                ventas = Controladora.ControladoraVentas.Instancia.ListarVentasxFecha(fecha).ToList();

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
                ventas = Controladora.ControladoraVentas.Instancia.ListarVentasxPeriodo(fechaDesde, fechaHasta).ToList();

            }
            CrearGraficos(ventas);
        }

        public void CrearGraficos(List<Venta> ventas)
        {
            chartColumna.Series.Clear();
            chartColumna.ChartAreas.Clear();

            chartCirculo.Series.Clear();
            chartCirculo.ChartAreas.Clear();

            chartColumna.Titles.Clear();
            chartCirculo.Titles.Clear();

            ChartArea chartAreaColumna = new ChartArea();
            ChartArea chartAreaCirculo = new ChartArea();
            chartColumna.ChartAreas.Add(chartAreaColumna);
            chartCirculo.ChartAreas.Add(chartAreaCirculo);

            Series seriesVentas = new Series("Ventas Columna");
            Series seriesVentas2 = new Series("Ventas Circulo");
            seriesVentas2.ChartType = SeriesChartType.Pie;

            foreach (var venta in ventas)
            {
                seriesVentas.Points.AddXY("Nro. Venta " + venta.Codigo.ToString() + "\n" + venta.Cliente.ToString() + "\n" + venta.Fecha.ToShortDateString(), venta.PrecioTotal);
                seriesVentas2.Points.AddXY("Nro. Venta " + venta.Codigo.ToString(), venta.PrecioTotal);
            }

            chartColumna.Series.Add(seriesVentas);
            chartCirculo.Series.Add(seriesVentas2);

            chartColumna.ChartAreas[0].AxisX.Title = "Nro. Venta - Cliente - Fecha";
            chartColumna.ChartAreas[0].AxisY.Title = "Precio Total";
            chartColumna.Titles.Add("Gráfico de Barras");
            chartCirculo.Titles.Add("Gráfico de Porción");
        }

        private void iconLimpiar_Click(object sender, EventArgs e)
        {
            cbFiltro.Text = "Todos";
            cbFiltroConfig();
            dtpDesde.Value = DateTime.Now;
            dtpHasta.Value = DateTime.Now;
            ActualizarGraficos();
        }

        public void CargarFiltros()
        {
            cbFiltro.Items.Clear();
            cbFiltro.Items.Add("Todos");
            cbFiltro.Items.Add("Fecha");
            cbFiltro.Items.Add("Periodo");
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
                dtpDesde.Value = DateTime.Now;
                dtpHasta.Value = DateTime.Now;
            }
            else if (cbFiltro.Text == "Periodo")
            {
                lblFechaHasta.Visible = true;
                lblFechaHasta.Text = "Hasta:";
                dtpHasta.Visible = true;
                lblFechaDesde.Visible = true;
                lblFechaDesde.Text = "Desde:";
                dtpDesde.Visible = true;
                dtpDesde.Value = DateTime.Now;
                dtpHasta.Value = DateTime.Now;
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
    }
}
