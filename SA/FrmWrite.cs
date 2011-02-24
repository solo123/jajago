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
            lstData.AutoGenerateColumns = false;
            if (lstData.Rows.Count > 0)
            {
                lstData.Columns[0].HeaderCell.Value = "类型";
                lstData.Columns[2].HeaderCell.Value = "名称";
                lstData.Columns[3].HeaderCell.Value = "路径";
                lstData.Columns[4].HeaderCell.Value = "创建时间";
                lstData.Columns[6].HeaderCell.Value = "大小";
                lstData.Columns.RemoveAt(5);
                lstData.Columns.RemoveAt(1);
                lstData.Columns[0].FillWeight = 15;
                lstData.Columns[1].FillWeight = 20;
                lstData.Columns[2].FillWeight = 35;
                lstData.Columns[3].FillWeight = 15;
                lstData.Columns[4].FillWeight = 15;
            }
            int count = lstData.Rows.Count;
            lbInfo.Text = "准备写入" + count + "个文件";
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
                    string fileName = d.Cells[1].Value.ToString();
                    string file = d.Cells[0].Value.ToString();
                    string[] array = fileName.Split('.');
                    string fileend = array[array.Length - 1];

                    DirectoryInfo di = new DirectoryInfo(txtPath.Text + @"\" + file);
                    if (!di.Exists)
                        Directory.CreateDirectory(txtPath.Text + @"\" + d.Cells[0].Value.ToString());
                    FileInfo f = new FileInfo(d.Cells[2].Value.ToString());
                    if (File.Exists(txtPath.Text + @"\" + file + @"\" + fileName))
                    {
                        while (File.Exists(txtPath.Text + @"\" + file + @"\" + fileName.Remove(fileName.LastIndexOf('.')) + i.ToString() + "." + fileend))
                            i++;
                        f.CopyTo(txtPath.Text + @"\" + file + @"\" + fileName.Remove(fileName.LastIndexOf('.')) + i++.ToString()+"."+fileend);
                    }
                    else
                        f.CopyTo(txtPath.Text + @"\" + file + @"\" + fileName);
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
