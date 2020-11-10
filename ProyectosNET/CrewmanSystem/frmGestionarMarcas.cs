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
	public partial class frmGestionarMarcas : Form
	{
		MarcaWS.MarcaWSClient daoMarca;
		public frmGestionarMarcas()
		{
			daoMarca = new MarcaWS.MarcaWSClient();
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.DataSource = new BindingList<MarcaWS.marca>(daoMarca.listarMarcas().ToArray());

			#region colores de seleccion
			dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);

			dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Program.colorR;
			dataGridView1.RowHeadersDefaultCellStyle.SelectionForeColor = ThemeColor.ChangeColorBrightness(Program.colorR, -0.7);
			#endregion
		}
	}
}
