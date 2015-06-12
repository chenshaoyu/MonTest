using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonTest
{
    public abstract class BaseTest
    {
        protected Control control = null;

        public BaseTest(Control c)
        {
            if (c == null)
            {
                throw new ArgumentNullException("Invalid Graphics to render test!");
            }

            control = c;
        }

        public virtual void RenderTest()
        {
        }
    }
}
