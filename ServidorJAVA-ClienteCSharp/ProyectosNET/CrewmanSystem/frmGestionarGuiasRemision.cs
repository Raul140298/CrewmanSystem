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
		public static GuiaRemisionWS.guiaRemision guiaRemisionSeleccionado;
		public static DataGridView dgv;
		public frmGestionarGuiasRemision()
		{
			daoGuiaRemision = new GuiaRemisionWS.GuiaRemisionWSClient();
			InitializeComponent();
			dgv = dgvGuiasDeRemision;
			dgvGuiasDeRemision.AutoGenerateColumns = false;
			GuiaRemisionWS.guiaRemision[] misGuias = daoGuiaRemision.listarGuiaRemisionsXVendedor(Program.empleado.idEmpleado,"", DateTime.MinValue, 
				DateTime.MaxValue, DateTime.MinValue, DateTime.MaxValue);
			dgv = dgvGuiasDeRemision;
			if (misGuias != null)
			{
				dgvGuiasDeRemision.DataSource = new BindingList<GuiaRemisionWS.guiaRemision>(daoGuiaRemision.listarGuiaRemisionsXVendedor(Program.empleado.idEmpleado, "", DateTime.MinValue,
				DateTime.MaxValue, DateTime.MinValue, DateTime.MaxValue).ToArray());
			}
			else
			{
				dgvGuiasDeRemision.DataSource = new BindingList<GuiaRemisionWS.guiaRemision>();

			}
			#region colores de seleccion
			dgvGuiasDeRemision.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvGuiasDeRemision.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvGuiasDeRemision.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvGuiasDeRemision.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvGuiasDeRemision.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvGuiasDeRemision.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

        private void dgvGuiasDeRemision_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
			//Castear objetos y mostrar valor determinado
			GuiaRemisionWS.guiaRemision guiaRemision = dgvGuiasDeRemision.Rows[e.RowIndex].DataBoundItem
											as GuiaRemisionWS.guiaRemision;

			dgvGuiasDeRemision.Rows[e.RowIndex].Cells["ID_PEDIDO"].Value = guiaRemision.pedido.idPedido;

		}

        private void dgvGuiasDeRemision_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
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
    }
}
