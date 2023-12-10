using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.GutsuAV.Sprint5.Task6.V24.Lib
{
    public class DataService : ISprint5Task6V24
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Regex regex = new Regex(@"\b\d{5}\b");
                    MatchCollection matches = regex.Matches(line);
                    count += matches.Count;
                }
            }
            return count;
        }
    }
}
