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
                ListViewItem item = new ListViewItem(t.taxonomy.name);
                item.SubItems.Add("0");
                item.SubItems.Add("0");
                item.Tag = t.taxonomy;
                lstTaxonomy.Items.Add(item);
            }
        }
        private void lstTaxonomy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTaxonomy.SelectedItems.Count > 0)
            {
                Taxonomy tx = (Taxonomy)lstTaxonomy.SelectedItems[0].Tag;
                ucResources.current_taxonomy = tx;
            }
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

    }
}
