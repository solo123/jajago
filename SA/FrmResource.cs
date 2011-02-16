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
        long sd_size = (long)2 << 30;

        public FrmResource()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ucResources.OnSelectChanged += new EventHandler(Resource_Select_Changed);
            foreach (ResourceTaxonomyNode t in rsm.AllTaxonomies)
            {
                ListViewItem item = new ListViewItem(t.title);
                item.SubItems.Add(t.count.ToString() + "/" + (t.size >> 20).ToString("n0"));
                item.SubItems.Add("0");
                item.Tag = t;
                lstTaxonomy.Items.Add(item);
            }
            ctlProgressBar1.Draw(0);
        }

        private void lstTaxonomy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTaxonomy.SelectedItems.Count > 0)
            {
                ResourceTaxonomyNode r = (ResourceTaxonomyNode)lstTaxonomy.SelectedItems[0].Tag;
                ucResources.current_taxonomy_id = r.id;
            }
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

            int cnt = 0;
            long size = 0;
            foreach (ListViewItem item in lstTaxonomy.Items)
            {
                ResourceTaxonomyNode r = (ResourceTaxonomyNode)item.Tag;
                if (r.id == ct.TaxonomyID)
                {
                    item.SubItems[2].Text = ct.SelectedCount.ToString() + "/" + (ct.SelectedSize >> 20).ToString("n0");
                }
                string[] s = item.SubItems[2].Text.Split('/');
                if (s != null && s.Length > 1)
                {
                    cnt += Convert.ToInt32(s[0]);
                    size += long.Parse(s[1], System.Globalization.NumberStyles.AllowThousands);
                }
            }
            ctlProgressBar1.Draw(Convert.ToInt32(((size * 100)<<20) / sd_size ));
            lbSelectedSize.Text ="选中"+cnt+"个资源，共"+size+"M";
        }

        private void btnWriteSD_Click(object sender, EventArgs e)
        {
            FrmWrite f = new FrmWrite();
            f.SetSelectedResource(ucResources.selected_items());
            f.ShowDialog();
        }
    }
}
