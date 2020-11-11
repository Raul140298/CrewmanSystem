using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrewmanSystem
{
	public partial class frmNuevaZona : Form
	{
		ZonaWS.ZonaWSClient daoZona;
		public frmNuevaZona()
		{
			daoZona = new ZonaWS.ZonaWSClient();
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

			frmConfirmarInsertar formInsertar = new frmConfirmarInsertar();
			if (formInsertar.ShowDialog() == DialogResult.OK)
			{
				ZonaWS.zona zona = new ZonaWS.zona();
				zona.nombre = txtNombre.Text;
				int resultado = daoZona.insertarZona(zona);
				txtId.Text = resultado.ToString();
				//Usar resultado para ver si se inserto correctamente
			}
				
        }
    }
}
