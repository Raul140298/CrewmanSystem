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
	public partial class frmGestionarVisitas : Form
	{
		private VisitaWS.VisitaWSClient daoVisita;
		public frmGestionarVisitas()
		{
			daoVisita = new VisitaWS.VisitaWSClient();
			InitializeComponent();
			VisitaWS.visita[] visitas = daoVisita.listarVisitas(Program.empleado.cartera.idCartera);
			BindingList<VisitaWS.visita> misVisitas;
			if (visitas != null) misVisitas = new BindingList<VisitaWS.visita>(visitas);
			else misVisitas = new BindingList<VisitaWS.visita>();
			dgvVisitas.AutoGenerateColumns = false;
			dgvVisitas.DataSource = misVisitas;

			#region colores de seleccion
			dgvVisitas.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvVisitas.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvVisitas.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvVisitas.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dgvVisitas.RowsDefaultCellStyle.SelectionBackColor = Program.colorR;
			dgvVisitas.RowsDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}

		private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			//if(((DataGridCell)sender).ColumnNumber == 6)//CHECK
			//{
			//	Visita visita = new Visita(datos de la fila);
			//	actualizar(visita.Id,true);
			//	return;
			//}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//bool check = false;

			if (((DataGridCell)sender).ColumnNumber == 6)//CHECK
			{
				//BLOQUEAR LA DESACTIVACIÓN DEL CHECK.
				//ACTIVAR TRAS UNA CONFIRMACIÓN
				//Visita visita = (DataGridRow)Visita(datos de la fila);
				//actualizar(visita.Id,true);
				return;
			}
		}

        private void dgvVisitas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
			VisitaWS.visita v = dgvVisitas.Rows[e.RowIndex].DataBoundItem as VisitaWS.visita;
            dgvVisitas.Rows[e.RowIndex].Cells["RUC"].Value = v.cliente.ruc;
			dgvVisitas.Rows[e.RowIndex].Cells["RAZON_SOCIAL"].Value = v.cliente.razonSocial;
			dgvVisitas.Rows[e.RowIndex].Cells["GRUPO"].Value = v.cliente.grupo;
			dgvVisitas.Rows[e.RowIndex].Cells["FECHA_REGISTRO"].Value = v.cliente.fechaRegistro.ToString("dd/MM/yyyy");
			DateTime ultCompra = v.cliente.fechaUltimaCompra;
			string fechaUltCompra;
			if (ultCompra.Year < 2000) fechaUltCompra = "";
			else fechaUltCompra = ultCompra.ToString("dd/MM/yyyy");
			dgvVisitas.Rows[e.RowIndex].Cells["FECHA_ULTIMA_COMPRA"].Value = fechaUltCompra;
			dgvVisitas.Rows[e.RowIndex].Cells["TIPO_CLIENTE"].Value = v.cliente.tipoEmpresa;
			dgvVisitas.Rows[e.RowIndex].Cells["ZONA"].Value = v.cliente.zona.nombre;
			dgvVisitas.Rows[e.RowIndex].Cells["DIRECCION"].Value = v.cliente.direccion;
			string estado;
			if (v.estado) estado = "VISITADO";
			else estado = "NO VISITADO";
			dgvVisitas.Rows[e.RowIndex].Cells["ESTADO"].Value = estado;
			//dgvVisitas.Rows[e.RowIndex].Cells["CHECK"].Value = v.estado;
			DateTime visita = v.fechaRegistro;
			string fechaVisita;
			if (visita.Year < 2000) fechaVisita = "";
			else fechaVisita = visita.ToString("dd/MM/yyyy");
			dgvVisitas.Rows[e.RowIndex].Cells["FECHA_VISITA"].Value = fechaVisita;
		}
    }
}
