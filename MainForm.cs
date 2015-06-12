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
    /*

    MonTest 0.2 - Monitor Test Software
    Copyright © 2002-2015, DRAGONESE Studio

    Quick tips:
       - Press "Start Test" button to start test
       - Left click with mouse or press "space" to cycle among tests
       - Right click with mouse or press "Esc" to terminate tests
       - Press "Exit" to exit application

    Created by Shaoyu Chen

    */

    public partial class mainForm : Form
    {
        bool isInTest = false;
        int testModeCounter = 0;
        int gridCountX = 8;
        int gridCountY = 8;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //buttonStart.Focus();
        }

        private void mainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (isInTest)
            {
                if (e.Button == MouseButtons.Left)
                {
                    cycleTest();
                }
                else if (e.Button == MouseButtons.Right)
                {
                    endTest();
                }
            }
        }

        //private void mainForm_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (isInTest)
        //    {
        //        if (e.KeyData == Keys.Space)
        //        {
        //            cycleTest();
        //        }
        //        else if (e.KeyData == Keys.Escape)
        //        {
        //            endTest();
        //        }
        //    }
        //}

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!isInTest)
            {
                startTest();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (!isInTest)
            {
                Application.Exit();
            }
        }

        private void startTest()
        {
            isInTest = true;

            textBoxInfo.Visible = false;
            buttonStart.Visible = false;
            buttonExit.Visible = false;

            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            this.TopMost = false;

            toolTip.SetToolTip(this, "Right click to terminate tests!");

            cycleTest();
        }

        private void endTest()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
            //this.TopMost = false;

            this.BackColor = Form.DefaultBackColor;

            textBoxInfo.Visible = true;
            buttonStart.Visible = true;
            buttonExit.Visible = true;

            buttonStart.Focus();
            testModeCounter = 0;

            isInTest = false;
        }

        private void cycleTest()
        {
            testModeCounter = testModeCounter % 9;

            switch (testModeCounter)
            {
                case 0:
                    this.BackColor = Color.White;
                    break;

                case 1:
                    this.BackColor = Color.Black;
                    break;

                case 2:
                    this.BackColor = Color.Red;
                    break;

                case 3:
                    this.BackColor = Color.Lime;
                    break;

                case 4:
                    this.BackColor = Color.Blue;
                    break;

                case 5:
                    drawColorGradientGrid(Color.White);
                    break;

                case 6:
                    drawColorGradientGrid(Color.Red);
                    break;

                case 7:
                    drawColorGradientGrid(Color.Lime);
                    break;

                case 8:
                    drawColorGradientGrid(Color.Blue);
                    break;

                default:
                    this.BackColor = Form.DefaultBackColor;
                    break;
            }

            testModeCounter++;
        }

        private void drawColorGradientGrid(Color color)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);

            SolidBrush br = new SolidBrush(color);

            for (float i = 0; i < gridCountX; i++)
            {
                for (float j = 0; j < gridCountY; j++)
                {
                    br.Color = Color.FromArgb(Convert.ToInt32((i * gridCountY + j) * 256 / gridCountX / gridCountY), color);
                    g.FillRectangle(br, i * this.Width / gridCountX, j * this.Height / gridCountY, this.Width / gridCountX, this.Height / gridCountY);
                }
            }

            g.Dispose();
            br.Dispose();
        }
    }
}
