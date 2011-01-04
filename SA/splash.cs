using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace com.jajago.SA
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void splash_Load(object sender, EventArgs e)
        {
            tim.Enabled = true;
            label1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgbStart.Value < pgbStart.Maximum)
            {
                pgbStart.Step = 1;
                pgbStart.PerformStep();
            }
        }
    }
}
