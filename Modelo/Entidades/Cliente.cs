using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Cliente : Persona
    {
        private int dni;
        private string apellido;
        private string nroCuit;
        private int codPostal;

        public int ClienteID { get; set; }
        public int Dni { get => dni; set => dni = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string NroCuit { get => nroCuit; set => nroCuit = value; }
        public int CodPostal { get => codPostal; set => codPostal = value; }

        public override string ToString()
        {
            return $"{apellido} {Nombre}";
        }
    }
}
