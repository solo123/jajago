using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace com.jajago.Biz
{
    public class AppManager
    {
        public event EventHandler ShowStatusText;
        private static AppManager theInstance = null;
        private AppManager()
        {
        }

        public static AppManager Instance
        {
            get 
            {
                if (theInstance == null) theInstance = new AppManager();
                return theInstance;
            }
        }

        public string StatusText
        {
            set
            {
                if (ShowStatusText != null) ShowStatusText(value, null);
            }
        }

    }
}
