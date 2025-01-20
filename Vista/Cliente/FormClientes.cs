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
    public partial class FormClientes : Form
    {
        private SaveFileDialog saveFileDialog;

        public FormClientes()
        {
            InitializeComponent();
            ActualizarGrilla();
            ExcelConfig();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = Controladora.ControladoraClientes.Instancia.ListarClientes();
            DgvConfig();
        }

        private void iconAgregar_Click(object sender, EventArgs e)
        {
            var formCliente = new FormCliente();
            formCliente.ShowDialog();
            ActualizarGrilla();
        }

        private void iconModificar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                var clienteSeleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                var formCliente = new FormCliente(clienteSeleccionado);
                formCliente.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente que modificar");
            }
        }

        private void iconEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                var clienteSeleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el cliente seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    var mensaje = Controladora.ControladoraClientes.Instancia.Eliminar(clienteSeleccionado);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente que eliminar");
            }
        }

        private void iconExportarExcel_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Confirma que desea exportar los clientes a excel?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ControladoraClientes.Instancia.ExportarAExcel(saveFileDialog.FileName);
                    MessageBox.Show("Datos de Clientes exportados con éxito");
                }
            }
        }

        public void ExcelConfig()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar como Excel";
            saveFileDialog.FileName = "Clientes";
        }

        public void DgvConfig()
        {
            dgvClientes.Columns["ClienteID"].Visible = false;

            dgvClientes.Columns["Nombre"].Width = 146;
            dgvClientes.Columns["Nombre"].DisplayIndex = 0;

            dgvClientes.Columns["Apellido"].Width = 146;
            dgvClientes.Columns["Apellido"].DisplayIndex = 1;

            dgvClientes.Columns["Dni"].Width = 146;
            dgvClientes.Columns["Dni"].DisplayIndex = 2;

            dgvClientes.Columns["NroCuit"].Width = 146;
            dgvClientes.Columns["NroCuit"].DisplayIndex = 3;

            dgvClientes.Columns["Direccion"].Width = 146;
            dgvClientes.Columns["Direccion"].DisplayIndex = 4;

            dgvClientes.Columns["CodPostal"].Width = 146;
            dgvClientes.Columns["CodPostal"].DisplayIndex = 5;

            dgvClientes.Columns["Telefono"].Width = 146;
            dgvClientes.Columns["Telefono"].DisplayIndex = 6;
        }
    }
}
