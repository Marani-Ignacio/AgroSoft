using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Auditorias
{
    public class AuditoriaIngreso
    {
        private Usuario usuario;
        private string Tipoauditoria;
        private DateTime fechayhora;
        private Agricultor agricultor;
        private int codigo;
        private DateTime fecha;
        private Semilla semilla;
        private Transporte transporte;
        private int cantidad;
        private decimal precioTotal;

        public int AuditoriaIngresoID { get; set; }
        public int UsuarioID { get; set; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public string TipoAuditoria { get => Tipoauditoria; set => Tipoauditoria = value; }
        public DateTime FechayHora { get => fechayhora; set => fechayhora = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int AgricultorID { get; set; }
        public Agricultor Agricultor { get => agricultor; set => agricultor = value; }
        public int SemillaID { get; set; }
        public Semilla Semilla { get => semilla; set => semilla = value; }
        public int TransporteID { get; set; }
        public Transporte Transporte { get => transporte; set => transporte = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal PrecioTotal { get => precioTotal; set => precioTotal = value; }
    }
}
