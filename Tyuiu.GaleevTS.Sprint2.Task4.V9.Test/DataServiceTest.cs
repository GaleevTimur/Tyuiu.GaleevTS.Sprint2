using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GaleevTS.Sprint2.Task4.V9.Lib;
namespace Tyuiu.GaleevTS.Sprint2.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {

        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 2762.816;

            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidExpression2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 8;
            double res = ds.Calculate(x, y);
            double wait = 0.625;

            Assert.AreEqual(wait, res);
        }
    }

}
