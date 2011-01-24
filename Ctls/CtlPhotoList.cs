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
    public partial class CtlPhotoList : CtlLists
    {
        public CtlPhotoList()
        {
            TaxonomyID = "IMG";
            InitializeComponent();
        }
        public override object DataSource
        {
            set
            {
                foreach (ResImage res in (IQueryable<object>)value)
                {
                    Ctls.CtlPhotoItem li = new Ctls.CtlPhotoItem();
                    li.res_image = res;
                    li.OnClicked += new EventHandler(PhotoDoubleClicked);
                    li.SelectChanged += new EventHandler(Item_Select_Changed);
                    plPhotos.Controls.Add(li);
                }
            }
        }

        public void PhotoDoubleClicked(object sender, EventArgs e)
        {
            /*
            FrmShowPic f = new FrmShowPic();
            f.res_image = (ResImage)sender;
            f.ShowDialog();
             */
        }

        private void Item_Select_Changed(object sender, EventArgs e)
        {
            CtlLists ct = (CtlLists)sender;
            SelectedCount += ct.SelectedCount;
            SelectedSize += ct.SelectedSize;
            base.OnSelectChanged(this, null);
        }

    }
}
