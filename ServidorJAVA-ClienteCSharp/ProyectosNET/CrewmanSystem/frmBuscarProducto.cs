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
	public partial class frmBuscarProducto : Form
	{
		private ProductoWS.ProductoWSClient daoProducto;
		public frmBuscarProducto()
		{
			daoProducto = new ProductoWS.ProductoWSClient();
			InitializeComponent();
			completarTabla();
			#region colores de seleccion
			dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dataGridView1.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dataGridView1.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

		private void completarTabla()
        {
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.DataSource = new BindingList<ProductoWS.producto>(daoProducto.listarProductos(txtNombre.Text, txtFamilia.Text, txtSubfamilia.Text, txtMarca.Text).ToArray());
		}

        private void btnBuscar_Click(object sender, EventArgs e)
        {
			completarTabla();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
			ProductoWS.producto producto = dataGridView1.Rows[e.RowIndex].DataBoundItem
			as ProductoWS.producto;
			dataGridView1.Rows[e.RowIndex].Cells["SUBFAMILIA"].Value = producto.subFamilia.descripcionSubFamilia;
			dataGridView1.Rows[e.RowIndex].Cells["FAMILIA"].Value = producto.subFamilia.familia.descripcion;
			dataGridView1.Rows[e.RowIndex].Cells["MARCA"].Value = producto.marca.nombre;
		}
	}
}
