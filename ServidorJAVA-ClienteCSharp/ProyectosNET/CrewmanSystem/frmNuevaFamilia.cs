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
	public partial class frmNuevaFamilia : Form
	{
        private FamiliaWS.FamiliaWSClient daoFamilia;
        public frmNuevaFamilia()
		{
			InitializeComponent();
            daoFamilia = new FamiliaWS.FamiliaWSClient();
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
					else
					{
                        if(textBox == txtDescripcion)
						{
                            String txtNombreAux = string.Join("", textBox.Text.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
                            if (!txtNombreAux.All(Char.IsLetter))
							{
                                MessageBox.Show("Los datos de " +
                                    textBox.Name.Substring(3) + " solo pueden contener letras");
                                return;
                            }    
						}
					}
                }
            }
            //AQUI VA EL INSERTAR
            frmConfirmarInsertar formInsertar = new frmConfirmarInsertar();
            if (formInsertar.ShowDialog() == DialogResult.OK)
            {
                FamiliaWS.familia familia = new FamiliaWS.familia();
                familia.descripcion = txtDescripcion.Text;
                int resultado = daoFamilia.insertarFamilia(familia);
                txtId.Text = resultado.ToString();
                //Usar resultado para ver si se inserto correctamente
            }
        }
	}
}
