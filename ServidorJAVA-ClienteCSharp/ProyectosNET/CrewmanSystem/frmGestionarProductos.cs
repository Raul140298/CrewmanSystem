using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace CrewmanSystem
{
	public partial class frmGestionarProductos : Form
	{
		public static ProductoWS.ProductoWSClient daoProducto;
		public static ProductoWS.producto productoSeleccionado;
		public static DataGridView dgv;
		public ProductoWS.producto[] misProductos;

		public frmGestionarProductos()
		{
			daoProducto = new ProductoWS.ProductoWSClient();
			InitializeComponent();
			dgv = dgvProductos;
			dgvProductos.AutoGenerateColumns = false;
			recargarDGV();

			#region colores de seleccion
			dgvProductos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvProductos.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvProductos.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvProductos.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvProductos.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvProductos.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

		private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			//Castear objetos y mostrar valor determinado
			ProductoWS.producto producto = dgvProductos.Rows[e.RowIndex].DataBoundItem
											as ProductoWS.producto;

			dgvProductos.Rows[e.RowIndex].Cells["SUBFAMILIA"].Value = producto.subFamilia.descripcionSubFamilia;

			dgvProductos.Rows[e.RowIndex].Cells["FAMILIA"].Value = producto.subFamilia.familia.descripcion;

			dgvProductos.Rows[e.RowIndex].Cells["MARCA"].Value = producto.marca.nombre;
		}

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			frmVentanaPrincipal.act.Enabled = false;
			frmVentanaPrincipal.elim.Enabled = false;
		}

		private void dgvProductos_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
		{
			//Preguntar al profe
			if(e.StateChanged != DataGridViewElementStates.Selected)
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

		public void recargarDGV()
		{
			misProductos = daoProducto.listarProductos("", "", "", "");
			if (misProductos != null)
			{
				dgvProductos.DataSource = new BindingList<ProductoWS.producto>(misProductos.ToArray());
			}
			else
			{
				dgvProductos.DataSource = new BindingList<ProductoWS.producto>();
			}
		}

		public void revisarDGV(object source, ElapsedEventArgs e)
		{

			if (dgvProductos.InvokeRequired)
			{
				dgvProductos.Invoke(new Action(() =>
				{
					if (dgvProductos.Rows.Count > 0)
					{
						int i = ((ProductoWS.producto)dgvProductos.CurrentRow.DataBoundItem).idProducto;
						int j = dgvProductos.CurrentCell.ColumnIndex;

						recargarDGV();

						int k = 0;
						foreach (ProductoWS.producto p in misProductos)
						{
							if (p.idProducto == i)
							{
								i = k;
								break;
							}
							k++;
						}

						if (k != misProductos.Length)
							dgvProductos.CurrentCell = dgv[j, i];
					}
				}));
			}
		}
	}
}
