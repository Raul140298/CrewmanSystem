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
		public frmNuevaFactura()
		{
			InitializeComponent();
		}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty && textBox.Name != "txtIdPedido" && textBox.Name != "txtMontoPendiente")
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
                        try
                        {
                            double impuestos = Convert.ToDouble(txtImpuestos.Text);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Los datos de " +
                                txtImpuestos.Name.Substring(3) + " solo pueden contener dígitos");
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
            //Insertar factura

        }

        private void btnBuscarProductoXZona_Click(object sender, EventArgs e)
        {
            frmBuscarPedido formBusquedaPedido = new frmBuscarPedido();
            if(formBusquedaPedido.ShowDialog() == DialogResult.OK)
            {

            }
        }

    }
}
