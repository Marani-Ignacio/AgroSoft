using Controladora;
using Microsoft.Win32;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;

namespace Vista
{
    public partial class FormIndustrias : Form
    {
        private SaveFileDialog saveFileDialog;

        public FormIndustrias()
        {
            InitializeComponent();
            ActualizarGrilla();
            ExcelConfig();            
        }

        public void ActualizarGrilla()
        {
            dgvIndustrias.DataSource = null;
            dgvIndustrias.DataSource = Controladora.ControladoraIndustrias.Instancia.ListarIndustrias();
            DgvConfig();            
        }
        private void FormIndustrias_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void iconAgregar_Click(object sender, EventArgs e)
        {
            var formIndustria = new FormIndustria();
            formIndustria.ShowDialog();
            ActualizarGrilla();
        }

        private void iconModificar_Click(object sender, EventArgs e)
        {
            if (dgvIndustrias.CurrentRow != null)
            {
                var industriaSeleccionada = (Industria)dgvIndustrias.CurrentRow.DataBoundItem;
                var formIndustria = new FormIndustria(industriaSeleccionada);
                formIndustria.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar uns industria que modificar");
            }
        }

        private void iconEliminar_Click(object sender, EventArgs e)
        {
            if (dgvIndustrias.CurrentRow != null)
            {
                var industriaSeleccionada = (Industria)dgvIndustrias.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar la industria seleccionada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    var mensaje = Controladora.ControladoraIndustrias.Instancia.Eliminar(industriaSeleccionada);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una industria que eliminar");
            }
        }

        private void iconAgregarTransportes_Click(object sender, EventArgs e)
        {
            if (dgvIndustrias.CurrentRow != null)
            {
                var industriaSeleccionada = (Industria)dgvIndustrias.CurrentRow.DataBoundItem;
                var formTransporte = new FormTransporte(industriaSeleccionada);
                formTransporte.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una industria para agregar transportes");
            }
        }

        private void iconVerTransportes_Click(object sender, EventArgs e)
        {
            if (dgvIndustrias.CurrentRow != null)
            {
                var industriaSeleccionada = (Industria)dgvIndustrias.CurrentRow.DataBoundItem;
                var formClienteTransporte = new FormClienteTransporte(industriaSeleccionada);
                formClienteTransporte.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una industria la cual desee ver sus transportes");
            }
        }

        private void iconExportarExcel_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Confirma que desea exportar las industrias a excel?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Controladora.ControladoraIndustrias.Instancia.ExportarAExcel(saveFileDialog.FileName);
                    MessageBox.Show("Datos de Industrias exportados con éxito");
                }
            }
        }

        public void ExcelConfig()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar como Excel";
            saveFileDialog.FileName = "Industrias";
        }

        public void DgvConfig()
        {
            dgvIndustrias.Columns["IndustriaID"].Visible = false;

            dgvIndustrias.Columns["Cuil"].Width = 258;
            dgvIndustrias.Columns["Cuil"].DisplayIndex = 0;

            dgvIndustrias.Columns["Nombre"].Width = 258;
            dgvIndustrias.Columns["Nombre"].DisplayIndex = 1;

            dgvIndustrias.Columns["Direccion"].Width = 258;
            dgvIndustrias.Columns["Direccion"].DisplayIndex = 2;

            dgvIndustrias.Columns["Telefono"].Width = 258;
            dgvIndustrias.Columns["Telefono"].DisplayIndex = 3;
        }
    }
}
