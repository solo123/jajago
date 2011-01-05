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
        List<TreeNode> selectedRoot = new List<TreeNode>();

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
                treeView2.Nodes.Add(t.name);
            }
            treeCatalog.AfterSelect += new TreeViewEventHandler(catalog_selected);
            // TODO: 读取本地资源，如果没有，提示扫描硬盘；


            foreach (ResourceTaxonomy t in rsm.taxonomy)
            {
                TreeNode node = new TreeNode(t.name);
                treeselect.Nodes.Add(node);
                selectedRoot.Add(node);
            }

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

        private void comBobox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBobox2.Items != null && comBobox2.Items.Count > 0 && comBobox2.SelectedItem != null)
                if (comBobox2.SelectedItem.Equals("k660i"))
                    MessageBox.Show("k660i");
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            FrmScan fp = new FrmScan();
            fp.ShowDialog();
        }

        int allcount = 0;
        private void btnselect_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection cells = gridResource.SelectedRows;
            foreach (DataGridViewRow cell in cells)
            {
                foreach(TreeNode parent in selectedRoot)
                {
                    parent.Collapse();
                    if (parent.Text == cell.Cells[0].Value.ToString())
                    {
                        parent.Expand();
                        parent.Nodes.Add(cell.Cells[2].Value.ToString());
                        allcount++;
                    }
                }
            }
            int count=gridResource.SelectedRows.Count;
            lbcount.Text = "本次选中"+count+"条,"+"总共选中"+allcount+"条";
            
        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"D:\test");
        }

    }
}
