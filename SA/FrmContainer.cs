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
        private FrmResource frmResource;
        private FrmMobiles frmMobiles;

        public FrmContainer()
        {
            // Load....
            System.Threading.Thread.Sleep(1000);

            InitializeComponent();
            FrmSplash.CloseSplash();
        }
        private void tsResource_Click(object sender, EventArgs e)
        {

            if (frmResource == null || frmResource.IsDisposed)
            {

                frmResource = new FrmResource();
                frmResource.MdiParent = this;
                
            }
            frmResource.WindowState = FormWindowState.Maximized;
            this.ActivateMdiChild(frmResource);  
            frmResource.Show();
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

        private void tsMobiles_Click(object sender, EventArgs e)
        {
            if (frmMobiles == null || frmMobiles.IsDisposed)
            {
                frmMobiles = new FrmMobiles();
                frmMobiles.MdiParent = this;
            }
            frmMobiles.WindowState = FormWindowState.Maximized;
            this.ActivateMdiChild(frmMobiles);
            frmMobiles.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTest f = new FrmTest();
            f.MdiParent = this;
            f.Show();
        }
    }
}
