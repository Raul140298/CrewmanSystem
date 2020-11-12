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
	public partial class frmNuevaPromocion : Form
	{
        ZonaWS.ZonaWSClient daoZona = new ZonaWS.ZonaWSClient();
        public frmNuevaPromocion()
		{
			InitializeComponent();
            cboZona.DataSource = new BindingList<ZonaWS.zona>(daoZona.listarZonas().ToArray());
            cboZona.ValueMember = "idZona";
            cboZona.DisplayMember = "nombre";
        }

        private void btnBuscarProductoXZona_Click(object sender, EventArgs e)
        {
            frmBuscarZona formBusquedaZona = new frmBuscarZona();
            if(formBusquedaZona.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnBuscarProductoXZona_Click_1(object sender, EventArgs e)
        {
            frmBuscarZona formBusquedaZona = new frmBuscarZona();
            if(formBusquedaZona.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmBuscarProductoPorZona formBusquedaProductoPorZona = new frmBuscarProductoPorZona();
            if(formBusquedaProductoPorZona.ShowDialog() == DialogResult.OK)
            {

            }
        }

		private void btnGuardar_Click(object sender, EventArgs e)
		{
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty && textBox.Name != "txtId")
                    {
                        MessageBox.Show("Falta llenar los datos de " +
                            textBox.Name.Substring(3) + " de " + groupBox1.Text);
                        return;
                    }
                }
            }

            foreach (Control c in groupBox2.Controls)
            {
                if (c is ComboBox)
                {
                    ComboBox cmbBox = c as ComboBox;
                    if (cmbBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("Falta llenar los datos de " +
                            cmbBox.Name.Substring(3));
                        return;
                    }
                }
            }

            foreach (Control c in groupBox3.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty && textBox.Name != "txtId")
                    {
                        MessageBox.Show("Falta llenar los datos de " +
                            textBox.Name.Substring(3) + " de " + groupBox3.Text);
                        return;
                    }
                }
            }
        }
	}
}
