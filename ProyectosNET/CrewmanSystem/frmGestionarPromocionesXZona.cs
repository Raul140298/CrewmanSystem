﻿using System;
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
			PromocionXZonaWS.promocionXZona[] misPromocionXZonas = daoPromocionXZona.listarPromocionXZona(0);
			if (misPromocionXZonas != null)
			{
				dataGridView1.DataSource = new BindingList<PromocionXZonaWS.promocionXZona>(misPromocionXZonas.ToArray());
			}
			else
			{
				dataGridView1.DataSource = new BindingList<PromocionXZonaWS.promocionXZona>();

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
	}
}