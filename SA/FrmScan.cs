using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

using System.Collections;
using System.Threading;
using com.jajago.Biz;

namespace com.jajago.SA
{
    public partial class FrmScan : Form
    {
        ResourceManager rm = ResourceManager.Instance;
        string[] scanPaths = null;
        public FrmScan()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            string path = rm.ConfigSearchPath;
            if (path != null)
            {
                scanPaths = path.Split(';');
                Array.Sort(scanPaths);
                foreach (string s in scanPaths)
                {
                    Button btn = new Button();
                    btn.Text = "删除";
                    listView1.Items.Add(s);
                }
            }


        }

        private void scan(DirectoryInfo dir)
        {
            if (backgroundWorker1.CancellationPending) return;
            Stack dirStack = new Stack();
            dirStack.Push(dir);
            while (dirStack.Count > 0)
            {
                DirectoryInfo p = (DirectoryInfo)dirStack.Pop();
                try
                {
                    foreach (DirectoryInfo d in p.GetDirectories())
                    {
                        dirStack.Push(d);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                backgroundWorker1.ReportProgress(1, p);
                FileInfo[] files = p.GetFiles();
                foreach (FileInfo f in files)
                {
                    if (backgroundWorker1.CancellationPending) return;
                    rm.AddResource(f);
                    backgroundWorker1.ReportProgress(2, f);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy) return;

            backgroundWorker1.RunWorkerAsync(100);
            btnStart.Enabled = false;
            btnCancel.Enabled = true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            lbFile.Text += " [操作被取消]";
        }

        #region Multi-thread scan directory
        // 多线程读取数据
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (string s in scanPaths)
            {
                scan(new DirectoryInfo(s));
            }
        }

        ListViewItem lastItem = null;
        int fileCount = 0;
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 1)
            {
                DirectoryInfo dir = (DirectoryInfo)e.UserState;
                lastItem = new ListViewItem(dir.FullName);
                lastItem.SubItems.Add("...");
                listView1.Items.Add(lastItem);
                listView1.EnsureVisible(listView1.Items.Count - 1);
                fileCount = 0;
            }
            else
            {
                FileInfo f = (FileInfo)e.UserState;
                lbFile.Text = f.Name;
                progressBar1.Value = 50;
                if (lastItem != null)
                {
                    lastItem.SubItems[1].Text = fileCount++.ToString();
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnCancel.Enabled = false;
            btnStart.Enabled = true;
        }
        #endregion
    }
}
