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
    public partial class FormGestionarPermisosGrupo : Form
    {
        Contexto contexto = Modelo.GContext.ObtenerContexto();
        private Grupo grupo;

        public FormGestionarPermisosGrupo(Grupo grupo)
        {
            InitializeComponent();
            this.grupo = grupo;
        }

        private void FormGestionarPermisosGrupo_Load(object sender, EventArgs e)
        {
            cbPermisos.Items.Clear();

            var permisos = contexto.Permisos.ToList();
            foreach (var permiso in permisos)
            {
                cbPermisos.Items.Add(permiso);
            }
        }

        private bool ValidarDatos()
        {
            if (cbPermisos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un permiso");
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

            Permiso permiso = contexto.Permisos.FirstOrDefault(p => p.Nombre == cbPermisos.Text);

            grupo.Agregar(permiso);
            var mensaje = ControladoraGrupos.Instancia.Modificar(grupo);
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void iconCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
