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
            if (frmVentanaPrincipal.nBtn == 1)
            {
                frmGestionarFamilias.familiaSeleccionada = (FamiliaWS.familia)frmGestionarFamilias.dgv.CurrentRow.DataBoundItem;
                txtId.Text = frmGestionarFamilias.familiaSeleccionada.idFamilia.ToString();
                txtDescripcion.Text = frmGestionarFamilias.familiaSeleccionada.descripcion;
            }
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
                            textBox.Name.Substring(3), "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (textBox == txtDescripcion)
                        {
                            String txtNombreAux = string.Join("", textBox.Text.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
                            if (!txtNombreAux.All(Char.IsLetter))
                            {
                                MessageBox.Show("Los datos de " +
                                    textBox.Name.Substring(3) + " solo pueden contener letras", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                }
            }
            frmConfirmarInsertar formInsertar = new frmConfirmarInsertar();
            if (formInsertar.ShowDialog() == DialogResult.OK)
            {
                FamiliaWS.familia familia = new FamiliaWS.familia();
                familia.descripcion = txtDescripcion.Text;
                if (frmVentanaPrincipal.nBtn == 0)
                {
                    int resultado = daoFamilia.insertarFamilia(familia);
                    txtId.Text = resultado.ToString();
                }
                else if (frmVentanaPrincipal.nBtn == 1)
                {
                    familia.idFamilia = Int32.Parse(txtId.Text);
                    daoFamilia.actualizarFamilia(familia);
                }
            }
        }
    }
}
