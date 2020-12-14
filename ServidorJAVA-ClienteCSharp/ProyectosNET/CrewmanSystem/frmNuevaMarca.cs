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
        private MarcaWS.MarcaWSClient daoMarca;
		public frmNuevaMarca()
		{
			InitializeComponent();
            if (frmVentanaPrincipal.nBtn == 1)
            {   
                //OBTENER DATOS DE FILA SELECCIONADA
                frmGestionarMarcas.marcaSeleccionada = (MarcaWS.marca)frmGestionarMarcas.dgv.CurrentRow.DataBoundItem;
                txtId.Text = frmGestionarMarcas.marcaSeleccionada.idMarca.ToString();
                txtNombre.Text = frmGestionarMarcas.marcaSeleccionada.nombre;
            }
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
                        MessageBox.Show("Falta llenar los datos de " + textBox.Name.Substring(3),
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
                                MessageBox.Show("Los datos de " + textBox.Name.Substring(3) + " solo pueden contener letras", 
                                    "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (frmVentanaPrincipal.nBtn == 0)
                {
                    int resultado = daoMarca.insertarMarca(marca);
                    txtId.Text = resultado.ToString();
                    if (resultado == 0)
                    {
                        MessageBox.Show("No se insertó correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ((frmGestionarMarcas)Program.pantallas[Program.pantallas.Count - 2].Formulario).recargarDGV();
                        MessageBox.Show("Se insertó correctamente", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (frmVentanaPrincipal.nBtn == 1)
                {
                    marca.idMarca = Int32.Parse(txtId.Text);
                    int resultado = daoMarca.actualizarMarca(marca);
                    if (resultado == 0)
                    {
                        MessageBox.Show("No se actualizó correctamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ((frmGestionarMarcas)Program.pantallas[Program.pantallas.Count - 2].Formulario).recargarDGV();
                        MessageBox.Show("Se actualizó correctamente", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
