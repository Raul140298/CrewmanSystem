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
	public partial class frmNuevaFactura : Form
	{
        PedidoWS.pedido pedidoSeleccionado = new PedidoWS.pedido();
        FacturaWS.FacturaWSClient daoFactura = new FacturaWS.FacturaWSClient();
        string[] estado = { "PAGADO", "POR PAGAR" };
		public frmNuevaFactura()
		{
			InitializeComponent();
            cboEstadoPagar.DataSource = estado;
		}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty && textBox.Name != "txtIdPedido" && textBox.Name != "txtMontoPendiente" && textBox.Name != "txtIdFactura" && textBox.Name != "txtImpuestos")
                    {
                        MessageBox.Show("Falta llenar los datos de " + textBox.Name.Substring(3), 
                            "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        try
                        {
                            double monto = Convert.ToDouble(txtMonto.Text);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Los datos de " + txtMonto.Name.Substring(3) + " solo pueden contener dígitos",
                                "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }

            if (dtpEmision.Value > dtpVencimiento.Value)
            {
                MessageBox.Show("Rango de fechas inválido","Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Convert.ToDouble(txtMonto.Text) > Convert.ToDouble(txtMontoPendiente.Text))
            {
                MessageBox.Show("Monto de pago excede el monto pendiente", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Insertar factura
            frmConfirmarInsertar formInsertar = new frmConfirmarInsertar();
            if (formInsertar.ShowDialog() == DialogResult.OK)
            {
                FacturaWS.factura factura = new FacturaWS.factura();
                factura.pedido = new FacturaWS.pedido();
                factura.pedido.idPedido = pedidoSeleccionado.idPedido;
                factura.monto = Convert.ToDouble(txtMonto.Text);
                factura.observacion = txtObservacion.Text;
                factura.fechaVencimiento = dtpVencimiento.Value;
                factura.impuestos = Math.Round(factura.monto * 0.18,2);
                txtImpuestos.Text = factura.impuestos.ToString();
                if (cboEstadoPagar.Text == "PAGADO")
                {
                    factura.estadoPagar = true;
                }
                else
                {
                    factura.estadoPagar = false;
                }
                int idFactura = daoFactura.insertarFactura(factura);
                txtIdFactura.Text = idFactura.ToString();
                txtMontoPendiente.Text = (Convert.ToDouble(txtMontoPendiente.Text) - Convert.ToDouble(txtMonto.Text)).ToString();
            }
        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            frmBuscarPedidoAPagar formBusquedaPedidoAPagar = new frmBuscarPedidoAPagar();
            if (formBusquedaPedidoAPagar.ShowDialog() == DialogResult.OK)
            {
                pedidoSeleccionado = frmBuscarPedidoAPagar.pedidoSeleccionado;
                txtIdPedido.Text = pedidoSeleccionado.idPedido.ToString();
                txtMontoPendiente.Text = pedidoSeleccionado.montoPagar.ToString();
            }
        }

    }
}
