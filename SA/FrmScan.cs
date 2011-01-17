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
        int resourceCount = 0;
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
            listView1.Columns[0].Width = listView1.Width - 90;
        }

       
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy) return;
            listView1.Items.Clear();
            backgroundWorker1.RunWorkerAsync(100);
            btnStart.Enabled = false;
            btnCancel.Enabled = true;
            lbOp.Text = "扫描中...";
            lbOp.ForeColor = Color.Green;
            scan_cancled = false;
        }
        bool scan_cancled = false;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                scan_cancled = true;
            }
        }
        private void FrmScan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker1.IsBusy) backgroundWorker1.CancelAsync();
        }

        private void FrmScan_Resize(object sender, EventArgs e)
        {
            listView1.Columns[0].Width = listView1.Width - 90;
        }

        #region Multi-thread scan directory
        // 多线程读取数据
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            do_scan();
        }

        ListViewItem lastItem = null;
        int fileCount = 0;
        float totalProgress = 0;
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 101)  // cur path
            {
                string s = (string)e.UserState;
                lastItem = new ListViewItem(s);
                lastItem.SubItems.Add("");
                listView1.Items.Add(lastItem);
                listView1.EnsureVisible(listView1.Items.Count - 1);
                fileCount = 0;
            }
            else if (e.ProgressPercentage == 102) // cur filename
            {
                string s = (string)e.UserState;
                lbFile.Text = s;
                if (lastItem != null)
                {
                    lastItem.SubItems[1].Text = (++fileCount).ToString();
                    lbCnt.Text = (++resourceCount).ToString() + "个";
                }
            }
            else if (e.ProgressPercentage == 1) // progress
            {
                totalProgress += (float)e.UserState;
                progressBar1.Value = (int)totalProgress;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnCancel.Enabled = false;
            btnStart.Enabled = true;
            if (scan_cancled)
            {
                lbOp.Text = "操作被中断";
                lbOp.ForeColor = Color.Red;
            }
            else
            {
                progressBar1.Value = 100;
                lbOp.Text = "扫描完成";
                lbOp.ForeColor = Color.Blue;
                MessageBox.Show("扫描已经完成");
                this.Close();
            }

        }

        private void do_scan()
        {
            resourceCount = 0;
            totalProgress = 0;
            Stack dirStack = new Stack();
            float tot = scanPaths.Count();
            foreach (string s in scanPaths)
            {
                ScanNode sn = new ScanNode();
                sn.path = s;
                sn.weight = 100 / (float)tot;
                dirStack.Push(sn);
            }

            while (dirStack.Count > 0)
            {
                if (backgroundWorker1.CancellationPending) return;
                ScanNode sn = (ScanNode)dirStack.Pop();
                DirectoryInfo cur = new DirectoryInfo(sn.path);
                DirectoryInfo[] subDirs = cur.GetDirectories();
                if (subDirs.Length > 0)
                {
                    sn.weight = sn.weight / (subDirs.Length + 1);
                    foreach (DirectoryInfo sub in subDirs)
                    {
                        if (backgroundWorker1.CancellationPending) return;
                        ScanNode subnode = new ScanNode();
                        subnode.path = sub.FullName;
                        subnode.weight = sn.weight;
                        dirStack.Push(subnode);
                    }
                }

                backgroundWorker1.ReportProgress(101, sn.path);
                FileInfo[] files = cur.GetFiles();
                foreach (FileInfo f in files)
                {
                    if (backgroundWorker1.CancellationPending) return;
                    rm.AddResource(f);
                    backgroundWorker1.ReportProgress(102, f.Name);
                }
                backgroundWorker1.ReportProgress(1, sn.weight);
            }
        }
        #endregion

    }
}
