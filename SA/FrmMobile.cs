using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using com.jajago.Biz;
using System.IO;

namespace com.jajago.SA
{
    public partial class FrmMobile : Form
    {
        public FrmMobile()
        {
            InitializeComponent();
        }

        public void ShowMobile(int id)
        {
            MobileManager mm = MobileManager.Instance;
            Mobile m = mm.GetMobile(id);
            lbName.Text = m.title;
            FrmMobile fm = new FrmMobile();
            System.Drawing.Image returnImage = System.Drawing.Image.FromFile("mobiles/Download.png");
            pbShowImage.Image = returnImage;
            pbShowImage.Height = returnImage.Height;
            pbShowImage.Width = returnImage.Width;
            webBrowser1.DocumentText = m.description;
            lbPrice.Text = "￥" + m.price_shop.ToString();
            lbRefPrice.Text = "￥" + m.price_market.ToString();

            int i = 0;
            int j = 0;
            foreach (MobileInAttribute ma in mm.GetAttributes(id))
            {
                Label lbId = new Label();
                Label lbTitle = new Label();
                lbId.Text = ma.attribute_id.ToString();
                lbTitle.Text = ma.title;
                tableLayoutPanel1.SetRow(lbId, i++);
                tableLayoutPanel1.SetColumn(lbId, 0);
                tableLayoutPanel1.SetRow(lbTitle, j++);
                tableLayoutPanel1.SetColumn(lbTitle, 1);
                tableLayoutPanel1.Controls.Add(lbId);
                tableLayoutPanel1.Controls.Add(lbTitle);
            }
            tableLayoutPanel1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.jajago.com");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.jajago.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMobiles frmMobiles = new FrmMobiles();
            if (frmMobiles == null || frmMobiles.IsDisposed)
            {
                frmMobiles = new FrmMobiles();
                FrmContainer fc=new FrmContainer();
            }
            frmMobiles.WindowState = FormWindowState.Maximized;
            this.ActivateMdiChild(frmMobiles);
            frmMobiles.Show();
        }
    }
}
