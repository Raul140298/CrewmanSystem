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
    public partial class frmBuscarProductoPorZona : Form
    {
        private ProductoXZonaWS.ProductoXZonaWSClient daoProductoXZona;
        private ProductoXZonaWS.productoXZona[] misProductoXZona;
        private int idZona;
        public frmBuscarProductoPorZona(int idZonaParam)
        {
            InitializeComponent();
            idZona = idZonaParam;
            daoProductoXZona = new ProductoXZonaWS.ProductoXZonaWSClient();
            cargarTabla();
            #region colores de seleccion
            dgvProductos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
            dgvProductos.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

            dgvProductos.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
            dgvProductos.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

            dgvProductos.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
            dgvProductos.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
            #endregion
        }

        private void cargarTabla()
        {
            misProductoXZona = daoProductoXZona.listarProductosXZonas(txtNombre.Text,txtFamilia.Text,txtSubfamilia.Text,txtMarca.Text,idZona);
            if (misProductoXZona != null)
            {
                dgvProductos.DataSource = new BindingList<ProductoXZonaWS.productoXZona>(misProductoXZona.ToArray());
            }
            else
            {
                dgvProductos.DataSource = new BindingList<ProductoXZonaWS.productoXZona>();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
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
                        if (textBox == txtNombre | textBox == txtFamilia | textBox == txtSubfamilia | textBox == txtMarca)
                        {
                            String txtNombreAux = string.Join("", textBox.Text.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
                            if (!txtNombreAux.Trim().All(Char.IsLetter))
                            {
                                MessageBox.Show("Los datos de " +
                                    textBox.Name.Substring(3) + " solo pueden contener letras");
                                return;
                            }
                        }
                    }
                }
            }
            //AQUI VA EL BUSCAR
            cargarTabla();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }
    }
}
