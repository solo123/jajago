using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.IO;
using System.Windows.Forms;

using System.Data.Objects;
using com.jajago.SA.Biz;

namespace com.jajago.SA
{
    public partial class FrmMain : Form
    {
        ResourceManager rsm = new ResourceManager();

        public FrmMain()
        {
            InitializeComponent();
            //DoSplash();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "家家购");

            foreach (ResourceTaxonomy t in rsm.taxonomy)
            {
                treeCatalog.Nodes.Add(t.name);
            }
            treeCatalog.AfterSelect += new TreeViewEventHandler(catalog_selected);
            // TODO: 读取本地资源，如果没有，提示扫描硬盘；

        }
        private void catalog_selected(object sender, TreeViewEventArgs e)
        {
            gridResource.DataSource = rsm.GetList(treeCatalog.SelectedNode.Text);
        }

        private void DoSplash()
        {
            splash sp = new splash();
            sp.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("欢迎使用家家购");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.jajago.com");
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {
            
        }

        private void comBobox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBobox2.Items != null && comBobox2.Items.Count > 0 && comBobox2.SelectedItem != null)
                if (comBobox2.SelectedItem.Equals("k660i"))
                    MessageBox.Show("k660i");
        }

        private void treeCatalog_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "大陆")
            {
                //StreamWriter sw = new StreamWriter(@"E:\temp.txt");
                //sw.WriteLine("123");
                //sw.WriteLine("酷购科技");
                //sw.Close();
                //StreamReader sr = new StreamReader(@"E:\temp.txt", Encoding.UTF8);
                MessageBox.Show("这是大陆歌曲");
            }
            if (e.Node.Text == "欧美")
            {
                
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            FrmScan fp = new FrmScan();
            fp.ShowDialog();
        }

        private void DoPop()
        {
        }



    }
}
