using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Semilla
    {
        private string codigo;
        private string nombre;
        private string clase;
        private Int64 cantidad;
        private decimal precioToneladaCompra;
        private decimal precioToneladaVenta;

        public int SemillaID { get; set; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Clase { get => clase; set => clase = value; }
        public long Cantidad { get => cantidad; set => cantidad = value; }
        public decimal PrecioToneladaCompra { get => precioToneladaCompra; set => precioToneladaCompra = value; }
        public decimal PrecioToneladaVenta { get => precioToneladaVenta; set => precioToneladaVenta = value; }

        public override string ToString()
        {
            return $"{codigo}";
        }

        public void ActualizarSemillaxIngreso(int cantidad)
        {
            Cantidad += cantidad;
        }

        public void ActualizarSemillaxSalida(int cantidad)
        {
            Cantidad -= cantidad;
        }
    }
}
