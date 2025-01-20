using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Auditorias
{
    public class AuditoriaVenta
    {
        private Usuario usuario;
        private string Tipoauditoria;
        private DateTime fechayhora;
        private Cliente cliente;
        private int codigo;
        private DateTime fecha;
        private List<DetalleVenta> detallesVenta;
        private decimal precioTotal;

        public AuditoriaVenta()
        {
            if (DetallesVenta == null)
            {
                DetallesVenta = new List<DetalleVenta>();
            }
        }

        public int AuditoriaVentaID { get; set; }
        public int UsuarioID { get; set; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public string TipoAuditoria { get => Tipoauditoria; set => Tipoauditoria = value; }
        public DateTime FechayHora { get => fechayhora; set => fechayhora = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int ClienteID { get; set; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public List<DetalleVenta> DetallesVenta { get => detallesVenta; set => detallesVenta = value; }
        public decimal PrecioTotal { get => precioTotal; set => precioTotal = value; }
    }
}
