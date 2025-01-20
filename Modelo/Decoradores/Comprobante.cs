using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Modelo.Decoradores
{
    public class Comprobante : Documento
    {
        private readonly dynamic venta;

        public Comprobante(dynamic venta)
        {
            this.venta = venta;
        }

        public override void ExportToPDF(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
                PdfWriter pw = PdfWriter.GetInstance(doc, fs);

                doc.Open();

                Font fuenteTitulo = new Font(Font.FontFamily.TIMES_ROMAN, 14, Font.NORMAL, BaseColor.BLACK);
                Font fuente = new Font(Font.FontFamily.TIMES_ROMAN, 10, Font.NORMAL, BaseColor.BLACK);

                doc.Add(new Paragraph("Comprobante", fuenteTitulo));
                doc.Add(Chunk.NEWLINE);

                doc.Add(new Phrase("Nro Comprobante: " + venta.Codigo, fuente));
                doc.Add(Chunk.NEWLINE);

                string fecha = venta.Fecha.ToString("dd/MM/yyyy");
                doc.Add(new Phrase("Fecha: " + fecha, fuente));
                doc.Add(Chunk.NEWLINE);

                doc.Add(new Phrase("Cliente: " + venta.Cliente.Nombre + " " + venta.Cliente.Apellido + " -- Cuit: " + venta.Cliente.NroCuit + " -- Dirección: " + venta.Cliente.Direccion + " -- Cod Postal: " + venta.Cliente.CodPostal, fuente));
                doc.Add(Chunk.NEWLINE);


                PdfPTable tblComprobante = new PdfPTable(3);
                tblComprobante.WidthPercentage = 100;

                PdfPCell clProducto = new PdfPCell(new Phrase("Producto", fuente));
                PdfPCell clCantidad = new PdfPCell(new Phrase("Cantidad", fuente));
                PdfPCell clPrecioUnidad = new PdfPCell(new Phrase("Precio", fuente));

                clProducto.BorderWidth = 1;
                clCantidad.BorderWidth = 1;
                clPrecioUnidad.BorderWidth = 1;

                tblComprobante.AddCell(clProducto);
                tblComprobante.AddCell(clCantidad);
                tblComprobante.AddCell(clPrecioUnidad);

                foreach (var producto in venta.DetallesVenta)
                {
                    clProducto = new PdfPCell(new Phrase(producto.Producto.ToString(), fuente));
                    clCantidad = new PdfPCell(new Phrase(producto.Cantidad.ToString(), fuente));
                    clPrecioUnidad = new PdfPCell(new Phrase(producto.PrecioParcial.ToString(), fuente));

                    tblComprobante.AddCell(clProducto);
                    tblComprobante.AddCell(clCantidad);
                    tblComprobante.AddCell(clPrecioUnidad);
                }

                PdfPTable tblTotal = new PdfPTable(1);
                tblTotal.WidthPercentage = 33;
                tblTotal.HorizontalAlignment = Element.ALIGN_RIGHT;

                PdfPCell clPrecioTotal = new PdfPCell(new Phrase("Total", fuente));
                clPrecioTotal.BorderWidth = 1;
                tblTotal.AddCell(clPrecioTotal);

                clPrecioTotal = new PdfPCell(new Phrase(venta.PrecioTotal.ToString(), fuente));
                tblTotal.AddCell(clPrecioTotal);

                doc.Add(tblComprobante);
                doc.Add(Chunk.NEWLINE);
                doc.Add(tblTotal);

                doc.Close();
                pw.Close();
            }
        }
    }
}
