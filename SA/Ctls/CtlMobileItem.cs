using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace com.jajago.SA.Ctls
{
    public partial class CtlMobileItem : UserControl
    {
        private string _title = null;
        public CtlMobileItem()
        {
            InitializeComponent();
        }
        public string title
        {
            get { return _title; }
            set { _title = value; lbTitle.Text = value; }
        }
        public Image image
        {
            set { pcb.Image = value; }
        }
    }
}
