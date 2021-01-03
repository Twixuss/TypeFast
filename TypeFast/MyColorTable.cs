using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeFast
{
    public class MyColorTable : ProfessionalColorTable
    {
		static readonly Color backgroundColor = Color.FromArgb(64, 64, 74);
		static readonly Color selectedColor   = Color.FromArgb(84, 84, 94);
		static readonly Color pressedColor    = Color.FromArgb(44, 44, 54);
		public override Color ToolStripDropDownBackground => backgroundColor;
		public override Color ImageMarginGradientBegin => backgroundColor;
		public override Color ImageMarginGradientMiddle => backgroundColor;
		public override Color ImageMarginGradientEnd => backgroundColor;
		public override Color MenuBorder => Color.Transparent;
		public override Color MenuItemBorder => Color.Transparent;
		public override Color MenuItemSelected => selectedColor;
		public override Color MenuStripGradientBegin => backgroundColor;
		public override Color MenuStripGradientEnd => backgroundColor;
		public override Color MenuItemSelectedGradientBegin => selectedColor;
		public override Color MenuItemSelectedGradientEnd => selectedColor;
		public override Color MenuItemPressedGradientBegin => pressedColor;
		public override Color MenuItemPressedGradientEnd => pressedColor;
	}
}
