using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text == "123" && tbPassword.Text == "abc")
            {
                panel1.Visible = false;
                panel2.Visible = true;
            }
            else if (tbUserName.Text == "" || tbPassword.Text == "")
                MessageBox.Show("用户名或密码为空");
            else
                MessageBox.Show("你输入的用户名或密码不正确");
        }
    }
}
