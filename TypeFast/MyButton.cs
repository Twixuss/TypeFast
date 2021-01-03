using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeFast
{
	public class MyButton : Button
	{
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			const int contrast = 30;
			var dark = new Pen(Color.FromArgb(
				Math.Max(BackColor.R - contrast, 0),
				Math.Max(BackColor.G - contrast, 0),
				Math.Max(BackColor.B - contrast, 0)
			));
			var light = new Pen(Color.FromArgb(
				Math.Max(BackColor.R + contrast, 0),
				Math.Max(BackColor.G + contrast, 0),
				Math.Max(BackColor.B + contrast, 0)
			));
			int top = ClientRectangle.Top;
			int bottom = ClientRectangle.Bottom - 1;
			int left = ClientRectangle.Left;
			int right = ClientRectangle.Right - 1;
			e.Graphics.DrawLine(light, left,  bottom, right, bottom);
			e.Graphics.DrawLine(light, right, top, right, bottom);
			e.Graphics.DrawLine(light, left,  top, right, top);
			e.Graphics.DrawLine(light, left, top, left, bottom);
			dark.Dispose();
			light.Dispose();
		}
		//protected override void OnCreateControl()
		//{
		//	base.OnCreateControl();
		//	Panel p = new Panel();
		//	p.Location = Point.Add(Location, new Size(-2, 2));
		//	p.Size = Size;
		//	p.Anchor = Anchor;
		//	p.BackColor = Color.FromArgb(128,0,0,0);
		//	Parent.Controls.Add(p);
		//}
	}
}
