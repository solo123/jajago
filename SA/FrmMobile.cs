using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.jajago.SA.Biz;

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
            //pictureBox1.Image = System.Drawing.Image.FromFile(m.photo_path);
        }
    }
}
