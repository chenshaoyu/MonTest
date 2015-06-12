using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonTest
{
    public class ColorGradientTest : BaseTest
    {
        private static Control g;
        private Color color = Color.Empty;

        private int gridCountX = 8;
        private int gridCountY = 8;

        public ColorGradientTest(Control ctr, Color c) : base(ctr)
        {
            if (c.IsEmpty)
            {
                throw new ArgumentException("Color cannot be empty!");
            }

            color = c;
        }

        public override void RenderTest()
        {
            base.RenderTest();

            using (Graphics g = control.CreateGraphics())
            {
                g.Clear(Color.Black);

                using (SolidBrush br = new SolidBrush(color))
                {
                    for (float i = 0; i < gridCountX; i++)
                    {
                        for (float j = 0; j < gridCountY; j++)
                        {
                            br.Color = Color.FromArgb(Convert.ToInt32((i * gridCountY + j) * 256 / gridCountX / gridCountY), color);
                            g.FillRectangle(br, i * control.Width / gridCountX, j * control.Height / gridCountY, control.Width / gridCountX, control.Height / gridCountY);
                        }
                    }
                }
            }
        }
    }
}
