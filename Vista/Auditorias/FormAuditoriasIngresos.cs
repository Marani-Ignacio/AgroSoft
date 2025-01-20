using Controladora;
using Modelo;
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
using System.Windows.Forms;

namespace Vista
{
    public partial class FormAuditoriasIngresos : Form
    {
        public FormAuditoriasIngresos()
        {
            InitializeComponent();
            CargarFiltros();
            cbFiltroConfig();
            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            dgvAuditoriasIngresos.DataSource = null;
            dgvAuditoriasIngresos.DataSource = ControladoraAuditoriaIngreso.Instancia.ListarAuditoriasIngresos();
            DgvConfig();
        }

        private void FormAuditoriasIngresos_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            cbFiltro.Text = "Todos";
            cbBusqueda.Text = "...";
        }

        private void iconFiltro_Click(object sender, EventArgs e)
        {
            if (cbFiltro.Text == "Todos")
            {
                dgvAuditoriasIngresos.DataSource = null;
                dgvAuditoriasIngresos.DataSource = Controladora.ControladoraAuditoriaIngreso.Instancia.ListarAuditoriasIngresos();

            }
            else if (cbFiltro.Text == "Más antiguo")
            {
                dgvAuditoriasIngresos.DataSource = null;
                dgvAuditoriasIngresos.DataSource = Controladora.ControladoraAuditoriaIngreso.Instancia.ListarAuditoriasxMasAntiguas();

            }
            else if (cbFiltro.Text == "Más reciente")
            {
                dgvAuditoriasIngresos.DataSource = null;
                dgvAuditoriasIngresos.DataSource = Controladora.ControladoraAuditoriaIngreso.Instancia.ListarAuditoriasxMasRecientes();

            }
            else if (cbFiltro.Text == "Fecha")
            {
                DateTime fecha = dtpHasta.Value;
                dgvAuditoriasIngresos.DataSource = null;
                dgvAuditoriasIngresos.DataSource = Controladora.ControladoraAuditoriaIngreso.Instancia.ListarAuditoriasxFecha(fecha);

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
                dgvAuditoriasIngresos.DataSource = null;
                dgvAuditoriasIngresos.DataSource = Controladora.ControladoraAuditoriaIngreso.Instancia.ListarAuditoriasxPeriodo(fechaDesde, fechaHasta);

            }
            else if (cbFiltro.Text == "Apellido y Nombre")
            {
                dgvAuditoriasIngresos.DataSource = null;
                dgvAuditoriasIngresos.DataSource = Controladora.ControladoraAuditoriaIngreso.Instancia.ListarAuditoriasxApellidoyNombre();

            }
            else if (cbFiltro.Text == "Código de semilla")
            {
                dgvAuditoriasIngresos.DataSource = null;
                dgvAuditoriasIngresos.DataSource = Controladora.ControladoraAuditoriaIngreso.Instancia.ListarAuditoriasxSemilla();

            }
            else if (cbFiltro.Text == "Cantidad")
            {
                dgvAuditoriasIngresos.DataSource = null;
                dgvAuditoriasIngresos.DataSource = Controladora.ControladoraAuditoriaIngreso.Instancia.ListarAuditoriasxCantidad();

            }
            else if (cbFiltro.Text == "Dinero Entregado")
            {
                dgvAuditoriasIngresos.DataSource = null;
                dgvAuditoriasIngresos.DataSource = Controladora.ControladoraAuditoriaIngreso.Instancia.ListarAuditoriasxPrecio();

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

            if (cbBusqueda.Text == "Dni" && cbFiltro.Text == "Todos")
            {
                int DNI;
                if (!int.TryParse(txtDatos.Text, out DNI))
                {
                    MessageBox.Show("Ingrese el DNI correctamente");
                    return;
                }

                Usuario usuario = contexto.Usuarios.FirstOrDefault(a => a.Dni == DNI);

                if (usuario == null)
                {
                    MessageBox.Show("No existe un usuario con el Dni ingresado");
                    return;
                }

                dgvAuditoriasIngresos.DataSource = null;
                dgvAuditoriasIngresos.DataSource = Controladora.ControladoraAuditoriaIngreso.Instancia.ListarAuditoriasxDniIngresado(DNI);

            }

            else if (cbBusqueda.Text == "Dni" && cbFiltro.Text == "Más antiguo")
            {
                int DNI;
                if (!int.TryParse(txtDatos.Text, out DNI))
                {
                    MessageBox.Show("Ingrese el DNI correctamente");
                    return;
                }

                Usuario usuario = contexto.Usuarios.FirstOrDefault(a => a.Dni == DNI);

                if (usuario == null)
                {
                    MessageBox.Show("No existe un usuario con el Dni ingresado");
                    return;
                }

                dgvAuditoriasIngresos.DataSource = null;
                dgvAuditoriasIngresos.DataSource = Controladora.ControladoraAuditoriaIngreso.Instancia.ListarAuditoriasxDniMasAntigua(DNI);
            }

            else if (cbBusqueda.Text == "Dni" && cbFiltro.Text == "Más reciente")
            {
                int DNI;
                if (!int.TryParse(txtDatos.Text, out DNI))
                {
                    MessageBox.Show("Ingrese el DNI correctamente");
                    return;
                }

                Usuario usuario = contexto.Usuarios.FirstOrDefault(a => a.Dni == DNI);

                if (usuario == null)
                {
                    MessageBox.Show("No existe un usuario con el Dni ingresado");
                    return;
                }

                dgvAuditoriasIngresos.DataSource = null;
                dgvAuditoriasIngresos.DataSource = Controladora.ControladoraAuditoriaIngreso.Instancia.ListarAuditoriasxDniMasReciente(DNI);
            }

            else if (cbBusqueda.Text == "Dni" && cbFiltro.Text == "Fecha")
            {
                int DNI;
                if (!int.TryParse(txtDatos.Text, out DNI))
                {
                    MessageBox.Show("Ingrese el DNI correctamente");
                    return;
                }

                Usuario usuario = contexto.Usuarios.FirstOrDefault(a => a.Dni == DNI);

                if (usuario == null)
                {
                    MessageBox.Show("No existe un usuario con el Dni ingresado");
                    return;
                }

                DateTime fecha = dtpHasta.Value;

                dgvAuditoriasIngresos.DataSource = null;
                dgvAuditoriasIngresos.DataSource = Controladora.ControladoraAuditoriaIngreso.Instancia.ListarAuditoriasxDniFecha(DNI, fecha);
            }

            else if (cbBusqueda.Text == "Dni" && cbFiltro.Text == "Periodo")
            {
                int DNI;
                if (!int.TryParse(txtDatos.Text, out DNI))
                {
                    MessageBox.Show("Ingrese el DNI correctamente");
                    return;
                }

                Usuario usuario = contexto.Usuarios.FirstOrDefault(a => a.Dni == DNI);

                if (usuario == null)
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
                dgvAuditoriasIngresos.DataSource = null;
                dgvAuditoriasIngresos.DataSource = Controladora.ControladoraAuditoriaIngreso.Instancia.ListarAuditoriasxDniPeriodo(DNI, fechaDesde, fechaHasta);
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

        private void iconConsultarAuditoria_Click(object sender, EventArgs e)
        {
            if (dgvAuditoriasIngresos.CurrentRow != null)
            {
                var auditoriaIngresoSeleccionado = (AuditoriaIngreso)dgvAuditoriasIngresos.CurrentRow.DataBoundItem;
                var formConsultarIngreso = new FormConsultarIngreso(auditoriaIngresoSeleccionado);
                formConsultarIngreso.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un auditoria de ingreso que consultar");
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
            dgvAuditoriasIngresos.Columns["AuditoriaIngresoID"].Visible = false;
            dgvAuditoriasIngresos.Columns["UsuarioID"].Visible = false;
            dgvAuditoriasIngresos.Columns["AgricultorID"].Visible = false;
            dgvAuditoriasIngresos.Columns["SemillaID"].Visible = false;
            dgvAuditoriasIngresos.Columns["TransporteID"].Visible = false;

            dgvAuditoriasIngresos.Columns["Usuario"].DisplayIndex = 0;
            dgvAuditoriasIngresos.Columns["Usuario"].Width = 103;

            dgvAuditoriasIngresos.Columns["FechayHora"].DisplayIndex = 1;
            dgvAuditoriasIngresos.Columns["FechayHora"].Width = 113;

            dgvAuditoriasIngresos.Columns["TipoAuditoria"].DisplayIndex = 2;
            dgvAuditoriasIngresos.Columns["TipoAuditoria"].Width = 143;

            dgvAuditoriasIngresos.Columns["Codigo"].DisplayIndex = 3;
            dgvAuditoriasIngresos.Columns["Codigo"].Width = 73;

            dgvAuditoriasIngresos.Columns["Fecha"].DisplayIndex = 4;
            dgvAuditoriasIngresos.Columns["Fecha"].Width = 93;

            dgvAuditoriasIngresos.Columns["Agricultor"].DisplayIndex = 5;
            dgvAuditoriasIngresos.Columns["Agricultor"].Width = 103;

            dgvAuditoriasIngresos.Columns["Transporte"].DisplayIndex = 6;
            dgvAuditoriasIngresos.Columns["Transporte"].Width = 103;

            dgvAuditoriasIngresos.Columns["Semilla"].DisplayIndex = 7;
            dgvAuditoriasIngresos.Columns["Semilla"].Width = 93;

            dgvAuditoriasIngresos.Columns["Cantidad"].DisplayIndex = 8;
            dgvAuditoriasIngresos.Columns["Cantidad"].Width = 103;

            dgvAuditoriasIngresos.Columns["PrecioTotal"].DisplayIndex = 9;
            dgvAuditoriasIngresos.Columns["PrecioTotal"].Width = 103;
        }

        
    }
}
