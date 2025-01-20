using Irony.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class DetalleVenta
    {
        private Producto producto;
        private int cantidad;
        private decimal precioParcial;
               

        public int DetalleVentaID { get; set; }
        public int ProductoID { get; set; }
        public Producto Producto { get => producto; set => producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal PrecioParcial { get => precioParcial; set => precioParcial = value; }
    }
}
