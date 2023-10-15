using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GaleevTS.Sprint2.Task3.V28.Lib;

namespace Tyuiu.GaleevTS.Sprint2.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 1.881;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = -5;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -10;
            double res = ds.Calculate(x);
            double wait = 0.004;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -35;
            double res = ds.Calculate(x);
            double wait = -384.8;
            Assert.AreEqual(wait, res);
        }
    }
}
