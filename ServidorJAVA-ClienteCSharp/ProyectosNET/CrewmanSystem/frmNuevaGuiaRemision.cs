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
        PedidoWS.PedidoWSClient daoPedido;
        GuiaRemisionWS.GuiaRemisionWSClient daoGuiaRemision;
       
        public frmNuevaGuiaRemision()
        {
            pedidoSeleccionado = new PedidoWS.pedido();
            daoGuiaRemision = new GuiaRemisionWS.GuiaRemisionWSClient();
            daoPedido = new PedidoWS.PedidoWSClient();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuiaRemisionWS.guiaRemision guiaRemision = new GuiaRemisionWS.guiaRemision();
            int resultado=daoPedido.entregarPedido(pedidoSeleccionado.idPedido);
            if (resultado == 0)
            {
                MessageBox.Show("No se entrego el pedido", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            guiaRemision.motivoTraslado = txtMotivoTraslado.Text;
            guiaRemision.pedido = new GuiaRemisionWS.pedido();
            guiaRemision.pedido.idPedido = pedidoSeleccionado.idPedido;
            guiaRemision.fechaRegistroSpecified = true;
            guiaRemision.fechaTrasladoSpecified = true;
            guiaRemision.fechaRegistro = dtpRangoIniRegistro.Value;
            guiaRemision.fechaTraslado = dtpRangoIniTraslado.Value;

            resultado = daoGuiaRemision.insertarGuiaRemision(guiaRemision);
            if(resultado == 0)
            {
                MessageBox.Show("No se insertó correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Se insertó correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdGuiaRemision.Text = resultado.ToString();
            }
        }
    }
}
