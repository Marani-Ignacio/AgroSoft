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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;
using DocumentFormat.OpenXml.Presentation;
using Modelo;
using Modelo.Decoradores;

namespace Vista.Reportes
{
    public partial class FormComprobante : Form
    {
        private SaveFileDialog saveFileDialog;
        private Venta venta;
        public FormComprobante(Venta venta)
        {
            InitializeComponent();
            this.venta = venta;
            PdfConfig();

            lblComprobante.Text = "Nro Comprobante:  " + venta.Codigo.ToString();
            lblFecha.Text = "Fecha:  " + venta.Fecha.ToString("dd/MM/yyyy");
            lblCliente.Text = venta.Cliente + " -- " + "Cuit:  " + venta.Cliente.NroCuit + " -- " + "Dirección:  " + venta.Cliente.Direccion + " -- " + "Cod Postal:  " + venta.Cliente.CodPostal;

            var listaProductos = venta.DetallesVenta;
            foreach ( var producto in listaProductos )
            {
                lblProducto.Text += producto.Producto + "\n";
                lblCantidad.Text += producto.Cantidad.ToString() + "\n";
                lblPrecio.Text += producto.PrecioParcial.ToString() + "\n";
            }

            lblTotal.Text = venta.PrecioTotal.ToString();
        }

        private void iconPDF_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Documento documento = new Comprobante(venta);
                documento = new Exportar(documento);
                documento.ExportToPDF(saveFileDialog.FileName);
                MessageBox.Show("Comprobante guardado con éxito");
            }
        }
        
        public void PdfConfig()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pdf files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar como Pdf";
            saveFileDialog.FileName = "ComprobanteNro_" + venta.Codigo.ToString();
        }
    }
}
