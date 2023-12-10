using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GutsuAV.Sprint5.Task7.V4.Lib;
using System.IO;
namespace Tyuiu.GutsuAV.Sprint5.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\mr.robot\source\repos\Tyuiu.GutsuAV.Sprint5\Tyuiu.GutsuAV.Sprint5.Task7.V4\bin\Debug\OutPutDataFileTask7V4.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
