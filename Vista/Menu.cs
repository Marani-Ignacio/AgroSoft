using Controladora;
using FontAwesome.Sharp;
using Microsoft.EntityFrameworkCore;
using Modelo;
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
    public partial class Menu : Form
    {
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        private Usuario usuario;

        private System.Windows.Forms.Timer timerInactividad;
        private const int TiempoInactividadMaximo = 500 * 60 * 1000;
        private DateTime ultimaActividad;

        public Menu(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AplicarPermisos(usuario);
            ActualizarBienvenido();
            SetTimer();
        }

        private void AplicarPermisos(Usuario usuario)
        {
            iconConfiguracion.Visible = false;
            iconAgricultor.Visible = false;
            iconIndustrias.Visible = false;
            iconClientes.Visible = false;
            iconSemillas.Visible = false;
            iconTransporte.Visible = false;
            iconTransporte1.Visible = false;
            iconIngreso.Visible = false;
            iconRegistroIngresos.Visible = false;
            iconSalida.Visible = false;
            iconRegistroSalida.Visible = false;
            iconSemillas.Visible = false;
            iconVentas.Visible = false;
            iconRegistroVentas.Visible = false;
            iconProductos.Visible = false;
            iconReportes.Visible = false;
            iconReporteIngreso.Visible = false;
            iconReporteSalida.Visible = false;
            iconReporteVenta.Visible = false;
            iconSeguridad.Visible = false;
            iconGestionarUsuarios.Visible = false;
            iconGestionarGrupos.Visible = false;
            iconDatosPersonales.Visible = false;
            iconAuditoria.Visible = false;
            iconAuditoriasIngresos.Visible = false;
            iconAuditoriasSalidas.Visible = false;
            iconAuditoriasVentas.Visible = false;
            iconAuditoriasInicioDeSesion.Visible = false;


            if (usuario.TienePermiso("Todos los permisos"))
            {
                iconConfiguracion.Visible = true;
                iconAgricultor.Visible = true;
                iconIndustrias.Visible = true;
                iconClientes.Visible = true;
                iconSemillas.Visible = true;
                iconTransporte.Visible = true;
                iconTransporte1.Visible = true;
                iconIngreso.Visible = true;
                iconRegistroIngresos.Visible = true;
                iconSalida.Visible = true;
                iconRegistroSalida.Visible = true;
                iconVentas.Visible = true;
                iconRegistroVentas.Visible = true;
                iconProductos.Visible = true;
                iconReportes.Visible = true;
                iconReporteIngreso.Visible = true;
                iconReporteSalida.Visible = true;
                iconReporteVenta.Visible = true;
                iconSeguridad.Visible = true;
                iconGestionarUsuarios.Visible = true;
                iconGestionarGrupos.Visible = true;
                iconDatosPersonales.Visible = true;
                iconAuditoria.Visible = true;
                iconAuditoriasIngresos.Visible = true;
                iconAuditoriasSalidas.Visible = true;
                iconAuditoriasVentas.Visible = true;
                iconAuditoriasInicioDeSesion.Visible = true;
            }
            if (usuario.TienePermiso("Gestionar Usuarios"))
            {
                iconSeguridad.Visible = true;
                iconGestionarUsuarios.Visible = true;
            }
            if (usuario.TienePermiso("Gestionar Grupos"))
            {
                iconSeguridad.Visible = true;
                iconGestionarGrupos.Visible = true;
            }
            if (usuario.TienePermiso("Gestionar Ingresos"))
            {
                iconIngreso.Visible = true;
                iconRegistroIngresos.Visible = true;
            }
            if (usuario.TienePermiso("Gestionar Agricultores"))
            {
                iconIngreso.Visible = true;
                iconAgricultor.Visible = true;
            }
            if (usuario.TienePermiso("Gestionar Transportes Ingreso"))
            {
                iconIngreso.Visible = true;
                iconTransporte1.Visible = true;
            }

            if (usuario.TienePermiso("Gestionar Salidas"))
            {
                iconSalida.Visible = true;
                iconRegistroSalida.Visible = true;
            }
            if (usuario.TienePermiso("Gestionar Industrias"))
            {
                iconSalida.Visible = true;
                iconIndustrias.Visible = true;
            }
            if (usuario.TienePermiso("Gestionar Transportes Salida"))
            {
                iconSalida.Visible = true;
                iconTransporte.Visible = true;
            }
            if (usuario.TienePermiso("Gestionar Semillas"))
            {
                iconSemillas.Visible = true;
            }
            if (usuario.TienePermiso("Gestionar Clientes"))
            {
                iconVentas.Visible = true;
                iconClientes.Visible = true;
            }
            if (usuario.TienePermiso("Gestionar Productos"))
            {
                iconVentas.Visible = true;
                iconProductos.Visible = true;
            }
            if (usuario.TienePermiso("Gestionar Ventas"))
            {
                iconVentas.Visible = true;
                iconRegistroVentas.Visible = true;
            }
            if (usuario.TienePermiso("Gestionar Reportes Ingreso"))
            {
                iconReportes.Visible = true;
                iconReporteIngreso.Visible = true;
            }
            if (usuario.TienePermiso("Gestionar Reportes Salida"))
            {
                iconReportes.Visible = true;
                iconReporteSalida.Visible = true;
            }
            if (usuario.TienePermiso("Gestionar Reportes Venta"))
            {
                iconReportes.Visible = true;
                iconReporteVenta.Visible = true;
            }
            if (usuario.TienePermiso("Gestionar Datos Personales"))
            {
                iconConfiguracion.Visible = true;
                iconDatosPersonales.Visible = true;
            }
            if (usuario.TienePermiso("Gestionar Auditorias"))
            {
                iconAuditoria.Visible = true;
                iconAuditoriasIngresos.Visible = true;
                iconAuditoriasSalidas.Visible = true;
                iconAuditoriasVentas.Visible = true;
                iconAuditoriasInicioDeSesion.Visible = true;
            }
            else if (usuario.TienePermiso(null))
            {
                iconConfiguracion.Visible = false;
                iconAgricultor.Visible = false;
                iconIndustrias.Visible = false;
                iconClientes.Visible = false;
                iconSemillas.Visible = false;
                iconTransporte.Visible = false;
                iconTransporte1.Visible = false;
                iconIngreso.Visible = false;
                iconRegistroIngresos.Visible = false;
                iconSalida.Visible = false;
                iconRegistroSalida.Visible = false;
                iconSemillas.Visible = false;
                iconVentas.Visible = false;
                iconRegistroVentas.Visible = false;
                iconProductos.Visible = false;
                iconReportes.Visible = false;
                iconReporteIngreso.Visible = false;
                iconReporteSalida.Visible = false;
                iconReporteVenta.Visible = false;
                iconSeguridad.Visible = false;
                iconGestionarUsuarios.Visible = false;
                iconGestionarGrupos.Visible = false;
                iconDatosPersonales.Visible = false;
                iconAuditoria.Visible = false;
                iconAuditoriasIngresos.Visible = false;
                iconAuditoriasSalidas.Visible = false;
                iconAuditoriasVentas.Visible = false;
                iconAuditoriasInicioDeSesion.Visible = false;

                MessageBox.Show("No tiene permisos para acceder a esta sección.");
            }
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.White;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        public void ActualizarBienvenido()
        {
            lblBienvenido.Text = string.Empty;
            lblBienvenido.Text = "Bienvenido: " + usuario.Apellido + " " + usuario.Nombre;
        }

        private void iconAgricultores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormAgricultores());
            RegistrarActividad();
            ActualizarBienvenido();
        }

        private void iconIndustrias_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormIndustrias());
            RegistrarActividad();
            ActualizarBienvenido();
        }

        private void iconClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormClientes());
            RegistrarActividad();
            ActualizarBienvenido();
        }

        private void iconSemillas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormSemillas());
            RegistrarActividad();
            ActualizarBienvenido();
        }

        private void iconTransporte_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormTransportes());
            RegistrarActividad();
            ActualizarBienvenido();
        }

        private void iconTransporte1_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormTransportes());
            RegistrarActividad();
            ActualizarBienvenido();
        }

        private void iconProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormProductos());
            ActualizarBienvenido();
        }


        private void iconRegistroIngresos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormIngresos(usuario));
            RegistrarActividad();
            ActualizarBienvenido();
        }

        private void iconRegistroSalida_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormSalidas(usuario));
            RegistrarActividad();
            ActualizarBienvenido();
        }

        private void iconRegistroVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormVentas(usuario));
            RegistrarActividad();
            ActualizarBienvenido();
        }

        private void iconReporteIngreso_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormReporteIngreso());
            RegistrarActividad();
            ActualizarBienvenido();
        }

        private void iconReporteSalida_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormReporteSalida());
            RegistrarActividad();
            ActualizarBienvenido();
        }

        private void iconReporteVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormReporteVenta());
            RegistrarActividad();
            ActualizarBienvenido();
        }

        private void iconGestionarUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormUsuarios());
            RegistrarActividad();
            ActualizarBienvenido();
        }

        private void iconGestionarGrupos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormGrupos());
            RegistrarActividad();
            ActualizarBienvenido();
        }

        private void iconDatosPersonales_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormDatosUsuarios(usuario));
            RegistrarActividad();
            ActualizarBienvenido();
        }

        private void iconAuditoriasIngresos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormAuditoriasIngresos());
            RegistrarActividad();
            ActualizarBienvenido();
        }

        private void iconAuditoriasSalidas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormAuditoriasSalidas());
            RegistrarActividad();
            ActualizarBienvenido();
        }

        private void iconAuditoriasVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormAuditoriasVentas());
            RegistrarActividad();
            ActualizarBienvenido();
        }

        private void iconAuditoriasInicioDeSesion_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormAuditoriasLogIn_LogOut());
            RegistrarActividad();
            ActualizarBienvenido();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            timerInactividad.Stop();
            AuditarLogInLogOut();
            var formLogin = new Login();
            formLogin.ShowDialog();
        }

        private void iconLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            var formLogin = new Login();
            formLogin.ShowDialog();
        }

        public void AuditarLogInLogOut()
        {
            var auditoriaLogInLogOut = new AuditoriaLogInLogOut
            {
                Usuario = usuario,
                TipoAuditoria = "Cierre de Sesión",
                FechayHora = DateTime.Now,
            };

            ControladoraAuditoriaLogIn_LogOut.Instancia.Agregar(auditoriaLogInLogOut);
        }

        public void RegistrarActividad()
        {
            ultimaActividad = DateTime.Now;
        }

        private void TimerInactividad_Tick(object sender, EventArgs e)
        {
            if ((DateTime.Now - ultimaActividad).TotalMilliseconds > TiempoInactividadMaximo)
            {
                timerInactividad.Stop();
                this.Close();
            }
        }

        public void SetTimer()
        {
            timerInactividad = new System.Windows.Forms.Timer();
            timerInactividad.Interval = 1000;
            timerInactividad.Tick += TimerInactividad_Tick;
            timerInactividad.Start();
            ultimaActividad = DateTime.Now;
        }        
    }
}
