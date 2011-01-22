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
    public partial class CtlResources : UserControl
    {
        bool image_loaded = false;
        bool music_loaded = false;
        public event EventHandler OnSelectChanged;
        public CtlResources()
        {
            InitializeComponent();
        }
        public void InitControl()
        {
            ctlMusicList.OnSelectChanged += this.OnSelectChanged;
        }

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
                            ctlPhotoList.OnSelectChanged += this.OnSelectChanged;
                            ctlPhotoList.DataSource = rsm.GetList(value.id);
                            image_loaded = true;
                        }
                        break;
                    case "MUSIC":
                        if (!music_loaded)
                        {
                            ctlMusicList.DataSource = rsm.GetList(value.id);
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
                    ctlPhotoList.Dock = DockStyle.Fill;
                    ctlPhotoList.Show();
                    dataGridView1.Hide();
                    ctlMusicList.Hide();
                    break;
                case "MUSIC":
                    ctlPhotoList.Hide();
                    dataGridView1.Hide();
                    ctlMusicList.Dock = DockStyle.Fill;
                    ctlMusicList.Show();
                    break;
                default:
                    dataGridView1.Dock = DockStyle.Fill;
                    dataGridView1.Show();
                    ctlPhotoList.Hide();
                    ctlMusicList.Hide();
                    break;
            }
        }

        public DataGridViewSelectedRowCollection DataGridSR()
        {
            return dataGridView1.SelectedRows;
        }



        public void CacelSelect()
        {
            dataGridView1.ClearSelection();
        }


    }
}
