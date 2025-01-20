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
using DocumentFormat.OpenXml.Presentation;

namespace Vista
{
    public partial class FormSalidas : Form
    {
        private SaveFileDialog saveFileDialog;
        private Usuario usuario;

        public FormSalidas(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            ActualizarGrilla();
            ExcelConfig();
        }

        private void FormSalidas_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            dgvSalidas.DataSource = null;
            dgvSalidas.DataSource = Controladora.ControladoraSalidas.Instancia.ListarSalidas();
            DgvConfig();
        }

        private void btnNuevaSalida_Click(object sender, EventArgs e)
        {
            var formCargaSalida = new FormCargaSalida(usuario);
            formCargaSalida.ShowDialog();
            ActualizarGrilla();
        }

        private void iconEliminarRegistro_Click(object sender, EventArgs e)
        {
            if (dgvSalidas.CurrentRow != null)
            {
                var registroSeleccionado = (Salida)dgvSalidas.CurrentRow.DataBoundItem;

                DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el registro seleccionado de la base de datos?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    var mensaje = Controladora.ControladoraSalidas.Instancia.Eliminar(registroSeleccionado);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();

                    if (mensaje == "Registro de salida eliminado con éxito")
                    {
                        var auditoriasalida = new AuditoriaSalida
                        {
                            Codigo = registroSeleccionado.Codigo,
                            Fecha = registroSeleccionado.Fecha,
                            Industria = registroSeleccionado.Industria,
                            Semilla = registroSeleccionado.Semilla,
                            Transporte = registroSeleccionado.Transporte,
                            Cantidad = registroSeleccionado.Cantidad,
                            PrecioTotal = registroSeleccionado.PrecioTotal,

                            Usuario = usuario,
                            TipoAuditoria = "Baja Registro Salida",
                            FechayHora = DateTime.Now,
                        };

                        Controladora.ControladoraAuditoriaSalida.Instancia.Agregar(auditoriasalida);
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
            if (dgvSalidas.CurrentRow != null)
            {
                var salidaSeleccionada = (Salida)dgvSalidas.CurrentRow.DataBoundItem;
                var formCartadePorte = new FormCartadePorte(salidaSeleccionada);
                formCartadePorte.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una salida para generar su carta de porte.");
            }
        }

        private void iconExportarExcel_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Confirma que desea exportar las salidas a excel?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ControladoraSalidas.Instancia.ExportarAExcel(saveFileDialog.FileName);
                    MessageBox.Show("Datos de Salidas exportados con éxito");
                }
            }
        }

        private void dgvSalidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var salidaSeleccionada = (Salida)dgvSalidas.Rows[e.RowIndex].DataBoundItem;

                using (var contexto = new Contexto())
                {
                    var industria = contexto.Industrias.FirstOrDefault(i => i.IndustriaID == salidaSeleccionada.Industria.IndustriaID);
                    var semilla = contexto.Semillas.FirstOrDefault(s => s.SemillaID == salidaSeleccionada.Semilla.SemillaID);
                    var transporte = contexto.Transportes.FirstOrDefault(t => t.TransporteID == salidaSeleccionada.Transporte.TransporteID);

                    dgvDatosIndustria.DataSource = new List<Object> { industria };
                    dgvDatosSemilla.DataSource = new List<Object> { semilla };
                    dgvDatosTransporte.DataSource = new List<Object> { transporte };

                    OcultarID();
                }
            }
        }



        public void DgvConfig()
        {
            dgvSalidas.Columns["SalidaID"].Visible = false;
            dgvSalidas.Columns["IndustriaID"].Visible = false;
            dgvSalidas.Columns["SemillaID"].Visible = false;
            dgvSalidas.Columns["TransporteID"].Visible = false;

            dgvSalidas.Columns["Codigo"].DisplayIndex = 0;
            dgvSalidas.Columns["Codigo"].Width = 140;

            dgvSalidas.Columns["Fecha"].DisplayIndex = 1;
            dgvSalidas.Columns["Fecha"].Width = 140;

            dgvSalidas.Columns["Industria"].DisplayIndex = 2;
            dgvSalidas.Columns["Industria"].Width = 140;

            dgvSalidas.Columns["Transporte"].DisplayIndex = 3;
            dgvSalidas.Columns["Transporte"].Width = 140;

            dgvSalidas.Columns["Semilla"].DisplayIndex = 4;
            dgvSalidas.Columns["Semilla"].Width = 140;

            dgvSalidas.Columns["Cantidad"].DisplayIndex = 5;
            dgvSalidas.Columns["Cantidad"].Width = 140;

            dgvSalidas.Columns["PrecioTotal"].DisplayIndex = 6;
            dgvSalidas.Columns["PrecioTotal"].Width = 140;
        }

        public void OcultarID()
        {
            dgvDatosIndustria.Columns["IndustriaID"].Visible = false;
            dgvDatosSemilla.Columns["SemillaID"].Visible = false;
            dgvDatosSemilla.Columns["PrecioToneladaCompra"].Visible = false;
            dgvDatosTransporte.Columns["TransporteID"].Visible = false;
        }       

        public void ExcelConfig()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar como Excel";
            saveFileDialog.FileName = "Salidas";
        }
    }
}
