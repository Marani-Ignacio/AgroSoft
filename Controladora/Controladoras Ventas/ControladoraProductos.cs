using ClosedXML.Excel;
using Modelo.Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Controladora
{
    public class ControladoraProductos
    {
        public Contexto contexto = Modelo.GContext.ObtenerContexto();
        private static ControladoraProductos instancia;

        public static ControladoraProductos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraProductos();
                }
                return instancia;
            }
        }

        public IReadOnlyCollection<Producto> ListarProductos()
        {
            try
            {
                return contexto.Productos.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Agregar(Producto producto)
        {
            try
            {
                var productoSeleccionado = contexto.Productos.FirstOrDefault(p => p.Codigo == producto.Codigo);
                if (productoSeleccionado == null)
                {
                    contexto.Productos.Add(producto);
                    contexto.SaveChanges();
                    return "Producto agregado con éxito";
                }
                else
                {
                    return "Ya existe el producto";
                }
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al agregar producto");
            }
        }

        public string Eliminar(Producto producto)
        {
            try
            {
                var productoEnVenta = contexto.Ventas.Any(v => v.DetallesVenta.Any(dv => dv.ProductoID == producto.ProductoID));
                var productoEnAuditoriaVenta = contexto.AuditoriasVentas.Any(v => v.DetallesVenta.Any(dv => dv.ProductoID == producto.ProductoID));

                if (productoEnVenta || productoEnAuditoriaVenta)
                {
                    return "No se puede eliminar el producto, tiene registros asociados.";
                }

                var productoSeleccionado = contexto.Productos.FirstOrDefault(p => p.Codigo == producto.Codigo);
                if (productoSeleccionado != null)
                {
                    contexto.Productos.Remove(productoSeleccionado);
                    contexto.SaveChanges();
                    return "Producto eliminado con éxito";
                }
                else
                {
                    return "No existe producto que eliminar";
                }
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al eliminar producto");
            }
        }

        public string Modificar(Producto producto)
        {
            try
            {
                var productoSeleccionado = contexto.Productos.FirstOrDefault(p => p.Codigo == producto.Codigo);
                if (productoSeleccionado != null)
                {
                    contexto.Productos.Update(producto);
                    contexto.SaveChanges();
                    return "Producto modificado con éxito";
                }
                else
                {
                    return "No existe producto que modificar";
                }
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al modificar producto");
            }
        }

        public Producto EncontrarProducto(string codigo)
        {
            return contexto.Productos.ToList().FirstOrDefault(x => x.Codigo == codigo);
        }

        public void ExportarAExcel(string filePath)
        {
            try
            {
                var productos = ListarProductos();

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Productos");
                    var currentRow = 1;

                    worksheet.Cell(currentRow, 1).Value = "Codigo";
                    worksheet.Cell(currentRow, 2).Value = "Nombre";
                    worksheet.Cell(currentRow, 3).Value = "Marca";
                    worksheet.Cell(currentRow, 4).Value = "Stock";
                    worksheet.Cell(currentRow, 5).Value = "PrecioUnidad";

                    foreach (var producto in productos)
                    {
                        currentRow++;
                        worksheet.Cell(currentRow, 1).Value = producto.Codigo;
                        worksheet.Cell(currentRow, 2).Value = producto.Nombre;
                        worksheet.Cell(currentRow, 3).Value = producto.Marca;
                        worksheet.Cell(currentRow, 4).Value = producto.Stock;
                        worksheet.Cell(currentRow, 5).Value = producto.PrecioUnidad;
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

