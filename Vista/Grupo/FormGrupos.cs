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
    public partial class FormGrupos : Form
    {
        public FormGrupos()
        {
            InitializeComponent();
        }

        public void ActualizarGrilla()
        {
            dgvGrupos.DataSource = null;
            dgvGrupos.DataSource = Controladora.Controladoras_Seguridad.ControladoraGrupos.Instancia.ListarGrupos();
            DgvConfig();
        }

        private void FormGrupos_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void iconAgregar_Click(object sender, EventArgs e)
        {
            var formGrupo = new FormGrupo();
            formGrupo.ShowDialog();
            ActualizarGrilla();
        }

        private void iconModificar_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.CurrentRow != null)
            {
                var grupoSeleccionado = (Grupo)dgvGrupos.CurrentRow.DataBoundItem;
                var formGrupo = new FormGrupo(grupoSeleccionado);
                formGrupo.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un grupo que modificar");
            }
        }

        private void iconEliminar_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.CurrentRow != null)
            {
                var grupoSeleccionado = (Grupo)dgvGrupos.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Confima que desea eliminar el grupo seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    var mensaje = Controladora.Controladoras_Seguridad.ControladoraGrupos.Instancia.Eliminar(grupoSeleccionado);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un grupo que eliminar");
            }
        }

        private void iconAgregarPermisos_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.CurrentRow != null)
            {
                var grupoSeleccionado = (Grupo)dgvGrupos.CurrentRow.DataBoundItem;
                var formPermisoGrupo = new FormGestionarPermisosGrupo(grupoSeleccionado);
                formPermisoGrupo.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un grupo para agregar permiso");
            }
        }

        private void iconVerPermisos_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.CurrentRow != null)
            {
                var grupoSeleccionado = (Grupo)dgvGrupos.CurrentRow.DataBoundItem;
                var formVerPermisos = new FormVerPermisosGrupo(grupoSeleccionado);
                formVerPermisos.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un grupo para ver permisos");
            }
        }

        public void DgvConfig()
        {
            dgvGrupos.Columns["Id"].Visible = false;

            dgvGrupos.Columns["Nombre"].DisplayIndex = 0;
            dgvGrupos.Columns["Nombre"].Width = 200;

            dgvGrupos.Columns["Descripcion"].DisplayIndex = 1;
            dgvGrupos.Columns["Descripcion"].Width = 832;
        }
    }
}
