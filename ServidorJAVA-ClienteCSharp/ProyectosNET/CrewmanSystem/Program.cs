using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrewmanSystem
{
	public class Program
	{
		#region VARIABLESESTATICAS
		public static EmpleadoWS.empleado empleado = new EmpleadoWS.empleado();
		public static frmVentanaPrincipal panel;
		public static Color color0 = Color.FromArgb(39, 39, 58);//COLOR DE BOTONES PRINCIPALES
		public static Color color1 = Color.FromArgb(57, 60, 67);//COLOR DE BOTONES SECUNDARIOS
		private static Random random = new Random();
		public static int indexColor = random.Next(ThemeColor.ColorList.Count);//COLOR RANDOM A USAR EN TODO EL PROGRAMA
		public static Color colorR = ThemeColor.getColor(indexColor);
		public static BindingList<CrewPantalla> pantallas = new BindingList<CrewPantalla>();
		#endregion

		//[STAThread]
		static void Main(string[] args)
        {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(true);
			Application.Run(new frmLogeo());

		}
	}
}
