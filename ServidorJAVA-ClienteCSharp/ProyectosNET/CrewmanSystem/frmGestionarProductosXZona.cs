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
			dgvProductoXZona.AutoGenerateColumns = false;
			ProductoXZonaWS.productoXZona[] misProductoXZonas = daoProductosXZona.listarProductosXZonas("","","","",0);
			if (misProductoXZonas != null)
			{
				dgvProductoXZona.DataSource = new BindingList<ProductoXZonaWS.productoXZona>(misProductoXZonas.ToArray());
			}
			else
			{
				dgvProductoXZona.DataSource = new BindingList<ProductoXZonaWS.productoXZona>();
			}

			#region colores de seleccion
			dgvProductoXZona.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvProductoXZona.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvProductoXZona.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvProductoXZona.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvProductoXZona.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvProductoXZona.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			//castear objetos y mostrar valor determinado
			ProductoXZonaWS.productoXZona productoXZona = dgvProductoXZona.Rows[e.RowIndex].DataBoundItem
			as ProductoXZonaWS.productoXZona;

			dgvProductoXZona.Rows[e.RowIndex].Cells["PRODUCTO"].Value = productoXZona.producto.nombre;
			dgvProductoXZona.Rows[e.RowIndex].Cells["CANT_UNIDADES"].Value = productoXZona.producto.cantUnidad;
			dgvProductoXZona.Rows[e.RowIndex].Cells["UNIDADES"].Value = productoXZona.producto.unidades;
			dgvProductoXZona.Rows[e.RowIndex].Cells["ZONA"].Value = productoXZona.zona.nombre;
			dgvProductoXZona.Rows[e.RowIndex].Cells["SUBFAMILIA"].Value = productoXZona.producto.subFamilia.descripcionSubFamilia;
			dgvProductoXZona.Rows[e.RowIndex].Cells["FAMILIA"].Value = productoXZona.producto.subFamilia.familia.descripcion;
			dgvProductoXZona.Rows[e.RowIndex].Cells["MARCA"].Value = productoXZona.producto.marca.nombre;
		}
	}
}
