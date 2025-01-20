using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Decoradores
{
    public abstract class Decorator : Documento
    {
        protected Documento _documento;

        public Decorator(Documento documento)
        {
            _documento = documento;
        }

        public override void ExportToPDF(string filePath)
        {
            _documento?.ExportToPDF(filePath);
        }
    }
}

