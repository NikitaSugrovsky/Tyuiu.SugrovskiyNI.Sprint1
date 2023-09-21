using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint1.Task1.V9.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint1.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2, res);
        }
    }
}
