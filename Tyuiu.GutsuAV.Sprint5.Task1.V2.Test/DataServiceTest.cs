using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GutsuAV.Sprint5.Task1.V2.Lib;

namespace Tyuiu.GutsuAV.Sprint5.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\mr.robot\source\repos\Tyuiu.GutsuAV.Sprint5\Tyuiu.GutsuAV.Sprint5.Task1.V2\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
