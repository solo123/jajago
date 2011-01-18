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
using com.jajago.Biz;

namespace com.jajago.SA
{
    public partial class FrmResource : Form
    {
        ResourceManager rsm = ResourceManager.Instance;
        List<TreeNode> selectedRoot = new List<TreeNode>();

        public FrmResource()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            foreach (ResourceTaxonomyNode t in rsm.AllTaxonomies)
            {
                TreeNode node = new TreeNode(t.taxonomy.name);
                node.Tag = t.taxonomy;
                treeCatalog.Nodes.Add(node);
                TreeNode node1 = new TreeNode(t.taxonomy.name);
                treeselect.Nodes.Add(node1);
                selectedRoot.Add(node);
            }
        }
        private void catalog_selected(object sender, TreeViewEventArgs e)
        {
            Taxonomy tx = (Taxonomy)treeCatalog.SelectedNode.Tag;
            ucResources.current_taxonomy = tx;
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

        private void btnScan_Click(object sender, EventArgs e)
        {
            FrmScan fp = new FrmScan();
            fp.ShowDialog();
        }

        int Total = 0;
        private void btnselect_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow cell in ucResources.DataGridSR())
            {
                treeselect.Nodes.Add(cell.Cells[2].Value.ToString());
                Total++;
            }
            foreach (ListViewItem lv in ucResources.ListSR())
            {
                treeselect.Nodes.Add(lv.Text);
                Total++;
            }
            lbCount.Text = "总共选中" + Total.ToString();
            ucResources.CacelSelect();
        }

        /*
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
       */

    }
}
