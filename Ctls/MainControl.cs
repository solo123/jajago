using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.jajago.SA.Ctls
{
    public class MainControl
    {
        public string Name = null;
        public bool Loaded = false;
        public CtlLists Control = null;
        public int ListIndex = -1;
        public MainControl(int idx, string name, CtlLists control)
        {
            ListIndex = idx;
            Name = name;
            Control = control;
        }
    }
}
