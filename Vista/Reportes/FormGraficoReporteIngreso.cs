using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport.DataVisualization.Charting;
using Modelo.Entidades;


namespace Vista
{
    public partial class FormGraficoReporteIngreso : Form
    {
        public FormGraficoReporteIngreso()
        {
            InitializeComponent();
            CargarFiltros();
            cbFiltroConfig();
            ActualizarGraficos();
        }

        private void FormGraficoReporteIngreso_Load(object sender, EventArgs e)
        {
            ActualizarGraficos();
        }

        public void ActualizarGraficos()
        {
            var ingresos = Controladora.ControladoraIngresos.Instancia.ListarIngresos().ToList();
            CrearGraficos(ingresos);
            cbFiltro.Text = "Todos";
        }

        private void iconFiltro_Click(object sender, EventArgs e)
        {
            var ingresos = new List<Ingreso>();
            if (cbFiltro.Text == "Todos")
            {
                ingresos = Controladora.ControladoraIngresos.Instancia.ListarIngresos().ToList();
            }
            else if (cbFiltro.Text == "Fecha")
            {
                DateTime fecha = dtpHasta.Value;
                ingresos = Controladora.ControladoraIngresos.Instancia.ListarIngresosxFecha(fecha).ToList();

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
                ingresos = Controladora.ControladoraIngresos.Instancia.ListarIngresosxPeriodo(fechaDesde, fechaHasta).ToList();

            }
            CrearGraficos(ingresos);
        }

        public void CrearGraficos(List<Ingreso> ingresos)
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

            Series seriesIngresos = new Series("Ingresos Columna");
            Series seriesIngresos2 = new Series("Ingresos Circulo");
            seriesIngresos2.ChartType = SeriesChartType.Pie;

            foreach (var ingreso in ingresos)
            {
                seriesIngresos.Points.AddXY("Nro. Ingreso " + ingreso.Codigo.ToString() + "\n" + ingreso.Agricultor.ToString() + "\n" + ingreso.Fecha.ToShortDateString(), ingreso.PrecioTotal);
                seriesIngresos2.Points.AddXY("Nro. Ingreso " + ingreso.Codigo.ToString(), ingreso.PrecioTotal);
            }

            chartColumna.Series.Add(seriesIngresos);
            chartCirculo.Series.Add(seriesIngresos2);

            chartColumna.ChartAreas[0].AxisX.Title = "Nro. Ingreso - Agricultor - Fecha";
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
