using Controladora.Controladoras_Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Modelo.Auditorias;
using Controladora;

namespace Vista
{
    public partial class Login : Form
    {
        private AuditoriaLogInLogOut auditoriaLogInLogOut;
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int dni;
            if (!int.TryParse(txtDni.Text, out dni))
            {
                MessageBox.Show("Ingrese un DNI válido");
                return;
            }

            string contraseña = txtClave.Text;
            Usuario UsuarioAutenticado = Controladora.Controladoras_Seguridad.ControladoraUsuarios.Instancia.Autenticar(dni, contraseña);

            if (UsuarioAutenticado != null)
            {
                DialogResult = DialogResult.OK;
                this.Hide();

                var auditoriaLogInLogOut = new AuditoriaLogInLogOut
                {
                    Usuario = UsuarioAutenticado,
                    TipoAuditoria = "Inicio de Sesión",
                    FechayHora = DateTime.Now,
                };

                ControladoraAuditoriaLogIn_LogOut.Instancia.Agregar(auditoriaLogInLogOut);

                var formMenu = new Menu(UsuarioAutenticado);
                formMenu.ShowDialog();                
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
