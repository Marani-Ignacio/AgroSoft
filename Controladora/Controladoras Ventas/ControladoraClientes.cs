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
    public class ControladoraClientes
    {
        public Contexto contexto = Modelo.GContext.ObtenerContexto();
        private static ControladoraClientes instancia;

        public static ControladoraClientes Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraClientes();
                }
                return instancia;
            }
        }

        public IReadOnlyCollection<Cliente> ListarClientes()
        {
            try
            {
                return contexto.Clientes.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Agregar(Cliente cliente)
        {
            try
            {
                var clienteExistente = contexto.Clientes.FirstOrDefault(c => c.Dni == cliente.Dni);
                if (clienteExistente == null)
                {
                    contexto.Clientes.Add(cliente);
                    contexto.SaveChanges();
                    return "Cliente agregado con éxito";
                }
                return "Ya existe el cliente";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al agregar cliente");
            }
        }

        public string Eliminar(Cliente cliente)
        {
            try
            {
                var clienteExistente = contexto.Clientes.FirstOrDefault(c => c.Dni == cliente.Dni);
                if (clienteExistente != null)
                {                    
                    bool registroVentas = contexto.Ventas.Any(v => v.ClienteID == clienteExistente.ClienteID);
                    bool registroAuditoriaVentas = contexto.AuditoriasVentas.Any(v => v.ClienteID == clienteExistente.ClienteID);
                    if (registroVentas || registroAuditoriaVentas)
                    {
                        return "No se puede eliminar el cliente, tiene registros asociados.";
                    }
                    
                    contexto.Clientes.Remove(cliente);
                    contexto.SaveChanges();
                    return "Cliente eliminado con éxito";
                }
                return "No existe cliente que eliminar";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al eliminar cliente");
            }
        }

        public string Modificar(Cliente cliente)
        {
            try
            {
                var clienteExistente = contexto.Clientes.FirstOrDefault(c => c.Dni == cliente.Dni);
                if (clienteExistente != null)
                {
                    contexto.Clientes.Update(cliente);
                    contexto.SaveChanges();
                    return "Cliente modificado con éxito";
                }
                return "No existe cliente que modificar";
            }
            catch (Exception)
            {
                throw new Exception("Error desconocido al modificar cliente");
            }
        }

        public Cliente EncontrarCliente(int dni)
        {
            return contexto.Clientes.ToList().FirstOrDefault(x => x.Dni == dni);
        }

        public void ExportarAExcel(string filePath)
        {
            try
            {
                var clientes = ListarClientes();

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Clientes");
                    var currentRow = 1;

                    worksheet.Cell(currentRow, 1).Value = "DNI";
                    worksheet.Cell(currentRow, 2).Value = "Nombre";
                    worksheet.Cell(currentRow, 3).Value = "Apellido";
                    worksheet.Cell(currentRow, 4).Value = "Dirección";
                    worksheet.Cell(currentRow, 5).Value = "Email";
                    worksheet.Cell(currentRow, 6).Value = "Telefono";
                    worksheet.Cell(currentRow, 7).Value = "CodPostal";

                    foreach (var cliente in clientes)
                    {
                        currentRow++;
                        worksheet.Cell(currentRow, 1).Value = cliente.Dni;
                        worksheet.Cell(currentRow, 2).Value = cliente.Nombre;
                        worksheet.Cell(currentRow, 3).Value = cliente.Apellido;
                        worksheet.Cell(currentRow, 4).Value = cliente.Direccion;
                        worksheet.Cell(currentRow, 5).Value = cliente.NroCuit;
                        worksheet.Cell(currentRow, 6).Value = cliente.Telefono;
                        worksheet.Cell(currentRow, 7).Value = cliente.CodPostal;
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
