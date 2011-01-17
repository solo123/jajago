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
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            ResourceManager rsm = ResourceManager.Instance;
            dataGridView1.DataSource = rsm.GetList("IMG");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = dataGridView1.SelectedRows.Count;
            MessageBox.Show(c.ToString());
        }
    }
}
