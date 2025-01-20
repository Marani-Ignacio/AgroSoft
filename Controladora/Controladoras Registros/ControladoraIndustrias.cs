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
    public class ControladoraIndustrias
    {
        private Contexto contexto = Modelo.GContext.ObtenerContexto();
        private static ControladoraIndustrias instancia;

        public static ControladoraIndustrias Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraIndustrias();
                }
                return instancia;
            }
        }

        public IReadOnlyCollection<Industria> ListarIndustrias()
        {
            try
            {
                return contexto.Industrias.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Agregar(Industria industria)
        {
            try
            {
                var industriaExistente = contexto.Industrias.FirstOrDefault(i => i.Cuil == industria.Cuil);
                if (industriaExistente == null)
                {
                    contexto.Industrias.Add(industria);
                    contexto.SaveChanges();
                    return "Industria agregada con éxito";
                }
                return "Ya existe la industria";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al agregar industria");
            }
        }

        public string Eliminar(Industria industria)
        {
            try
            {
                var industriaExistente = contexto.Industrias.FirstOrDefault(i => i.Cuil == industria.Cuil);
                if (industriaExistente != null)
                {
                    bool registroSalida = contexto.Salidas.Any(s => s.IndustriaID == industriaExistente.IndustriaID);
                    bool registroAuditoriaSalidas = contexto.AuditoriasSalidas.Any(s => s.IndustriaID == industriaExistente.IndustriaID);
                    if (registroSalida || registroAuditoriaSalidas)
                    {
                        return "No se puede eliminar la industria, tiene registros asociados.";
                    }

                    contexto.Industrias.Remove(industria);
                    contexto.SaveChanges();
                    return "Industria eliminada con éxito";
                }
                return "No existe industria que eliminar";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al eliminar industria");
            }
        }

        public string Modificar(Industria industria)
        {
            try
            {
                var industriaExistente = contexto.Industrias.FirstOrDefault(i => i.Cuil == industria.Cuil);
                if (industriaExistente != null)
                {
                    contexto.Industrias.Update(industria);
                    contexto.SaveChanges();
                    return "Industria modificada con éxito";
                }
                return "No existe industria que modificar";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al modificar industria");
            }
        }

        public Industria EncontrarIndustria(string cuil)
        {
            return contexto.Industrias.ToList().FirstOrDefault(x => x.Cuil == cuil);
        }

        public void ExportarAExcel(string filePath)
        {
            try
            {
                var industrias = ListarIndustrias();
                contexto.Industrias.Include(a => a.Transportes).ToList();

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Industrias");
                    var currentRow = 1;

                    worksheet.Cell(currentRow, 1).Value = "Cuil";
                    worksheet.Cell(currentRow, 2).Value = "Nombre";
                    worksheet.Cell(currentRow, 3).Value = "Dirección";
                    worksheet.Cell(currentRow, 4).Value = "Telefono";
                    worksheet.Cell(currentRow, 5).Value = "Transportes";

                    foreach (var industria in industrias)
                    {
                        currentRow++;
                        worksheet.Cell(currentRow, 1).Value = industria.Cuil;
                        worksheet.Cell(currentRow, 2).Value = industria.Nombre;
                        worksheet.Cell(currentRow, 3).Value = industria.Direccion;
                        worksheet.Cell(currentRow, 4).Value = industria.Telefono;

                        if (industria.Transportes != null)
                        {
                            string transportesInfo = string.Join("  /  ", industria.Transportes.Select(t => $"Marca: {t.Marca}, Modelo: {t.Modelo}, Patente: {t.Patente}"));
                            worksheet.Cell(currentRow, 5).Value = transportesInfo;
                        }
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
