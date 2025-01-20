using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class GContext
    {
        private static Contexto contexto;

        public static Contexto ObtenerContexto()
        {
            if (contexto == null)
            {
                contexto = new Contexto();
            }
            return contexto;
        }
    }
}

