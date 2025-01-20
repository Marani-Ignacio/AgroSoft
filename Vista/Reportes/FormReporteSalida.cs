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
    public partial class FormReporteSalida : Form
    {
        public FormReporteSalida()
        {
            InitializeComponent();
            CargarFiltros();
            cbFiltroConfig();
            ActualizarGrilla();
        }

        private void FormReporteSalida_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            cbFiltro.Text = "Todos";
            cbBusqueda.Text = "...";
        }

        public void ActualizarGrilla()
        {
            dgvRegistrosSalidas.DataSource = null;
            dgvRegistrosSalidas.DataSource = Controladora.ControladoraSalidas.Instancia.ListarSalidas();
            DgvConfig();
        }

        private void iconFiltro_Click(object sender, EventArgs e)
        {
            if (cbFiltro.Text == "Todos")
            {
                dgvRegistrosSalidas.DataSource = null;
                dgvRegistrosSalidas.DataSource = Controladora.ControladoraSalidas.Instancia.ListarSalidas();

            }
            else if (cbFiltro.Text == "Más antiguo")
            {
                dgvRegistrosSalidas.DataSource = null;
                dgvRegistrosSalidas.DataSource = Controladora.ControladoraSalidas.Instancia.ListarSalidasxMasAntiguas();

            }
            else if (cbFiltro.Text == "Más reciente")
            {
                dgvRegistrosSalidas.DataSource = null;
                dgvRegistrosSalidas.DataSource = Controladora.ControladoraSalidas.Instancia.ListarSalidasxMasRecientes();

            }
            else if (cbFiltro.Text == "Fecha")
            {
                DateTime fecha = dtpHasta.Value;
                dgvRegistrosSalidas.DataSource = null;
                dgvRegistrosSalidas.DataSource = Controladora.ControladoraSalidas.Instancia.ListarSalidasxFecha(fecha);

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
                dgvRegistrosSalidas.DataSource = null;
                dgvRegistrosSalidas.DataSource = Controladora.ControladoraSalidas.Instancia.ListarSalidasxPeriodo(fechaDesde, fechaHasta);

            }
            else if (cbFiltro.Text == "Nombre Industria")
            {
                dgvRegistrosSalidas.DataSource = null;
                dgvRegistrosSalidas.DataSource = Controladora.ControladoraSalidas.Instancia.ListarSalidasxNombre();

            }
            else if (cbFiltro.Text == "Código de semilla")
            {
                dgvRegistrosSalidas.DataSource = null;
                dgvRegistrosSalidas.DataSource = Controladora.ControladoraSalidas.Instancia.ListarSalidasxSemilla();

            }
            else if (cbFiltro.Text == "Cantidad")
            {
                dgvRegistrosSalidas.DataSource = null;
                dgvRegistrosSalidas.DataSource = Controladora.ControladoraSalidas.Instancia.ListarSalidasxCantidad();

            }
            else if (cbFiltro.Text == "Dinero Ingresado")
            {
                dgvRegistrosSalidas.DataSource = null;
                dgvRegistrosSalidas.DataSource = Controladora.ControladoraSalidas.Instancia.ListarSalidasxPrecio();

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

            if (cbBusqueda.Text == "Número de salida")
            {
                int NroSalida;
                if (!int.TryParse(txtDatos.Text, out NroSalida))
                {
                    MessageBox.Show("Ingrese el Nro de salida correctamente");
                    return;
                }

                Salida salida = contexto.Salidas.FirstOrDefault(i => i.Codigo == NroSalida);

                if (salida == null)
                {
                    MessageBox.Show("No existe una salida con el Nro de salida ingresado");
                    return;
                }

                dgvRegistrosSalidas.DataSource = null;
                dgvRegistrosSalidas.DataSource = Controladora.ControladoraSalidas.Instancia.ListarSalidasxNroDeSalida(NroSalida);

            }

            else if (cbBusqueda.Text == "Cuil" && cbFiltro.Text == "Todos")
            {
                Industria industria = contexto.Industrias.FirstOrDefault(i => i.Cuil == txtDatos.Text);

                if (industria == null)
                {
                    MessageBox.Show("No existe una industria con el Cuil ingresado");
                    return;
                }

                dgvRegistrosSalidas.DataSource = null;
                dgvRegistrosSalidas.DataSource = Controladora.ControladoraSalidas.Instancia.ListarSalidasxCuilIngresado(txtDatos.Text);

            }
            else if (cbBusqueda.Text == "Código de semilla" && cbFiltro.Text == "Todos")
            {
                Semilla semilla = contexto.Semillas.FirstOrDefault(s => s.Codigo == txtDatos.Text.ToUpper());

                if (semilla == null)
                {
                    MessageBox.Show("No existe una semilla con el código ingresado");
                    return;
                }
                dgvRegistrosSalidas.DataSource = null;
                dgvRegistrosSalidas.DataSource = Controladora.ControladoraSalidas.Instancia.ListarSalidasxSemillaIngresada(txtDatos.Text);
            }

            else if (cbBusqueda.Text == "Cuil" && cbFiltro.Text == "Más antiguo")
            {
                Industria industria = contexto.Industrias.FirstOrDefault(i => i.Cuil == txtDatos.Text);

                if (industria == null)
                {
                    MessageBox.Show("No existe una industria con el Cuil ingresado");
                    return;
                }

                dgvRegistrosSalidas.DataSource = null;
                dgvRegistrosSalidas.DataSource = Controladora.ControladoraSalidas.Instancia.ListarSalidasxCuilMasAntiguo(txtDatos.Text);
            }
            else if (cbBusqueda.Text == "Código de semilla" && cbFiltro.Text == "Más antiguo")
            {
                Semilla semilla = contexto.Semillas.FirstOrDefault(s => s.Codigo == txtDatos.Text.ToUpper());

                if (semilla == null)
                {
                    MessageBox.Show("No existe una semilla con el código ingresado");
                    return;
                }
                dgvRegistrosSalidas.DataSource = null;
                dgvRegistrosSalidas.DataSource = Controladora.ControladoraSalidas.Instancia.ListarSalidasxSemillaMasAntiguo(txtDatos.Text);
            }

            else if (cbBusqueda.Text == "Cuil" && cbFiltro.Text == "Más reciente")
            {
                Industria industria = contexto.Industrias.FirstOrDefault(i => i.Cuil == txtDatos.Text);

                if (industria == null)
                {
                    MessageBox.Show("No existe una industria con el Cuil ingresado");
                    return;
                }

                dgvRegistrosSalidas.DataSource = null;
                dgvRegistrosSalidas.DataSource = Controladora.ControladoraSalidas.Instancia.ListarSalidasxCuilMasReciente(txtDatos.Text);
            }
            else if (cbBusqueda.Text == "Código de semilla" && cbFiltro.Text == "Más reciente")
            {
                Semilla semilla = contexto.Semillas.FirstOrDefault(s => s.Codigo == txtDatos.Text.ToUpper());

                if (semilla == null)
                {
                    MessageBox.Show("No existe una semilla con el código ingresado");
                    return;
                }
                dgvRegistrosSalidas.DataSource = null;
                dgvRegistrosSalidas.DataSource = Controladora.ControladoraSalidas.Instancia.ListarSalidasxSemillaMasReciente(txtDatos.Text);
            }

            else if (cbBusqueda.Text == "Cuil" && cbFiltro.Text == "Fecha")
            {
                Industria industria = contexto.Industrias.FirstOrDefault(i => i.Cuil == txtDatos.Text);

                if (industria == null)
                {
                    MessageBox.Show("No existe una industria con el Cuil ingresado");
                    return;
                }

                DateTime fecha = dtpHasta.Value;

                dgvRegistrosSalidas.DataSource = null;
                dgvRegistrosSalidas.DataSource = Controladora.ControladoraSalidas.Instancia.ListarSalidasxCuilFecha(txtDatos.Text, fecha);
            }

            else if (cbBusqueda.Text == "Código de semilla" && cbFiltro.Text == "Fecha")
            {
                Semilla semilla = contexto.Semillas.FirstOrDefault(s => s.Codigo == txtDatos.Text.ToUpper());

                if (semilla == null)
                {
                    MessageBox.Show("No existe una semilla con el código ingresado");
                    return;
                }
                DateTime fecha = dtpHasta.Value;
                dgvRegistrosSalidas.DataSource = null;
                dgvRegistrosSalidas.DataSource = Controladora.ControladoraSalidas.Instancia.ListarSalidasxSemillaFecha(txtDatos.Text, fecha);
            }

            else if (cbBusqueda.Text == "Cuil" && cbFiltro.Text == "Periodo")
            {
                Industria industria = contexto.Industrias.FirstOrDefault(i => i.Cuil == txtDatos.Text);

                if (industria == null)
                {
                    MessageBox.Show("No existe una industria con el Cuil ingresado");
                    return;
                }

                DateTime fechaDesde = dtpDesde.Value;
                DateTime fechaHasta = dtpHasta.Value;
                if (fechaDesde > fechaHasta)
                {
                    MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.", "Error de Fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvRegistrosSalidas.DataSource = null;
                dgvRegistrosSalidas.DataSource = Controladora.ControladoraSalidas.Instancia.ListarSalidasxCuilPeriodo(txtDatos.Text, fechaDesde, fechaHasta);
            }
            else if (cbBusqueda.Text == "Código de semilla" && cbFiltro.Text == "Periodo")
            {
                Semilla semilla = contexto.Semillas.FirstOrDefault(s => s.Codigo == txtDatos.Text.ToUpper());

                if (semilla == null)
                {
                    MessageBox.Show("No existe una semilla con el código ingresado");
                    return;
                }
                DateTime fechaDesde = dtpDesde.Value;
                DateTime fechaHasta = dtpHasta.Value;
                if (fechaDesde > fechaHasta)
                {
                    MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.", "Error de Fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvRegistrosSalidas.DataSource = null;
                dgvRegistrosSalidas.DataSource = Controladora.ControladoraSalidas.Instancia.ListarSalidasxSemillaPeriodo(txtDatos.Text, fechaDesde, fechaHasta);
            }
            else
            {
                MessageBox.Show("Debes seleccionar un tipo de busqueda");
                return;
            }
            DgvConfig();
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
            cbFiltro.Items.Add("Nombre Industria");
            cbFiltro.Items.Add("Código de semilla");
            cbFiltro.Items.Add("Cantidad");
            cbFiltro.Items.Add("Dinero Ingresado");


            cbBusqueda.Items.Clear();
            cbBusqueda.Items.Add("...");
            cbBusqueda.Items.Add("Número de salida");
            cbBusqueda.Items.Add("Cuil");
            cbBusqueda.Items.Add("Código de semilla");
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
                cbFiltro.Items.Add("Nombre Industria");
                cbFiltro.Items.Add("Código de semilla");
                cbFiltro.Items.Add("Cantidad");
                cbFiltro.Items.Add("Dinero Ingresado");

                cbFiltro.Text = "Todos";
                cbFiltro.Enabled = true;
                txtDatos.Text = string.Empty;
            }
            else if (cbBusqueda.Text == "Número de salida")
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
            dgvRegistrosSalidas.Columns["SalidaID"].Visible = false;
            dgvRegistrosSalidas.Columns["IndustriaID"].Visible = false;
            dgvRegistrosSalidas.Columns["SemillaID"].Visible = false;
            dgvRegistrosSalidas.Columns["TransporteID"].Visible = false;

            dgvRegistrosSalidas.Columns["Codigo"].DisplayIndex = 0;
            dgvRegistrosSalidas.Columns["Codigo"].Width = 147;

            dgvRegistrosSalidas.Columns["Fecha"].DisplayIndex = 1;
            dgvRegistrosSalidas.Columns["Fecha"].Width = 147;

            dgvRegistrosSalidas.Columns["Industria"].DisplayIndex = 2;
            dgvRegistrosSalidas.Columns["Industria"].Width = 147;

            dgvRegistrosSalidas.Columns["Transporte"].DisplayIndex = 3;
            dgvRegistrosSalidas.Columns["Transporte"].Width = 147;

            dgvRegistrosSalidas.Columns["Semilla"].DisplayIndex = 4;
            dgvRegistrosSalidas.Columns["Semilla"].Width = 147;

            dgvRegistrosSalidas.Columns["Cantidad"].DisplayIndex = 5;
            dgvRegistrosSalidas.Columns["Cantidad"].Width = 147;

            dgvRegistrosSalidas.Columns["PrecioTotal"].DisplayIndex = 6;
            dgvRegistrosSalidas.Columns["PrecioTotal"].Width = 147;
        }

        private void iconConsultarRegistro_Click(object sender, EventArgs e)
        {
            if (dgvRegistrosSalidas.CurrentRow != null)
            {
                var salidaSeleccionada = (Salida)dgvRegistrosSalidas.CurrentRow.DataBoundItem;
                var formConsultarSalida = new FormConsultarSalida(salidaSeleccionada);
                formConsultarSalida.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una salida que consultar");
            }
        }

        private void iconGrafico_Click(object sender, EventArgs e)
        {
            var formGrafico = new FormGraficoReporteSalida();
            formGrafico.ShowDialog();
        }
    }
}
