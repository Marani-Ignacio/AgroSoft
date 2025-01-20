using Controladora;
using Modelo;
using Modelo.Auditorias;
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
    public partial class FormAuditoriasSalidas : Form
    {
        public FormAuditoriasSalidas()
        {
            InitializeComponent();
            CargarFiltros();
            cbFiltroConfig();
            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            dgvAuditoriasSalidas.DataSource = null;
            dgvAuditoriasSalidas.DataSource = ControladoraAuditoriaSalida.Instancia.ListarAuditoriasSalidas();
            DgvConfig();
        }

        private void FormAuditoriasSalidas_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            cbFiltro.Text = "Todos";
            cbBusqueda.Text = "...";
        }

        private void iconFiltro_Click(object sender, EventArgs e)
        {
            if (cbFiltro.Text == "Todos")
            {
                dgvAuditoriasSalidas.DataSource = null;
                dgvAuditoriasSalidas.DataSource = Controladora.ControladoraAuditoriaSalida.Instancia.ListarAuditoriasSalidas();

            }
            else if (cbFiltro.Text == "Más antiguo")
            {
                dgvAuditoriasSalidas.DataSource = null;
                dgvAuditoriasSalidas.DataSource = Controladora.ControladoraAuditoriaSalida.Instancia.ListarAuditoriasxMasAntiguas();

            }
            else if (cbFiltro.Text == "Más reciente")
            {
                dgvAuditoriasSalidas.DataSource = null;
                dgvAuditoriasSalidas.DataSource = Controladora.ControladoraAuditoriaSalida.Instancia.ListarAuditoriasxMasRecientes();

            }
            else if (cbFiltro.Text == "Fecha")
            {
                DateTime fecha = dtpHasta.Value;
                dgvAuditoriasSalidas.DataSource = null;
                dgvAuditoriasSalidas.DataSource = Controladora.ControladoraAuditoriaSalida.Instancia.ListarAuditoriasxFecha(fecha);

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
                dgvAuditoriasSalidas.DataSource = null;
                dgvAuditoriasSalidas.DataSource = Controladora.ControladoraAuditoriaSalida.Instancia.ListarAuditoriasxPeriodo(fechaDesde, fechaHasta);

            }
            else if (cbFiltro.Text == "Apellido y Nombre")
            {
                dgvAuditoriasSalidas.DataSource = null;
                dgvAuditoriasSalidas.DataSource = Controladora.ControladoraAuditoriaSalida.Instancia.ListarAuditoriasxNombre();

            }
            else if (cbFiltro.Text == "Código de semilla")
            {
                dgvAuditoriasSalidas.DataSource = null;
                dgvAuditoriasSalidas.DataSource = Controladora.ControladoraAuditoriaSalida.Instancia.ListarAuditoriasxSemilla();

            }
            else if (cbFiltro.Text == "Cantidad")
            {
                dgvAuditoriasSalidas.DataSource = null;
                dgvAuditoriasSalidas.DataSource = Controladora.ControladoraAuditoriaSalida.Instancia.ListarAuditoriasxCantidad();

            }
            else if (cbFiltro.Text == "Dinero Ingresado")
            {
                dgvAuditoriasSalidas.DataSource = null;
                dgvAuditoriasSalidas.DataSource = Controladora.ControladoraAuditoriaSalida.Instancia.ListarAuditoriasxPrecio();

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

                dgvAuditoriasSalidas.DataSource = null;
                dgvAuditoriasSalidas.DataSource = Controladora.ControladoraAuditoriaSalida.Instancia.ListarAuditoriasxDniIngresado(DNI);

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

                dgvAuditoriasSalidas.DataSource = null;
                dgvAuditoriasSalidas.DataSource = Controladora.ControladoraAuditoriaSalida.Instancia.ListarAuditoriasxDniMasAntigua(DNI);
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

                dgvAuditoriasSalidas.DataSource = null;
                dgvAuditoriasSalidas.DataSource = Controladora.ControladoraAuditoriaSalida.Instancia.ListarAuditoriasxDniMasReciente(DNI);
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

                dgvAuditoriasSalidas.DataSource = null;
                dgvAuditoriasSalidas.DataSource = Controladora.ControladoraAuditoriaSalida.Instancia.ListarAuditoriasxDniFecha(DNI, fecha);
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
                dgvAuditoriasSalidas.DataSource = null;
                dgvAuditoriasSalidas.DataSource = Controladora.ControladoraAuditoriaSalida.Instancia.ListarAuditoriasxDniPeriodo(DNI, fechaDesde, fechaHasta);
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
            cbFiltro.Items.Add("Dinero Ingresado");


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
            if (dgvAuditoriasSalidas.CurrentRow != null)
            {
                var auditoriaSalidaSeleccionada = (AuditoriaSalida)dgvAuditoriasSalidas.CurrentRow.DataBoundItem;
                var formConsultarSalida = new FormConsultarSalida(auditoriaSalidaSeleccionada);
                formConsultarSalida.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un auditoria de salida que consultar");
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
                cbFiltro.Items.Add("Dinero Ingresado");

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
            dgvAuditoriasSalidas.Columns["AuditoriaSalidaID"].Visible = false;
            dgvAuditoriasSalidas.Columns["UsuarioID"].Visible = false;
            dgvAuditoriasSalidas.Columns["IndustriaID"].Visible = false;
            dgvAuditoriasSalidas.Columns["SemillaID"].Visible = false;
            dgvAuditoriasSalidas.Columns["TransporteID"].Visible = false;

            dgvAuditoriasSalidas.Columns["Usuario"].DisplayIndex = 0;
            dgvAuditoriasSalidas.Columns["Usuario"].Width = 103;

            dgvAuditoriasSalidas.Columns["FechayHora"].DisplayIndex = 1;
            dgvAuditoriasSalidas.Columns["FechayHora"].Width = 113;

            dgvAuditoriasSalidas.Columns["TipoAuditoria"].DisplayIndex = 2;
            dgvAuditoriasSalidas.Columns["TipoAuditoria"].Width = 143;

            dgvAuditoriasSalidas.Columns["Codigo"].DisplayIndex = 3;
            dgvAuditoriasSalidas.Columns["Codigo"].Width = 73;

            dgvAuditoriasSalidas.Columns["Fecha"].DisplayIndex = 4;
            dgvAuditoriasSalidas.Columns["Fecha"].Width = 93;

            dgvAuditoriasSalidas.Columns["Industria"].DisplayIndex = 5;
            dgvAuditoriasSalidas.Columns["Industria"].Width = 103;

            dgvAuditoriasSalidas.Columns["Transporte"].DisplayIndex = 6;
            dgvAuditoriasSalidas.Columns["Transporte"].Width = 103;

            dgvAuditoriasSalidas.Columns["Semilla"].DisplayIndex = 7;
            dgvAuditoriasSalidas.Columns["Semilla"].Width = 93;

            dgvAuditoriasSalidas.Columns["Cantidad"].DisplayIndex = 8;
            dgvAuditoriasSalidas.Columns["Cantidad"].Width = 103;

            dgvAuditoriasSalidas.Columns["PrecioTotal"].DisplayIndex = 9;
            dgvAuditoriasSalidas.Columns["PrecioTotal"].Width = 103;
        }
    }
}
