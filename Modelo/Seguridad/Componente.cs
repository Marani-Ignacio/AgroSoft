using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class Componente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }


        public abstract void Agregar(Componente componente);
        public abstract void Eliminar(Componente componente);
        public virtual List<Componente> Mostrar() => new List <Componente>();
    }
}
