using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;


namespace com.jajago.SA.Biz
{
   
    public class ResourceManager : JajagoBiz
    {
        public ObjectSet<Taxonomy> Catalog()
        {
            jajagoEntities ent = new jajagoEntities();
            return ent.Taxonomies;
        }
        public int Scan(string path)
        {
            return 0;
        }

        public static void ListFiles(FileSystemInfo info, string Ext, TextBox obj)
        {
            if (!info.Exists) return;

            DirectoryInfo dir = info as DirectoryInfo;
            //不是目录 
            if (dir == null) return;
            try
            {

                FileSystemInfo[] files = dir.GetFileSystemInfos();
                for (int i = 0; i < files.Length; i++)
                {
                    FileInfo file = files[i] as FileInfo;
                    //是文件
                    if (file != null && file.Extension.ToUpper() == "." + Ext.ToUpper())
                    {
                        obj.Text = obj.Text + file.FullName + "\r\n";
                        obj.Refresh();
                    }
                    //对于子目录，进行递归调用 
                    else
                        ListFiles(files[i], Ext, obj);

                }
            }
            catch (UnauthorizedAccessException ex)
            {
                obj.Text = obj.Text + ex.Message;
            }

        }

    }
}
