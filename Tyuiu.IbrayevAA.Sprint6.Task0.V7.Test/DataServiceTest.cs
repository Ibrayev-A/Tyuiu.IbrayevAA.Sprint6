using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IbrayevAA.Sprint6.Task0.V7.Lib;

namespace Tyuiu.IbrayevAA.Sprint6.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 0.211;
            Assert.AreEqual(wait, res);
        }
    }
}
