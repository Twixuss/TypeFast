using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeFast
{
	public class ShadowLabel : Label
	{
		protected override void OnPaint(PaintEventArgs e)
		{
			const int DISTANCE = 2;
			Color color = Color.FromArgb(128, 0,0,0);
			using (var brush = new SolidBrush(color))
			{
				var point = new PointF()
				{
					X = -DISTANCE,
					Y = DISTANCE
				};
				e.Graphics.DrawString(Text, Font, brush, point);
			}
			using (var brush = new SolidBrush(ForeColor))
			{
				e.Graphics.DrawString(Text, Font, brush, new PointF());
			}
		}
	}
}
