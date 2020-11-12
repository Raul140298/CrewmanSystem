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
	public partial class frmNuevaMarca : Form
	{
        MarcaWS.MarcaWSClient daoMarca;
		public frmNuevaMarca()
		{
			InitializeComponent();
            daoMarca = new MarcaWS.MarcaWSClient();
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
                        if (textBox == txtNombre)
                        {
                            if (!textBox.Text.All(Char.IsLetter))
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
                MarcaWS.marca marca = new MarcaWS.marca();
                marca.nombre = txtNombre.Text;
                int resultado = daoMarca.insertarMarca(marca);
                txtId.Text = resultado.ToString();
                //Usar resultado para ver si se inserto correctamente
            }
        }
    }
}
