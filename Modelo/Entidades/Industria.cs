using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Industria : Persona
    {
        private string cuil;
        private List<Transporte> transportes;

        public int IndustriaID { get; set; }
        public string Cuil { get => cuil; set => cuil = value; }
        public List<Transporte> Transportes { get => transportes; set => transportes = value; }

        public override string ToString()
        {
            return $"{Nombre}";
        }
    }
}
