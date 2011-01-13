using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using com.jajago.SA.Biz;
namespace com.jajago.SA
{
    public partial class UcResources : UserControl
    {
        public Taxonomy current_taxonomy {
            set
            {
                ResourceManager rsm = ResourceManager.Instance;

                if (value.id == "IMG")
                {
                    foreach(com.jajago.SA.Biz.Image res in rsm.GetList(value.id))
                    {
                        ListViewItem li = new ListViewItem();
                        li.Text = res.id;
                        listView1.Items.Add(li);
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
