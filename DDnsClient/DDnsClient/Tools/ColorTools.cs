using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Charlotte.Tools
{
	public static class ColorTools
	{
		public static Color FromRRGGBB(string str)
		{
			int value = IntTools.ToInt_16(str);

			value = IntTools.ToRange(value, 0, 0xffffff);

			int b = value % 256;
			value /= 256;
			int g = value % 256;
			int r = value / 256;

			return Color.FromArgb(r, g, b);
		}
	}
}
