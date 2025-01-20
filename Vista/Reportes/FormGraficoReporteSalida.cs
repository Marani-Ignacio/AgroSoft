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
    public partial class FormGraficoReporteSalida : Form
    {
        public FormGraficoReporteSalida()
        {
            InitializeComponent();
            CargarFiltros();
            cbFiltroConfig();
            ActualizarGraficos();
        }

        private void FormGraficoReporteSalida_Load(object sender, EventArgs e)
        {
            ActualizarGraficos();
        }

        public void ActualizarGraficos()
        {
            var salidas = Controladora.ControladoraSalidas.Instancia.ListarSalidas().ToList();
            CrearGraficos(salidas);
            cbFiltro.Text = "Todos";
        }

        private void iconFiltro_Click(object sender, EventArgs e)
        {
            var salidas = new List<Salida>();
            if (cbFiltro.Text == "Todos")
            {
                salidas = Controladora.ControladoraSalidas.Instancia.ListarSalidas().ToList();
            }
            else if (cbFiltro.Text == "Fecha")
            {
                DateTime fecha = dtpHasta.Value;
                salidas = Controladora.ControladoraSalidas.Instancia.ListarSalidasxFecha(fecha).ToList();

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
                salidas = Controladora.ControladoraSalidas.Instancia.ListarSalidasxPeriodo(fechaDesde, fechaHasta).ToList();

            }
            CrearGraficos(salidas);
        }

        public void CrearGraficos(List<Salida> salidas)
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

            Series seriesSalidas = new Series("Salidas Columna");
            Series seriesSalidas2 = new Series("Salidas Circulo");
            seriesSalidas2.ChartType = SeriesChartType.Pie;

            foreach (var salida in salidas)
            {
                seriesSalidas.Points.AddXY("Nro. Salida " + salida.Codigo.ToString() + "\n" + salida.Industria.ToString() + "\n" + salida.Fecha.ToShortDateString(), salida.PrecioTotal);
                seriesSalidas2.Points.AddXY("Nro. Salida " + salida.Codigo.ToString(), salida.PrecioTotal);
            }

            chartColumna.Series.Add(seriesSalidas);
            chartCirculo.Series.Add(seriesSalidas2);

            chartColumna.ChartAreas[0].AxisX.Title = "Nro. Salida - Industria - Fecha";
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
