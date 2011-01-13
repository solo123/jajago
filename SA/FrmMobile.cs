using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.jajago.SA.Biz;
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
            lbDescription.Text = m.description;
            lbProps.Text = m.props;
            lbStandard.Text = m.standard;
            tsslTitle.Text = m.title;
            //byte[] img = m.small_icon;
            System.Drawing.Image returnImage = System.Drawing.Image.FromFile(@"d:\logo.jpg");
            //MemoryStream ms = new MemoryStream(m.small_icon);
            //System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            pbShowImage.Image = returnImage;
            pbShowImage.Height = returnImage.Height;
            pbShowImage.Width = returnImage.Width;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAllImage fai = new FrmAllImage();
            fai.ShowDialog();
        }
    }
}
