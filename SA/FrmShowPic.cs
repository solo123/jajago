using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using com.jajago.Biz;

namespace com.jajago.SA
{
    public partial class FrmShowPic : Form
    {
        public FrmShowPic()
        {
            InitializeComponent();
        }

        ResourceManager rsm = ResourceManager.Instance;
        public void ShowImage(ResImage res)
        {
            this.Text = res.filename;
            lbSize.Text = res.filesize;
            lbType.Text = res.filetype;
            MemoryStream ms = new MemoryStream(res.thumb);
            Image img = Image.FromStream(ms);
            pictureBox1.Image = img;
        }
    }
}
