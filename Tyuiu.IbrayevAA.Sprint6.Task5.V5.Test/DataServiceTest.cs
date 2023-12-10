using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IbrayevAA.Sprint6.Task5.V5.Lib;
using System.IO;

namespace Tyuiu.IbrayevAA.Sprint6.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\Quyzt\Source\Repos\Tyuiu.IbrayevAA.Sprint6\Tyuiu.IbrayevAA.Sprint6.Task5.V5\bin\Sprint6Task4\InPutFileTask5V5.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
