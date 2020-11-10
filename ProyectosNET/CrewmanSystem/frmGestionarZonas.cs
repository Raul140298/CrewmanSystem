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
	public partial class frmGestionarZonas : Form
	{
		ZonaWS.ZonaWSClient daoZona;
		public frmGestionarZonas()
		{
			daoZona = new ZonaWS.ZonaWSClient();
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.DataSource = new BindingList<ZonaWS.zona>(daoZona.listarZonas().ToArray());
		}

		private void frmGestionarZonas_Load(object sender, EventArgs e)
		{

		}
	}
}
