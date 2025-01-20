using Modelo.Auditorias;
using Modelo.Entidades;
using Org.BouncyCastle.Cms;
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
    public partial class FormConsultarIngreso : Form
    {
        private Ingreso ingreso;
        private AuditoriaIngreso auditoriaIngreso;
        private string origen;

        public FormConsultarIngreso(Ingreso ingreso)
        {
            InitializeComponent();
            this.ingreso = ingreso;
            origen = "reporte ingreso";
        }

        public FormConsultarIngreso(AuditoriaIngreso auditoriaIngreso)
        {
            InitializeComponent();
            this.auditoriaIngreso = auditoriaIngreso;
            origen = "auditoria ingreso";
        }

        private void FormConsultarIngreso_Load(object sender, EventArgs e)
        {
            if (origen == "reporte ingreso")
            {
                txtCodigo.Text = ingreso.Codigo.ToString();
                txtTotal.Text = ingreso.PrecioTotal.ToString();
                txtFecha.Text = ingreso.Fecha.ToString("dd/MM/yyyy");

                txtApellido.Text = ingreso.Agricultor.Apellido;
                txtNombre.Text = ingreso.Agricultor.Nombre;
                txtDni.Text = ingreso.Agricultor.Dni.ToString();
                txtCuit.Text = ingreso.Agricultor.NroCuit;

                txtCodSemilla.Text = ingreso.Semilla.Codigo;
                txtClaseSemilla.Text = ingreso.Semilla.Clase;
                txtCantSemilla.Text = ingreso.Cantidad.ToString() + " Kg";

                txtPatente.Text = ingreso.Transporte.Patente;
                txtMarca.Text = ingreso.Transporte.Marca;
                txtModelo.Text = ingreso.Transporte.Modelo;
            }
            else if (origen == "auditoria ingreso")
            {
                txtCodigo.Text = auditoriaIngreso.Codigo.ToString();
                txtTotal.Text = auditoriaIngreso.PrecioTotal.ToString();
                txtFecha.Text = auditoriaIngreso.Fecha.ToString("dd/MM/yyyy");

                txtApellido.Text = auditoriaIngreso.Agricultor.Apellido;
                txtNombre.Text = auditoriaIngreso.Agricultor.Nombre;
                txtDni.Text = auditoriaIngreso.Agricultor.Dni.ToString();
                txtCuit.Text = auditoriaIngreso.Agricultor.NroCuit;

                txtCodSemilla.Text = auditoriaIngreso.Semilla.Codigo;
                txtClaseSemilla.Text = auditoriaIngreso.Semilla.Clase;
                txtCantSemilla.Text = auditoriaIngreso.Cantidad.ToString() + " Kg";

                txtPatente.Text = auditoriaIngreso.Transporte.Patente;
                txtMarca.Text = auditoriaIngreso.Transporte.Marca;
                txtModelo.Text = auditoriaIngreso.Transporte.Modelo;
            }
        }
    }
}
