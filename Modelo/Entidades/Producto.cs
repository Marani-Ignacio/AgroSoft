using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Producto
    {
        private string codigo;
        private string nombre;
        private string marca;
        private int stock;
        private decimal precioUnidad;

        public int ProductoID { get; set; } 
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Stock { get => stock; set => stock = value; }
        public decimal PrecioUnidad { get => precioUnidad; set => precioUnidad = value; }

        public override string ToString()
        {
            return $"{codigo} / {nombre} / {marca}";
        }

        public void ActualizarStock(int cantidad)
        {
            Stock -= cantidad;
        }
    }
}
