using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;
using com.jajago.Biz;
using System.Net;
using System.IO;

namespace com.jajago.SA
{
    public partial class FrmMobiles : Form
    {
        Queue queLoadImage = new Queue(500);
        Queue queDownload = new Queue(500);
        WebClient web = new WebClient();
        MobileManager mm = MobileManager.Instance;
        string photo_path = "mobiles/photos";

        public FrmMobiles()
        {
            InitializeComponent();
        }
        private void FrmMobiles_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile("mobiles/Download.png");
            imageList1.Images.Add(img);
            show_mobiles();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            show_mobiles();
        }

        private void show_mobiles()
        {
            Image no_img = Image.FromFile("mobiles/Download.png");
            foreach (Mobile m in mm.GetList())
            {
                Ctls.CtlMobileItem item = new Ctls.CtlMobileItem();
                item.title = m.title;
                fpanel.Controls.Add(item);
                MobileNode mn = new MobileNode(m, item);
                if (m.status == 0)
                {
                    item.image = no_img;
                    queDownload.Enqueue(mn);
                }
                else
                {
                    queLoadImage.Enqueue(mn);
                }
            }
            bwShowImage.RunWorkerAsync();
            bwDownload.RunWorkerAsync();
        }




        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            //int id = Convert.ToInt32(row.Cells[0].Value);
            FrmMobile f = new FrmMobile();
            f.MdiParent = this.MdiParent;
            f.Show();
            //f.ShowMobile(id);
        }

        int thumb_count = 0;
        int thumb_loaded = 0;
        private void bwDownload_DoWork(object sender, DoWorkEventArgs e)
        {
            int total = queDownload.Count;
            int cnt = 0;

            if (!Directory.Exists(photo_path)) Directory.CreateDirectory(photo_path);

            while (queDownload.Count > 0)
            {
                MobileNode mn = (MobileNode)queDownload.Dequeue();
                Mobile m = mn.mobile;
                web.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                web.DownloadFile("http://jajago.com/" + m.img_url, photo_path + "/" + m.id + ".jpg");
                m.status = 1;
                mm.SaveChanges();
                bwDownload.ReportProgress((++cnt)*100/total, mn);
            }
        }
        private void bwDownload_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            MobileNode mn = (MobileNode)e.UserState;
            progressBar1.Value = e.ProgressPercentage;
            lbDownloading.Text = mn.mobile.title;
        }

       

        private void bwShowImage_DoWork(object sender, DoWorkEventArgs e)
        {
            int total = queLoadImage.Count;
            int cnt = 0;
            while (queLoadImage.Count > 0)
            {
                BackgroundWorker bw = (BackgroundWorker)sender;
                if (bw.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                MobileNode mn = (MobileNode)queLoadImage.Dequeue();
                bwShowImage.ReportProgress((++cnt) * 100 / total, mn);
                System.Threading.Thread.Sleep(1000);
            }
        }
        private void bwShowImage_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            MobileNode mn = (MobileNode)e.UserState;
            progressBar1.Value = e.ProgressPercentage;
            mn.ctl.image = Image.FromFile("mobiles/photos/" + mn.mobile.id.ToString() + ".jpg");
        }
        private void bwShowImage_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show("Canceled");
            else
                MessageBox.Show("Done");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (bwShowImage.IsBusy)
            {
                bwShowImage.CancelAsync();
            }
        }




    }
    public class MobileNode
    {
        public Mobile mobile { get; set; }
        public Ctls.CtlMobileItem ctl { get; set; }
        public MobileNode(Mobile m, Ctls.CtlMobileItem item)
        {
            mobile = m;
            ctl = item;
        }
    }
}
