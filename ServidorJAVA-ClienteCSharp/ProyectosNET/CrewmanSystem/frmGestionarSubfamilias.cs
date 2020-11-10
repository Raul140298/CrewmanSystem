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
	public partial class frmGestionarSubfamilias : Form
	{
		SubFamiliaWS.SubFamiliaWSClient daoSubFamilia;
		public frmGestionarSubfamilias()
		{
			daoSubFamilia = new SubFamiliaWS.SubFamiliaWSClient();
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
			SubFamiliaWS.subFamilia[] misSubFamilias = daoSubFamilia.listarSubFamilias("");
			if (misSubFamilias != null)
			{
				dataGridView1.DataSource = new BindingList<SubFamiliaWS.subFamilia>(misSubFamilias.ToArray());
			}
			else
			{
				dataGridView1.DataSource = new BindingList<SubFamiliaWS.subFamilia>();

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
			//castear objetos y mostrar valor determinado
			SubFamiliaWS.subFamilia subfamilia = dataGridView1.Rows[e.RowIndex].DataBoundItem
			as SubFamiliaWS.subFamilia;

			dataGridView1.Rows[e.RowIndex].Cells["FAMILIA"].Value = subfamilia.familia.descripcion;
		}
	}
}
