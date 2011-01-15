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
                            li.Text = res.filename;
                            li.ImageIndex = imageList1.Images.Count - 1;
                            listView1.Items.Add(li);
                        }
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

        public UcResources()
        {
            InitializeComponent();
        }
    }
}
