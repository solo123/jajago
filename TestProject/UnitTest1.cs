using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using com.jajago.SA.Biz;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ResourceManager rm = new ResourceManager();
            Assert.IsNotNull(rm.Catalog());

        }
    }
}
