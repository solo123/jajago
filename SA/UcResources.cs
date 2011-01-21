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
        bool music_loaded = false;
        public Taxonomy current_taxonomy {
            set
            {
                ResourceManager rsm = ResourceManager.Instance;
                ShowCurrentPanel(value.id);
                switch (value.id)
                {
                    case "IMG":
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
                        break;
                    case "MUSIC":
                        if (!music_loaded)
                        {
                            listMusics.DataSource = rsm.GetList(value.id);
                            music_loaded = true;
                        }
                        break;
                    default:
                        dataGridView1.DataSource = rsm.GetList(value.id);
                        break;
                }

            }
        }
        public void ShowCurrentPanel(string taxonomy_id)
        {
            switch (taxonomy_id)
            {
                case "IMG":
                    plPhotos.Dock = DockStyle.Fill;
                    plPhotos.Show();
                    dataGridView1.Hide();
                    listMusics.Hide();
                    break;
                case "MUSIC":
                    plPhotos.Hide();
                    dataGridView1.Hide();
                    listMusics.Dock = DockStyle.Fill;
                    listMusics.Show();
                    break;
                default:
                    dataGridView1.Dock = DockStyle.Fill;
                    dataGridView1.Show();
                    plPhotos.Hide();
                    listMusics.Hide();
                    break;
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

        private void listMusics_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cell in listMusics.Rows[e.RowIndex].Cells)
            {
                cell.Style.BackColor = SystemColors.Highlight;
                cell.Style.ForeColor = Color.White;
            }
        }

 

    }
}
