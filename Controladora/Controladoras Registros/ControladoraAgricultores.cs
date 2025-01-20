using Modelo;
using Modelo.Entidades;
using ClosedXML.Excel;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Controladora
{
    public class ControladoraAgricultores
    {
        private Contexto contexto = Modelo.GContext.ObtenerContexto();
        private static ControladoraAgricultores instancia;

        public static ControladoraAgricultores Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraAgricultores();
                }
                return instancia;
            }
        }

        public IReadOnlyCollection<Agricultor> ListarAgricultores()
        {
            try
            {
                return contexto.Agricultores.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Agregar(Agricultor agricultor)
        {
            try
            {
                var agricultorExistente = contexto.Agricultores.FirstOrDefault(a => a.Dni == agricultor.Dni);
                if (agricultorExistente == null)
                {
                    contexto.Agricultores.Add(agricultor);
                    contexto.SaveChanges();
                    return "Agricultor agregado con éxito";
                }
                return "Ya existe el agricultor";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al agregar agricultor");
            }
        }

        public string Eliminar(Agricultor agricultor)
        {
            try
            {
                var agricultorExistente = contexto.Agricultores.FirstOrDefault(a => a.Dni == agricultor.Dni);
                if (agricultorExistente != null)
                {
                    bool registroIngresos = contexto.Ingresos.Any(i => i.AgricultorID == agricultorExistente.AgricultorID);
                    bool registroAuditoriaIngresos = contexto.AuditoriasIngresos.Any(i => i.AgricultorID == agricultorExistente.AgricultorID);
                    if (registroIngresos || registroAuditoriaIngresos)
                    {
                        return "No se puede eliminar el agricultor, tiene registros asociados.";
                    }
                    contexto.Agricultores.Remove(agricultor);
                    contexto.SaveChanges();
                    return "Agricultor eliminado con éxito";
                }
                return "No existe agricultor que eliminar";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al eliminar agricultor");
            }
        }

        public string Modificar(Agricultor agricultor)
        {
            try
            {
                var agricultorExistente = contexto.Agricultores.FirstOrDefault(a => a.Dni == agricultor.Dni);
                if (agricultorExistente != null)
                {
                    contexto.Agricultores.Update(agricultor);
                    contexto.SaveChanges();
                    return "Agricultor modificado con éxito";
                }
                return "No existe agricultor que modificar";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al modificar agricultor");
            }
        }

        public Agricultor EncontrarAgricultor(int dni)
        {
            return contexto.Agricultores.ToList().FirstOrDefault(x => x.Dni == dni);
        }

        public void ExportarAExcel(string filePath)
        {            
            try
            {
                var agricultores = ListarAgricultores();
                contexto.Agricultores.Include(a => a.Transportes).ToList();

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Agricultores");
                    var currentRow = 1;

                    worksheet.Cell(currentRow, 1).Value = "DNI";
                    worksheet.Cell(currentRow, 2).Value = "Nombre";
                    worksheet.Cell(currentRow, 3).Value = "Apellido";
                    worksheet.Cell(currentRow, 4).Value = "Dirección";
                    worksheet.Cell(currentRow, 5).Value = "Email";
                    worksheet.Cell(currentRow, 6).Value = "Transportes";

                    foreach (var agricultor in agricultores)
                    {
                        currentRow++;
                        worksheet.Cell(currentRow, 1).Value = agricultor.Dni;
                        worksheet.Cell(currentRow, 2).Value = agricultor.Nombre;
                        worksheet.Cell(currentRow, 3).Value = agricultor.Apellido;
                        worksheet.Cell(currentRow, 4).Value = agricultor.Direccion;
                        worksheet.Cell(currentRow, 5).Value = agricultor.NroCuit;

                        if (agricultor.Transportes != null)
                        {
                            string transportesInfo = string.Join("  /  ", agricultor.Transportes.Select(t => $"Marca: {t.Marca}, Modelo: {t.Modelo}, Patente: {t.Patente}"));
                            worksheet.Cell(currentRow, 6).Value = transportesInfo;
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
