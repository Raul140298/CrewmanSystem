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
        private SubFamiliaWS.SubFamiliaWSClient daoSubfamilia;
        private FamiliaWS.FamiliaWSClient daoFamilia;
        public frmNuevaSubfamilia()
        {
            InitializeComponent();
            
            daoSubfamilia = new SubFamiliaWS.SubFamiliaWSClient();
            daoFamilia = new FamiliaWS.FamiliaWSClient();
            FamiliaWS.familia[] misFamilias = daoFamilia.listarFamilias();
            BindingList<FamiliaWS.familia> listaFamilias;
            if (misFamilias != null) listaFamilias = new BindingList<FamiliaWS.familia>(misFamilias.ToArray());
            else listaFamilias = new BindingList<FamiliaWS.familia>();

            cboFamilia.DataSource = listaFamilias;
            cboFamilia.ValueMember = "idFamilia";
            cboFamilia.DisplayMember = "descripcion";


            if (frmVentanaPrincipal.nBtn == 1)
            {   //OBTNER DATOS DE FILA SELECCIONADA
                frmGestionarSubfamilias.subfamiliaSeleccionada = (SubFamiliaWS.subFamilia)frmGestionarSubfamilias.dgv.CurrentRow.DataBoundItem;
                txtId.Text = frmGestionarSubfamilias.subfamiliaSeleccionada.idSubFamilia.ToString();
                txtDescripcion.Text = frmGestionarSubfamilias.subfamiliaSeleccionada.descripcionSubFamilia;
                cboFamilia.SelectedValue = frmGestionarSubfamilias.subfamiliaSeleccionada.familia.idFamilia;
                cboFamilia.Enabled = false;
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
                        if (textBox == txtDescripcion)
                        {
                            String txtNombreAux = string.Join("", textBox.Text.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
                            if (!txtNombreAux.Trim().All(Char.IsLetter))
                            {
                                MessageBox.Show("Los datos de " +textBox.Name.Substring(3) + " solo pueden contener letras",
                                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                }

                if (c is ComboBox)
				{
                    ComboBox cmbBox = c as ComboBox;
                    if(cmbBox.SelectedIndex == -1)
					{
                        MessageBox.Show("Falta escoger el dato de " + cmbBox.Name.Substring(3), 
                            "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

            }

            frmConfirmarInsertar formInsertar = new frmConfirmarInsertar();
            if (formInsertar.ShowDialog() == DialogResult.OK)
            {
                SubFamiliaWS.subFamilia subFamilia = new SubFamiliaWS.subFamilia();
                subFamilia.descripcionSubFamilia = txtDescripcion.Text;
                subFamilia.familia = new SubFamiliaWS.familia();
                subFamilia.familia.idFamilia = ((FamiliaWS.familia)cboFamilia.SelectedItem).idFamilia;
                if (frmVentanaPrincipal.nBtn == 0)
                {
                    int resultado = daoSubfamilia.insertarSubFamilia(subFamilia);
                    txtId.Text = resultado.ToString();
                    if (resultado == 0)
                    {
                        MessageBox.Show("No se insertó correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Se insertó correctamente", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (frmVentanaPrincipal.nBtn == 1)
                {
                    subFamilia.idSubFamilia = Int32.Parse(txtId.Text);
                    int resultado = daoSubfamilia.actualizarSubFamilia(subFamilia);
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
