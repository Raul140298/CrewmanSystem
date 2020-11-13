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
	public partial class frmGestionarProductosXZona : Form
	{
		private ProductoXZonaWS.ProductoXZonaWSClient daoProductosXZona;
		public frmGestionarProductosXZona()
		{
			daoProductosXZona = new ProductoXZonaWS.ProductoXZonaWSClient();
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
			ProductoXZonaWS.productoXZona[] misProductoXZonas = daoProductosXZona.listarProductosXZonas("", "");
			if (misProductoXZonas != null)
			{
				dataGridView1.DataSource = new BindingList<ProductoXZonaWS.productoXZona>(misProductoXZonas.ToArray());
			}
			else
			{
				dataGridView1.DataSource = new BindingList<ProductoXZonaWS.productoXZona>();

			}

			#region colores de seleccion
			dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dataGridView1.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dataGridView1.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			//castear objetos y mostrar valor determinado
			ProductoXZonaWS.productoXZona productoXZona = dataGridView1.Rows[e.RowIndex].DataBoundItem
			as ProductoXZonaWS.productoXZona;

			dataGridView1.Rows[e.RowIndex].Cells["ID_PRODUCTO"].Value = productoXZona.producto.idProducto;
			dataGridView1.Rows[e.RowIndex].Cells["PRODUCTO"].Value = productoXZona.producto.nombre;
			dataGridView1.Rows[e.RowIndex].Cells["ID_ZONA"].Value = productoXZona.zona.idZona;
			dataGridView1.Rows[e.RowIndex].Cells["ZONA"].Value = productoXZona.zona.nombre;
		}
	}
}
