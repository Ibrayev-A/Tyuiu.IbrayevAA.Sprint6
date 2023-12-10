using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IbrayevAA.Sprint6.Task6.V21.Lib;
using System.IO;

namespace Tyuiu.IbrayevAA.Sprint6.Task6.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string resStr = "gsfggsgg gdsgdsgg";
            string line = "ff gsfggsgg gdsgdsgg ff";
            string[] words = line.Split(' ');
            string res = "";

            foreach (string word in words)
            {
                if (word.Contains("g"))
                {
                    res += word + " ";
                }
            }
            res = res.TrimEnd();
            Assert.AreEqual(resStr, res);
        }
    }
}
