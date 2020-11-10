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
	public partial class frmListarCumplimientoDeMetas : Form
	{
		public frmListarCumplimientoDeMetas()
		{
			InitializeComponent();
			this.circularProgressBar1.ProgressColor = ThemeColor.getColor(Program.indexColor);
		}

		private void circularProgressBar1_Click(object sender, EventArgs e)
		{

		}
	}
}
