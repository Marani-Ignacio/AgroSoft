using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Decoradores
{
    public class Exportar : Decorator
    {
        public Exportar(Documento documento) : base(documento) { }

        public override void ExportToPDF(string filePath)
        {
            _documento.ExportToPDF(filePath);
        }
    }
}
