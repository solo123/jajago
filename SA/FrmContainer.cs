using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Diagnostics;

using com.jajago.Biz;
namespace com.jajago.SA
{
    public partial class FrmContainer : Form
    {
        private FrmResource frmResource;
        private FrmMobiles frmMobiles;
        private FrmUpdate frmUpdate;
        private AppManager app = AppManager.Instance;

        public FrmContainer()
        {
            InitializeComponent();
            FrmSplash.CloseSplash();
            app.ShowStatusText += new EventHandler(on_show_status_text);
        }

        private void on_show_status_text(object sender, EventArgs e)
        {
            lbstatus.Text = sender.ToString();
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


        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            KillSelfThenRun();
        }

        private void KillSelfThenRun()
        {
            string batFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AutoUpdate.bat");
            using (StreamWriter sw = File.CreateText(batFile))
            {
                sw.WriteLine(@"
@echo off 

:TASKLIST 
tasklist /FI ""IMAGENAME eq com.jajago.sa.exe"" | find /i ""com.jajago.sa.exe""  >  nul
 
IF ERRORLEVEL 2 GOTO FOUND
IF ERRORLEVEL 1 GOTO NOT_FOUND 
goto :NOT_FOUND
 
:FOUND
echo still running!!!!!
goto :TASKLIST
 
:NOT_FOUND 
echo good, not running.

update\unzip update\20110124\update.pak -o
update\sqlcecmd -d ""data source=Mobiles.sdf;password=liang"" -i ""mobiles.sql""

goto EXIT 
 
:EXIT 
echo exit now!
pause
");
            }
            ProcessStartInfo info = new ProcessStartInfo(batFile);
            //info.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(info);

            // 强制关闭当前进程
            Environment.Exit(0);
        }


        private void tsUpdate_Click(object sender, EventArgs e)
        {
            if (frmUpdate == null)
            {
                frmUpdate = new FrmUpdate();
            }
            frmUpdate.ShowDialog();

            this.Dispose();
            KillSelfThenRun();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
