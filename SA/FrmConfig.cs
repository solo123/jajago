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
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void treeConfig_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnAddResourcePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                listResourcePath.Items.Add(folderBrowserDialog1.SelectedPath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
