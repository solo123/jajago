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
        List<CtlLists> control_list = new List<CtlLists>();
        public event EventHandler OnSelectChanged;
        public CtlResources()
        {
            InitializeComponent();

            control_list.Add(new CtlPhotoList());
            control_list.Add(new CtlMusicList());
            control_list.Add(new CtlVideoList());
            control_list.Add(new CtlImageList());
            control_list.Add(new CtlVideoList());

            foreach (CtlLists ctl in control_list)
            {
                ctl.Dock = DockStyle.Fill;
                ctl.Hide();
                this.Controls.Add(ctl);
            }
        }

        public Taxonomy current_taxonomy {
            set
            {
                ResourceManager rsm = ResourceManager.Instance;
                foreach (CtlLists ctl in control_list)
                {
                    if (value.id == ctl.TaxonomyID)
                    {
                        ctl.Show();
                        if (!ctl.IsLoaded)
                        {
                            ctl.SelectChanged += this.OnSelectChanged;
                            ctl.DataSource = rsm.GetList(value.id);
                            ctl.IsLoaded = true;
                        }
                    }
                    else ctl.Hide();
                }


            }
        }




    }
}
