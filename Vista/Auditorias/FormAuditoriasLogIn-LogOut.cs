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
    public partial class FormAuditoriasLogIn_LogOut : Form
    {
        public FormAuditoriasLogIn_LogOut()
        {
            InitializeComponent();
            CargarFiltros();
            cbFiltroConfig();
            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            dgvAuditoriasLogInLogOut.DataSource = null;
            dgvAuditoriasLogInLogOut.DataSource = ControladoraAuditoriaLogIn_LogOut.Instancia.ListarAuditoriasLogInLogOut();
            DgvConfig();
        }

        private void FormAuditoriasLogIn_LogOut_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            cbFiltro.Text = "Todos";
            cbBusqueda.Text = "...";
        }

        private void iconFiltro_Click(object sender, EventArgs e)
        {
            if (cbFiltro.Text == "Todos")
            {
                dgvAuditoriasLogInLogOut.DataSource = null;
                dgvAuditoriasLogInLogOut.DataSource = Controladora.ControladoraAuditoriaLogIn_LogOut.Instancia.ListarAuditoriasLogInLogOut();

            }
            else if (cbFiltro.Text == "Más antiguo")
            {
                dgvAuditoriasLogInLogOut.DataSource = null;
                dgvAuditoriasLogInLogOut.DataSource = Controladora.ControladoraAuditoriaLogIn_LogOut.Instancia.ListarAuditoriasxMasAntiguas();

            }
            else if (cbFiltro.Text == "Más reciente")
            {
                dgvAuditoriasLogInLogOut.DataSource = null;
                dgvAuditoriasLogInLogOut.DataSource = Controladora.ControladoraAuditoriaLogIn_LogOut.Instancia.ListarAuditoriasxMasRecientes();

            }
            else if (cbFiltro.Text == "Fecha")
            {
                DateTime fecha = dtpHasta.Value;
                dgvAuditoriasLogInLogOut.DataSource = null;
                dgvAuditoriasLogInLogOut.DataSource = Controladora.ControladoraAuditoriaLogIn_LogOut.Instancia.ListarAuditoriasxFecha(fecha);

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
                dgvAuditoriasLogInLogOut.DataSource = null;
                dgvAuditoriasLogInLogOut.DataSource = Controladora.ControladoraAuditoriaLogIn_LogOut.Instancia.ListarAuditoriasxPeriodo(fechaDesde, fechaHasta);

            }
            else if (cbFiltro.Text == "Apellido y Nombre")
            {
                dgvAuditoriasLogInLogOut.DataSource = null;
                dgvAuditoriasLogInLogOut.DataSource = Controladora.ControladoraAuditoriaLogIn_LogOut.Instancia.ListarAuditoriasxApellidoyNombre();

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

                dgvAuditoriasLogInLogOut.DataSource = null;
                dgvAuditoriasLogInLogOut.DataSource = Controladora.ControladoraAuditoriaLogIn_LogOut.Instancia.ListarAuditoriasxDniIngresado(DNI);

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

                dgvAuditoriasLogInLogOut.DataSource = null;
                dgvAuditoriasLogInLogOut.DataSource = Controladora.ControladoraAuditoriaLogIn_LogOut.Instancia.ListarAuditoriasxDniMasAntigua(DNI);
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

                dgvAuditoriasLogInLogOut.DataSource = null;
                dgvAuditoriasLogInLogOut.DataSource = Controladora.ControladoraAuditoriaLogIn_LogOut.Instancia.ListarAuditoriasxDniMasReciente(DNI);
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

                dgvAuditoriasLogInLogOut.DataSource = null;
                dgvAuditoriasLogInLogOut.DataSource = Controladora.ControladoraAuditoriaLogIn_LogOut.Instancia.ListarAuditoriasxDniFecha(DNI, fecha);
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
                dgvAuditoriasLogInLogOut.DataSource = null;
                dgvAuditoriasLogInLogOut.DataSource = Controladora.ControladoraAuditoriaLogIn_LogOut.Instancia.ListarAuditoriasxDniPeriodo(DNI, fechaDesde, fechaHasta);
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
            if (dgvAuditoriasLogInLogOut.CurrentRow != null)
            {
                var auditoriaLogInLogOutSeleccionado = (AuditoriaLogInLogOut)dgvAuditoriasLogInLogOut.CurrentRow.DataBoundItem;
                var formConsultarLogInLogOut = new FormConsultarUsuario(auditoriaLogInLogOutSeleccionado);
                formConsultarLogInLogOut.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un auditoria de login - logout que consultar");
            }
        }

        public void DgvConfig()
        {
            dgvAuditoriasLogInLogOut.Columns["AuditoriaLogInLogOutID"].Visible = false;
            dgvAuditoriasLogInLogOut.Columns["UsuarioID"].Visible = false;

            dgvAuditoriasLogInLogOut.Columns["Usuario"].DisplayIndex = 0;
            dgvAuditoriasLogInLogOut.Columns["Usuario"].Width = 343;

            dgvAuditoriasLogInLogOut.Columns["FechayHora"].DisplayIndex = 1;
            dgvAuditoriasLogInLogOut.Columns["FechayHora"].Width = 343;

            dgvAuditoriasLogInLogOut.Columns["TipoAuditoria"].DisplayIndex = 2;
            dgvAuditoriasLogInLogOut.Columns["TipoAuditoria"].Width = 343;
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
    }
}
