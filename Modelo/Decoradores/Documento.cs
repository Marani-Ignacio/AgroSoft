using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo.Decoradores
{
    public abstract class Documento
    {
        public abstract void ExportToPDF(string filePath);

    }
}
