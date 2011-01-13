using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

using com.jajago.Biz;

namespace TestProject
{
    [TestClass]
    public class TestMobiles
    {
        [TestMethod]
        public void TestOneMobile()
        {
            MobileManager mm = MobileManager.Instance;
            Mobile mobile = mm.GetMobile(1);
            Assert.IsNotNull(mobile);
        }
    }
}
