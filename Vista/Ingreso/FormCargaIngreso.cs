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
    public partial class FormCargaIngreso : Form
    {
        private Usuario usuario;
        public FormCargaIngreso(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FormCargaIngreso_Load(object sender, EventArgs e)
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

            int DNI;
            if (!int.TryParse(txtDni.Text, out DNI))
            {
                MessageBox.Show("Ingrese el DNI correctamente");
                return;
            }

            Agricultor agricultor = contexto.Agricultores.FirstOrDefault(a => a.Dni == DNI);

            if (agricultor == null)
            {
                MessageBox.Show("No existe un agricultor con el Dni ingresado");
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

            if (Cantidad > transporte.Tara)
            {
                MessageBox.Show("La Cantidad ingresada es mayor a la que el Transporte puede cargar");
                return;
            }

            var ingreso = new Ingreso
            {
                Fecha = dtpFecha.Value.Date,
                Agricultor = Controladora.ControladoraAgricultores.Instancia.EncontrarAgricultor(int.Parse(txtDni.Text)),
                Semilla = Controladora.ControladoraSemillas.Instancia.EncontrarSemilla(cbCodigo.Text),
                Transporte = Controladora.ControladoraTransportes.Instancia.EncontrarTransporte(txtPatenteTransporte.Text.ToUpper()),
                Cantidad = int.Parse(txtCantidad.Text),
                PrecioTotal = int.Parse(txtCantidad.Text) * (semilla.PrecioToneladaCompra / 1000),
            };

            var mensaje = Controladora.ControladoraIngresos.Instancia.Agregar(ingreso);
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            semilla.ActualizarSemillaxIngreso(ingreso.Cantidad);
            contexto.SaveChanges();

            if (mensaje == "Ingreso registrado con éxito")
            {
                var auditoriaingreso = new AuditoriaIngreso
                {
                    Codigo = ingreso.Codigo,
                    Fecha = ingreso.Fecha,
                    Agricultor = ingreso.Agricultor,
                    Semilla = ingreso.Semilla,
                    Transporte = ingreso.Transporte,
                    Cantidad = ingreso.Cantidad,
                    PrecioTotal = ingreso.PrecioTotal,

                    Usuario = usuario,
                    TipoAuditoria = "Alta Registro Ingreso",
                    FechayHora = DateTime.Now,             
                };

                Controladora.ControladoraAuditoriaIngreso.Instancia.Agregar(auditoriaingreso);
            }

            this.Close();
        }

        private void btnConsultarAgricultor_Click(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = null;

            int DNI;
            if (!int.TryParse(txtDni.Text, out DNI))
            {
                MessageBox.Show("Ingrese el Dni correctamente");
                return;
            }

            Agricultor agricultor = Controladora.ControladoraAgricultores.Instancia.EncontrarAgricultor(DNI);

            if (agricultor == null)
            {
                MessageBox.Show("No existe un agricultor con el Dni ingresado");
                return;
            }

            var mostrarAgricultor = new
            {
                agricultor.Nombre,
                agricultor.Apellido,
                agricultor.Dni,
            };

            dgvConsulta.DataSource = new List<object> { mostrarAgricultor };
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
