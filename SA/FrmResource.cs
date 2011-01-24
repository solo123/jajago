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
        long selected_size = 0;
        int selected_count = 0;
        long sd_size = 2000000000;

        public FrmResource()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ucResources.OnSelectChanged += new EventHandler(Resource_Select_Changed);
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

        private void Resource_Select_Changed(object sender, EventArgs e)
        {
            AppManager app = AppManager.Instance;
            Ctls.CtlLists ct = (Ctls.CtlLists)sender;
            app.StatusText = "Selected: " + ct.TotalSize + "/" + ct.TotalCount + "/" + ct.SelectedSize + "/" + ct.SelectedCount;

            foreach (ListViewItem item in lstTaxonomy.Items)
            {
                Taxonomy tx = (Taxonomy)item.Tag;
                if (tx.id == ct.TaxonomyID)
                {
                    item.SubItems[1].Text = ct.TotalCount.ToString() + "/" + ct.TotalSize.ToString();
                    item.SubItems[2].Text = ct.SelectedCount.ToString() + "/" + (ct.SelectedSize >> 10);
                    selected_size += ct.SelectedSize;
                    selected_count += ct.SelectedCount;
                    break;
                }
            }

            progressBar1.Value += Convert.ToInt32(selected_size * 100 / sd_size);
            lbSelectedSize.Text ="选中"+selected_count+"个资源，共"+(selected_size >> 10)+"M";
        }

    }
}
