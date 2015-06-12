using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonTest
{
    public partial class TestCanvas : Form
    {
        private TestManager testManager = null;

        public TestCanvas(TestManager tm, bool isFullScreen) : base()
        {
            InitializeComponent();

            if (tm == null)
            {
                throw new ArgumentNullException("Invalid TestManager!");
            }

            testManager = tm;

            if (isFullScreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }

            toolTip.SetToolTip(this, "Right click or press \"Esc\" to terminate tests!");
        }

        private void TestCanvasForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                testManager.NextTest();
                testManager.RenderTest();
            }
            else if (e.Button == MouseButtons.Right)
            {
                endTest();
            }
        }

        private void TestCanvasForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                testManager.NextTest();
                testManager.RenderTest();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                endTest();
            }
        }

        private void endTest()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.BackColor = Form.DefaultBackColor;

            this.Close();
        }

        private void TestCanvas_Paint(object sender, PaintEventArgs e)
        {
            testManager.RenderTest();
        }
    }
}