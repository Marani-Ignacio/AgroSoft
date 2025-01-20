using Controladora;
using Microsoft.Win32;
using Modelo;
using Modelo.Entidades;
using Modelo.Auditorias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;

namespace Vista
{
    public partial class FormIngresos : Form
    {
        private SaveFileDialog saveFileDialog;
        private Usuario usuario;

        public FormIngresos(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            ActualizarGrilla();
            ExcelConfig();
        }

        private void FormIngresos_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            dgvIngresos.DataSource = null;
            dgvIngresos.DataSource = Controladora.ControladoraIngresos.Instancia.ListarIngresos();
            DgvConfig();
        }

        private void btnNuevoIngreso_Click(object sender, EventArgs e)
        {
            var formCargaIngreso = new FormCargaIngreso(usuario);
            formCargaIngreso.ShowDialog();
            ActualizarGrilla();
        }

        private void iconEliminarRegistro_Click(object sender, EventArgs e)
        {
            if (dgvIngresos.CurrentRow != null)
            {
                var registroSeleccionado = (Ingreso)dgvIngresos.CurrentRow.DataBoundItem;

                DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el registro seleccionado de la base de datos?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    var mensaje = Controladora.ControladoraIngresos.Instancia.Eliminar(registroSeleccionado);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();

                    if (mensaje == "Registro de ingreso eliminado con éxito")
                    {
                        var auditoriaingreso = new AuditoriaIngreso
                        {
                            Codigo = registroSeleccionado.Codigo,
                            Fecha = registroSeleccionado.Fecha,
                            Agricultor = registroSeleccionado.Agricultor,
                            Semilla = registroSeleccionado.Semilla,
                            Transporte = registroSeleccionado.Transporte,
                            Cantidad = registroSeleccionado.Cantidad,
                            PrecioTotal = registroSeleccionado.PrecioTotal,

                            Usuario = usuario,
                            TipoAuditoria = "Baja Registro Ingreso",
                            FechayHora = DateTime.Now,
                        };

                        Controladora.ControladoraAuditoriaIngreso.Instancia.Agregar(auditoriaingreso);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro que eliminar");
            }
        }

        private void iconCartadePorte_Click(object sender, EventArgs e)
        {
            if (dgvIngresos.CurrentRow != null)
            {
                var ingresoSeleccionado = (Ingreso)dgvIngresos.CurrentRow.DataBoundItem;
                var formCartadePorte = new FormCartadePorte(ingresoSeleccionado);
                formCartadePorte.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un ingreso para generar su carta de porte.");
            }
        }

        private void iconExportarExcel_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Confirma que desea exportar los ingresos a excel?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ControladoraIngresos.Instancia.ExportarAExcel(saveFileDialog.FileName);
                    MessageBox.Show("Datos de Ingresos exportados con éxito");
                }
            }
        }

        private void dgvIngresos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var ingresoSeleccionado = (Ingreso)dgvIngresos.Rows[e.RowIndex].DataBoundItem;

                using (var contexto = new Contexto())
                {
                    var agricultor = contexto.Agricultores.FirstOrDefault(a => a.AgricultorID == ingresoSeleccionado.Agricultor.AgricultorID);
                    var semilla = contexto.Semillas.FirstOrDefault(s => s.SemillaID == ingresoSeleccionado.Semilla.SemillaID);
                    var transporte = contexto.Transportes.FirstOrDefault(t => t.TransporteID == ingresoSeleccionado.Transporte.TransporteID);

                    dgvDatosAgricultor.DataSource = new List<Object> { agricultor };
                    dgvDatosSemilla.DataSource = new List<Object> { semilla };
                    dgvDatosTransporte.DataSource = new List<Object> { transporte };

                    OcultarID();
                }
            }
        }        

        public void DgvConfig()
        {
            dgvIngresos.Columns["IngresoID"].Visible = false;
            dgvIngresos.Columns["AgricultorID"].Visible = false;
            dgvIngresos.Columns["SemillaID"].Visible = false;
            dgvIngresos.Columns["TransporteID"].Visible = false;

            dgvIngresos.Columns["Codigo"].DisplayIndex = 0;
            dgvIngresos.Columns["Codigo"].Width = 140;

            dgvIngresos.Columns["Fecha"].DisplayIndex = 1;
            dgvIngresos.Columns["Fecha"].Width = 140;

            dgvIngresos.Columns["Agricultor"].DisplayIndex = 2;
            dgvIngresos.Columns["Agricultor"].Width = 140;

            dgvIngresos.Columns["Transporte"].DisplayIndex = 3;
            dgvIngresos.Columns["Transporte"].Width = 140;

            dgvIngresos.Columns["Semilla"].DisplayIndex = 4;
            dgvIngresos.Columns["Semilla"].Width = 140;

            dgvIngresos.Columns["Cantidad"].DisplayIndex = 5;
            dgvIngresos.Columns["Cantidad"].Width = 140;

            dgvIngresos.Columns["PrecioTotal"].DisplayIndex = 6;
            dgvIngresos.Columns["PrecioTotal"].Width = 140;
        }

        public void OcultarID()
        {
            dgvDatosAgricultor.Columns["AgricultorID"].Visible = false;
            dgvDatosAgricultor.Columns["Telefono"].Visible = false;
            dgvDatosSemilla.Columns["SemillaID"].Visible = false;
            dgvDatosSemilla.Columns["PrecioToneladaVenta"].Visible = false;
            dgvDatosTransporte.Columns["TransporteID"].Visible = false;
        }
     
        public void ExcelConfig()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar como Excel";
            saveFileDialog.FileName = "Ingresos";
        }
    }
}
