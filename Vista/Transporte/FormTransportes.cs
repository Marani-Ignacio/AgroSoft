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
    public partial class FormTransportes : Form
    {
        private SaveFileDialog saveFileDialog;

        public FormTransportes()
        {
            InitializeComponent();
            ActualizarGrilla();
            ExcelConfig();
        }

        public void ActualizarGrilla()
        {
            dgvTransportes.DataSource = null;
            dgvTransportes.DataSource = Controladora.ControladoraTransportes.Instancia.ListarTransportes();
            DgvConfig();            
        }

        private void FormTransportes_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void iconAgregar_Click(object sender, EventArgs e)
        {
            var formTransporte = new FormTransporte();
            formTransporte.ShowDialog();
            ActualizarGrilla();
        }

        private void iconModificar_Click(object sender, EventArgs e)
        {
            if (dgvTransportes.CurrentRow != null)
            {
                var transporteSeleccionado = (Transporte)dgvTransportes.CurrentRow.DataBoundItem;
                var formTransporte = new FormTransporte(transporteSeleccionado);
                formTransporte.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un transporte que modificar");
            }
        }

        private void iconEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTransportes.CurrentRow != null)
            {
                var transporteSeleccionado = (Transporte)dgvTransportes.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el transporte seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    var mensaje = Controladora.ControladoraTransportes.Instancia.Eliminar(transporteSeleccionado);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un transporte que eliminar");
            }
        }

        private void iconExportarExcel_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Confirma que desea exportar los transportes a excel?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ControladoraTransportes.Instancia.ExportarAExcel(saveFileDialog.FileName);
                    MessageBox.Show("Datos de Transportes exportados con éxito");
                }
            }
        }

        public void ExcelConfig()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar como Excel";
            saveFileDialog.FileName = "Transportes";
        }

        public void DgvConfig()
        {
            dgvTransportes.Columns["TransporteID"].Visible = false;

            dgvTransportes.Columns["Patente"].Width = 258;
            dgvTransportes.Columns["Patente"].DisplayIndex = 0;

            dgvTransportes.Columns["Marca"].Width = 258;
            dgvTransportes.Columns["Marca"].DisplayIndex = 1;

            dgvTransportes.Columns["Modelo"].Width = 258;
            dgvTransportes.Columns["Modelo"].DisplayIndex = 2;

            dgvTransportes.Columns["Tara"].Width = 258;
            dgvTransportes.Columns["Tara"].DisplayIndex = 3;
        }
    }
}
