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
			dtpRangoIniRegistro.Value = DateTime.Today.AddMonths(-3);
            dtpRangoFinRegistro.Value = DateTime.Today.AddMonths(3);
			dtpRangoIniTraslado.Value = DateTime.Today.AddMonths(-3);
			dtpRangoFinTraslado.Value = DateTime.Today.AddMonths(3);
			if (Program.empleado.cargo.nombre == "VENDEDOR")
			{
				dgvGuiasDeRemision.Columns["NOMBRE"].Visible = false;
				dgvGuiasDeRemision.Columns["APELLIDO_PATERNO"].Visible = false;
				dgvGuiasDeRemision.Columns["APELLIDO_MATERNO"].Visible = false;
			}
			completarTabla();
        }

        private void dgvGuiasDeRemision_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			//
        }

		private void completarTabla()
		{
			dgvGuiasDeRemision.AutoGenerateColumns = false;
			misGuiasRemision = 
				daoGuiaRemision.listarGuiaRemisions(Program.empleado.idEmpleado,txtRazonSocial.Text,txtGrupo.Text, 
				dtpRangoIniRegistro.Value,dtpRangoFinRegistro.Value, dtpRangoIniTraslado.Value,dtpRangoFinTraslado.Value);
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
			try
			{
				GuiaRemisionWS.guiaRemision guiaRemision = dgvGuiasDeRemision.Rows[e.RowIndex].DataBoundItem
								as GuiaRemisionWS.guiaRemision;

				dgvGuiasDeRemision.Rows[e.RowIndex].Cells["ID_PEDIDO"].Value = guiaRemision.pedido.idPedido;
				dgvGuiasDeRemision.Rows[e.RowIndex].Cells["RUC"].Value = guiaRemision.pedido.cliente.ruc;
				dgvGuiasDeRemision.Rows[e.RowIndex].Cells["RAZON_SOCIAL"].Value = guiaRemision.pedido.cliente.razonSocial;
				dgvGuiasDeRemision.Rows[e.RowIndex].Cells["GRUPO"].Value = guiaRemision.pedido.cliente.grupo;
				dgvGuiasDeRemision.Rows[e.RowIndex].Cells["TIPO_CLIENTE"].Value = guiaRemision.pedido.cliente.tipoEmpresa;
				dgvGuiasDeRemision.Rows[e.RowIndex].Cells["NOMBRE"].Value = guiaRemision.pedido.empleado.nombre;
				dgvGuiasDeRemision.Rows[e.RowIndex].Cells["APELLIDO_PATERNO"].Value = guiaRemision.pedido.empleado.apellidoPaterno;
				dgvGuiasDeRemision.Rows[e.RowIndex].Cells["APELLIDO_MATERNO"].Value = guiaRemision.pedido.empleado.apellidoMaterno;
			}
			catch (Exception) { }
		}
    }
}
