using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
namespace com.jajago.SA.Ctls
{
    public class CtlLists : UserControl
    {
        public event EventHandler SelectChanged;
        public string TaxonomyID = "BASE CLASS";
        public bool IsLoaded = false;
        public long TotalSize { get; set; }
        public int TotalCount { get; set; }
        public long SelectedSize { get; set; }
        public int SelectedCount { get; set; }
        public virtual object DataSource { get; set; }
        public CtlLists()
        {
            TotalSize = SelectedSize = 0;
            TotalCount = SelectedCount = 0;
        }

        protected void OnSelectChanged(object sender, EventArgs e)
        {
            if (SelectChanged != null) SelectChanged(sender, e);
        }
    }
}
