﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint1.Task7.V8.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint1.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double wait = 0.75;
            var res = ds.Calculate(x, y);
            res = Math.Round(res, 3);
            Assert.AreEqual(wait, res);
        }
    }
}