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
            if (frmVentanaPrincipal.nBtn == 1)
            {
                frmGestionarFacturas.facturaSeleccionada = (FacturaWS.factura)frmGestionarFacturas.dgv.CurrentRow.DataBoundItem;
                FacturaWS.factura miFactura = frmGestionarFacturas.facturaSeleccionada;
                txtIdFactura.Text = miFactura.idFactura.ToString();
                txtIdPedido.Text = miFactura.pedido.idPedido.ToString();
                txtMontoPendiente.Text = miFactura.pedido.montoPagar.ToString();
                txtMonto.Text = miFactura.monto.ToString();
                if (miFactura.estadoPagar)
                {
                    cboEstadoPagar.SelectedIndex = 0;
                    cboEstadoPagar.Enabled = false;
                }

                else cboEstadoPagar.SelectedIndex = 1;
                txtObservacion.Text = miFactura.observacion;
                dtpEmision.Value = miFactura.fechaEmision;
                dtpVencimiento.Value = miFactura.fechaVencimiento;
                txtImpuestos.Text = miFactura.impuestos.ToString();
                btnBuscarPedido.Enabled = false;
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
                    else
                    {
                        try
                        {
                            double impuestos = Convert.ToDouble(txtImpuestos.Text);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Los datos del impuesta de la factura solo pueden contener dígitos",
                                "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        try
                        {
                            double monto = Convert.ToDouble(txtMonto.Text);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Los datos del monto de la factura solo pueden contener dígitos",
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
                factura.fechaVencimientoSpecified = true;
                factura.impuestos = Math.Round(factura.monto * 0.18, 2);
                txtImpuestos.Text = factura.impuestos.ToString("n2");
                if (cboEstadoPagar.Text == "PAGADO") factura.estadoPagar = true;
                else factura.estadoPagar = false;

                if (frmVentanaPrincipal.nBtn == 0)
                {
                    int resultado = daoFactura.insertarFactura(factura);
                    if (resultado == 0)
                    {
                        MessageBox.Show("No se insertó correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Se insertó correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdFactura.Text = resultado.ToString();
                        txtMontoPendiente.Text = (Convert.ToDouble(txtMontoPendiente.Text) - Convert.ToDouble(txtMonto.Text)).ToString();
                    }
                }
                else if (frmVentanaPrincipal.nBtn == 1)
                {
                    factura.idFactura = Convert.ToInt32(txtIdFactura.Text);
                    int resultado = daoFactura.actualizarFactura(factura);
                    if (resultado == 0)
                    {
                        MessageBox.Show("No se actualizó correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Se actualizó correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdFactura.Text = resultado.ToString();
                        txtMontoPendiente.Text = (frmGestionarFacturas.facturaSeleccionada.pedido.montoPagar - Convert.ToDouble(txtMonto.Text)).ToString();
                    }
                }
            }
        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            frmBuscarPedido formBusquedaPedidoAPagar = new frmBuscarPedido(1);
            if (formBusquedaPedidoAPagar.ShowDialog() == DialogResult.OK)
            {
                pedidoSeleccionado = frmBuscarPedido.pedidoSeleccionado;
                txtIdPedido.Text = pedidoSeleccionado.idPedido.ToString();
                txtMontoPendiente.Text = pedidoSeleccionado.montoPagar.ToString("n2");
            }
        }

    }
}
