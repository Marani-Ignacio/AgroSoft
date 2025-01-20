using Modelo.Auditorias;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormConsultarSalida : Form
    {
        private Salida salida;
        private AuditoriaSalida auditoriaSalida;
        private string origen;

        public FormConsultarSalida(Salida salida)
        {
            InitializeComponent();
            this.salida = salida;
            origen = "reporte salida";
        }

        public FormConsultarSalida(AuditoriaSalida auditoriaSalida)
        {
            InitializeComponent();
            this.auditoriaSalida = auditoriaSalida;
            origen = "auditoria salida";
        }

        private void FormConsultarSalida_Load(object sender, EventArgs e)
        {
            if (origen == "reporte salida")
            {
                txtCodigo.Text = salida.Codigo.ToString();
                txtTotal.Text = salida.PrecioTotal.ToString();
                txtFecha.Text = salida.Fecha.ToString("dd/MM/yyyy");

                txtNombre.Text = salida.Industria.Nombre;
                txtCuil.Text = salida.Industria.Cuil.ToString();
                txtDireccion.Text = salida.Industria.Direccion;

                txtCodSemilla.Text = salida.Semilla.Codigo;
                txtClaseSemilla.Text = salida.Semilla.Clase;
                txtCantSemilla.Text = salida.Cantidad.ToString() + " Kg";

                txtPatente.Text = salida.Transporte.Patente;
                txtMarca.Text = salida.Transporte.Marca;
                txtModelo.Text = salida.Transporte.Modelo;
            }
            else if (origen == "auditoria salida")
            {
                txtCodigo.Text = auditoriaSalida.Codigo.ToString();
                txtTotal.Text = auditoriaSalida.PrecioTotal.ToString();
                txtFecha.Text = auditoriaSalida.Fecha.ToString("dd/MM/yyyy");

                txtNombre.Text = auditoriaSalida.Industria.Nombre;
                txtCuil.Text = auditoriaSalida.Industria.Cuil.ToString();
                txtDireccion.Text = auditoriaSalida.Industria.Direccion;

                txtCodSemilla.Text = auditoriaSalida.Semilla.Codigo;
                txtClaseSemilla.Text = auditoriaSalida.Semilla.Clase;
                txtCantSemilla.Text = auditoriaSalida.Cantidad.ToString() + " Kg";

                txtPatente.Text = auditoriaSalida.Transporte.Patente;
                txtMarca.Text = auditoriaSalida.Transporte.Marca;
                txtModelo.Text = auditoriaSalida.Transporte.Modelo;
            }
            
        }
    }
}
