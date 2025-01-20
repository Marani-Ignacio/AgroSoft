using iTextSharp.text;
using Microsoft.EntityFrameworkCore;
using Modelo;
using Modelo.Auditorias;
using Modelo.Entidades;
using Modelo.Seguridad;
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
    public partial class FormConsultarUsuario : Form
    {
        private AuditoriaLogInLogOut auditoriaLogInLogOut;
        private Contexto contexto = Modelo.GContext.ObtenerContexto();
        public FormConsultarUsuario(AuditoriaLogInLogOut auditoriaLogInLogOut)
        {
            InitializeComponent();
            this.auditoriaLogInLogOut = auditoriaLogInLogOut;
        }

        private void FormConsultarUsuario_Load(object sender, EventArgs e)
        {

            txtApellido.Text = auditoriaLogInLogOut.Usuario.Apellido;
            txtNombre.Text = auditoriaLogInLogOut.Usuario.Nombre;
            txtDni.Text = auditoriaLogInLogOut.Usuario.Dni.ToString();

            dgvPermisos.DataSource = null;
            dgvGrupos.DataSource = null;
            List<UsuarioComponentes> permisos = new List<UsuarioComponentes>();
            List<UsuarioComponentes> grupos = new List<UsuarioComponentes>();

            var usuario = contexto.Usuarios.Include(u => u.UsuarioComponentes).ThenInclude(uc => uc.Componente).Include(u => u.UsuarioComponentes).ThenInclude(uc => uc.Componente).ThenInclude(c => (c as Grupo).GrupoPermisos).ThenInclude(gp => gp.Permiso);
            foreach (var componente in auditoriaLogInLogOut.Usuario.UsuarioComponentes)
            {
                if (componente.Componente is Permiso)
                {
                    permisos.Add(componente);
                }
                else if (componente.Componente is Grupo)
                {
                    grupos.Add(componente);
                }
            }
            Controladora.Controladoras_Seguridad.ControladoraPermisos.Instancia.ListarPermisos();
            Controladora.Controladoras_Seguridad.ControladoraGrupos.Instancia.ListarGrupos();
            dgvPermisos.DataSource = permisos.ToList();
            dgvGrupos.DataSource = grupos.ToList();
            DgvConfig();
        }

        public void DgvConfig()
        {
            dgvPermisos.Columns["Id"].Visible = false;
            dgvGrupos.Columns["Id"].Visible = false;

            dgvPermisos.Columns["ComponenteId"].Visible = false;
            dgvGrupos.Columns["ComponenteId"].Visible = false;

            dgvPermisos.Columns["UsuarioId"].Visible = false;
            dgvGrupos.Columns["UsuarioId"].Visible = false;

            dgvPermisos.Columns["Usuario"].Visible = false;
            dgvGrupos.Columns["Usuario"].Visible = false;

            dgvPermisos.Columns["Componente"].Width = 400;
            dgvGrupos.Columns["Componente"].Width = 400;

        }
    }
}
