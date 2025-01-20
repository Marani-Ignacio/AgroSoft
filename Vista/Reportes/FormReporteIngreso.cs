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
    public partial class FormReporteIngreso : Form
    {
        public FormReporteIngreso()
        {
            InitializeComponent();
            CargarFiltros();
            cbFiltroConfig();
            ActualizarGrilla();
        }

        private void FormReporteIngreso_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            cbFiltro.Text = "Todos";
            cbBusqueda.Text = "...";
        }

        public void ActualizarGrilla()
        {
            dgvRegistrosIngresos.DataSource = null;
            dgvRegistrosIngresos.DataSource = Controladora.ControladoraIngresos.Instancia.ListarIngresos();
            DgvConfig();
        }

        private void iconFiltro_Click(object sender, EventArgs e)
        {
            if (cbFiltro.Text == "Todos")
            {
                dgvRegistrosIngresos.DataSource = null;
                dgvRegistrosIngresos.DataSource = Controladora.ControladoraIngresos.Instancia.ListarIngresos();

            }
            else if (cbFiltro.Text == "Más antiguo")
            {
                dgvRegistrosIngresos.DataSource = null;
                dgvRegistrosIngresos.DataSource = Controladora.ControladoraIngresos.Instancia.ListarIngresosxMasAntiguas();

            }
            else if (cbFiltro.Text == "Más reciente")
            {
                dgvRegistrosIngresos.DataSource = null;
                dgvRegistrosIngresos.DataSource = Controladora.ControladoraIngresos.Instancia.ListarIngresosxMasRecientes();

            }
            else if (cbFiltro.Text == "Fecha")
            {
                DateTime fecha = dtpHasta.Value;
                dgvRegistrosIngresos.DataSource = null;
                dgvRegistrosIngresos.DataSource = Controladora.ControladoraIngresos.Instancia.ListarIngresosxFecha(fecha);

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
                dgvRegistrosIngresos.DataSource = null;
                dgvRegistrosIngresos.DataSource = Controladora.ControladoraIngresos.Instancia.ListarIngresosxPeriodo(fechaDesde, fechaHasta);

            }
            else if (cbFiltro.Text == "Apellido y Nombre")
            {
                dgvRegistrosIngresos.DataSource = null;
                dgvRegistrosIngresos.DataSource = Controladora.ControladoraIngresos.Instancia.ListarIngresosxApellidoyNombre();

            }
            else if (cbFiltro.Text == "Código de semilla")
            {
                dgvRegistrosIngresos.DataSource = null;
                dgvRegistrosIngresos.DataSource = Controladora.ControladoraIngresos.Instancia.ListarIngresosxSemilla();

            }
            else if (cbFiltro.Text == "Cantidad")
            {
                dgvRegistrosIngresos.DataSource = null;
                dgvRegistrosIngresos.DataSource = Controladora.ControladoraIngresos.Instancia.ListarIngresosxCantidad();

            }
            else if (cbFiltro.Text == "Dinero Entregado")
            {
                dgvRegistrosIngresos.DataSource = null;
                dgvRegistrosIngresos.DataSource = Controladora.ControladoraIngresos.Instancia.ListarIngresosxPrecio();

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

            if (cbBusqueda.Text == "Número de ingreso")
            {
                int NroIngreso;
                if (!int.TryParse(txtDatos.Text, out NroIngreso))
                {
                    MessageBox.Show("Ingrese el Nro de ingreso correctamente");
                    return;
                }

                Ingreso ingreso = contexto.Ingresos.FirstOrDefault(i => i.Codigo == NroIngreso);

                if (ingreso == null)
                {
                    MessageBox.Show("No existe un ingreso con el Nro de ingreso ingresado");
                    return;
                }

                dgvRegistrosIngresos.DataSource = null;
                dgvRegistrosIngresos.DataSource = Controladora.ControladoraIngresos.Instancia.ListarIngresosxNroDeIngreso(NroIngreso);

            }

            else if (cbBusqueda.Text == "Dni" && cbFiltro.Text == "Todos")
            {
                int DNI;
                if (!int.TryParse(txtDatos.Text, out DNI))
                {
                    MessageBox.Show("Ingrese el DNI correctamente");
                    return;
                }

                Agricultor agricultor = contexto.Agricultores.FirstOrDefault(a => a.Dni == DNI);

                if (agricultor == null)
                {
                    MessageBox.Show("No existe un agricultor con el Dni ingresado");
                    return;
                }

                dgvRegistrosIngresos.DataSource = null;
                dgvRegistrosIngresos.DataSource = Controladora.ControladoraIngresos.Instancia.ListarIngresosxDniIngresado(DNI);

            }

            else if (cbBusqueda.Text == "Código de semilla" && cbFiltro.Text == "Todos")
            {
                Semilla semilla = contexto.Semillas.FirstOrDefault(s => s.Codigo == txtDatos.Text.ToUpper());

                if (semilla == null)
                {
                    MessageBox.Show("No existe una semilla con el código ingresado");
                    return;
                }
                dgvRegistrosIngresos.DataSource = null;
                dgvRegistrosIngresos.DataSource = Controladora.ControladoraIngresos.Instancia.ListarIngresosxSemillaIngresada(txtDatos.Text);
            }

            else if (cbBusqueda.Text == "Dni" && cbFiltro.Text == "Más antiguo")
            {
                int DNI;
                if (!int.TryParse(txtDatos.Text, out DNI))
                {
                    MessageBox.Show("Ingrese el DNI correctamente");
                    return;
                }

                Agricultor agricultor = contexto.Agricultores.FirstOrDefault(a => a.Dni == DNI);

                if (agricultor == null)
                {
                    MessageBox.Show("No existe un agricultor con el Dni ingresado");
                    return;
                }

                dgvRegistrosIngresos.DataSource = null;
                dgvRegistrosIngresos.DataSource = Controladora.ControladoraIngresos.Instancia.ListarIngresosxDniMasAntiguo(DNI);
            }
            else if (cbBusqueda.Text == "Código de semilla" && cbFiltro.Text == "Más antiguo")
            {
                Semilla semilla = contexto.Semillas.FirstOrDefault(s => s.Codigo == txtDatos.Text.ToUpper());

                if (semilla == null)
                {
                    MessageBox.Show("No existe una semilla con el código ingresado");
                    return;
                }
                dgvRegistrosIngresos.DataSource = null;
                dgvRegistrosIngresos.DataSource = Controladora.ControladoraIngresos.Instancia.ListarIngresosxSemillaMasAntiguo(txtDatos.Text);
            }

            else if (cbBusqueda.Text == "Dni" && cbFiltro.Text == "Más reciente")
            {
                int DNI;
                if (!int.TryParse(txtDatos.Text, out DNI))
                {
                    MessageBox.Show("Ingrese el DNI correctamente");
                    return;
                }

                Agricultor agricultor = contexto.Agricultores.FirstOrDefault(a => a.Dni == DNI);

                if (agricultor == null)
                {
                    MessageBox.Show("No existe un agricultor con el Dni ingresado");
                    return;
                }

                dgvRegistrosIngresos.DataSource = null;
                dgvRegistrosIngresos.DataSource = Controladora.ControladoraIngresos.Instancia.ListarIngresosxDniMasReciente(DNI);
            }
            else if (cbBusqueda.Text == "Código de semilla" && cbFiltro.Text == "Más reciente")
            {
                Semilla semilla = contexto.Semillas.FirstOrDefault(s => s.Codigo == txtDatos.Text.ToUpper());

                if (semilla == null)
                {
                    MessageBox.Show("No existe una semilla con el código ingresado");
                    return;
                }
                dgvRegistrosIngresos.DataSource = null;
                dgvRegistrosIngresos.DataSource = Controladora.ControladoraIngresos.Instancia.ListarIngresosxSemillaMasReciente(txtDatos.Text);
            }

            else if (cbBusqueda.Text == "Dni" && cbFiltro.Text == "Fecha")
            {
                int DNI;
                if (!int.TryParse(txtDatos.Text, out DNI))
                {
                    MessageBox.Show("Ingrese el DNI correctamente");
                    return;
                }

                Agricultor agricultor = contexto.Agricultores.FirstOrDefault(a => a.Dni == DNI);

                if (agricultor == null)
                {
                    MessageBox.Show("No existe un agricultor con el Dni ingresado");
                    return;
                }

                DateTime fecha = dtpHasta.Value;

                dgvRegistrosIngresos.DataSource = null;
                dgvRegistrosIngresos.DataSource = Controladora.ControladoraIngresos.Instancia.ListarIngresosxDniFecha(DNI, fecha);
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
                dgvRegistrosIngresos.DataSource = null;
                dgvRegistrosIngresos.DataSource = Controladora.ControladoraIngresos.Instancia.ListarIngresosxSemillaFecha(txtDatos.Text, fecha);
            }

            else if (cbBusqueda.Text == "Dni" && cbFiltro.Text == "Periodo")
            {
                int DNI;
                if (!int.TryParse(txtDatos.Text, out DNI))
                {
                    MessageBox.Show("Ingrese el DNI correctamente");
                    return;
                }

                Agricultor agricultor = contexto.Agricultores.FirstOrDefault(a => a.Dni == DNI);

                if (agricultor == null)
                {
                    MessageBox.Show("No existe un agricultor con el Dni ingresado");
                    return;
                }

                DateTime fechaDesde = dtpDesde.Value;
                DateTime fechaHasta = dtpHasta.Value;
                if (fechaDesde > fechaHasta)
                {
                    MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.", "Error de Fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvRegistrosIngresos.DataSource = null;
                dgvRegistrosIngresos.DataSource = Controladora.ControladoraIngresos.Instancia.ListarIngresosxDniPeriodo(DNI, fechaDesde, fechaHasta);
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
                dgvRegistrosIngresos.DataSource = null;
                dgvRegistrosIngresos.DataSource = Controladora.ControladoraIngresos.Instancia.ListarIngresosxSemillaPeriodo(txtDatos.Text, fechaDesde, fechaHasta);
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
            cbFiltro.Items.Add("Apellido y Nombre");
            cbFiltro.Items.Add("Código de semilla");
            cbFiltro.Items.Add("Cantidad");
            cbFiltro.Items.Add("Dinero Entregado");


            cbBusqueda.Items.Clear();
            cbBusqueda.Items.Add("...");
            cbBusqueda.Items.Add("Número de ingreso");
            cbBusqueda.Items.Add("Dni");
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
                cbFiltro.Items.Add("Apellido y Nombre");
                cbFiltro.Items.Add("Código de semilla");
                cbFiltro.Items.Add("Cantidad");
                cbFiltro.Items.Add("Dinero Entregado");

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
            dgvRegistrosIngresos.Columns["IngresoID"].Visible = false;
            dgvRegistrosIngresos.Columns["AgricultorID"].Visible = false;
            dgvRegistrosIngresos.Columns["SemillaID"].Visible = false;
            dgvRegistrosIngresos.Columns["TransporteID"].Visible = false;

            dgvRegistrosIngresos.Columns["Codigo"].DisplayIndex = 0;
            dgvRegistrosIngresos.Columns["Codigo"].Width = 147;

            dgvRegistrosIngresos.Columns["Fecha"].DisplayIndex = 1;
            dgvRegistrosIngresos.Columns["Fecha"].Width = 147;

            dgvRegistrosIngresos.Columns["Agricultor"].DisplayIndex = 2;
            dgvRegistrosIngresos.Columns["Agricultor"].Width = 147;

            dgvRegistrosIngresos.Columns["Transporte"].DisplayIndex = 3;
            dgvRegistrosIngresos.Columns["Transporte"].Width = 147;

            dgvRegistrosIngresos.Columns["Semilla"].DisplayIndex = 4;
            dgvRegistrosIngresos.Columns["Semilla"].Width = 147;

            dgvRegistrosIngresos.Columns["Cantidad"].DisplayIndex = 5;
            dgvRegistrosIngresos.Columns["Cantidad"].Width = 147;

            dgvRegistrosIngresos.Columns["PrecioTotal"].DisplayIndex = 6;
            dgvRegistrosIngresos.Columns["PrecioTotal"].Width = 147;
        }

        private void iconConsultarRegistro_Click(object sender, EventArgs e)
        {
            if (dgvRegistrosIngresos.CurrentRow != null)
            {
                var ingresoSeleccionado = (Ingreso)dgvRegistrosIngresos.CurrentRow.DataBoundItem;
                var formConsultarIngreso = new FormConsultarIngreso(ingresoSeleccionado);
                formConsultarIngreso.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un ingreso que consultar");
            }
        }

        private void iconGrafico_Click(object sender, EventArgs e)
        {
            var formGrafico = new FormGraficoReporteIngreso();
            formGrafico.ShowDialog();
        }
    }
}
