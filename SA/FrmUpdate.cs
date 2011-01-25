using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.IO;
namespace com.jajago.SA
{
    public partial class FrmUpdate : Form
    {
        WebClient web = new WebClient();
        public FrmUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string version, pack_path;
            version = pack_path = null;
            using (Stream stream = web.OpenRead("http://jajago.com/jajago_client_update.txt"))
            {
                StreamReader sr = new StreamReader(stream);
                string s = sr.ReadToEnd();
                if (s != null)
                {
                    string[] ss = s.Split(':');
                    if (ss != null && ss.Length > 1)
                    {
                        version = ss[0];
                        pack_path = ss[1];
                    }
                }
            }
            string cur_version = ConfigAppSettings.GetValue("ClientVersion");
            if (version != null && (cur_version == null || cur_version == "" || long.Parse(cur_version) < long.Parse(version)))
            {
                MessageBox.Show("Found update at:" + pack_path);

                if (!Directory.Exists("update")) Directory.CreateDirectory("update");
                if (!Directory.Exists("update/"+version)) Directory.CreateDirectory("update/"+version);
                web.DownloadFile("http://jajago.com/download/V20110124/02.pak", "update/" + version + "/update.pak");
                MessageBox.Show("更新包下载完成。");
            }
            else
                MessageBox.Show("没有找到更新!");


            
        }
    }
}
