using Irony.Parsing;
using Microsoft.Data.SqlClient.DataClassification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Venta
    {
        private int codigo;
        private DateTime fecha;
        private Cliente cliente;
        private List<DetalleVenta> detallesVenta;
        private decimal precioTotal;

        public Venta()
        {
            if (DetallesVenta == null)
            {
                DetallesVenta = new List<DetalleVenta>();
            }
        }

        public int VentaID { get; set; }
        public int Codigo { get => codigo; set => codigo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int ClienteID { get; set; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public List<DetalleVenta> DetallesVenta { get => detallesVenta; set => detallesVenta = value; }
        public decimal PrecioTotal { get => precioTotal; set => precioTotal = value; }

        public override string ToString()
        {
            return $"{codigo}";
        }
    }
}
