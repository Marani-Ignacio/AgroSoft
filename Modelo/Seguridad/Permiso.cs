using Modelo.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClosedXML.Excel.XLPredefinedFormat;

namespace Modelo
{
    public class Permiso : Componente
    {
        public override string ToString()
        {
            return $"{Nombre}";
        }

        public override void Agregar(Componente componente)
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(Componente componente)
        {
            throw new NotImplementedException();

        }
    }
}
