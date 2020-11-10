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
		public frmGestionarVisitas()
		{
			InitializeComponent();
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
