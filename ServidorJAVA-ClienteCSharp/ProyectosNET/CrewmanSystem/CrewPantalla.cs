using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrewmanSystem
{
	public class CrewPantalla
	{
		IconButton _boton;
		CrewPantalla _padre;
		Panel _panel;
		Color _color;
		BTNtipo _tipo;
		Form _formulario;
		bool _n, _a, _e, _b, _f;

		public CrewPantalla()
		{
		}

		public CrewPantalla(IconButton boton, CrewPantalla padre, Panel panel, Color color, Form formulario, BTNtipo tipo)
		{
			Boton = boton;
			Padre = padre;
			Panel = panel;
			Color = color;
			Formulario = formulario;
			Tipo = tipo;
		}

		public void SetCabecera(bool n, bool a, bool e, bool b, bool f)
		{
			N = n;
			A = a;
			E = e;
			B = b;
			F = f;
		}

		public IconButton Boton { get => _boton; set => _boton = value; }
		public CrewPantalla Padre { get => _padre; set => _padre = value; }
		public Panel Panel { get => _panel; set => _panel = value; }
		public Color Color { get => _color; set => _color = value; }
		public Form Formulario { get => _formulario; set => _formulario = value; }
		public BTNtipo Tipo { get => _tipo; set => _tipo = value; }
		public bool N { get => _n; set => _n = value; }
		public bool A { get => _a; set => _a = value; }
		public bool E { get => _e; set => _e = value; }
		public bool B { get => _b; set => _b = value; }
		public bool F { get => _f; set => _f = value; }
	}
}
