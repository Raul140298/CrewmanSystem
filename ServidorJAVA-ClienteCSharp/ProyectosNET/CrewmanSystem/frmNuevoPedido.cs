using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrewmanSystem
{
	public partial class frmNuevoPedido : Form
	{
        public static ClienteWS.cliente clienteSeleccionado;
        public static ClienteWS.ClienteWSClient daoCliente;
        public static ProductoXZonaWS.productoXZona productoXZonaSeleccionado;
        public static PedidoWS.pedido pedido;
		public frmNuevoPedido()
		{
            daoCliente = new ClienteWS.ClienteWSClient();
            InitializeComponent();
		}

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente formBusquedaCliente = new frmBuscarCliente(1);
            if (formBusquedaCliente.ShowDialog() == DialogResult.OK)
            {
                clienteSeleccionado = frmBuscarCliente.clienteSeleccionado;

                txtRucCliente.Text = clienteSeleccionado.ruc.ToString();
                txtRazonSocial.Text = clienteSeleccionado.razonSocial;
                //pedido.lineasPedidos = null;
                txtIdProducto.Text = "";
                txtNombreProducto.Text = "";
                txtPrecioUnitario.Text = "";
                productoXZonaSeleccionado = null;
                //completarTabla();
            }
        }

        private void completarTabla()
        {
            dgvLineas.AutoGenerateColumns = false;
            if (pedido.lineasPedidos != null)
            {
                //dgvLineas.DataSource = new BindingList<LineaPedidoWS.lineaPedido>(pedido.lineasPedidos.ToArray());
            }
            else
            {
                //dgvLineas.DataSource = new BindingList<LineaPedidoWS.lineaPedido>();
            }
        }

        private void btnBuscarProductoXZona_Click(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text == "")
            {
                MessageBox.Show("Debe escoger un cliente","Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmBuscarProductoPorZona formBusquedaProductoPorZona = new frmBuscarProductoPorZona(clienteSeleccionado.zona.idZona);
            if (formBusquedaProductoPorZona.ShowDialog() == DialogResult.OK)
            {
                productoXZonaSeleccionado = frmBuscarProductoPorZona.productoXZonaSeleccionado;
                txtIdProducto.Text = productoXZonaSeleccionado.idProductoXZona.ToString();
                txtNombreProducto.Text = productoXZonaSeleccionado.producto.nombre;
                txtPrecioUnitario.Text = productoXZonaSeleccionado.precioReal.ToString();
            }
        }
    }
}
