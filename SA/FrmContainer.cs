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
    public partial class FrmContainer : Form
    {
        public FrmContainer()
        {
            InitializeComponent();
        }
        FrmMain f;
        private void tsResource_Click(object sender, EventArgs e)
        {
            
            if (f==null || f.IsDisposed)
            {
                
                f = new FrmMain();
                
            }
            f.MdiParent = this;
            
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void menuConfig_Click(object sender, EventArgs e)
        {
            FrmConfig f = new FrmConfig();
            f.ShowDialog();
        }

        private void tuiChuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这是酷购科技实用平台软件！");
        }
    }
}
