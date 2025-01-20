using Controladora.Controladoras_Seguridad;
using Modelo;
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
    public partial class FormGrupo : Form
    {
        private Grupo grupo;
        private bool modificar = false;

        public FormGrupo()
        {
            InitializeComponent();
        }

        public FormGrupo(Grupo grupo)
        {
            InitializeComponent();
            this.grupo = grupo;
            modificar = true;
        }

        private void FormGrupo_Load(object sender, EventArgs e)
        {
            var permisos = Controladora.Controladoras_Seguridad.ControladoraPermisos.Instancia.ListarPermisos();

            if (modificar)
            {
                this.Text = "Modificar Grupo";
                txtNombre.Text = grupo.Nombre;
                txtNombre.Enabled = false;
                txtDescripcion.Text = grupo.Descripcion;
            }
            else
            {
                this.Text = "Agregar Grupo";
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el Nombre correctamente");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Ingrese la Descripción correctamente");
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
                grupo.Nombre = txtNombre.Text;
                grupo.Descripcion = txtDescripcion.Text;

                var mensaje = ControladoraGrupos.Instancia.Modificar(grupo);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var nuevoGrupo = new Grupo()
                {
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                };

                var mensaje = ControladoraGrupos.Instancia.Agregar(nuevoGrupo);
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
