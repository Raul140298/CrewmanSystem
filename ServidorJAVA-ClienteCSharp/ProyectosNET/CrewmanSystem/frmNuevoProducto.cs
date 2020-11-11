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
	public partial class frmNuevoProducto : Form
	{
        FamiliaWS.FamiliaWSClient daoFamilia;
        SubFamiliaWS.SubFamiliaWSClient daoSubfamilia;

        public frmNuevoProducto()
		{
			InitializeComponent();

            daoFamilia = new FamiliaWS.FamiliaWSClient();
            daoSubfamilia = new SubFamiliaWS.SubFamiliaWSClient();

            FamiliaWS.familia[] misFamilias = daoFamilia.listarFamilias();
            if (misFamilias != null)
            {
                cboFamilia.DataSource = new BindingList<FamiliaWS.familia>(misFamilias.ToArray());
                cboFamilia.ValueMember = "idFamilia";
                cboFamilia.DisplayMember = "descripcion";
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
                                    textBox.Name.Substring(3) + " no son correctos");
                                return;
                            }
                        }
                        if (textBox == txtPrecioSugerido)
                        {
                            if (!textBox.Text.All(Char.IsDigit))
                            {
                                MessageBox.Show("Los datos de " +
                                    textBox.Name.Substring(3) + " no son correctos");
                                return;
                            }
                        }
                    }
                }
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

            //HACER LO QUE TIENE QUE HACER:
        }

		private void cboFamilia_SelectedIndexChanged(object sender, EventArgs e)
		{
            SubFamiliaWS.subFamilia[] misSubfamilias = daoSubfamilia.listarSubFamilias(((FamiliaWS.familia)cboFamilia.SelectedItem).descripcion);
            if (misSubfamilias != null)
            {
                cboSubfamilia.DataSource = new BindingList<SubFamiliaWS.subFamilia>(misSubfamilias.ToArray());
                cboSubfamilia.ValueMember = "idSubFamilia";
                cboSubfamilia.DisplayMember = "descripcionSubFamilia";
            }
        }

		private void cboSubfamilia_SelectedIndexChanged(object sender, EventArgs e)
		{
            
        }
	}
}
