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
	public partial class frmGestionarClientes : Form
	{
		private ClienteWS.ClienteWSClient daoCliente;
		public frmGestionarClientes()
		{
			daoCliente = new ClienteWS.ClienteWSClient();
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
			ClienteWS.cliente[] misClientes = daoCliente.listarClientes("","");
            if (misClientes != null)
            {
				dataGridView1.DataSource = new BindingList<ClienteWS.cliente>(misClientes.ToArray());
            }
            else
            {
				dataGridView1.DataSource = new BindingList<ClienteWS.cliente>();

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
			ClienteWS.cliente cliente = dataGridView1.Rows[e.RowIndex].DataBoundItem
										as ClienteWS.cliente;
		}
	}
}
