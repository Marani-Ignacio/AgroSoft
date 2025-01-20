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

namespace Vista
{
    public partial class FormCartadePorte : Form
    {
        private SaveFileDialog saveFileDialog;
        string tipoCodigo = "";

        private Ingreso ingreso;
        private Salida salida;

        public FormCartadePorte(Ingreso ingreso)
        {
            InitializeComponent();
            this.ingreso = ingreso;
            tipoCodigo = "Ingreso";
            PdfConfig();

            lblAgriIndu.Text = "Datos del Agricultor";
            lblNombre.Text = "Nombre:  " + ingreso.Agricultor.Nombre;
            lblApellido.Text = "Apellido:  " + ingreso.Agricultor.Apellido;
            lblCuit.Text = "CUIT Nro:  " + ingreso.Agricultor.NroCuit;
            lblDireccion.Text = "Dirección:  " + ingreso.Agricultor.Direccion;

            lblCodigoSemilla.Text = "Codigo:  " + ingreso.Semilla.Codigo;
            lblNombreSemilla.Text = "Nombre:  " + ingreso.Semilla.Nombre;
            lblClaseSemilla.Text = "Clase:  " + ingreso.Semilla.Clase;
            lblPrecioSemilla.Text = "Precio x Tonelada:  $" + ingreso.Semilla.PrecioToneladaCompra;

            lblPatenteTransporte.Text = "Patente:  " + ingreso.Transporte.Patente;
            lblMarcaTransporte.Text = "Marca:  " + ingreso.Transporte.Marca;
            lblModeloTransporte.Text = "Modelo:  " + ingreso.Transporte.Modelo;
            lblTaraTransporte.Text = "Tara:  " + ingreso.Transporte.Tara + "kg";

            lblIngresoSalida.Text = "Datos del Ingreso";
            lblCodigoIS.Text = "Codigo:  " + ingreso.Codigo;
            lblFechaIS.Text = "Fecha: " + ingreso.Fecha.ToString("dd/MM/yyyy");
            lblCantidadIS.Text = "Cantidad:  " + ingreso.Cantidad + "kg";
            lblPrecioTotalIS.Text = "Precio Total:  $" + ingreso.PrecioTotal;
        }

        public FormCartadePorte(Salida salida)
        {
            InitializeComponent();
            this.salida = salida;
            tipoCodigo = "Salida";
            PdfConfig();

            lblAgriIndu.Text = "Datos de la Industria";
            lblNombre.Text = "CUIL Nro:  " + salida.Industria.Cuil;
            lblApellido.Text = "Nombre:  " + salida.Industria.Nombre;
            lblDireccion.Text = "Dirección:  " + salida.Industria.Direccion;
            lblCuit.Text = "Teléfono:  " + salida.Industria.Telefono;

            lblCodigoSemilla.Text = "Codigo:  " + salida.Semilla.Codigo;
            lblNombreSemilla.Text = "Nombre:  " + salida.Semilla.Nombre;
            lblClaseSemilla.Text = "Clase:  " + salida.Semilla.Clase;
            lblPrecioSemilla.Text = "Precio x Tonelada:  $" + salida.Semilla.PrecioToneladaVenta;

            lblPatenteTransporte.Text = "Patente:  " + salida.Transporte.Patente;
            lblMarcaTransporte.Text = "Marca:  " + salida.Transporte.Marca;
            lblModeloTransporte.Text = "Modelo:  " + salida.Transporte.Modelo;
            lblTaraTransporte.Text = "Tara:  " + salida.Transporte.Tara + "kg";

            lblIngresoSalida.Text = "Datos de la Salida";
            lblCodigoIS.Text = "Codigo:  " + salida.Codigo;
            lblFechaIS.Text = "Fecha: " + salida.Fecha.ToString("dd/MM/yyyy");
            lblCantidadIS.Text = "Cantidad:  " + salida.Cantidad + "kg";
            lblPrecioTotalIS.Text = "Precio Total:  $" + salida.PrecioTotal;
        }

        private void iconPDF_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (tipoCodigo == "Ingreso")
                {
                    Documento documento = new CartaDePorte(ingreso, tipoCodigo);
                    documento = new Exportar(documento);
                    documento.ExportToPDF(saveFileDialog.FileName);
                    MessageBox.Show("Carta de Porte guardada con éxito");
                }
                else if (tipoCodigo == "Salida")
                {
                    Documento documento = new CartaDePorte(salida, tipoCodigo);
                    documento = new Exportar(documento);
                    documento.ExportToPDF(saveFileDialog.FileName);
                    MessageBox.Show("Carta de Porte guardada con éxito");
                }                
            }
        }

        public void PdfConfig()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pdf files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar como Pdf";

            if (tipoCodigo == "Ingreso")
            {
                saveFileDialog.FileName = "CartadePorteIngresoNro_" + ingreso.Codigo.ToString();
            }
            else if (tipoCodigo == "Salida")
            {
                saveFileDialog.FileName = "CartadePorteSalidaNro_" + salida.Codigo.ToString();
            }
        }
    }
}
