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
    public partial class FrmAllImage : Form
    {
        public FrmAllImage()
        {
            InitializeComponent();
        }

        private void FrmAllImage_Load(object sender, EventArgs e)
        {
            imageList1.Images.Add(System.Drawing.Image.FromFile(@"d:\logo.jpg"));
            imageList1.Images.Add(System.Drawing.Image.FromFile(@"d:\ecshop_logo.gif"));
            listView1.View = View.LargeIcon;
            imageList1.ImageSize = new Size(82, 82);
            listView1.LargeImageList = imageList1;
            for (int j = 0; j < this.imageList1.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                listView1.Items.Add(item);
            }
        }
    }
}
