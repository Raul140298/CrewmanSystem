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
		private ZonaWS.ZonaWSClient daoZona;
		public frmNuevaZona()
		{
			daoZona = new ZonaWS.ZonaWSClient();
			InitializeComponent();
			if (frmVentanaPrincipal.nBtn == 1)
			{   //OBTNER DATOS DE FILA SELECCIONADA
				frmGestionarZonas.zonaSeleccionada = (ZonaWS.zona)frmGestionarZonas.dgv.CurrentRow.DataBoundItem;
				txtId.Text = frmGestionarZonas.zonaSeleccionada.idZona.ToString();
				txtNombre.Text = frmGestionarZonas.zonaSeleccionada.nombre;
			}
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
						MessageBox.Show("Falta llenar los datos de " +textBox.Name.Substring(3),
							"Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
					else
					{
						if (textBox == txtNombre)
						{
							String txtNombreAux = string.Join("", textBox.Text.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
							if (!txtNombreAux.All(Char.IsLetter))
							{
								MessageBox.Show("Los datos de " +textBox.Name.Substring(3) + " solo pueden contener letras",
									"Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								return;
							}
						}
					}
				}
			}
			
			frmConfirmarInsertar formInsertar = new frmConfirmarInsertar();
			if (formInsertar.ShowDialog() == DialogResult.OK)
			{
				ZonaWS.zona zona = new ZonaWS.zona();
				zona.nombre = txtNombre.Text;
				if (frmVentanaPrincipal.nBtn == 0) 
				{
					int resultado = daoZona.insertarZona(zona);
					txtId.Text = resultado.ToString();
					if(resultado == 0)
                    {
						MessageBox.Show("No se insertó correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
						MessageBox.Show("Se insertó correctamente", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
                else if(frmVentanaPrincipal.nBtn == 1)
                {
					zona.idZona = Convert.ToInt32(txtId.Text);
					int resultado = daoZona.actualizarZona(zona);
					if (resultado == 0)
					{
						MessageBox.Show("No se actualizó correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						MessageBox.Show("Se actualizó correctamente", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
        }
    }
}
