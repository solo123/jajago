using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.jajago.Biz
{
    public class ConfigManager
    {
        
        public static string[] ResourceSearchPaths
        {
            set
            {
                ResourceManager rm = ResourceManager.Instance;
                rm.ConfigSearchPath = string.Join(";", value);
            }
            get
            {
                ResourceManager rm = ResourceManager.Instance;
                string path = rm.ConfigSearchPath;
                if (path == null) return null;
                else return path.Split(';');
            }
        }
        public static bool Exist(string path)
        {
            if (path==null) return false;
            string[] ps = ResourceSearchPaths;
            if (ps==null) return false;

            foreach (string p in ResourceSearchPaths)
            {
                if (path == p) return true;
                if (p.Length >= path.Length)
                {
                    if (p.IndexOf(path) >= 0 && p[path.Length] == '\\') 
                        return true;
                }
                else
                {
                    if (path.IndexOf(p) >= 0 && path[p.Length] == '\\')
                        return true;
                }
            }
            return false;
        }
    }
}
