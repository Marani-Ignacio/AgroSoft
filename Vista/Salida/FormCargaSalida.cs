using Controladora;
using Modelo.Auditorias;
using Modelo.Entidades;
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
    public partial class FormCargaSalida : Form
    {
        private Usuario usuario;

        public FormCargaSalida(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FormCargaSalida_Load(object sender, EventArgs e)
        {
            var semillas = Controladora.ControladoraSemillas.Instancia.ListarSemillas();

            cbCodigo.Items.Clear();

            foreach (var semilla in semillas)
            {
                cbCodigo.Items.Add(semilla);
            }
        }

        private void iconRegistrar_Click(object sender, EventArgs e)
        {
            Contexto contexto = Modelo.GContext.ObtenerContexto();

            Industria industria = contexto.Industrias.FirstOrDefault(i => i.Cuil == txtCuil.Text);

            if (industria == null)
            {
                MessageBox.Show("No existe una industria con el Cuil ingresado");
                return;
            }

            Semilla semilla = contexto.Semillas.FirstOrDefault(s => s.Codigo == cbCodigo.Text);

            if (semilla == null)
            {
                MessageBox.Show("No existe una semilla con el código ingresado");
                return;
            }

            Transporte transporte = contexto.Transportes.FirstOrDefault(t => t.Patente == txtPatenteTransporte.Text.ToUpper());

            if (transporte == null)
            {
                MessageBox.Show("No existe un transporte con la patente ingresada");
                return;
            }

            int Cantidad;
            if (!int.TryParse(txtCantidad.Text, out Cantidad))
            {
                MessageBox.Show("Ingrese la Cantidad correctamente");
                return;
            }

            if (Cantidad > semilla.Cantidad)
            {
                MessageBox.Show("No hay cantidad suficiente de semillas disponibles");
                return;
            }

            if (Cantidad > transporte.Tara)
            {
                MessageBox.Show("La Cantidad ingresada es mayor a la que el Transporte puede cargar");
                return;
            }

            var salida = new Salida
            {
                Fecha = dtpFecha.Value.Date,
                Industria = Controladora.ControladoraIndustrias.Instancia.EncontrarIndustria(txtCuil.Text),
                Semilla = Controladora.ControladoraSemillas.Instancia.EncontrarSemilla(cbCodigo.Text),
                Transporte = Controladora.ControladoraTransportes.Instancia.EncontrarTransporte(txtPatenteTransporte.Text.ToUpper()),
                Cantidad = int.Parse(txtCantidad.Text),
                PrecioTotal = int.Parse(txtCantidad.Text) * (semilla.PrecioToneladaVenta / 1000),
            };

            var mensaje = Controladora.ControladoraSalidas.Instancia.Agregar(salida);
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            semilla.ActualizarSemillaxSalida(salida.Cantidad);
            contexto.SaveChanges();

            if (mensaje == "Salida registrada con éxito")
            {
                var auditoriasalida = new AuditoriaSalida
                {
                    Codigo = salida.Codigo,
                    Fecha = salida.Fecha,
                    Industria = salida.Industria,
                    Semilla = salida.Semilla,
                    Transporte = salida.Transporte,
                    Cantidad = salida.Cantidad,
                    PrecioTotal = salida.PrecioTotal,

                    Usuario = usuario,
                    TipoAuditoria = "Alta Registro Salida",
                    FechayHora = DateTime.Now,
                };

                Controladora.ControladoraAuditoriaSalida.Instancia.Agregar(auditoriasalida);
            }

            this.Close();
        }

        private void btnConsultarIndustria_Click(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = null;

            Industria industria = Controladora.ControladoraIndustrias.Instancia.EncontrarIndustria(txtCuil.Text);

            if (industria == null)
            {
                MessageBox.Show("No existe una industria con el Cuil ingresado");
                return;
            }

            var mostrarIndustria = new
            {
                industria.Cuil,
                industria.Nombre,
                industria.Direccion,
            };

            dgvConsulta.DataSource = new List<object> { mostrarIndustria };
        }

        private void btnConsultarSemilla_Click(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = null;

            Semilla semilla = Controladora.ControladoraSemillas.Instancia.EncontrarSemilla(cbCodigo.Text);

            if (semilla == null)
            {
                MessageBox.Show("No existe una semilla con el código ingresado");
                return;
            }

            var mostrarSemilla = new
            {
                semilla.Codigo,
                semilla.Nombre,
                semilla.Clase,
            };

            dgvConsulta.DataSource = new List<object> { mostrarSemilla };
        }

        private void btnConsultarTransporte_Click(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = null;

            Transporte transporte = Controladora.ControladoraTransportes.Instancia.EncontrarTransporte(txtPatenteTransporte.Text.ToUpper());

            if (transporte == null)
            {
                MessageBox.Show("No existe un Transporte con la patente ingresada");
                return;
            }

            var mostrarTransporte = new
            {
                transporte.Patente,
                transporte.Marca,
                transporte.Tara,
            };

            dgvConsulta.DataSource = new List<object> { mostrarTransporte };
        }

        private void iconCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
