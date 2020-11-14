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
	public partial class frmGestionarProductos : Form
	{
		public static ProductoWS.ProductoWSClient daoProducto;
		public static ProductoWS.producto productoSeleccionado;
		public static DataGridView dgv;

		public frmGestionarProductos()
		{
			daoProducto = new ProductoWS.ProductoWSClient();
			InitializeComponent();
			dgv = dataGridView1;
			dataGridView1.AutoGenerateColumns = false;
			ProductoWS.producto[] misProductos = daoProducto.listarProductos("", "", "", "");
			if (misProductos != null)
			{
				dataGridView1.DataSource = new BindingList<ProductoWS.producto>(misProductos.ToArray());
			}
			else
			{
				dataGridView1.DataSource = new BindingList<ProductoWS.producto>();
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
			//Castear objetos y mostrar valor determinado
			ProductoWS.producto producto = dataGridView1.Rows[e.RowIndex].DataBoundItem
											as ProductoWS.producto;

			dataGridView1.Rows[e.RowIndex].Cells["SUBFAMILIA"].Value = producto.subFamilia.descripcionSubFamilia;

			dataGridView1.Rows[e.RowIndex].Cells["FAMILIA"].Value = producto.subFamilia.familia.descripcion;

			dataGridView1.Rows[e.RowIndex].Cells["MARCA"].Value = producto.marca.nombre;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			frmVentanaPrincipal.act.Enabled = false;
			frmVentanaPrincipal.elim.Enabled = false;
		}

		private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
		{
			//Preguntar al profe
			if (e.StateChanged != DataGridViewElementStates.Selected)
			{
				//frmVentanaPrincipal.act.Enabled = false;
				//frmVentanaPrincipal.elim.Enabled = false;
				return;
			}
			else
			{
				frmVentanaPrincipal.act.Enabled = true;
				frmVentanaPrincipal.elim.Enabled = true;
			}
		}

		public static void eliminar()
		{
			productoSeleccionado = (ProductoWS.producto)dgv.CurrentRow.DataBoundItem;
			daoProducto.eliminarProducto(productoSeleccionado.idProducto);
		}
	}
}
