using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace com.jajago.SA
{
    public partial class FrmShowPic : Form
    {
        public FrmShowPic()
        {
            InitializeComponent();
            DirectoryInfo dir = new DirectoryInfo(@"d:\a");
            foreach (FileInfo file in dir.GetFiles())
            {
                imageList1.Images.Add(Image.FromFile(file.FullName));
            }
            listView1.View = View.LargeIcon;
            listView1.View = View.SmallIcon;
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
