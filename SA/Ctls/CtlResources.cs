using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace com.jajago.SA.Ctls
{
    public partial class CtlResources : UserControl
    {
        public CtlResources()
        {
            InitializeComponent();
        }

        [Category("AddressData"),
       Description("Gets or sets the AddressLine1 value"),
       DefaultValue(" ")]
        public string address { get; set; }
    }
}
