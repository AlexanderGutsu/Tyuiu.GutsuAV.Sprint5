﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GutsuAV.Sprint5.Task5.V21.Lib;
using System.IO;
namespace Tyuiu.GutsuAV.Sprint5.Task5.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Гуцу А. В. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #5                                                                *");
            Console.WriteLine("*Задание #5                                                               *");
            Console.WriteLine("*Вариант #21                                                              *");
            Console.WriteLine("*Выполнил: Гуцу Александр Владимирович | ИИПб 23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask5V21.txt";
            Console.WriteLine("File path: " + path);
            Console.WriteLine("data is: ");
            Console.WriteLine(String.Join(" ", File.ReadAllLines(path)));
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Factorial of the greates int number is:");
            Console.WriteLine(service1.LoadFromDataFile(path));
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
