using DocumentFormat.OpenXml.Drawing;
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
    public partial class FormClienteTransporte : Form
    {
        private Agricultor agricultor;
        private Industria industria;
        private bool seleccionAgricultor = false;
        private bool seleccionIndustria = false;

        public FormClienteTransporte(Agricultor agricultor)
        {
            InitializeComponent();
            this.agricultor = agricultor;
            seleccionAgricultor = true;
        }

        public FormClienteTransporte(Industria industria)
        {
            InitializeComponent();
            this.industria = industria;
            seleccionIndustria = true;
        }

        private void FormClienteTransporte_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            if (dgvClienteTransporte.Columns.Count > 0)
            {
                DgvConfig();
            }
        }

        public void ActualizarGrilla()
        {
            Controladora.ControladoraTransportes.Instancia.ListarTransportes();
            if (seleccionAgricultor)
            {
                dgvClienteTransporte.DataSource = null;
                if (agricultor.Transportes != null)
                {
                    dgvClienteTransporte.DataSource = agricultor.Transportes.ToList();
                }
            }
            if (seleccionIndustria)
            {
                dgvClienteTransporte.DataSource = null;
                if (industria.Transportes != null)
                {
                    dgvClienteTransporte.DataSource = industria.Transportes.ToList();
                }
            }
        }

        private void iconEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClienteTransporte.CurrentRow != null)
            {
                var transporteSeleccionado = (Transporte)dgvClienteTransporte.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el transporte seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    var mensaje = Controladora.ControladoraTransportes.Instancia.Eliminar(transporteSeleccionado);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un transporte que eliminar");
            }
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void DgvConfig()
        {
            dgvClienteTransporte.Columns["TransporteID"].Visible = false;

            dgvClienteTransporte.Columns["Patente"].Width = 130;
            dgvClienteTransporte.Columns["Patente"].DisplayIndex = 0;

            dgvClienteTransporte.Columns["Marca"].Width = 130;
            dgvClienteTransporte.Columns["Marca"].DisplayIndex = 1;

            dgvClienteTransporte.Columns["Modelo"].Width = 130;
            dgvClienteTransporte.Columns["Modelo"].DisplayIndex = 2;

            dgvClienteTransporte.Columns["Tara"].Width = 130;
            dgvClienteTransporte.Columns["Tara"].DisplayIndex = 3;
        }
    }
}
