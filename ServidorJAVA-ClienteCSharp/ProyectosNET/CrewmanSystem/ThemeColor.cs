using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrewmanSystem
{
    public static class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        public static List<string> ColorList = new List<string>() { "#7BCFE9",
                                                                    "#FF5722",
                                                                    "#FF9800",
                                                                    "#9C27B0",
                                                                    "#2196F3",
                                                                    "#EA676C",
                                                                    "#E41A4A",
                                                                    "#00B0AD",
                                                                    "#EA4833",
                                                                    "#EF937E",
                                                                    "#F37521",
                                                                    "#8BC240",
                                                                    "#C7DC5B",
                                                                    "#E4126B",
                                                                    "#43B76E"};

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }

        public static Color getColor(int index)
		{
            return ColorTranslator.FromHtml(ThemeColor.ColorList[index]);
        }
    }
}
