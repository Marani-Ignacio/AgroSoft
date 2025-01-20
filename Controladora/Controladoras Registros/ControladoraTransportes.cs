using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using Modelo;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraTransportes
    {
        private Contexto contexto = Modelo.GContext.ObtenerContexto();
        private static ControladoraTransportes instancia;

        public static ControladoraTransportes Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraTransportes();
                }
                return instancia;
            }
        }

        public IReadOnlyCollection<Transporte> ListarTransportes()
        {
            try
            {
                return contexto.Transportes.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Agregar(Transporte transporte)
        {
            try
            {
                var transporteExistente = contexto.Transportes.FirstOrDefault(t => t.Patente == transporte.Patente);
                if (transporteExistente == null)
                {
                    contexto.Transportes.Add(transporte);
                    contexto.SaveChanges();
                    return "Transporte agregado con éxito";
                }
                return "Ya existe el transporte";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al agregar transporte");
            }
        }


        public string Eliminar(Transporte transporte)
        {
            try
            {
                var transporteExistente = contexto.Transportes.FirstOrDefault(t => t.Patente == transporte.Patente);
                if (transporteExistente != null)
                {
                    bool registroIngreso = contexto.Ingresos.Any(i => i.TransporteID == transporteExistente.TransporteID);
                    bool registroSalida = contexto.Salidas.Any(s => s.TransporteID == transporteExistente.TransporteID);
                    bool registroAuditoriaIngresos = contexto.AuditoriasIngresos.Any(i => i.TransporteID == transporteExistente.TransporteID);
                    bool registroAuditoriasSalidas = contexto.AuditoriasSalidas.Any(s => s.TransporteID == transporteExistente.TransporteID);
                    if (registroIngreso || registroSalida || registroAuditoriaIngresos || registroAuditoriasSalidas)
                    {
                        return "No se puede eliminar el transporte, tiene registros asociados.";
                    }
                    contexto.Transportes.Remove(transporte);
                    contexto.SaveChanges();
                    return "Transporte eliminado con éxito";
                }
                return "No existe transporte que eliminar";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al eliminar transporte");
            }
        }


        public string Modificar(Transporte transporte)
        {
            try
            {
                var transporteExistente = contexto.Transportes.FirstOrDefault(t => t.Patente == transporte.Patente);
                if (transporteExistente != null)
                {
                    contexto.Transportes.Update(transporte);
                    contexto.SaveChanges();
                    return "Transporte modificado con éxito";
                }
                return "No existe transporte que modificar";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al modificar transporte");
            }
        }

        public Transporte EncontrarTransporte(string patente)
        {
            return contexto.Transportes.ToList().FirstOrDefault(x => x.Patente == patente);
        }

        public void ExportarAExcel(string filePath)
        {
            try
            {
                var transportes = ListarTransportes();

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Transportes");
                    var currentRow = 1;

                    worksheet.Cell(currentRow, 1).Value = "Modelo";
                    worksheet.Cell(currentRow, 2).Value = "Marca";
                    worksheet.Cell(currentRow, 3).Value = "Patente";
                    worksheet.Cell(currentRow, 4).Value = "Tara";

                    foreach (var transporte in transportes)
                    {
                        currentRow++;
                        worksheet.Cell(currentRow, 1).Value = transporte.Modelo;
                        worksheet.Cell(currentRow, 2).Value = transporte.Marca;
                        worksheet.Cell(currentRow, 3).Value = transporte.Patente;
                        worksheet.Cell(currentRow, 4).Value = transporte.Tara;
                    }

                    worksheet.Columns().AdjustToContents();
                    workbook.SaveAs(filePath);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al exportar los datos a Excel: " + ex.Message, ex);
            }            
        }       
    }
}
