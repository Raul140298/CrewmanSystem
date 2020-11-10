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
	public partial class frmBuscarEmpleado : Form
	{
		public frmBuscarEmpleado()
		{
			InitializeComponent();
		}

        private void btnBuscarZona_Click(object sender, EventArgs e)
        {
			frmBuscarZona formBusquedaZona = new frmBuscarZona();
			if(formBusquedaZona.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
