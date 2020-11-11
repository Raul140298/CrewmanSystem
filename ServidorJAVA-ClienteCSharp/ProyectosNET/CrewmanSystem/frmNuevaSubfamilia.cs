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
	public partial class frmNuevaSubfamilia : Form
	{
		public frmNuevaSubfamilia()
		{
			InitializeComponent();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
            foreach (Control c in panel2.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty && textBox.Name != "txtId")
                    {
                        MessageBox.Show("Falta llenar los datos de " +
                            textBox.Name.Substring(3));
                        return;
                    }
                }
            }
        }
	}
}
