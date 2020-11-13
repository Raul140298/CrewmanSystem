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
			dgvVisitas.AutoGenerateColumns = false;
			VisitaWS.visita[] misVisitas = daoVisita.listarVisitas(null);
			if (misVisitas != null)
			{
				dgvVisitas.DataSource = new BindingList<VisitaWS.visita>(misVisitas.ToArray());
			}
			else
			{
				dgvVisitas.DataSource = new BindingList<VisitaWS.visita>();

			}


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
	}
}
