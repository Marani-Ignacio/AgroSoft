using Modelo.Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace Controladora
{
    public class ControladoraSemillas
    {
        private Contexto contexto = Modelo.GContext.ObtenerContexto();
        private static ControladoraSemillas instancia;

        public static ControladoraSemillas Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraSemillas();
                }
                return instancia;
            }
        }

        public IReadOnlyCollection<Semilla> ListarSemillas()
        {
            try
            {
                return contexto.Semillas.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Agregar(Semilla semilla)
        {
            try
            {
                var semillaExistente = contexto.Semillas.FirstOrDefault(s => s.Codigo == semilla.Codigo);
                if (semillaExistente == null)
                {
                    contexto.Semillas.Add(semilla);
                    contexto.SaveChanges();
                    return "Semilla agregada con éxito";
                }
                return "Ya existe la semilla";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al agregar semilla");
            }
        }

        public string Eliminar(Semilla semilla)
        {
            try
            {
                var semillaExistente = contexto.Semillas.FirstOrDefault(s => s.Codigo == semilla.Codigo);
                if (semillaExistente != null)
                {
                    bool registroIngreso = contexto.Ingresos.Any(i => i.SemillaID == semillaExistente.SemillaID);
                    bool registroSalida = contexto.Salidas.Any(s => s.SemillaID == semillaExistente.SemillaID);
                    bool registroAuditoriaIngresos = contexto.AuditoriasIngresos.Any(i => i.SemillaID == semillaExistente.SemillaID);
                    bool registroAuditoriasSalidas = contexto.AuditoriasSalidas.Any(s => s.SemillaID == semillaExistente.SemillaID);
                    if (registroIngreso || registroSalida || registroAuditoriaIngresos || registroAuditoriasSalidas)
                    {
                        return "No se puede eliminar la semilla, tiene registros asociados.";
                    }
                    contexto.Semillas.Remove(semilla);
                    contexto.SaveChanges();
                    return "Semilla eliminada con éxito";
                }
                return "No existe semilla que eliminar";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al eliminar semilla");
            }
        }

        public string Modificar(Semilla semilla)
        {
            try
            {
                var semillaExistente = contexto.Semillas.FirstOrDefault(s => s.Codigo == semilla.Codigo);
                if (semillaExistente != null)
                {
                    contexto.Semillas.Update(semilla);
                    contexto.SaveChanges();
                    return "Semilla modificada con éxito";
                }
                return "No existe semilla que modificar";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al modificar semilla");
            }
        }

        public List<Semilla> ListarSemillasAgricultor(int Dni)
        {
            try
            {
                return contexto.Ingresos.Where(i => i.Agricultor.Dni == Dni).Select(i => i.Semilla).Distinct().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Semilla> ListarSemillasIndustria(string Cuil)
        {
            try
            {
                return contexto.Salidas.Where(s => s.Industria.Cuil == Cuil).Select(s => s.Semilla).Distinct().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Semilla EncontrarSemilla(string codigo)
        {
            return contexto.Semillas.ToList().FirstOrDefault(x => x.Codigo == codigo);
        }

        
        public void ExportarAExcel(string filePath)
        {
            try
            {
                var semillas = ListarSemillas();

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Semillas");
                    var currentRow = 1;

                    worksheet.Cell(currentRow, 1).Value = "Codigo";
                    worksheet.Cell(currentRow, 2).Value = "Nombre";
                    worksheet.Cell(currentRow, 3).Value = "Clase";
                    worksheet.Cell(currentRow, 4).Value = "Cantidad";
                    worksheet.Cell(currentRow, 5).Value = "Precio Tonelada Compra";
                    worksheet.Cell(currentRow, 6).Value = "Precio Tonelada Venta";


                    foreach (var semilla in semillas)
                    {
                        currentRow++;
                        worksheet.Cell(currentRow, 1).Value = semilla.Codigo;
                        worksheet.Cell(currentRow, 2).Value = semilla.Nombre;
                        worksheet.Cell(currentRow, 3).Value = semilla.Clase;
                        worksheet.Cell(currentRow, 4).Value = semilla.Cantidad;
                        worksheet.Cell(currentRow, 5).Value = semilla.PrecioToneladaCompra;
                        worksheet.Cell(currentRow, 6).Value = semilla.PrecioToneladaVenta;
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
