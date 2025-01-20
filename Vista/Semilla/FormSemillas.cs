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
    public partial class FormSemillas : Form
    {
        private SaveFileDialog saveFileDialog;

        public FormSemillas()
        {
            InitializeComponent();
            ActualizarGrilla();
            ExcelConfig();
        }

        public void ActualizarGrilla()
        {
            dgvSemillas.DataSource = null;
            dgvSemillas.DataSource = Controladora.ControladoraSemillas.Instancia.ListarSemillas();
            DgvConfig();            
        }

        private void FormSemillas_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void iconAgregar_Click(object sender, EventArgs e)
        {
            var formSemilla = new FormSemilla();
            formSemilla.ShowDialog();
            ActualizarGrilla();
        }

        private void iconModificar_Click(object sender, EventArgs e)
        {
            if (dgvSemillas.CurrentRow != null)
            {
                var semillaSeleccionada = (Semilla)dgvSemillas.CurrentRow.DataBoundItem;
                var formSemilla = new FormSemilla(semillaSeleccionada);
                formSemilla.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una semilla que modificar");
            }
        }

        private void iconEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSemillas.CurrentRow != null)
            {
                var semillaSeleccionada = (Semilla)dgvSemillas.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar la semilla seleccionada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    var mensaje = Controladora.ControladoraSemillas.Instancia.Eliminar(semillaSeleccionada);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una semilla que eliminar");
            }
        }

        private void iconExportarExcel_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Confirma que desea exportar los semillas a excel?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Controladora.ControladoraSemillas.Instancia.ExportarAExcel(saveFileDialog.FileName);
                    MessageBox.Show("Datos de Semillas exportados con éxito");
                }
            }
        }

        public void ExcelConfig()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar como Excel";
            saveFileDialog.FileName = "Semillas";
        }

        public void DgvConfig()
        {
            dgvSemillas.Columns["SemillaID"].Visible = false;

            dgvSemillas.Columns["Codigo"].Width = 172;
            dgvSemillas.Columns["Codigo"].DisplayIndex = 0;

            dgvSemillas.Columns["Nombre"].Width = 172;
            dgvSemillas.Columns["Nombre"].DisplayIndex = 1;

            dgvSemillas.Columns["Clase"].Width = 172;
            dgvSemillas.Columns["Clase"].DisplayIndex = 2;

            dgvSemillas.Columns["Cantidad"].Width = 172;
            dgvSemillas.Columns["Cantidad"].DisplayIndex = 3;

            dgvSemillas.Columns["PrecioToneladaCompra"].Width = 172;
            dgvSemillas.Columns["PrecioToneladaCompra"].DisplayIndex = 4;

            dgvSemillas.Columns["PrecioToneladaVenta"].Width = 172;
            dgvSemillas.Columns["PrecioToneladaVenta"].DisplayIndex = 5;
        }
    }
}
