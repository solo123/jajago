using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
namespace com.jajago.SA.Ctls
{
    public class CtlLists : UserControl
    {
        public int TotalSize { get; set; }
        public int TotalCount { get; set; }
        public int SelectedSize { get; set; }
        public int SelectedCount { get; set; }
        public CtlLists()
        {
            TotalCount = TotalSize = SelectedCount = SelectedSize = 0;
        }
    }
}
