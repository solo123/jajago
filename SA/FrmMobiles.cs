using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using com.jajago.Biz;

namespace com.jajago.SA
{
    public partial class FrmMobiles : Form
    {
        public FrmMobiles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MobileManager mm = MobileManager.Instance;
            dataGridView1.DataSource = mm.GetList();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Value);
            FrmMobile f = new FrmMobile();
            f.MdiParent = this.MdiParent;
            f.Show();
            f.ShowMobile(id);
        }
    }
}
