using Controladora.Controladoras_Seguridad;
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
    public partial class FormGestionarGruposUsuario : Form
    {
        Contexto contexto = Modelo.GContext.ObtenerContexto();
        private Usuario usuario;

        public FormGestionarGruposUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FormGestionarGruposUsuario_Load(object sender, EventArgs e)
        {
            cbGrupos.Items.Clear();

            var grupos = contexto.Grupos.ToList();
            foreach (var grupo in grupos)
            {
                cbGrupos.Items.Add(grupo);
            }
        }

        private bool ValidarDatos()
        {
            if (cbGrupos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un grupo");
                return false;
            }

            return true;
        }

        private void iconAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            Grupo grupo = contexto.Grupos.FirstOrDefault(p => p.Nombre == cbGrupos.Text);

            if (grupo != null)
            {
                usuario.AgregarPermisoCompuesto(grupo);

                var mensaje = ControladoraUsuarios.Instancia.Modificar(usuario);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Grupo no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void iconCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
