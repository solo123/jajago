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
        private Boolean IsChange = false;
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
                if (listResourcePath.Items.Count == 0)
                    listResourcePath.Items.Add(folderBrowserDialog1.SelectedPath);
                else
                {
                    for (int i = 0; i < listResourcePath.Items.Count; i++)
                    {
                        if (folderBrowserDialog1.SelectedPath == listResourcePath.Items[i].ToString())
                        {
                            MessageBox.Show("你当前选择的文件已经存在!");
                            break;
                        }
                        else if (i == listResourcePath.Items.Count - 1)
                        {
                            listResourcePath.Items.Add(folderBrowserDialog1.SelectedPath);
                            break;
                        }
                    }
                }
            }
        }

        private void btnDelResourcePath_Click(object sender, EventArgs e)
        {
            listResourcePath.Items.Remove(listResourcePath.SelectedItem);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (IsChange)
            {
                this.Close();
            }
            else
            {
                if (MessageBox.Show("你还没有保存，是否保存", "退出", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rm.ClearSearchPath();
                    foreach (object item in listResourcePath.Items)
                    {
                        rm.AddSearchPath(item.ToString());
                    }
                    this.Close();
                }
            }
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
            foreach (object item in listResourcePath.Items)
            {
                rm.AddSearchPath(item.ToString());
            }
            IsChange = true;
            this.Close();
        }
    }
}
