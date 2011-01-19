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
        Image no_img = Image.FromFile("mobiles/downloading.png");
        Image loading_img = Image.FromFile("mobiles/loading.png");

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

            foreach (Mobile m in mm.GetList())
            {
                Ctls.CtlMobileItem item = new Ctls.CtlMobileItem();
                item.mobile = m;
                item.OnClicked += new EventHandler(item_clicked);
                fpanel.Controls.Add(item);
                MobileNode mn = new MobileNode(m, item);
                if (m.status == 0)
                {
                    item.image = no_img;
                    queDownload.Enqueue(mn);
                }
                else
                {
                    item.image = loading_img;
                    queLoadImage.Enqueue(mn);
                }
            }
            bwShowImage.RunWorkerAsync();
            //bwDownload.RunWorkerAsync();
        }

        private void item_clicked(object sender, EventArgs e)
        {
            Mobile m = (Mobile)sender;
            FrmMobile f = new FrmMobile();
            f.MdiParent = this.MdiParent;
            f.Show();
            f.ShowMobile((int)m.id);
        }


        private void bwDownload_DoWork(object sender, DoWorkEventArgs e)
        {
            AppManager app = AppManager.Instance;
            int total = queDownload.Count;
            int cnt = 0;
            string img_org_path = photo_path + "/original";
            string img_thu_path = photo_path + "/thumb";

            if (!Directory.Exists(photo_path)) Directory.CreateDirectory(photo_path);
            if (!Directory.Exists(img_org_path)) Directory.CreateDirectory(img_org_path);
            if (!Directory.Exists(img_thu_path)) Directory.CreateDirectory(img_thu_path);

            while (queDownload.Count > 0)
            {
                MobileNode mn = (MobileNode)queDownload.Dequeue();
                Mobile m = mn.mobile;
                app.StatusText = "下载: " + m.img_url;

                string img_path = img_org_path + "/" + m.id + ".jpg";
                string thu_path = img_thu_path + "/" + m.id + ".jpg";
                web.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                web.DownloadFile("http://jajago.com/" + m.img_url, img_path);
                Image thumb = ImageManager.MakeThumbnail(img_path, 100);
                thumb.Save(thu_path);
                m.status = 1;
                mm.SaveChanges();
                bwDownload.ReportProgress((++cnt)*100/total, mn);
            }
        }
        private void bwDownload_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            MobileNode mn = (MobileNode)e.UserState;
            pbDownload.Value = e.ProgressPercentage;
            string imagefile = "mobiles/photos/thumb/" + mn.mobile.id.ToString() + ".jpg";
            if (File.Exists(imagefile))
                mn.ctl.image = Image.FromFile(imagefile);
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
                //System.Threading.Thread.Sleep(500);
            }
        }
        private void bwShowImage_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            MobileNode mn = (MobileNode)e.UserState;
            pbShow.Value = e.ProgressPercentage;
            string imagefile = "mobiles/photos/thumb/" + mn.mobile.id.ToString() + ".jpg";
            if (File.Exists(imagefile))
                mn.ctl.image = Image.FromFile(imagefile);
            else
            {
                mn.ctl.image = no_img;
                queDownload.Enqueue(mn);
            }
        }
        private void bwShowImage_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            AppManager app = AppManager.Instance;
            if (e.Cancelled)
                app.StatusText = "显示图片被取消。";
            else
            {
                bwDownload.RunWorkerAsync();
                app.StatusText = "图片已全部显示。";
            }
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
