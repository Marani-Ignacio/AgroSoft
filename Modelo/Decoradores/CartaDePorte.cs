using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Decoradores
{
    public class CartaDePorte : Documento
    {
        private readonly dynamic registro;
        private readonly string tipoCodigo;

        public CartaDePorte(dynamic registro, string tipoCodigo)
        {
            this.registro = registro;
            this.tipoCodigo = tipoCodigo;
        }

        public override void ExportToPDF(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
                PdfWriter pw = PdfWriter.GetInstance(doc, fs);

                doc.Open();

                Font fuenteTitulo = new Font(Font.FontFamily.TIMES_ROMAN, 14, Font.NORMAL, BaseColor.BLACK);
                Font fuenteSubTitulo = new Font(Font.FontFamily.TIMES_ROMAN, 12, Font.BOLD, BaseColor.BLACK);
                Font fuente = new Font(Font.FontFamily.TIMES_ROMAN, 10, Font.NORMAL, BaseColor.BLACK);

                if (tipoCodigo == "Ingreso")
                {
                    doc.Add(new Paragraph("Carta de Porte -- Ingreso", fuenteTitulo));
                    doc.Add(Chunk.NEWLINE);

                    doc.Add(new Phrase("Nro Carta de Porte: " + registro.Codigo, fuente));
                    doc.Add(Chunk.NEWLINE);

                    string fecha = registro.Fecha.ToString("dd/MM/yyyy");
                    doc.Add(new Phrase("Fecha: " + fecha, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);

                    doc.Add(new Phrase("Datos del Agricultor", fuenteSubTitulo));
                    doc.Add(Chunk.NEWLINE);

                    doc.Add(new Phrase("Nombre: " + registro.Agricultor.Nombre, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Phrase("Apellido: " + registro.Agricultor.Apellido, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Phrase("CUIT Nro: " + registro.Agricultor.NroCuit, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Phrase("Dirección: " + registro.Agricultor.Direccion, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);

                    doc.Add(new Phrase("Datos de la Semilla", fuenteSubTitulo));
                    doc.Add(Chunk.NEWLINE);

                    doc.Add(new Phrase("Codigo: " + registro.Semilla.Codigo, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Phrase("Apellido: " + registro.Semilla.Nombre, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Phrase("CUIT Nro: " + registro.Semilla.Clase, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Phrase("Precio x Tonelada: " + registro.Semilla.PrecioToneladaCompra, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);

                    doc.Add(new Phrase("Datos del Transporte", fuenteSubTitulo));
                    doc.Add(Chunk.NEWLINE);

                    doc.Add(new Phrase("Patente: " + registro.Transporte.Patente, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Phrase("Marca: " + registro.Transporte.Marca, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Phrase("Modelo: " + registro.Transporte.Modelo, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Phrase("Tara: " + registro.Transporte.Tara, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);

                    doc.Add(new Phrase("Datos del Ingreso", fuenteSubTitulo));
                    doc.Add(Chunk.NEWLINE);

                    doc.Add(new Phrase("Cantidad: " + registro.Cantidad, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Phrase("Precio Total: " + registro.PrecioTotal, fuente));
                    doc.Add(Chunk.NEWLINE);
                }
                else if (tipoCodigo == "Salida")
                {
                    doc.Add(new Paragraph("Carta de Porte -- Salida", fuenteTitulo));
                    doc.Add(Chunk.NEWLINE);

                    doc.Add(new Phrase("Nro Carta de Porte: " + registro.Codigo, fuente));
                    doc.Add(Chunk.NEWLINE);

                    string fecha = registro.Fecha.ToString("dd/MM/yyyy");
                    doc.Add(new Phrase("Fecha: " + fecha, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);

                    doc.Add(new Phrase("Datos de la Industria", fuenteSubTitulo));
                    doc.Add(Chunk.NEWLINE);

                    doc.Add(new Phrase("Nombre: " + registro.Industria.Nombre, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Phrase("CUIL Nro: " + registro.Industria.Cuil, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Phrase("Dirección: " + registro.Industria.Direccion, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Phrase("Teléfono: " + registro.Industria.Telefono, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);

                    doc.Add(new Phrase("Datos de la Semilla", fuenteSubTitulo));
                    doc.Add(Chunk.NEWLINE);

                    doc.Add(new Phrase("Codigo: " + registro.Semilla.Codigo, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Phrase("Apellido: " + registro.Semilla.Nombre, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Phrase("CUIT Nro: " + registro.Semilla.Clase, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Phrase("Precio x Tonelada: " + registro.Semilla.PrecioToneladaVenta, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);

                    doc.Add(new Phrase("Datos del Transporte", fuenteSubTitulo));
                    doc.Add(Chunk.NEWLINE);

                    doc.Add(new Phrase("Patente: " + registro.Transporte.Patente, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Phrase("Marca: " + registro.Transporte.Marca, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Phrase("Modelo: " + registro.Transporte.Modelo, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Phrase("Tara: " + registro.Transporte.Tara, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);

                    doc.Add(new Phrase("Datos de la Salida", fuenteSubTitulo));
                    doc.Add(Chunk.NEWLINE);

                    doc.Add(new Phrase("Cantidad: " + registro.Cantidad, fuente));
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(new Phrase("Precio Total: " + registro.PrecioTotal, fuente));
                    doc.Add(Chunk.NEWLINE);
                }

                doc.Close();
                pw.Close();
            }
        }
    }
}
