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
using ClosedXML.Excel;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;


namespace Vista
{
    public partial class FormAgricultores : Form
    {
        private SaveFileDialog saveFileDialog;

        public FormAgricultores()
        {
            InitializeComponent();
            ActualizarGrilla();
            ExcelConfig();            
        }

        public void ActualizarGrilla()
        {
            dgvAgricultores.DataSource = null;
            dgvAgricultores.DataSource = Controladora.ControladoraAgricultores.Instancia.ListarAgricultores();
            DgvConfig();            
        }

        private void FormAgricultores_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void iconAgregar_Click(object sender, EventArgs e)
        {
            var formAgricultor = new FormAgricultor();
            formAgricultor.ShowDialog();
            ActualizarGrilla();
        }

        private void iconModificar_Click(object sender, EventArgs e)
        {
            if (dgvAgricultores.CurrentRow != null)
            {
                var agricultorSeleccionado = (Agricultor)dgvAgricultores.CurrentRow.DataBoundItem;
                var formAgricultor = new FormAgricultor(agricultorSeleccionado);
                formAgricultor.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un agricultor que modificar");
            }
        }

        private void iconEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAgricultores.CurrentRow != null)
            {
                var agricultorSeleccionado = (Agricultor)dgvAgricultores.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el agricultor seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    var mensaje = Controladora.ControladoraAgricultores.Instancia.Eliminar(agricultorSeleccionado);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un agricultor que eliminar");
            }
        }

        private void iconAgregarTransportes_Click(object sender, EventArgs e)
        {
            if (dgvAgricultores.CurrentRow != null)
            {
                var agricultorSeleccionado = (Agricultor)dgvAgricultores.CurrentRow.DataBoundItem;
                var formTransporte = new FormTransporte(agricultorSeleccionado);
                formTransporte.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un agricultor para agregar transportes");
            }
        }

        private void iconVerTransportes_Click(object sender, EventArgs e)
        {
            if (dgvAgricultores.CurrentRow != null)
            {
                var agricultorSeleccionado = (Agricultor)dgvAgricultores.CurrentRow.DataBoundItem;
                var formClienteTransporte = new FormClienteTransporte(agricultorSeleccionado);
                formClienteTransporte.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un agricultor el cual desee ver sus transportes");
            }
        }

        private void iconExportarExcel_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Confirma que desea exportar los agricultores a excel?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Controladora.ControladoraAgricultores.Instancia.ExportarAExcel(saveFileDialog.FileName);
                    MessageBox.Show("Datos de Agricultores exportados con éxito");
                }
            }
            
        }

        public void ExcelConfig()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar como Excel";
            saveFileDialog.FileName = "Agricultores";
        }

        public void DgvConfig()
        {
            dgvAgricultores.Columns["AgricultorID"].Visible = false;

            dgvAgricultores.Columns["Nombre"].Width = 172;
            dgvAgricultores.Columns["Nombre"].DisplayIndex = 0;

            dgvAgricultores.Columns["Apellido"].Width = 172;
            dgvAgricultores.Columns["Apellido"].DisplayIndex = 1;

            dgvAgricultores.Columns["Dni"].Width = 172;
            dgvAgricultores.Columns["Dni"].DisplayIndex = 2;

            dgvAgricultores.Columns["NroCuit"].Width = 172;
            dgvAgricultores.Columns["NroCuit"].DisplayIndex = 3;

            dgvAgricultores.Columns["Direccion"].Width = 172;
            dgvAgricultores.Columns["Direccion"].DisplayIndex = 4;

            dgvAgricultores.Columns["Telefono"].Width = 172;
            dgvAgricultores.Columns["Telefono"].DisplayIndex = 5;
        }
    }
}
