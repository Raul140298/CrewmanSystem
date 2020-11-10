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
	public partial class frmGestionarPromocionesXZona : Form
	{
		PromocionXZonaWS.PromocionXZonaWSClient daoPromocionXZona;
		public frmGestionarPromocionesXZona()
		{
			daoPromocionXZona = new PromocionXZonaWS.PromocionXZonaWSClient();
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.DataSource = new BindingList<PromocionXZonaWS.promocionXZona>(daoPromocionXZona.listarPromocionXZona(0).ToArray());
		}
	}
}
