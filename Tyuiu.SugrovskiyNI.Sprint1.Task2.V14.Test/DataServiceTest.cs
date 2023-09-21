using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint1.Task2.V10.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint1.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 1; // Пример температуры в Кельвинах
            double b = 39.37;
            var res = ds.Calculate(a, b);
            Assert.AreEqual(39.37, res);
        }
    }
}
