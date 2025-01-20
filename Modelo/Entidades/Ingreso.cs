using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Ingreso : Registro
    {
        private Agricultor agricultor;

        public int IngresoID { get; set; }
        public int AgricultorID { get; set; }
        public Agricultor Agricultor { get => agricultor; set => agricultor = value; }

        public override string ToString()
        {
            return $"Codigo: {Codigo}";
        }
    }
}
