using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GutsuAV.Sprint5.Task3.V15.Lib;
using System.IO;
namespace Tyuiu.GutsuAV.Sprint5.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\mr.robot\source\repos\Tyuiu.GutsuAV.Sprint5\Tyuiu.GutsuAV.Sprint5.Task3.V15\bin\Debug\OutPutFileTask3.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
