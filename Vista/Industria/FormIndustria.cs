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
    public partial class FormIndustria : Form
    {
        private Industria industria;
        private bool modificar = false;

        public FormIndustria()
        {
            InitializeComponent();
        }

        public FormIndustria(Industria industria)
        {
            InitializeComponent();
            this.industria = industria;
            modificar = true;
        }

        private void FormIndustria_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                this.Text = "Modificar";
                txtNroCuil.Enabled = false;
                txtNroCuil.Text = industria.Cuil;
                txtNombre.Text = industria.Nombre;
                txtDireccion.Text = industria.Direccion;
                txtTelefono.Text = industria.Telefono.ToString();
            }
            else
            {
                this.Text = "Agregar";
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNroCuil.Text))
            {
                MessageBox.Show("Ingrese el Cuil correctamente");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el Nombre correctamente");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Ingrese la Dirección correctamente");
                return false;
            }

            long Telefono;
            if (!long.TryParse(txtTelefono.Text, out Telefono))
            {
                MessageBox.Show("Ingrese el Teléfono correctamente");
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
                industria.Cuil = txtNroCuil.Text;
                industria.Nombre = txtNombre.Text;
                industria.Direccion = txtDireccion.Text;
                industria.Telefono = Convert.ToInt64(txtTelefono.Text);

                var mensaje = Controladora.ControladoraIndustrias.Instancia.Modificar(industria);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var industria = new Industria()
                {
                    Cuil = txtNroCuil.Text,
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = Convert.ToInt64(txtTelefono.Text),
                };

                var mensaje = Controladora.ControladoraIndustrias.Instancia.Agregar(industria);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void iconCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
