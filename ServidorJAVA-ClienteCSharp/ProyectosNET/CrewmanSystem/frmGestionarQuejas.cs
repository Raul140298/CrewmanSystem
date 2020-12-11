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
	public partial class frmGestionarQuejas : Form
	{
		private QuejaWS.QuejaWSClient daoQueja;
		public frmGestionarQuejas()
		{
			daoQueja = new QuejaWS.QuejaWSClient();
			InitializeComponent();
			
			dgvQuejas.AutoGenerateColumns = false;
			QuejaWS.queja[] misQuejas = daoQueja.listarQuejas(Program.empleado.idEmpleado); 
			if (misQuejas != null)
				dgvQuejas.DataSource = new BindingList<QuejaWS.queja>(misQuejas.ToArray());
			else
				dgvQuejas.DataSource = new BindingList<QuejaWS.queja>();

			if (Program.empleado.cargo.nombre == "VENDEDOR")
			{
				dgvQuejas.Columns["NOMBRE"].Visible = false;
				dgvQuejas.Columns["APELLIDO_PATERNO"].Visible = false;
				dgvQuejas.Columns["APELLIDO_MATERNO"].Visible = false;
			}

			#region colores de seleccion
			dgvQuejas.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvQuejas.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvQuejas.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvQuejas.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvQuejas.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvQuejas.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

		private void dgvQuejas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			try
			{
				QuejaWS.queja queja = dgvQuejas.Rows[e.RowIndex].DataBoundItem
				as QuejaWS.queja;

				dgvQuejas.Rows[e.RowIndex].Cells["ID_PEDIDO"].Value = queja.pedido.idPedido;
				dgvQuejas.Rows[e.RowIndex].Cells["RUC"].Value = queja.pedido.cliente.ruc;
				dgvQuejas.Rows[e.RowIndex].Cells["RAZON_SOCIAL"].Value = queja.pedido.cliente.razonSocial;
				dgvQuejas.Rows[e.RowIndex].Cells["GRUPO"].Value = queja.pedido.cliente.grupo;
				dgvQuejas.Rows[e.RowIndex].Cells["TIPO_CLIENTE"].Value = queja.pedido.cliente.tipoEmpresa;
				dgvQuejas.Rows[e.RowIndex].Cells["NOMBRE"].Value = queja.pedido.empleado.nombre;
				dgvQuejas.Rows[e.RowIndex].Cells["APELLIDO_PATERNO"].Value = queja.pedido.empleado.apellidoPaterno;
				dgvQuejas.Rows[e.RowIndex].Cells["APELLIDO_MATERNO"].Value = queja.pedido.empleado.apellidoMaterno;
			}
			catch (Exception) { }
		}
	}
}
