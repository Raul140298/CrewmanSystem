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
	public partial class frmBuscarGuiaRemision : Form
	{
		public static GuiaRemisionWS.guiaRemision[] misGuiasRemision;
		public static GuiaRemisionWS.GuiaRemisionWSClient daoGuiaRemision= new GuiaRemisionWS.GuiaRemisionWSClient();
		public frmBuscarGuiaRemision()
        {
            InitializeComponent();
			dgvGuiasDeRemision.AutoGenerateColumns = false;
			dtpRangoIniRegistro.Value = DateTime.Today.AddMonths(-1);
            dtpRangoFinRegistro.Value = DateTime.Today.AddMonths(1);
			dtpRangoIniTraslado.Value = DateTime.Today.AddMonths(-1);
			dtpRangoFinTraslado.Value = DateTime.Today.AddMonths(1);
			txtMotivoTraslado.Text = "";
            completarTabla();
        }

        private void dgvGuiasDeRemision_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void completarTabla()
		{
			misGuiasRemision = daoGuiaRemision.listarGuiaRemisionsXVendedor(Program.empleado.idEmpleado,txtMotivoTraslado.Text, dtpRangoIniRegistro.Value,
				dtpRangoFinRegistro.Value, dtpRangoIniTraslado.Value,dtpRangoFinTraslado.Value);
			dgvGuiasDeRemision.AutoGenerateColumns = false;
			if (misGuiasRemision != null)
				dgvGuiasDeRemision.DataSource = new BindingList<GuiaRemisionWS.guiaRemision>(misGuiasRemision.ToArray());
			else
				dgvGuiasDeRemision.DataSource = new BindingList<GuiaRemisionWS.guiaRemision>();
		
		}

        private void btnBuscar_Click(object sender, EventArgs e)
        {
			completarTabla();
        }

        private void dgvGuiasDeRemision_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
			GuiaRemisionWS.guiaRemision guiaRemision = dgvGuiasDeRemision.Rows[e.RowIndex].DataBoundItem
											as GuiaRemisionWS.guiaRemision;

			dgvGuiasDeRemision.Rows[e.RowIndex].Cells["ID_PEDIDO"].Value = guiaRemision.pedido.idPedido;
		}
    }
}
