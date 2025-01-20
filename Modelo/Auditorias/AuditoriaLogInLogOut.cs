using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class AuditoriaLogInLogOut
    {
        private Usuario usuario;
        private string Tipoauditoria;
        private DateTime fechayhora;

        public int AuditoriaLogInLogOutID { get; set; }
        public int UsuarioID { get; set; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public string TipoAuditoria { get => Tipoauditoria; set => Tipoauditoria = value; }
        public DateTime FechayHora { get => fechayhora; set => fechayhora = value; }
    }
}
