using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using com.jajago.Biz;
namespace com.jajago.SA
{
    public partial class FrmPrice : Form
    {
        public FrmPrice()
        {
            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = false;
        }

        public string UserName { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            UserName = tbUserName.Text;
            if (tbUserName.Text == "123" && tbPassword.Text == "123456")
            {
                panel1.Visible = false;
                panel2.Visible = true;
                lbUserName.Text = UserName + "用户，您好！";
            }
            else if (tbPassword.TextLength < 6 || tbPassword.TextLength > 18)
            {
                MessageBox.Show("你输入的密码长度不正确");
            }
            else
                MessageBox.Show("你输入的用户名或密码不正确");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MobileManager mm=MobileManager.Instance;
            string a = tbSearch.Text;
            lstPriceData.DataSource = mm.GetList(a);
            if (lstPriceData.Rows.Count > 0)
            {
                lstPriceData.Columns[1].HeaderCell.Value = "品牌";
                lstPriceData.Columns[3].HeaderCell.Value = "批发价格";
                lstPriceData.Columns.RemoveAt(6);
                lstPriceData.Columns.RemoveAt(5);
                lstPriceData.Columns.RemoveAt(4);
                lstPriceData.Columns.RemoveAt(2);
                lstPriceData.Columns.RemoveAt(0);
            }
        }

        private void llbExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbUserName.Text = "";
            tbPassword.Text = "";
            panel2.Visible = false;
            panel1.Visible = true;
        }
    }
}
