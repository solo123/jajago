﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace com.jajago.SA
{
    public partial class FrmContainer : Form
    {
        public FrmContainer()
        {
            InitializeComponent();
        }

        private void tsResource_Click(object sender, EventArgs e)
        {
            FrmMain f = new FrmMain();
            f.MdiParent = this;
            f.Show();
        }

        private void menuConfig_Click(object sender, EventArgs e)
        {
            FrmConfig f = new FrmConfig();
            f.ShowDialog();
        }
    }
}
