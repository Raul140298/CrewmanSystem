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
	public partial class frmNuevaQueja : Form
	{
        PedidoWS.pedido pedidoSeleccionado = new PedidoWS.pedido();
        QuejaWS.QuejaWSClient daoQueja = new QuejaWS.QuejaWSClient();

        public frmNuevaQueja()
		{
			InitializeComponent();
		}

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            frmBuscarBorrador formBusquedaPedidoAPagar = new frmBuscarBorrador(1);
            if (formBusquedaPedidoAPagar.ShowDialog() == DialogResult.OK)
            {
                pedidoSeleccionado = frmBuscarBorrador.pedidoSeleccionado;
                txtIdPedido.Text = pedidoSeleccionado.idPedido.ToString();
            }
        }

		private void btnGuardar_Click(object sender, EventArgs e)
		{
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty && textBox.Name != "txtIdPedido" && textBox.Name != "txtMontoPendiente" && textBox.Name != "txtIdFactura")
                    {
                        MessageBox.Show("Falta llenar los datos de " + textBox.Name.Substring(3),
                            "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            //Insertar queja
            frmConfirmarInsertar formInsertar = new frmConfirmarInsertar();
            if (formInsertar.ShowDialog() == DialogResult.OK)
            {
                QuejaWS.queja queja = new QuejaWS.queja();
                queja.pedido = new QuejaWS.pedido();
                queja.pedido.idPedido = Int32.Parse(txtIdPedido.Text);
                queja.descripcion = txtObservacion.Text;
                int resultado = daoQueja.insertarQueja(queja);
                if (resultado == 0)
                {
                    MessageBox.Show("No se insertó correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ((frmGestionarQuejas)Program.pantallas[Program.pantallas.Count - 2].Formulario).recargarDGV();
                    MessageBox.Show("Se insertó correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdFactura.Text = resultado.ToString();
                }
            }
        }
	}
}
