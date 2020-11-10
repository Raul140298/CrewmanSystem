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
	public partial class frmGestionarPromociones : Form
	{
		PromocionWS.PromocionWSClient daoPromocion;
		public frmGestionarPromociones()
		{
			daoPromocion = new PromocionWS.PromocionWSClient();
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.DataSource = new BindingList<PromocionWS.promocion>(daoPromocion.listarPromocions("",DateTime.MinValue,DateTime.Today).ToArray());
		}
	}
}
