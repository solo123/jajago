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
    public partial class FrmResource : Form
    {
        ResourceManager rsm = ResourceManager.Instance;
        List<TreeNode> selectedRoot = new List<TreeNode>();

        public FrmResource()
        {
            InitializeComponent();
            //DoSplash();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "家家购");

            foreach (Taxonomy t in rsm.AllTaxonomies)
            {
                TreeNode node = new TreeNode(t.name);
                node.Tag = t;
                treeCatalog.Nodes.Add(node);
                treeView2.Nodes.Add(t.name);
                TreeNode node1 = new TreeNode(t.name);
                treeselect.Nodes.Add(node1);
                selectedRoot.Add(node);
            }
            treeCatalog.AfterSelect += new TreeViewEventHandler(catalog_selected);
        }
        private void catalog_selected(object sender, TreeViewEventArgs e)
        {
            Taxonomy tx = (Taxonomy)treeCatalog.SelectedNode.Tag;
            gridResource.DataSource = rsm.GetList(tx.id);
        }

        private void DoSplash()
        {
            FrmSplash sp = new FrmSplash();
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
        jajagoEntities ent = new jajagoEntities();
        private void btnselect_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection cells = gridResource.SelectedRows;
            foreach (DataGridViewRow cell in cells)
            {
                foreach (TreeNode parent in selectedRoot)
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
            int count = gridResource.SelectedRows.Count;
            lbcount.Text = "本次选中" + count + "条," + "总共选中" + allcount + "条";

        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("d:\\temp.txt");
            DataGridViewSelectedRowCollection cells = gridResource.SelectedRows;
            foreach (DataGridViewRow cell in cells)
            {
                sw.WriteLine(cell.Cells[2].Value.ToString());
            }
            sw.Close();
        }

<<<<<<< HEAD
        Boolean IsClick = false;
        private void splitter1_MouseClick(object sender, MouseEventArgs e)
        {
            if (IsClick)
            {
                splitContainer2.Panel1Collapsed = false;
                IsClick = false;
            }
            else
            {
                splitContainer2.Panel1Collapsed = true;
                IsClick = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMobiles fms = new FrmMobiles();
            fms.Show();
        }
=======

>>>>>>> 59c4662d76b89b802d16d9f551b3a9194ae8fbb5
    }
}
