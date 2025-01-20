using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Salida : Registro
    {
        private Industria industria;

        public int SalidaID { get; set; }
        public int IndustriaID { get; set; }
        public Industria Industria { get => industria; set => industria = value; }

        public override string ToString()
        {
            return $"Codigo: {Codigo}";
        }
    }
}
