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
    public partial class FormTransporte : Form
    {
        private Transporte transporte;
        private Agricultor agricultor;
        private Industria industria;
        private bool modificar = false;
        private bool transporteAgricultor = false;
        private bool transporteIndustria = false;

        public FormTransporte()
        {
            InitializeComponent();
        }

        public FormTransporte(Transporte transporte)
        {
            InitializeComponent();
            this.transporte = transporte;
            modificar = true;
        }

        public FormTransporte(Agricultor agricultor)
        {
            InitializeComponent();
            this.agricultor = agricultor;
            transporteAgricultor = true;
        }

        public FormTransporte(Industria industria)
        {
            InitializeComponent();
            this.industria = industria;
            transporteIndustria = true;
        }

        private void FormTransporte_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                this.Text = "Modificar";
                txtPatente.Enabled = false;
                txtPatente.Text = transporte.Patente;
                txtMarca.Text = transporte.Marca;
                txtModelo.Text = transporte.Modelo;
                txtTara.Text = transporte.Tara.ToString();
            }
            else
            {
                this.Text = "Agregar";
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtPatente.Text))
            {
                MessageBox.Show("Ingrese la Patente correctamente");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("Ingrese la Marca correctamente");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("Ingrese el Modelo correctamente");
                return false;
            }

            int Tara;
            if (!int.TryParse(txtTara.Text, out Tara))
            {
                MessageBox.Show("Ingrese la Tara correctamente");
                return false;
            }

            return true;
        }        

        private void iconAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }
            if (modificar)
            {
                transporte.Patente = txtPatente.Text.ToUpper();
                transporte.Marca = txtMarca.Text;
                transporte.Modelo = txtModelo.Text;
                transporte.Tara = Convert.ToInt32(txtTara.Text);

                var mensaje = Controladora.ControladoraTransportes.Instancia.Modificar(transporte);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var transporte = new Transporte()
                {
                    Patente = txtPatente.Text.ToUpper(),
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    Tara = Convert.ToInt32(txtTara.Text),
                };

                var mensaje = Controladora.ControladoraTransportes.Instancia.Agregar(transporte);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (transporteAgricultor)
                {
                    if (mensaje == "Transporte agregado con éxito")
                    {
                        if (agricultor.Transportes == null)
                        {
                            agricultor.Transportes = new List<Transporte>();
                        }
                        agricultor.Transportes.Add(transporte);
                        var mensajeAgri = Controladora.ControladoraAgricultores.Instancia.Modificar(agricultor);
                        MessageBox.Show(mensajeAgri, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (transporteIndustria)
                {
                    if (mensaje == "Transporte agregado con éxito")
                    {
                        if (industria.Transportes == null)
                        {
                            industria.Transportes = new List<Transporte>();
                        }
                        industria.Transportes.Add(transporte);
                        var mensajeIndu = Controladora.ControladoraIndustrias.Instancia.Modificar(industria);
                        MessageBox.Show(mensajeIndu, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            this.Close();
        }

        private void iconCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
