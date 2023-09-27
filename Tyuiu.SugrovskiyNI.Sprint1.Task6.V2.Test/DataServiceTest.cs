using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint1.Task6.V2.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Hello";
            DataService ds = new DataService();
            bool v = ds.CheckHello(strTest);
            string wait = "Hello";
            string res = v;
            Assert.AreEqual(wait, res);
        }
    }
}
