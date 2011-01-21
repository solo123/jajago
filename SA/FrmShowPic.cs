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
        public ResImage res_image
        {
            set
            {
                ResImage res = value;
                this.Text = res.filename;
                lbFilename.Text = res.filename;
                lbFileext.Text = res.fileext;
                lbWidth.Text = res.width;
                lbHeight.Text = res.height;
                lbDpi.Text = res.dpi;
                lbFiletype.Text = res.filetype;
                lbFilesize.Text = res.filesize;
                Resource rs = rsm.GetResource(res.id);
                Image img = Image.FromFile(rs.path);
                pictureBox1.Image = img;
            }
        }
    }
}
