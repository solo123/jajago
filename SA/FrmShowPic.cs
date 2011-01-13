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
    public partial class FrmShowPic : Form
    {
        public FrmShowPic()
        {
            InitializeComponent();
            pictureBox1.Image = global::com.jajago.SA.Properties.Resources.logo;
        }
    }
}
