using Controladora;
using Microsoft.EntityFrameworkCore;
using Modelo;
using Modelo.Entidades;
using Modelo.Auditorias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Vista.Reportes;
using ClosedXML.Excel;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;
using iTextSharp.text;


namespace Vista
{
    public partial class FormVentas : Form
    {
        private SaveFileDialog saveFileDialog;
        private Usuario usuario;

        public FormVentas(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            ActualizarGrilla();
            ExcelConfig();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = Controladora.ControladoraVentas.Instancia.ListarVentas();
            OcultarID();
        }

        private void btnNuevoIngreso_Click(object sender, EventArgs e)
        {
            var formCargarVenta = new FormCargarVenta(usuario);
            formCargarVenta.ShowDialog();
            ActualizarGrilla();
        }

        private void iconEliminarRegistro_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
            {
                var ventaSeleccionada = (Venta)dgvVentas.CurrentRow.DataBoundItem;

                DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el registro de venta seleccionado de la base de datos?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    var mensaje = Controladora.ControladoraVentas.Instancia.Eliminar(ventaSeleccionada);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();

                    if (mensaje == "Registro de venta eliminado con éxito")
                    {

                        var auditoriaVenta = new AuditoriaVenta
                        {
                            Codigo = ventaSeleccionada.Codigo,
                            Fecha = ventaSeleccionada.Fecha,
                            Cliente = ventaSeleccionada.Cliente,
                            DetallesVenta = ventaSeleccionada.DetallesVenta,
                            PrecioTotal = ventaSeleccionada.PrecioTotal,

                            Usuario = usuario,
                            TipoAuditoria = "Baja Registro Venta",
                            FechayHora = DateTime.Now,
                        };

                        Controladora.ControladoraAuditoriaVenta.Instancia.Agregar(auditoriaVenta);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro de venta que eliminar");
            }
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var ventaSeleccionada = (Venta)dgvVentas.Rows[e.RowIndex].DataBoundItem;

                using (var contexto = new Contexto())
                {
                    var instancia = Controladora.ControladoraProductos.Instancia.ListarProductos();
                    var cliente = contexto.Clientes.FirstOrDefault(c => c.ClienteID == ventaSeleccionada.Cliente.ClienteID);

                    dgvDatosCliente.DataSource = new List<Object> { cliente };
                    dgvDetalleVenta.DataSource = ventaSeleccionada.DetallesVenta.ToList();
                    DgvConfig();
                }
            }
        }

        public void OcultarID()
        {
            dgvVentas.Columns["VentaID"].Visible = false;
            dgvVentas.Columns["ClienteID"].Visible = false;
        }

        public void DgvConfig()
        {
            dgvDatosCliente.Columns["ClienteID"].Visible = false;

            dgvDetalleVenta.Columns["DetalleVentaID"].Visible = false;
            dgvDetalleVenta.Columns["ProductoID"].Visible = false;
            dgvDatosCliente.Columns["Dni"].Visible = false;
            dgvDatosCliente.Columns["CodPostal"].Visible = false;

            dgvDatosCliente.Columns["Nombre"].Width = 100;
            dgvDatosCliente.Columns["Nombre"].DisplayIndex = 0;

            dgvDatosCliente.Columns["Apellido"].Width = 100;
            dgvDatosCliente.Columns["Apellido"].DisplayIndex = 1;

            dgvDatosCliente.Columns["NroCuit"].Width = 110;
            dgvDatosCliente.Columns["NroCuit"].DisplayIndex = 2;

            dgvDatosCliente.Columns["Telefono"].Width = 95;
            dgvDatosCliente.Columns["Telefono"].DisplayIndex = 3;

            dgvDatosCliente.Columns["Direccion"].Width = 110;
            dgvDatosCliente.Columns["Direccion"].DisplayIndex = 4;

            dgvDetalleVenta.Columns["Producto"].Width = 330;
            dgvDetalleVenta.Columns["Cantidad"].Width = 90;
            dgvDetalleVenta.Columns["PrecioParcial"].Width = 95;
        }

        private void iconComprobante_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
            {
                var ventaSeleccionada = (Venta)dgvVentas.CurrentRow.DataBoundItem;
                var formComprobante = new FormComprobante(ventaSeleccionada);
                formComprobante.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una venta para generar el comprobante");
            }
        }

        private void iconExportarExcel_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Confirma que desea exportar las ventas a excel?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Controladora.ControladoraVentas.Instancia.ExportarAExcel(saveFileDialog.FileName);
                    MessageBox.Show("Datos de Ventas exportados con éxito");
                }
            }
        }

        public void ExcelConfig()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar como Excel";
            saveFileDialog.FileName = "Ventas";
        }
    }
}
