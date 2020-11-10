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
	public partial class frmGestionarQuejas : Form
	{
		QuejaWS.QuejaWSClient daoQueja;
		public frmGestionarQuejas()
		{
			daoQueja = new QuejaWS.QuejaWSClient();
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.DataSource = new BindingList<QuejaWS.queja>(daoQueja.listarQuejas(0).ToArray());
		}
	}
}
