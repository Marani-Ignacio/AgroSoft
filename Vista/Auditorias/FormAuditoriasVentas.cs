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
    public partial class FormAuditoriasVentas : Form
    {
        public FormAuditoriasVentas()
        {
            InitializeComponent();
            CargarFiltros();
            cbFiltroConfig();
            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            dgvAuditoriasVentas.DataSource = null;
            dgvAuditoriasVentas.DataSource = ControladoraAuditoriaVenta.Instancia.ListarAuditoriasVentas();
            DgvConfig();
        }

        private void FormAuditoriasVentas_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            cbFiltro.Text = "Todos";
            cbBusqueda.Text = "...";
        }

        private void iconFiltro_Click(object sender, EventArgs e)
        {
            if (cbFiltro.Text == "Todos")
            {
                dgvAuditoriasVentas.DataSource = null;
                dgvAuditoriasVentas.DataSource = Controladora.ControladoraAuditoriaVenta.Instancia.ListarAuditoriasVentas();

            }
            else if (cbFiltro.Text == "Más antiguo")
            {
                dgvAuditoriasVentas.DataSource = null;
                dgvAuditoriasVentas.DataSource = Controladora.ControladoraAuditoriaVenta.Instancia.ListarAuditoriasxMasAntiguas();

            }
            else if (cbFiltro.Text == "Más reciente")
            {
                dgvAuditoriasVentas.DataSource = null;
                dgvAuditoriasVentas.DataSource = Controladora.ControladoraAuditoriaVenta.Instancia.ListarAuditoriasxMasRecientes();

            }
            else if (cbFiltro.Text == "Fecha")
            {
                DateTime fecha = dtpHasta.Value;
                dgvAuditoriasVentas.DataSource = null;
                dgvAuditoriasVentas.DataSource = Controladora.ControladoraAuditoriaVenta.Instancia.ListarAuditoriasxFecha(fecha);

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
                dgvAuditoriasVentas.DataSource = null;
                dgvAuditoriasVentas.DataSource = Controladora.ControladoraAuditoriaVenta.Instancia.ListarAuditoriasxPeriodo(fechaDesde, fechaHasta);

            }
            else if (cbFiltro.Text == "Apellido y Nombre")
            {
                dgvAuditoriasVentas.DataSource = null;
                dgvAuditoriasVentas.DataSource = Controladora.ControladoraAuditoriaVenta.Instancia.ListarAuditoriasxApellidoyNombre();

            }
            else if (cbFiltro.Text == "Precio total")
            {
                dgvAuditoriasVentas.DataSource = null;
                dgvAuditoriasVentas.DataSource = Controladora.ControladoraAuditoriaVenta.Instancia.ListarAuditoriasxPrecio();

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

                dgvAuditoriasVentas.DataSource = null;
                dgvAuditoriasVentas.DataSource = Controladora.ControladoraAuditoriaVenta.Instancia.ListarAuditoriasxDniIngresado(DNI);

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

                dgvAuditoriasVentas.DataSource = null;
                dgvAuditoriasVentas.DataSource = Controladora.ControladoraAuditoriaVenta.Instancia.ListarAuditoriasxDniMasAntigua(DNI);
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

                dgvAuditoriasVentas.DataSource = null;
                dgvAuditoriasVentas.DataSource = Controladora.ControladoraAuditoriaVenta.Instancia.ListarAuditoriasxDniMasReciente(DNI);
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

                dgvAuditoriasVentas.DataSource = null;
                dgvAuditoriasVentas.DataSource = Controladora.ControladoraAuditoriaVenta.Instancia.ListarAuditoriasxDniFecha(DNI, fecha);
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
                dgvAuditoriasVentas.DataSource = null;
                dgvAuditoriasVentas.DataSource = Controladora.ControladoraAuditoriaVenta.Instancia.ListarAuditoriasxDniPeriodo(DNI, fechaDesde, fechaHasta);
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
            cbFiltro.Items.Add("Precio total");


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
            if (dgvAuditoriasVentas.CurrentRow != null)
            {
                var auditoriaVentaSeleccionada = (AuditoriaVenta)dgvAuditoriasVentas.CurrentRow.DataBoundItem;
                var formConsultarVenta = new FormConsultarVenta(auditoriaVentaSeleccionada);
                formConsultarVenta.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un auditoria de venta que consultar");
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
            dgvAuditoriasVentas.Columns["AuditoriaVentaID"].Visible = false;
            dgvAuditoriasVentas.Columns["UsuarioID"].Visible = false;
            dgvAuditoriasVentas.Columns["ClienteID"].Visible = false;

            dgvAuditoriasVentas.Columns["Usuario"].DisplayIndex = 0;
            dgvAuditoriasVentas.Columns["Usuario"].Width = 147;

            dgvAuditoriasVentas.Columns["FechayHora"].DisplayIndex = 1;
            dgvAuditoriasVentas.Columns["FechayHora"].Width = 147;

            dgvAuditoriasVentas.Columns["TipoAuditoria"].DisplayIndex = 2;
            dgvAuditoriasVentas.Columns["TipoAuditoria"].Width = 147;

            dgvAuditoriasVentas.Columns["Codigo"].DisplayIndex = 3;
            dgvAuditoriasVentas.Columns["Codigo"].Width = 147;

            dgvAuditoriasVentas.Columns["Fecha"].DisplayIndex = 4;
            dgvAuditoriasVentas.Columns["Fecha"].Width = 147;

            dgvAuditoriasVentas.Columns["Cliente"].DisplayIndex = 5;
            dgvAuditoriasVentas.Columns["Cliente"].Width = 147;

            dgvAuditoriasVentas.Columns["PrecioTotal"].DisplayIndex = 6;
            dgvAuditoriasVentas.Columns["PrecioTotal"].Width = 147;
        }

        
    }
}
