using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Transporte
    {
        private string patente;
        private string marca;
        private string modelo;
        private int tara;

        public int TransporteID { get; set; }
        public string Patente { get => patente; set => patente = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Tara { get => tara; set => tara = value; }

        public override string ToString()
        {
            return $"{marca}";
        }
    }
}
