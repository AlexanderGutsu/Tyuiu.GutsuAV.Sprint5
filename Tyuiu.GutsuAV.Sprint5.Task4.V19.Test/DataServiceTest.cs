using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GutsuAV.Sprint5.Task4.V19.Lib;
using System.IO;
namespace Tyuiu.GutsuAV.Sprint5.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V19.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService dt = new DataService();

            string path = $@"C:\DataSprint5\InPutDataFileTask4V19.txt";

            double y = dt.LoadFromDataFile(path);

            Assert.AreEqual(y, 8.983);
        }
    }
}
