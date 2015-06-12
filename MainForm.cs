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
    
        MonTest 0.3
        ============

        MonTest - free Monitor Test software for Windows
        Copyright © 2015, Shaoyu Chen

        Quick tips:
           - Press "Start Test" button to start test
           - Left click with mouse or press "space" to cycle among tests
           - Right click with mouse or press "Esc" to terminate tests
           - Press "Exit" button to exit application

        LICENSE Info
        ============

        This program is free software; you can redistribute it and/or modify
        it under the terms of the GNU General Public License as published by
        the Free Software Foundation; either version 2 of the License, or
        (at your option) any later version.

        This program is distributed in the hope that it will be useful,
        but WITHOUT ANY WARRANTY; without even the implied warranty of
        MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
        GNU General Public License for more details.

        You should have received a copy of the GNU General Public License along
        with this program; if not, write to the Free Software Foundation, Inc.,
        51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.

    */

    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            TestManager tm = new TestManager();
            TestCanvas canvas = new TestCanvas(tm, checkBoxFullScreen.Checked);

            tm.Initialize();

            tm.AddTest(new SolidColorTest(canvas, Color.White));
            tm.AddTest(new SolidColorTest(canvas, Color.Black));
            tm.AddTest(new SolidColorTest(canvas, Color.Red));
            tm.AddTest(new SolidColorTest(canvas, Color.Lime));
            tm.AddTest(new SolidColorTest(canvas, Color.Blue));

            tm.AddTest(new ColorGradientTest(canvas, Color.White));
            tm.AddTest(new ColorGradientTest(canvas, Color.Red));
            tm.AddTest(new ColorGradientTest(canvas, Color.Lime));
            tm.AddTest(new ColorGradientTest(canvas, Color.Blue));

            tm.StartTest();
            canvas.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/chenshaoyu/MonTest");
        }
    }
}
