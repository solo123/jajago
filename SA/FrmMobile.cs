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

        public Mobile mobile
        {
            set
            {
                MobileManager mm = MobileManager.Instance;
                Mobile m = value;
                lbName.Text = m.title;
                FrmMobile fm = new FrmMobile();
                string imageFile = "mobiles/photos/original/" + m.id + ".jpg";
                if (File.Exists(imageFile))
                    pbShowImage.Image = Image.FromFile(imageFile);
                webBrowser1.DocumentText = m.description;
                lbPrice.Text = "￥" + m.price_shop.ToString();
                lbRefPrice.Text = "￥" + m.price_market.ToString();
                lbStandard.Text = mm.MobileStandard(m.id);

                foreach (KeyValuePair<string, string> a in mm.GetAttributes(m.id))
                {
                    ListViewItem item = new ListViewItem(a.Key);
                    item.SubItems.Add(a.Value);
                    lstProp.Items.Add(item);
                }
            }
        }
    }
}
