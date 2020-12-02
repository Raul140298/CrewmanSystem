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
    public partial class frmNuevaGuiaRemision : Form
    {
        PedidoWS.pedido pedidoSeleccionado;
        public frmNuevaGuiaRemision()
        {
            pedidoSeleccionado = new PedidoWS.pedido();
            InitializeComponent();
        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            frmBuscarPedido formBusquedaPedidoAGuiaRemision = new frmBuscarPedido(2);
            if (formBusquedaPedidoAGuiaRemision.ShowDialog() == DialogResult.OK)
            {
                pedidoSeleccionado = frmBuscarPedido.pedidoSeleccionado;
                txtIdPedido.Text = pedidoSeleccionado.idPedido.ToString();
            }
        }
    }
}
