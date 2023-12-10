using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GutsuAV.Sprint5.Task6.V24.Lib;
using System.IO;
namespace Tyuiu.GutsuAV.Sprint5.Task6.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Гуцу А. В. | ИИПб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла.                                     *");
            Console.WriteLine("* Задание #6                                                                   *");
            Console.WriteLine("* Вариант #24                                                                  *");
            Console.WriteLine("* Выполнил  Гуцу А.В.   | ИИПб-23-1                                            *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан файл в котором есть набор символьных данных.                             *");
            Console.WriteLine("* Найти количество пятизначных чисел в заданной строке.                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            string path = $@"C:\DataSprint5\InPutDataFileTask6V24.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
 