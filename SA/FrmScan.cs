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
    public partial class FrmScan : Form
    {
        private BuffLines buff = new BuffLines();
        private Thread run_scan = null;

        public FrmScan()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            run_scan = new Thread(new ThreadStart(do_scan));
            run_scan.Start();
        }


        private void do_scan()
        {
            abort_scan = false;
            scan(new DirectoryInfo("c:\\"));
            pictureBox1.Image = null;
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
            catch(Exception e) { 
                buff.AddLine( "<<ERROR>> " + e.Message );
            }

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
                //run_scan.Abort();
                run_scan.Join();

                MessageBox.Show("Abort!");
            }

        }


    }
}
