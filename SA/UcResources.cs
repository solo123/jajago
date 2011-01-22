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
namespace com.jajago.SA
{
    public partial class UcResources : UserControl
    {
        bool image_loaded = false;
        public Taxonomy current_taxonomy {
            set
            {
                ResourceManager rsm = ResourceManager.Instance;

                if (value.id == "IMG")
                {
                    if (!image_loaded)
                    {
                        foreach (ResImage res in rsm.GetList(value.id))
                        {
                            Ctls.CtlPhotoItem li = new Ctls.CtlPhotoItem();
                            li.res_image = res;
                            li.OnClicked += new EventHandler(PhotoDoubleClicked);
                            plPhotos.Controls.Add(li);
                        }
                        image_loaded = true;
                    }
                    dataGridView1.Hide();
                    plPhotos.Show();
                }
                else
                {
                    plPhotos.Hide();
                    dataGridView1.Show();
                    dataGridView1.DataSource = rsm.GetList(value.id);
                }
            }
        }

        public void PhotoDoubleClicked(object sender, EventArgs e)
        {
            FrmShowPic f = new FrmShowPic();
            f.res_image = (ResImage)sender;
            f.ShowDialog();
        }

        public DataGridViewSelectedRowCollection DataGridSR()
        {
            return dataGridView1.SelectedRows;
        }

        public void CacelSelect()
        {
            dataGridView1.ClearSelection();
        }

        public UcResources()
        {
            InitializeComponent();
        }

 

    }
}
