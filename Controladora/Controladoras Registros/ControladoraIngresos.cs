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
    public class ControladoraIngresos
    {
        private Contexto contexto = Modelo.GContext.ObtenerContexto();
        private static ControladoraIngresos instancia;

        public static ControladoraIngresos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraIngresos();
                }
                return instancia;
            }
        }

        public IReadOnlyCollection<Ingreso> ListarIngresos()
        {
            try
            {
                return contexto.Ingresos.Include(i => i.Agricultor).Include(i => i.Semilla).Include(s => s.Transporte).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Agregar(Ingreso ingreso)
        {
            try
            {                
                contexto.Ingresos.Add(ingreso);
                contexto.SaveChanges();
                ingreso.Codigo = ingreso.IngresoID;
                contexto.SaveChanges();

                return "Ingreso registrado con éxito";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al registrar ingreso");
            }
        }

        public string Eliminar(Ingreso ingreso)
        {
            try
            {
                var ingresoExistente = contexto.Ingresos.FirstOrDefault(i => i.Codigo == ingreso.Codigo);
                if (ingresoExistente != null)
                {
                    contexto.Ingresos.Remove(ingreso);
                    contexto.SaveChanges();
                    return "Registro de ingreso eliminado con éxito";
                }
                return "No existe registro que eliminar";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al eliminar registro de ingreso");
            }
        }

        public void ExportarAExcel(string filePath)
        {
            try
            {
                var ingresos = ListarIngresos();
                contexto.Ingresos.Include(i => i.Agricultor).Include(i => i.Semilla).Include(i => i.Transporte).ToList();

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Ingresos");
                    var currentRow = 1;

                    worksheet.Cell(currentRow, 1).Value = "Codigo";
                    worksheet.Cell(currentRow, 2).Value = "Fecha";
                    worksheet.Cell(currentRow, 3).Value = "Agricultor";
                    worksheet.Cell(currentRow, 4).Value = "Transporte";
                    worksheet.Cell(currentRow, 5).Value = "Semilla";
                    worksheet.Cell(currentRow, 6).Value = "Cantidad";
                    worksheet.Cell(currentRow, 7).Value = "Precio Total";


                    foreach (var ingreso in ingresos)
                    {
                        currentRow++;
                        worksheet.Cell(currentRow, 1).Value = ingreso.Codigo;
                        worksheet.Cell(currentRow, 2).Value = ingreso.Fecha;
                        worksheet.Cell(currentRow, 3).Value = ingreso.Agricultor.ToString();
                        worksheet.Cell(currentRow, 4).Value = ingreso.Transporte.ToString();
                        worksheet.Cell(currentRow, 5).Value = ingreso.Semilla.ToString();
                        worksheet.Cell(currentRow, 6).Value = ingreso.Cantidad;
                        worksheet.Cell(currentRow, 7).Value = ingreso.PrecioTotal;
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
        public IReadOnlyCollection<Ingreso> ListarIngresosxMasAntiguas()
        {
            try
            {
                return contexto.Ingresos.OrderBy(s => s.Fecha).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Ingreso> ListarIngresosxMasRecientes()
        {
            try
            {
                return contexto.Ingresos.OrderByDescending(s => s.Fecha).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Ingreso> ListarIngresosxApellidoyNombre()
        {
            try
            {
                return contexto.Ingresos.OrderBy(s => s.Agricultor.Apellido).ThenBy(s => s.Agricultor.Nombre).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Ingreso> ListarIngresosxSemilla()
        {
            try
            {
                return contexto.Ingresos.OrderBy(i => i.Semilla.Codigo).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Ingreso> ListarIngresosxCantidad()
        {
            try
            {
                return contexto.Ingresos.OrderByDescending(i => i.Cantidad).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Ingreso> ListarIngresosxPrecio()
        {
            try
            {
                return contexto.Ingresos.OrderByDescending(i => i.PrecioTotal).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Ingreso> ListarIngresosxFecha(DateTime Fecha)
        {
            try
            {
                return contexto.Ingresos.Where(i => i.Fecha.Date == Fecha.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Ingreso> ListarIngresosxPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                return contexto.Ingresos.Where(i => i.Fecha.Date >= fechaDesde.Date && i.Fecha.Date <= fechaHasta.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Busquedas
        public IReadOnlyCollection<Ingreso> ListarIngresosxDniIngresado(int Dni)
        {
            try
            {
                return contexto.Ingresos.Where(i => i.Agricultor.Dni == Dni).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Ingreso> ListarIngresosxSemillaIngresada(string codigo)
        {
            try
            {
                return contexto.Ingresos.Where(i => i.Semilla.Codigo == codigo).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Ingreso> ListarIngresosxNroDeIngreso(int NroIngreso)
        {
            try
            {
                return contexto.Ingresos.Where(i => i.Codigo == NroIngreso).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Ingreso> ListarIngresosxDniMasAntiguo(int Dni)
        {
            try
            {
                return contexto.Ingresos.Where(i => i.Agricultor.Dni == Dni).OrderBy(i => i.Fecha).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Ingreso> ListarIngresosxSemillaMasAntiguo(string codigo)
        {
            try
            {
                return contexto.Ingresos.Where(i => i.Semilla.Codigo == codigo).OrderBy(i => i.Fecha).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Ingreso> ListarIngresosxDniMasReciente(int Dni)
        {
            try
            {
                return contexto.Ingresos.Where(i => i.Agricultor.Dni == Dni).OrderByDescending(i => i.Fecha).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Ingreso> ListarIngresosxSemillaMasReciente(string codigo)
        {
            try
            {
                return contexto.Ingresos.Where(i => i.Semilla.Codigo == codigo).OrderByDescending(i => i.Fecha).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Ingreso> ListarIngresosxDniFecha(int Dni, DateTime fecha)
        {
            try
            {
                return contexto.Ingresos.Where(i => i.Agricultor.Dni == Dni && i.Fecha.Date == fecha.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Ingreso> ListarIngresosxSemillaFecha(string codigo, DateTime fecha)
        {
            try
            {
                return contexto.Ingresos.Where(i => i.Semilla.Codigo == codigo && i.Fecha.Date == fecha.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Ingreso> ListarIngresosxDniPeriodo(int Dni, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                return contexto.Ingresos.Where(i => i.Agricultor.Dni == Dni && i.Fecha.Date >= fechaInicio.Date && i.Fecha.Date <= fechaFin.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Ingreso> ListarIngresosxSemillaPeriodo(string codigo, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                return contexto.Ingresos.Where(i => i.Semilla.Codigo == codigo && i.Fecha.Date >= fechaInicio.Date && i.Fecha.Date <= fechaFin.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }       
    }
}
