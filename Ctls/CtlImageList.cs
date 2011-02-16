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
    public partial class CtlImageList : CtlLists
    {
        private List<int> _selected_items = new List<int>();
        ResourceManager rm = null;

        public CtlImageList()
        {
            TaxonomyID = "IMAGE";
            InitializeComponent();
        }

        public override object DataSource 
        { 
            set 
            { 
                listData.DataSource = value;
                if (listData.Rows.Count > 0)
                {
                    listData.Columns[2].HeaderCell.Value = "名称";
                    listData.Columns[3].HeaderCell.Value = "路径";
                    listData.Columns[4].HeaderCell.Value = "创建时间";
                    listData.Columns[6].HeaderCell.Value = "大小";
                }
                TotalSize = 107832;
                TotalCount = 1031;
            } 
        }

        private void listMusics_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            if (rm == null) rm = ResourceManager.Instance;
            DataGridViewRow crow = listData.Rows[idx];
            Resource res = (Resource)crow.DataBoundItem;
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
                foreach (DataGridViewCell cell in listData.Rows[e.RowIndex].Cells)
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

        public override List<object> SelectedItems
        {
            get
            {
                List<object> s = new List<object>();
                foreach (int i in _selected_items)
                {
                    DataGridViewRow crow = listData.Rows[i];
                    Resource r = (Resource)crow.DataBoundItem;
                    s.Add(r);
                }
                return s;
            }
        }

    }
}
