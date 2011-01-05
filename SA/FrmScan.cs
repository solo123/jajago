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
            ResourceManager rm = new ResourceManager();
            rm.scan(new DirectoryInfo("d:\\"));
            pictureBox1.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (run_scan != null && run_scan.IsAlive)
            {
                run_scan.Join();
                MessageBox.Show("Abort!");
            }

        }

    }
}
