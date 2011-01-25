using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
namespace com.jajago.SA.Ctls
{
    public partial class CtlProgressBar : UserControl
    {
        public CtlProgressBar()
        {
            InitializeComponent();
        }
        public void Draw(int percent)
        {
            _draw(percent, this.Width, this.Height);
        }
        private void _draw(int percent, int width, int height)
        {
            int bar_height = height;
            int bar_width = width - 50;
            int padding = 2;

            //产生一个image对象，并由此产生一个Graphics对象 
            Bitmap bm = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bm);
            //设置对象g的属性 
            //g.ScaleTransform((Convert.ToSingle(width)) / SIDE_LENGTH, (Convert.ToSingle(height)) / SIDE_LENGTH);
            g.SmoothingMode = SmoothingMode.Default;
            g.TextRenderingHint = TextRenderingHint.AntiAlias;

            //画布和边的设定 
            float w = (bar_width * percent / 100) - padding - padding;
            if (percent > 100) w = bar_width - padding - padding;
            SolidBrush brush_progress = new SolidBrush(Color.FromArgb(45,99,49));
            SolidBrush brush_bar = new SolidBrush(Color.FromArgb(220, 220, 220));
            SolidBrush brush_over = new SolidBrush(Color.FromArgb(185, 48, 30));
            g.FillRectangle(brush_bar, 0, height-bar_height, bar_width, bar_height);
            g.FillRectangle(brush_progress, padding, height - bar_height + padding, w, bar_height - padding-padding);
            if (percent > 100)
            {
                g.FillRectangle(brush_over, bar_width + padding, height - bar_height + padding, width - bar_width - padding - padding, bar_height - padding - padding);
                g.DrawString("超出!", new Font("Tahoma", 9, FontStyle.Bold), Brushes.LightYellow, new PointF(bar_width + 10, height / 2 - 8));
            }
            else
            {
                string prom = (100 - percent).ToString() + "%";
                if (percent > 98) prom = "已满";
                if (percent == 0) prom = "";
                if (percent > 0 && percent < 80) prom = "尚有" + prom + "空间";
                g.DrawString(prom, new Font("Tahoma", 9, FontStyle.Regular), Brushes.Black, new PointF(w + 10, height / 2 - 8));
            }
            //回收资源 
            g.Dispose();
            pictureBox1.Image = bm;
        }

    }
}
