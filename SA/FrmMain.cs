using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace com.jajago.SA
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            Thread th = new Thread(new ThreadStart(DoSplash));
            th.Start();
            Thread.Sleep(3000);
            th.Abort();
            Thread.Sleep(1000);
        }

        private void DoSplash()
        {
            splash sp = new splash();
            sp.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("欢迎使用家家购");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.jajago.com");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items != null && comboBox1.Items.Count > 0 && comboBox1.SelectedItem != null)
            {
                comBobox2.Items.Clear();
                comBobox2.Text = "";
                if (comboBox1.SelectedItem == "诺基亚")
                {
                    comBobox2.Items.Add("N97");
                    comBobox2.Items.Add("A9");
                }
                if (comboBox1.SelectedItem == "索爱")
                {
                    comBobox2.Items.Add("k660i");
                    comBobox2.Items.Add("k750");
                }
            }
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {
            
        }

        private void comBobox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBobox2.Items != null && comBobox2.Items.Count > 0 && comBobox2.SelectedItem != null)
                if (comBobox2.SelectedItem == "k660i")
                    MessageBox.Show("k660i");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1,"家家购");
        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "大陆")
            {
                //StreamWriter sw = new StreamWriter(@"E:\temp.txt");
                //sw.WriteLine("123");
                //sw.WriteLine("酷购科技");
                //sw.Close();
                StreamReader sr = new StreamReader(@"E:\temp.txt",Encoding.UTF8);
                label5.Text=sr.ReadToEnd();
                //MessageBox.Show("这是大陆歌曲");
            }
            if (e.Node.Text == "欧美")
            {
                label5.Text = "欧美视频";
            }
        }
    }
}
