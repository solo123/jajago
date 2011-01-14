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
            System.Drawing.Image returnImage = System.Drawing.Image.FromFile(@"d:\logo.jpg");
            pbShowImage.Image = returnImage;
            pbShowImage.Height = returnImage.Height;
            pbShowImage.Width = returnImage.Width;
            webBrowser1.DocumentText = m.description;
            lbPrice.Text = "￥" + m.price_shop.ToString();
            lbRefPrice.Text = "￥" + m.price_market.ToString();
            StringBuilder sb = new StringBuilder();
            foreach (MobileInAttribute ma in mm.GetAttributes(id))
            {
                sb.Append(ma.attribute_id);
                sb.Append(":");
                sb.Append(ma.title);
                sb.Append("\n");
            }
            tbProps.Text = sb.ToString();
        }
    }
}
