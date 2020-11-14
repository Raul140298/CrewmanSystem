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
            {   //OBTNER DATOS DE FILA SELECCIONADA
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
                        MessageBox.Show("Falta llenar los datos de " + textBox.Name.Substring(3), 
                            "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (textBox == txtDescripcion)
                        {
                            String txtNombreAux = string.Join("", textBox.Text.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
                            if (!txtNombreAux.All(Char.IsLetter))
                            {
                                MessageBox.Show("Los datos de " + textBox.Name.Substring(3) + " solo pueden contener letras", 
                                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                }
            }

            frmConfirmarInsertar formInsertar = new frmConfirmarInsertar();
            if (formInsertar.ShowDialog() == DialogResult.OK)
            {   //VERIFICAR QUE TIPO DE BOTÓN SE MACHUCÓ Y DEPENDIENDO HACER ALGO
                FamiliaWS.familia familia = new FamiliaWS.familia();
                familia.descripcion = txtDescripcion.Text;
                if (frmVentanaPrincipal.nBtn == 0)
                {
                    int resultado = daoFamilia.insertarFamilia(familia);
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
                    familia.idFamilia = Int32.Parse(txtId.Text);
                    int resultado = daoFamilia.actualizarFamilia(familia);
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
