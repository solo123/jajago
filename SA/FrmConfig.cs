using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using com.jajago.Biz;

namespace com.jajago.SA
{
    public partial class FrmConfig : Form
    {
        private Boolean IsChange = false;
        ResourceManager rm = ResourceManager.Instance;

        public FrmConfig()
        {
            InitializeComponent();
            btnSave.Visible = false;
            btnCancel.Visible = false;
        }
        private void FrmConfig_Load(object sender, EventArgs e)
        {
            string path = rm.ConfigSearchPath;
            if (path != null)
            {
                string[] paths = path.Split(';');
                Array.Sort(paths);
                foreach (string s in paths)
                {
                    listResourcePath.Items.Add(s);
                }
            }
        }

        private void treeConfig_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeConfig.SelectedNode.Text == "资源路径")
            {
                plConfig.Visible = true;
                btnSave.Visible= true;
                btnCancel.Visible = true;
            }
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
                           if (folderBrowserDialog1.SelectedPath == listResourcePath.Items[i].ToString()
                               || Directory.GetDirectoryRoot(folderBrowserDialog1.SelectedPath.Trim()).ToString() == listResourcePath.Items[i].ToString())
                           {
                               MessageBox.Show("你当前选择的文件已经存在!");
                               break;
                           }
                           else if (Directory.GetDirectoryRoot(listResourcePath.Items[i].ToString()) == folderBrowserDialog1.SelectedPath.Trim().ToString())
                           {
                               MessageBox.Show("当前文件与此前文件存在重复的部分！");
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
                    btnSave_Click(sender, e);
                }
            }
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (object item in listResourcePath.Items)
            {
                sb.Append(item.ToString());
                sb.Append(';');
            }
            sb.Remove(sb.Length - 1, 1);
            rm.ConfigSearchPath = sb.ToString();
            this.Close();
        }
    }
}
