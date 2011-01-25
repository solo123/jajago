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
    public partial class CtlMusicList : CtlLists
    {
        private List<int> _selected_items = new List<int>();
        ResourceManager rm = null;
        public CtlMusicList()
        {
            TaxonomyID = "MUSIC";
            InitializeComponent();
        }
        public override object DataSource 
        { 
            set 
            { 
                listMusics.DataSource = value;
                TotalSize = 107832;
                TotalCount = 1031;
            } 
        }

        private void listMusics_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            //if (idx < 0) return;
            //if (rm == null) rm = ResourceManager.Instance;
            //DataGridViewRow crow = listMusics.Rows[idx];
            //ResMusic music = (ResMusic)crow.DataBoundItem;
            //Resource res = rm.GetResource(music.id);
            //a(idx, res, crow);
            if (idx < 0) return;

            if (rm == null) rm = ResourceManager.Instance;
            DataGridViewRow crow = listMusics.Rows[idx];
            ResMusic music = (ResMusic)crow.DataBoundItem;
            Resource res = rm.GetResource(music.id);
            if (_selected_items.IndexOf(idx) < 0)
            {
                _selected_items.Add(idx);
                foreach (DataGridViewCell cell in crow.Cells)
                {
                    cell.Style.BackColor = SystemColors.Highlight;
                    cell.Style.ForeColor = SystemColors.HighlightText;
                }
                crow.HeaderCell.Value = "√";
                SelectedCount++;
                if (res != null && res.size != null) SelectedSize += res.size.Value;
            }
            else
            {
                _selected_items.Remove(idx);
                foreach (DataGridViewCell cell in listMusics.Rows[e.RowIndex].Cells)
                {
                    cell.Style.BackColor = SystemColors.Control;
                    cell.Style.ForeColor = SystemColors.WindowText;
                }
                crow.HeaderCell.Value = "";
                SelectedCount--;
                if (res != null && res.size != null) SelectedSize -= res.size.Value;
            }
            base.OnSelectChanged(this, null);
        }

        public void a(int idx, Resource res, DataGridViewRow crow)
        {
            if (_selected_items.IndexOf(idx) < 0)
            {
                _selected_items.Add(idx);
                foreach (DataGridViewCell cell in crow.Cells)
                {
                    cell.Style.BackColor = SystemColors.Highlight;
                    cell.Style.ForeColor = SystemColors.HighlightText;
                }
                crow.HeaderCell.Value = "√";
                SelectedCount++;
                if (res != null && res.size != null) SelectedSize += res.size.Value;
            }
            else
            {
                _selected_items.Remove(idx);
                foreach (DataGridViewCell cell in crow.Cells)
                {
                    cell.Style.BackColor = SystemColors.Control;
                    cell.Style.ForeColor = SystemColors.WindowText;
                }
                crow.HeaderCell.Value = "";
                SelectedCount--;
                if (res != null && res.size != null) SelectedSize -= res.size.Value;
            }
            base.OnSelectChanged(this, null);
        }

    }
}
