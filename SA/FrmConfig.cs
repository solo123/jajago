using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using com.jajago.SA.Biz;

namespace com.jajago.SA
{
    public partial class FrmConfig : Form
    {
        ResourceManager rm = ResourceManager.Instance;

        public FrmConfig()
        {
            InitializeComponent();
        }

        private void treeConfig_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeConfig.SelectedNode.Text == "资源路径")
                plConfig.Visible = true;
        }

        private void btnAddResourcePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                listResourcePath.Items.Add(folderBrowserDialog1.SelectedPath);
            }
        }

        private void btnDelResourcePath_Click(object sender, EventArgs e)
        {
            listResourcePath.Items.Remove(listResourcePath.SelectedItem);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {

            foreach (SearchPath sp in rm.GetSearchPath())
            {
                listResourcePath.Items.Add(sp.path);
            }
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            rm.ClearSearchPath();
            foreach(object item in listResourcePath.Items)
            {
                rm.AddSearchPath(item.ToString());
            }
        }
    }
}
