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
    public class ControladoraVentas
    {
        public Contexto contexto = GContext.ObtenerContexto();
        private static ControladoraVentas instancia;

        public static ControladoraVentas Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraVentas();
                }
                return instancia;
            }
        }

        public IReadOnlyCollection<Venta> ListarVentas()
        {
            try
            {
                return contexto.Ventas.Include(v => v.Cliente).Include(v => v.DetallesVenta).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Agregar(Venta venta)
        {
            try
            {
                contexto.Ventas.Add(venta);
                contexto.SaveChanges();
                venta.Codigo = venta.VentaID;
                contexto.SaveChanges();

                return "Venta registrada con éxito";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al registrar venta");
            }
        }

        public string Eliminar(Venta venta)
        {
            try
            {
                var ventaExistente = contexto.Ventas.FirstOrDefault(v => v.Codigo == venta.Codigo);
                if (ventaExistente != null)
                {
                    contexto.Ventas.Remove(venta);
                    contexto.SaveChanges();
                    return "Registro de venta eliminado con éxito";
                }
                return "No existe registro de venta que eliminar";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al eliminar registro de venta");
            }
        }

        public void ExportarAExcel(string filePath)
        {
            try
            {
                var ventas = ListarVentas();
                contexto.Ventas.Include(v => v.Cliente).Include(v => v.DetallesVenta).ToList();

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Ventas");
                    var currentRow = 1;

                    worksheet.Cell(currentRow, 1).Value = "Codigo";
                    worksheet.Cell(currentRow, 2).Value = "Fecha";
                    worksheet.Cell(currentRow, 3).Value = "Cliente";
                    worksheet.Cell(currentRow, 4).Value = "Total";
                    worksheet.Cell(currentRow, 5).Value = "Productos";

                    foreach (var venta in ventas)
                    {
                        currentRow++;
                        worksheet.Cell(currentRow, 1).Value = venta.Codigo;
                        worksheet.Cell(currentRow, 2).Value = venta.Fecha;
                        worksheet.Cell(currentRow, 3).Value = venta.Cliente.ToString();
                        worksheet.Cell(currentRow, 4).Value = venta.PrecioTotal;

                        if (venta.DetallesVenta != null)
                        {
                            contexto.Productos.ToList();
                            string detalleVenta = string.Join("  /  ", venta.DetallesVenta.Select(dv => $"Producto: {dv.Producto}, Cantidad: {dv.Cantidad}, Precio Parcial: {dv.PrecioParcial}"));
                            worksheet.Cell(currentRow, 5).Value = detalleVenta;
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

        // Filtros
        public IReadOnlyCollection<Venta> ListarVentasxMasAntiguas()
        {
            try
            {
                return contexto.Ventas.OrderBy(v => v.Fecha).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Venta> ListarVentasxMasRecientes()
        {
            try
            {
                return contexto.Ventas.OrderByDescending(v => v.Fecha).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Venta> ListarVentasxApellidoyNombre()
        {
            try
            {
                return contexto.Ventas.OrderBy(v => v.Cliente.Apellido).ThenBy(v => v.Cliente.Nombre).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Venta> ListarVentasxPrecio()
        {
            try
            {
                return contexto.Ventas.OrderByDescending(v => v.PrecioTotal).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Venta> ListarVentasxFecha(DateTime Fecha)
        {
            try
            {
                return contexto.Ventas.Where(v => v.Fecha.Date == Fecha.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Venta> ListarVentasxPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                return contexto.Ventas.Where(v => v.Fecha.Date >= fechaDesde.Date && v.Fecha.Date <= fechaHasta.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Búsquedas
        public IReadOnlyCollection<Venta> ListarVentasxDniIngresado(int Dni)
        {
            try
            {
                return contexto.Ventas.Where(v => v.Cliente.Dni == Dni).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Venta> ListarVentasxNroDeVenta(int NroVenta)
        {
            try
            {
                return contexto.Ventas.Where(v => v.Codigo == NroVenta).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Venta> ListarVentasxDniMasAntiguo(int Dni)
        {
            try
            {
                return contexto.Ventas.Where(v => v.Cliente.Dni == Dni).OrderBy(v => v.Fecha).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Venta> ListarVentasxDniMasReciente(int Dni)
        {
            try
            {
                return contexto.Ventas.Where(v => v.Cliente.Dni == Dni).OrderByDescending(v => v.Fecha).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Venta> ListarVentasxDniFecha(int Dni, DateTime fecha)
        {
            try
            {
                return contexto.Ventas.Where(v => v.Cliente.Dni == Dni && v.Fecha.Date == fecha.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IReadOnlyCollection<Venta> ListarVentasxDniPeriodo(int Dni, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                return contexto.Ventas.Where(v => v.Cliente.Dni == Dni && v.Fecha.Date >= fechaInicio.Date && v.Fecha.Date <= fechaFin.Date).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
