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
            btnStart.Enabled = false;
            btnCancel.Enabled = true;
            lbOp.Text = "扫描中...";
            lbOp.ForeColor = Color.Green; 
            backgroundWorker1.RunWorkerAsync(100);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy) backgroundWorker1.CancelAsync();
        }
        private void FrmScan_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnCancel_Click(null,null);
        }

        private void FrmScan_Resize(object sender, EventArgs e)
        {
            listView1.Columns[0].Width = listView1.Width - 90;
        }

        #region Multi-thread scan directory

        // 多线程读取数据
        ListViewItem lastItem = null;
        int fileCount = 0;
        float totalProgress = 0;
        DirectoryInfo cur = null;
        DirectoryInfo[] subDirs = null;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (scanPaths == null || scanPaths.Length < 1)
            {
                MessageBox.Show("请先添加搜索目录");
                return;
            }

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
                try
                {
                    cur = new DirectoryInfo(sn.path);
                    subDirs = cur.GetDirectories();
                }
                catch
                {
                    backgroundWorker1.ReportProgress(103, sn.path);
                }
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
                FileInfo[] files = null;
                backgroundWorker1.ReportProgress(101, sn.path);
                try { files = cur.GetFiles(); }
                catch (UnauthorizedAccessException ex) { continue; }

                foreach (FileInfo f in files)
                {
                    if (backgroundWorker1.CancellationPending) return;
                    rm.AddResource(f);
                    backgroundWorker1.ReportProgress(102, f.Name);
                }
                backgroundWorker1.ReportProgress(1, sn.weight);
            }
        }


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
            else if (e.ProgressPercentage == 103) // error
            {
                string s = (string)e.UserState;
                lastItem = new ListViewItem(s);
                lastItem.SubItems.Add("出错");
                listView1.Items.Add(lastItem);
                listView1.EnsureVisible(listView1.Items.Count - 1);
                fileCount = 0;
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
            if (e.Cancelled)
            {
                lbOp.Text = "操作被中断";
                lbOp.ForeColor = Color.Red;
            }
            else
            {
                progressBar1.Value = 100;
                lbOp.Text = "扫描完成";
                lbOp.ForeColor = Color.Blue;
            }
        }

        #endregion

    }
}
