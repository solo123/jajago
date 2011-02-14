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
        }

        public void SetSelectedResource(object datasource)
        {
            lstData.DataSource = datasource;
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

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (txtPath.Text != null && txtPath.Text != "")
            {
                foreach (DataGridViewRow d in lstData.Rows)
                {
                    int i = 1;
                    DirectoryInfo di = new DirectoryInfo(txtPath.Text + @"\" + d.Cells[0].Value.ToString());
                    if (!di.Exists)
                        Directory.CreateDirectory(txtPath.Text + @"\" + d.Cells[0].Value.ToString());
                    FileInfo f = new FileInfo(d.Cells[3].Value.ToString());
                    if (File.Exists(txtPath.Text + @"\" + d.Cells[0].Value.ToString() + @"\" + d.Cells[2].Value.ToString()))
                    {
                        while (File.Exists(txtPath.Text + @"\" + d.Cells[0].Value.ToString()+@"\"+d.Cells[2].Value.ToString() + i.ToString()))
                            i++;
                        f.CopyTo(txtPath.Text + @"\" + d.Cells[0].Value.ToString() + @"\" + d.Cells[2].Value.ToString() + i++.ToString());
                    }
                    else
                        f.CopyTo(txtPath.Text + @"\" + d.Cells[0].Value.ToString() + @"\" + d.Cells[2].Value.ToString());
                }
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
