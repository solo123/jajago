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
        static string mobile_path = "mobiles/";
        string photo_path = "mobiles/photos";
        Image no_img = Image.FromFile(mobile_path + "downloading.png");
        Image loading_img = Image.FromFile(mobile_path + "loading.png");

        public FrmMobiles()
        {
            InitializeComponent();
        }

        private void FrmMobiles_Load(object sender, EventArgs e)
        {
            show_mobiles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show_mobiles();
        }

        private void show_mobiles()
        {
            fpanel.SuspendLayout();
            fpanel.Controls.Clear();
            foreach (Mobile m in mm.GetList(txtFilter.Text))
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
                    string imagefile = mobile_path + "photos/thumb/" + mn.mobile.id + ".jpg";
                    if (File.Exists(imagefile))
                        item.image = Image.FromFile(imagefile);
                    else
                    {
                        item.image = loading_img;
                        queDownload.Enqueue(mn);
                    }
                    queLoadImage.Enqueue(mn);
                }
            }
            fpanel.ResumeLayout();
            plProgress.Show();
            progressBar.Value = 0;
            lbProgressMessage.Text = "读取图片：";
            Application.DoEvents();
            if (!bwDownload.IsBusy) bwDownload.RunWorkerAsync();
        }

        private void item_clicked(object sender, EventArgs e)
        {
            Mobile m = (Mobile)sender;
            FrmMobile f = new FrmMobile();
            f.MdiParent = this.MdiParent;
            f.Show();
            f.mobile = m;
        }

        #region background download
        private void bwDownload_DoWork(object sender, DoWorkEventArgs e)
        {
            AppManager app = AppManager.Instance;
            int total = queDownload.Count;
            if (total < 1) return;

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
            progressBar.Value = e.ProgressPercentage;
            string imagefile = mobile_path + "photos/thumb/" + mn.mobile.id.ToString() + ".jpg";
            if (File.Exists(imagefile))
                mn.ctl.image = Image.FromFile(imagefile);
        }

        private void bwDownload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            AppManager app = AppManager.Instance;
            if (e.Cancelled)
                app.StatusText = "下载图片被取消。";
            else
            {
                app.StatusText = "下载图片完成。";
                plProgress.Hide();
            }
        }
        #endregion

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (bwDownload.IsBusy)
            {
                bwDownload.CancelAsync();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            show_mobiles();
        }

        private void tvSelect_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            fpanel.SuspendLayout();
            fpanel.Controls.Clear();
            string s = e.Node.Text;
            if (e.Node.Parent != null && e.Node.Parent.Text.Equals("手机价格分类"))
            {
                int p1 = Convert.ToInt16(s.Substring(0, 4));
                int p2;
                if (p1 == 2000)
                    p2 = 10000;
                else if (p1 == 200)
                {
                    p1 = 0;
                    p2 = 200;
                }
                else
                    p2 = Convert.ToInt16(s.Substring(6, 4));
                foreach (Mobile m in mm.GetPriceList(p1, p2))
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
                        string imagefile = mobile_path + "photos/thumb/" + mn.mobile.id + ".jpg";
                        if (File.Exists(imagefile))
                            item.image = Image.FromFile(imagefile);
                        else
                        {
                            item.image = loading_img;
                            queDownload.Enqueue(mn);
                        }
                        queLoadImage.Enqueue(mn);
                    }
                }
            }
            else if (e.Node.Parent != null && e.Node.Parent.Text.Equals("手机品牌分类"))
            {
                foreach (Mobile m in mm.GetList(e.Node.Text))
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
                        string imagefile = mobile_path + "photos/thumb/" + mn.mobile.id + ".jpg";
                        if (File.Exists(imagefile))
                            item.image = Image.FromFile(imagefile);
                        else
                        {
                            item.image = loading_img;
                            queDownload.Enqueue(mn);
                        }
                        queLoadImage.Enqueue(mn);
                    }
                }
            }
            else
                show_mobiles();
            fpanel.ResumeLayout();
            plProgress.Show();
            progressBar.Value = 0;
            lbProgressMessage.Text = "读取图片：";
            Application.DoEvents();
            if (!bwDownload.IsBusy) bwDownload.RunWorkerAsync();
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
