using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
namespace com.jajago.Biz
{
    public class ImageManager
    {
        /// <summary>
        /// 生成缩略图
        /// </summary>
        /// <param name="originalImagePath">源图路径（物理路径）</param>
        /// <param name="thumbnailPath">缩略图路径（物理路径）</param>
        /// <param name="width">缩略图宽度</param>
        /// <param name="height">缩略图高度</param>
        /// <param name="mode">生成缩略图的方式</param>    
        public static System.Drawing.Image MakeThumbnail(string originalImagePath, int size)
        {
            System.Drawing.Image originalImage = System.Drawing.Image.FromFile(originalImagePath);
            int oh, ow;
            oh = ow = size;
            if (originalImage.Width <= size && originalImage.Height <= size)
            {
                ow = originalImage.Width;
                oh = originalImage.Height;
            }
            else
            {
                if (originalImage.Width > originalImage.Height)
                    oh = size * originalImage.Height / originalImage.Width;
                else
                    ow = size * originalImage.Width / originalImage.Height;
            }
            if (ow == 0) ow = 1;
            if (oh == 0) oh = 1;
            System.Drawing.Image bitmap = new System.Drawing.Bitmap(size, size);
            Graphics g = Graphics.FromImage(bitmap);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.Clear(Color.White);
            int startX = (size - ow) / 2;
            int startY = (size - oh) / 2;

            g.DrawImage(originalImage, new Rectangle(startX, startY, ow, oh), new Rectangle(0, 0, originalImage.Width, originalImage.Height), GraphicsUnit.Pixel);
            return bitmap;
        }
        public static Image QuickThumbnail(string original_filename, int size)
        {
            Image ori = Image.FromFile(original_filename);
            Image thumb = ori.GetThumbnailImage(size, size, thumb_cb, IntPtr.Zero);
            return thumb;
        }
        public static bool thumb_cb()
        {
            return true;
        }
        public static byte[] BinaryThumbnail(string path, int size)
        {
            Image img = MakeThumbnail(path, size);
            //Image img = QuickThumbnail(path, size);
            if (img==null) return null;

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}
