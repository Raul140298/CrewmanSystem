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
	public partial class frmGestionarGuiasRemision : Form
	{
		private GuiaRemisionWS.GuiaRemisionWSClient daoGuiaRemision;
		public frmGestionarGuiasRemision()
		{
			daoGuiaRemision = new GuiaRemisionWS.GuiaRemisionWSClient();
			InitializeComponent();
			dgvGuiasDeRemision.AutoGenerateColumns = false;
			//GuiaRemisionWS.guiaRemision[] misGuias = daoGuiaRemision.listarGuiaRemisionsXVendedor(Program.empleado.idEmpleado);
			//if (misGuias != null)
			//{
			//	dgvGuiasDeRemision.DataSource = new BindingList<GuiaRemisionWS.guiaRemision>(daoGuiaRemision.listarGuiaRemisionsXVendedor(Program.empleado.idEmpleado).ToArray());
			//}
			//else
			//{
			//	dgvGuiasDeRemision.DataSource = new BindingList<GuiaRemisionWS.guiaRemision>();

			//}
			#region colores de seleccion
			dgvGuiasDeRemision.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvGuiasDeRemision.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvGuiasDeRemision.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvGuiasDeRemision.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvGuiasDeRemision.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvGuiasDeRemision.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}
	}
}
