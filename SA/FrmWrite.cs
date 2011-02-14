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
    public partial class FrmWrite : Form
    {
        public FrmWrite()
        {
            InitializeComponent();
            List<Resource> SelectSource = new List<Resource>();
            ResourceManager rm = ResourceManager.Instance;
            lstData.DataSource = rm.GetList("VIDEO");
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            txtPath.Text = "";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                txtPath.Text = "";
            } 
        }

        int i=1;
        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (txtPath.Text != null && txtPath.Text != "")
            {
                String oldPath = lstData.SelectedCells[3].Value.ToString();
                String newPath = txtPath.Text + @"\" + lstData.SelectedCells[2].Value.ToString();
                FileInfo f = new FileInfo(oldPath);
                if (File.Exists(newPath))
                {
                    while (File.Exists(newPath + i.ToString()))
                        i++;
                    f.CopyTo(newPath + i++.ToString());
                }
                else
                    f.CopyTo(newPath);
                MessageBox.Show("写入成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("请选择你要写入的文件路径！");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
