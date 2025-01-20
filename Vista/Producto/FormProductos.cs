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
    public partial class FormProductos : Form
    {
        private SaveFileDialog saveFileDialog;

        public FormProductos()
        {
            InitializeComponent();
            ActualizarGrilla();
            ExcelConfig();            
        }

        public void ActualizarGrilla()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = Controladora.ControladoraProductos.Instancia.ListarProductos();
            DgvConfig();            
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void iconAgregar_Click(object sender, EventArgs e)
        {
            var formProducto = new FormProducto();
            formProducto.ShowDialog();
            ActualizarGrilla();
        }

        private void iconModificar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                var productoSeleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                var formProducto = new FormProducto(productoSeleccionado);
                formProducto.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto que modificar");
            }
        }

        private void iconEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                var productoSeleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el producto seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    var mensaje = Controladora.ControladoraProductos.Instancia.Eliminar(productoSeleccionado);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto que eliminar");
            }
        }

        private void iconExportarExcel_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Confirma que desea exportar los productos a excel?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Controladora.ControladoraProductos.Instancia.ExportarAExcel(saveFileDialog.FileName);
                    MessageBox.Show("Datos de Productos exportados con éxito");
                }
            }
        }

        public void ExcelConfig()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar como Excel";
            saveFileDialog.FileName = "Productos";
        }

        public void DgvConfig()
        {
            dgvProductos.Columns["ProductoID"].Visible = false;

            dgvProductos.Columns["Codigo"].Width = 206;
            dgvProductos.Columns["Codigo"].DisplayIndex = 0;

            dgvProductos.Columns["Nombre"].Width = 206;
            dgvProductos.Columns["Nombre"].DisplayIndex = 1;

            dgvProductos.Columns["Marca"].Width = 206;
            dgvProductos.Columns["Marca"].DisplayIndex = 2;

            dgvProductos.Columns["Stock"].Width = 206;
            dgvProductos.Columns["Stock"].DisplayIndex = 3;

            dgvProductos.Columns["PrecioUnidad"].Width = 206;
            dgvProductos.Columns["PrecioUnidad"].DisplayIndex = 4;
        }
    }
}
