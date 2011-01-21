using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using com.jajago.Biz;
namespace com.jajago.SA.Ctls
{
    public partial class CtlMobileItem : UserControl
    {
        private Mobile _mobile = null;
        public CtlMobileItem()
        {
            InitializeComponent();
        }

        public Mobile mobile
        {
            get { return _mobile; }
            set { _mobile = value; lbTitle.Text = value.title; }
        }

        public Image image
        {
            set { pcb.Image = value; }
        }

        public event EventHandler OnClicked;

        private void pcb_DoubleClick(object sender, EventArgs e)
        {
            if (OnClicked!=null) OnClicked(_mobile, e);
        }
    }
}
