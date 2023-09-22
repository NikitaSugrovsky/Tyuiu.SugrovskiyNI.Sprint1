using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint1.Task3.V15.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double v1 = 80;
            double v2 = 60;
            double S = 200;
            double T = 1;
            double wait = 340;
            var res = ds.DistanceOverTime(v1, v2, S, T); 
            Assert.AreEqual(wait, res);
            

        }
    }
}
