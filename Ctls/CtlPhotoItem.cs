using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using com.jajago.Biz;
namespace com.jajago.SA.Ctls
{
    public partial class CtlPhotoItem : CtlLists
    {
        private ResImage _res_image = null;
        private bool _is_selected = false;
        public event EventHandler OnClicked;
        public event EventHandler OnSelectChanged;

        public CtlPhotoItem()
        {
            InitializeComponent();
        }
        public ResImage res_image
        {
            get { return _res_image; }
            set { 
                _res_image = value; 
                lbTitle.Text = value.filename;
                lbFileSize.Text = value.filesize;
                lbPhotoSize.Text = value.width;
                MemoryStream ms = new MemoryStream(value.thumb);
                pcb.Image = Image.FromStream(ms);
            }
        }

        private void pcb_DoubleClick(object sender, EventArgs e)
        {
            if (OnClicked!=null) OnClicked(_res_image, e);
        }

        private void pcb_Click(object sender, EventArgs e)
        {
            _is_selected = !_is_selected;
            if (_is_selected)
            {
                this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.BackColor = Color.LightYellow;
                SelectedCount = 1;
                SelectedSize = 500;
            }
            else
            {
                this.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.BackColor = Color.Transparent;
                SelectedCount = -1;
                SelectedSize = -500;
            }
            if (OnSelectChanged != null) OnSelectChanged(this, null);
        }
    }
}
