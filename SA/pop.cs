using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

using System.Threading;
using com.jajago.SA.Biz;
namespace com.jajago.SA
{
    public partial class frmPop : Form
    {
        private BuffLines buff = new BuffLines();
        public frmPop()
        {
            InitializeComponent();
        }

        private void frmPop_Load(object sender, EventArgs e)
        {
            tim.Enabled = true;
        }

        Thread run_scan = null;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgbpop.Value < pgbpop.Maximum)
            {
                pgbpop.Step = 1;
                pgbpop.PerformStep();
            }

            run_scan = new Thread(new ThreadStart(do_scan));
            run_scan.Start();
        }
        private void do_scan()
        {
            abort_scan = false;
            scan(new DirectoryInfo("d:\\"));
        }

        bool abort_scan = false;

        private void scan(DirectoryInfo dir)
        {
            if (abort_scan) return;
            // subdir
            try
            {
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo di in dirs)
                {
                    if (abort_scan) return;
                    scan(di);
                }
            }
            catch { }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo f in files)
            {
                if (abort_scan) return;
                if (f.Extension == ".jpg" || f.Extension == ".gif")
                {
                    buff.AddLine(abort_scan.ToString() + "|" + dir + f.FullName);
                    lbOut.Text = buff.ToString();
                }
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abort_scan = true;

            if (run_scan != null && run_scan.IsAlive)
            {
                run_scan.Abort();
                run_scan.Join();

                MessageBox.Show("Abort!");
            }

        }
    }
}
