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
    public partial class FrmOrder : Form
    {
        OrdersEntities orent = new OrdersEntities();

        public FrmOrder()
        {
            InitializeComponent();
        }

        public void ListOrder(String proName)
        {
            lbProductName.Text = proName;
            cbCount.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.name = tbName.Text;
            o.productName = lbProductName.Text;
            o.mobilePhone = tbMobilePhone.Text;
            o.address = tbAddress.Text;
            o.count = Convert.ToInt16(cbCount.Text);
            o.invoice = tbInvoice.Text;
            orent.SaveChanges();
            MessageBox.Show("添加成功");
            this.Close();
        }

    }
}
