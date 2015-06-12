using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonTest
{
    public class SolidColorTest : BaseTest
    {
        private Color color = Color.Empty;

        public SolidColorTest(Control ctr, Color c) : base(ctr)
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
                g.Clear(color);
            }
        }
    }
}
