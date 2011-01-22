using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace com.jajago.SA.Ctls
{
    public partial class CtlMusicList : CtlLists
    {
        public event EventHandler OnSelectChanged;
        private List<int> _selected_items = new List<int>();
        public CtlMusicList()
        {
            InitializeComponent();
        }
        public object DataSource 
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
            if (idx < 0) return;
            DataGridViewRow crow = listMusics.Rows[idx];
            if (_selected_items.IndexOf(idx) < 0)
            {
                _selected_items.Add(idx);
                foreach (DataGridViewCell cell in crow.Cells)
                {
                    cell.Style.BackColor = SystemColors.Highlight;
                    cell.Style.ForeColor = SystemColors.HighlightText;
                }
                //crow.HeaderCell.Style.BackColor = Color.Blue;
                crow.HeaderCell.Value = "√";
                SelectedSize++;
                SelectedCount += 10000;
            }
            else
            {
                _selected_items.Remove(idx);
                foreach (DataGridViewCell cell in listMusics.Rows[e.RowIndex].Cells)
                {
                    cell.Style.BackColor = SystemColors.Control;
                    cell.Style.ForeColor = SystemColors.WindowText;
                }
                //crow.HeaderCell.Style.BackColor = SystemColors.Control;
                crow.HeaderCell.Value = "";
                SelectedSize--;
                SelectedCount -= 10000;
            }
            if (OnSelectChanged != null) OnSelectChanged(this, null);
        }
    }
}
