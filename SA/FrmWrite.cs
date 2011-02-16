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
            checkBox1.Checked = true;
        }

        public void SetSelectedResource(object datasource)
        {
            lstData.DataSource = datasource;
            if (lstData.Rows.Count > 0)
            {
                lstData.Columns[2].HeaderCell.Value = "名称";
                lstData.Columns[3].HeaderCell.Value = "路径";
                lstData.Columns[4].HeaderCell.Value = "创建时间";
                lstData.Columns[6].HeaderCell.Value = "大小";
            }
            int count = lstData.Rows.Count;
            lbInfo.Text = "准备写入"+count+"个文件";
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
