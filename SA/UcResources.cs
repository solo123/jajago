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
                            MemoryStream ms = new MemoryStream(res.thumb);
                            Image img = Image.FromStream(ms);
                            imageList1.Images.Add(img);
                            ListViewItem li = new ListViewItem();
                            li.Text = res.filename+"\n"+res.width+res.filesize;
                            li.ImageIndex = imageList1.Images.Count - 1;
                            listView1.Items.Add(li);
                        }
                        image_loaded = true;
                    }
                    dataGridView1.Hide();
                    listView1.Show();
                }
                else
                {
                    listView1.Hide();
                    dataGridView1.Show();
                    dataGridView1.DataSource = rsm.GetList(value.id);
                }
            }
        }

        public DataGridViewSelectedRowCollection DataGridSR()
        {
            return dataGridView1.SelectedRows;
        }

        public ListView.SelectedListViewItemCollection ListSR()
        {
            return listView1.SelectedItems;
        }

        public int ImageCount()
        {
            return listView1.SelectedItems.Count;
        }

        public int DataCount()
        {
            return dataGridView1.SelectedRows.Count;
        }

        public UcResources()
        {
            InitializeComponent();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FrmShowPic fsp = new FrmShowPic();
            fsp.ShowDialog();
        }
    }
}
