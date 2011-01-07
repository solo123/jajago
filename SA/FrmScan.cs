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
        ResourceManager rm = ResourceManager.Instance;

        delegate void ShowDirAndFile(string dir, string file);
    

        public FrmScan()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            rm.OnAddResource += new EventHandler(OnAddResource);
            run_scan = new Thread(new ThreadStart(do_scan));
            run_scan.Start();
            //do_scan();
        }

        private void do_scan()
        {
            foreach (SearchPath sp in rm.GetSearchPath())
            {
                scan(new DirectoryInfo(sp.path));
            }

            pictureBox1.Image = null;
        }

        private void show_dir_and_file(string dir, string file)
        {
            if (dir != null) { lbFolder.Text = dir; lbFile.Text = ""; }
            if (file != null) lbFile.Text = file;
        }

        private void scan(DirectoryInfo dir)
        {
            try
            {
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo di in dirs)
                {
                    scan(di);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            ShowDirAndFile sdf = new ShowDirAndFile(show_dir_and_file);
            sdf(dir.FullName, null);
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo f in files)
            {
                rm.AddResource(f);
            }
        }
        private void OnAddResource(object sender, EventArgs e)
        {
            Resource rs = (Resource)sender;
            lbFile.Text = rs.name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (run_scan != null && run_scan.IsAlive)
            {
                run_scan.Abort();
                run_scan.Join();
                MessageBox.Show("Abort!");
            }

        }

    }
}
