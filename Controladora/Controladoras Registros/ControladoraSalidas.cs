using Modelo.Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClosedXML.Excel;

namespace Controladora
{
    public class ControladoraSalidas
    {
        private Contexto contexto = Modelo.GContext.ObtenerContexto();
        private static ControladoraSalidas instancia;

        public static ControladoraSalidas Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraSalidas();
                }
                return instancia;
            }
        }

        public IReadOnlyCollection<Salida> ListarSalidas()
        {
            try
            {
                return contexto.Salidas.Include(s => s.Industria).Include(se => se.Semilla).Include(i => i.Transporte).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Agregar(Salida salida)
        {
            try
            {
                contexto.Salidas.Add(salida);
                contexto.SaveChanges();
                salida.Codigo = salida.SalidaID;
                contexto.SaveChanges();

                return "Salida registrada con éxito";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al registrar salida");
            }
        }

        public string Eliminar(Salida salida)
        {
            try
            {
                var salidaExistente = contexto.Salidas.FirstOrDefault(s => s.Codigo == salida.Codigo);
                if (salidaExistente != null)
                {
                    contexto.Salidas.Remove(salida);
                    contexto.SaveChanges();
                    return "Registro de salida eliminado con éxito";
                }
                return "No existe registro que eliminar";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al eliminar registro de salida");
            }
        }

        public void ExportarAExcel(string filePath)
        {            
            try
            {
                var salidas = ListarSalidas();
                contexto.Salidas.Include(s => s.Industria).Include(s => s.Semilla).Include(s => s.Transporte).ToList();

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Salidas");
                    var currentRow = 1;

                    worksheet.Cell(currentRow, 1).Value = "Codigo";
                    worksheet.Cell(currentRow, 2).Value = "Fecha";
                    worksheet.Cell(currentRow, 3).Value = "Industria";
                    worksheet.Cell(currentRow, 4).Value = "Transporte";
                    worksheet.Cell(currentRow, 5).Value = "Semilla";
                    worksheet.Cell(currentRow, 6).Value = "Cantidad";
                    worksheet.Cell(currentRow, 7).Value = "Precio Total";


                    foreach (var salida in salidas)
                    {
                        currentRow++;
                        worksheet.Cell(currentRow, 1).Value = salida.Codigo;
                        worksheet.Cell(currentRow, 2).Value = salida.Fecha;
                        worksheet.Cell(currentRow, 3).Value = salida.Industria.ToString();
                        worksheet.Cell(currentRow, 4).Value = salida.Transporte.ToString();
                        worksheet.Cell(currentRow, 5).Value = salida.Semilla.ToString();
                        worksheet.Cell(currentRow, 6).Value = salida.Cantidad;
                        worksheet.Cell(currentRow, 7).Value = salida.PrecioTotal;
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

        // Filtros

        public IReadOnlyCollection<Salida> ListarSalidasxMasAntiguas()
        {
            try
            {
                return contexto.Salidas.OrderBy(s => s.Fecha).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Salida> ListarSalidasxMasRecientes()
        {
            try
            {
                return contexto.Salidas.OrderByDescending(s => s.Fecha).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Salida> ListarSalidasxNombre()
        {
            try
            {
                return contexto.Salidas.OrderBy(s => s.Industria.Nombre).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Salida> ListarSalidasxSemilla()
        {
            try
            {
                return contexto.Salidas.OrderBy(s => s.Semilla.Codigo).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Salida> ListarSalidasxCantidad()
        {
            try
            {
                return contexto.Salidas.OrderByDescending(s => s.Cantidad).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Salida> ListarSalidasxPrecio()
        {
            try
            {
                return contexto.Salidas.OrderByDescending(s => s.PrecioTotal).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IReadOnlyCollection<Salida> ListarSalidasxFecha(DateTime Fecha)
        {
            try
            {
                return contexto.Salidas.Where(s => s.Fecha.Date == Fecha.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Salida> ListarSalidasxPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                return contexto.Salidas.Where(s => s.Fecha.Date >= fechaDesde.Date && s.Fecha.Date <= fechaHasta.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Búsquedas
        public IReadOnlyCollection<Salida> ListarSalidasxCuilIngresado(string Cuil)
        {
            try
            {
                return contexto.Salidas.Where(s => s.Industria.Cuil == Cuil).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Salida> ListarSalidasxSemillaIngresada(string codigo)
        {
            try
            {
                return contexto.Salidas.Where(s => s.Semilla.Codigo == codigo).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Salida> ListarSalidasxNroDeSalida(int NroSalida)
        {
            try
            {
                return contexto.Salidas.Where(s => s.Codigo == NroSalida).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Salida> ListarSalidasxCuilMasAntiguo(string Cuil)
        {
            try
            {
                return contexto.Salidas.Where(s => s.Industria.Cuil == Cuil).OrderBy(s => s.Fecha).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Salida> ListarSalidasxSemillaMasAntiguo(string codigo)
        {
            try
            {
                return contexto.Salidas.Where(s => s.Semilla.Codigo == codigo).OrderBy(s => s.Fecha).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Salida> ListarSalidasxCuilMasReciente(string Cuil)
        {
            try
            {
                return contexto.Salidas.Where(s => s.Industria.Cuil == Cuil).OrderByDescending(s => s.Fecha).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Salida> ListarSalidasxSemillaMasReciente(string codigo)
        {
            try
            {
                return contexto.Salidas.Where(s => s.Semilla.Codigo == codigo).OrderByDescending(s => s.Fecha).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Salida> ListarSalidasxCuilFecha(string Cuil, DateTime fecha)
        {
            try
            {
                return contexto.Salidas.Where(s => s.Industria.Cuil == Cuil && s.Fecha.Date == fecha.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Salida> ListarSalidasxSemillaFecha(string codigo, DateTime fecha)
        {
            try
            {
                return contexto.Salidas.Where(s => s.Semilla.Codigo == codigo && s.Fecha.Date == fecha.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Salida> ListarSalidasxCuilPeriodo(string Cuil, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                return contexto.Salidas.Where(s => s.Industria.Cuil == Cuil && s.Fecha.Date >= fechaInicio.Date && s.Fecha.Date <= fechaFin.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Salida> ListarSalidasxSemillaPeriodo(string codigo, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                return contexto.Salidas.Where(s => s.Semilla.Codigo == codigo && s.Fecha.Date >= fechaInicio.Date && s.Fecha.Date <= fechaFin.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
