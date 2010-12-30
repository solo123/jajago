using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.Objects;
using com.jajago.SA.Biz;

namespace com.jajago.SA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jajagoEntities ent = new jajagoEntities();
            ObjectQuery<Resource> oo = ent.Resources.OrderBy("rowid");

            dataGridView1.DataSource = oo;
            
        }
    }
}
