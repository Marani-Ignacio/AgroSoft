using Controladora;
using Microsoft.EntityFrameworkCore;
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
using DocumentFormat.OpenXml.Presentation;

namespace Vista
{
    public partial class FormCargarVenta : Form
    {
        private List<DetalleVenta> detallesVenta = new List<DetalleVenta>();
        private Usuario usuario;

        public FormCargarVenta(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FormCargarVenta_Load(object sender, EventArgs e)
        {
            cbProducto.Items.Clear();
            var productos = ControladoraProductos.Instancia.ListarProductos();
            foreach (var producto in productos)
            {
                cbProducto.Items.Add(producto.Codigo);
            }
        }

        public void ActualizarGrilla()
        {
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = detallesVenta;
            DgvConfig();

            if (detallesVenta.Count >= 1)
            {
                txtDni.Enabled = false;
            }
            else
            {
                txtDni.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Contexto contexto = Modelo.GContext.ObtenerContexto();

                Cliente cliente = contexto.Clientes.FirstOrDefault(c => c.Dni == Convert.ToInt32(txtDni.Text));
                Producto producto = contexto.Productos.FirstOrDefault(p => p.Codigo == cbProducto.Text);

                if (cliente == null)
                {
                    MessageBox.Show("No existe el cliente ingresado");
                    return;
                }

                if (producto == null)
                {
                    MessageBox.Show("No existe el producto seleccionado");
                    return;
                }

                if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Ingrese la cantidad correctamente");
                    return;
                }

                if (cantidad > producto.Stock)
                {
                    MessageBox.Show("No hay stock suficiente del producto");
                    return;
                }

                var detalleVentaExistente = detallesVenta.FirstOrDefault(dv => dv.Producto.Codigo == producto.Codigo);

                if (detalleVentaExistente != null)
                {
                    detalleVentaExistente.Cantidad += cantidad;
                    detalleVentaExistente.PrecioParcial += producto.PrecioUnidad * cantidad;
                }
                else
                {
                    var detalleVenta = new DetalleVenta
                    {
                        Producto = producto,
                        Cantidad = cantidad,
                        PrecioParcial = producto.PrecioUnidad * cantidad
                    };

                    detallesVenta.Add(detalleVenta);
                }

                ActualizarGrilla();                
                txtCantidad.Text = string.Empty;
                cbProducto.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.CurrentRow != null)
            {
                var productoSeleccionado = (DetalleVenta)dgvCarrito.CurrentRow.DataBoundItem;

                DialogResult respuesta = MessageBox.Show("¿Confirma que desea modicar el producto seleccionado de la compra?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    txtCantidad.Text = productoSeleccionado.Cantidad.ToString();
                    cbProducto.Text = productoSeleccionado.Producto.Codigo.ToString();
                    detallesVenta.Remove(productoSeleccionado);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto que eliminar");
                return;
            }

            ActualizarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.CurrentRow != null)
            {
                var productoSeleccionado = (DetalleVenta)dgvCarrito.CurrentRow.DataBoundItem;

                DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el producto seleccionado de la compra?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    detallesVenta.Remove(productoSeleccionado);
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto que eliminar");
            }
        }

        private void iconRegistrar_Click(object sender, EventArgs e)
        {
            if (detallesVenta.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito de compras.");
                return;
            }

            decimal precioTotal = 0;

            foreach (var producto in detallesVenta)
            {
                precioTotal += producto.PrecioParcial;
            }

            var venta = new Venta
            {
                Fecha = dtpFecha.Value.Date,
                Cliente = ControladoraClientes.Instancia.EncontrarCliente(Convert.ToInt32(txtDni.Text)),
                DetallesVenta = detallesVenta,
                PrecioTotal = precioTotal,
            };

            var mensaje = Controladora.ControladoraVentas.Instancia.Agregar(venta);
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mensaje == "Venta registrada con éxito")
            {
                foreach (var detalle in detallesVenta)
                {
                    detalle.Producto.ActualizarStock(detalle.Cantidad);
                }

                var auditoriaVenta = new AuditoriaVenta
                {
                    Codigo = venta.Codigo,
                    Fecha = venta.Fecha,
                    Cliente = venta.Cliente,
                    DetallesVenta = venta.DetallesVenta,
                    PrecioTotal = venta.PrecioTotal,

                    Usuario = usuario,
                    TipoAuditoria = "Alta Registro Venta",
                    FechayHora = DateTime.Now,
                };

                Controladora.ControladoraAuditoriaVenta.Instancia.Agregar(auditoriaVenta);
            }

            this.Close();
        }

        private void btnConsultarAgricultor_Click(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = null;

            Cliente consumidor = Controladora.ControladoraClientes.Instancia.EncontrarCliente(Convert.ToInt32(txtDni.Text));

            if (consumidor == null)
            {
                MessageBox.Show("No existe un cliente con el Dni ingresado");
                return;
            }

            var mostrarConsumidor = new
            {
                consumidor.Nombre,
                consumidor.Apellido,
                consumidor.NroCuit,
                consumidor.Direccion
            };

            dgvConsulta.DataSource = new List<object> { mostrarConsumidor };
        }

        private void btnConsultarSemilla_Click(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = null;

            Producto producto = Controladora.ControladoraProductos.Instancia.EncontrarProducto(cbProducto.Text.ToUpper());

            if (producto == null)
            {
                MessageBox.Show("No existe un producto con el Código ingresado");
                return;
            }

            var mostrarProducto = new
            {
                producto.Nombre,
                producto.Marca,
                producto.PrecioUnidad,
                producto.Stock
            };

            dgvConsulta.DataSource = new List<object> { mostrarProducto };
        }

        public void DgvConfig()
        {
            dgvCarrito.Columns["DetalleVentaID"].Visible = false;
            dgvCarrito.Columns["ProductoID"].Visible = false;

            dgvCarrito.Columns["Producto"].Width = 522;
        }

        private void iconCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
