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
	public partial class frmGestionarFamilias : Form
	{
		FamiliaWS.FamiliaWSClient daoFamilia;
		public frmGestionarFamilias()
		{
			daoFamilia = new FamiliaWS.FamiliaWSClient();
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.DataSource = new BindingList<FamiliaWS.familia>(daoFamilia.listarFamilias().ToArray());
		}

		private void frmGestionarFamilias_Load(object sender, EventArgs e)
		{

		}
	}
}
