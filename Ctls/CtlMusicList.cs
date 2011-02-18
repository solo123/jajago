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
        ResourceManager rm = ResourceManager.Instance;

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
                if (listMusics.Rows.Count > 0)
                {
                    listMusics.Columns[1].HeaderCell.Value = "歌名";
                    listMusics.Columns[2].HeaderCell.Value = "歌手";
                    listMusics.Columns[4].HeaderCell.Value = "创建时间";
                    listMusics.Columns[5].HeaderCell.Value = "类型";
                    listMusics.Columns.RemoveAt(3);
                    listMusics.Columns.RemoveAt(0);
                    listMusics.Columns[0].FillWeight = 30;
                    listMusics.Columns[1].FillWeight = 20;
                    listMusics.Columns[2].FillWeight = 25;
                    listMusics.Columns[3].FillWeight = 25;
                }
                TotalSize = 107832;
                TotalCount = 1031;
            } 
        }

        public override List<object> SelectedItems
        {
            get
            {
                List<object> s = new List<object>();
                foreach (int i in _selected_items)
                {
                    DataGridViewRow crow = listMusics.Rows[i];
                    ResMusic music = (ResMusic)crow.DataBoundItem;
                    object r = rm.GetResource(music.id);
                    s.Add(r);
                }
                return s;
            }
        }

        private void listMusics_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
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
    }
}
