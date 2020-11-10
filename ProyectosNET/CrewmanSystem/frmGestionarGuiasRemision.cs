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
	public partial class frmGestionarGuiasRemision : Form
	{
		GuiaRemisionWS.GuiaRemisionWSClient daoGuiaRemision;
		public frmGestionarGuiasRemision()
		{
			daoGuiaRemision = new GuiaRemisionWS.GuiaRemisionWSClient();
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.DataSource = new BindingList<GuiaRemisionWS.guiaRemision>(daoGuiaRemision.listarGuiaRemisions(0).ToArray());
		}
	}
}
