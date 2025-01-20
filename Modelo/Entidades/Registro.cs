using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public abstract class Registro
    {
        private int codigo;
        private DateTime fecha;
        private Semilla semilla;
        private Transporte transporte;
        private int cantidad;
        private decimal precioTotal;

        public int Codigo { get => codigo; set => codigo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int SemillaID { get; set; }
        public Semilla Semilla { get => semilla; set => semilla = value; }
        public int TransporteID { get; set; }
        public Transporte Transporte { get => transporte; set => transporte = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal PrecioTotal { get => precioTotal; set => precioTotal = value; }
    }
}
