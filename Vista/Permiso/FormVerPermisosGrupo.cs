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
    public partial class FormVerPermisosGrupo : Form
    {
        private Grupo grupo;

        public FormVerPermisosGrupo(Grupo grupo)
        {
            InitializeComponent();
            this.grupo = grupo;
        }

        private void FormVerPermisosGrupo_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            Controladora.Controladoras_Seguridad.ControladoraPermisos.Instancia.ListarPermisos();
            dgvPermisosGrupo.DataSource = null;
            if (grupo.GrupoPermisos != null)
            {
                var permisos = grupo.Mostrar();
                dgvPermisosGrupo.DataSource = permisos;
                dgvPermisosGrupo.Columns["Id"].Visible = false;
                dgvPermisosGrupo.Columns["Nombre"].Width = 520;
            }
        }

        private void iconEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPermisosGrupo.CurrentRow != null)
            {
                var permisoSeleccionado = (Permiso)dgvPermisosGrupo.CurrentRow.DataBoundItem;

                DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el permiso seleccionado del grupo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    grupo.Eliminar(permisoSeleccionado);

                    var mensaje = Controladora.Controladoras_Seguridad.ControladoraGrupos.Instancia.Modificar(grupo);

                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un permiso que eliminar");
            }
        }

        private void iconVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
