using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public class FileReader
    {

        public void ReadFromFile()
        {
            var reader = new StreamReader(File.OpenRead(@"../../Test.csv"));
            List<string> listA = new List<string>();
            List<List<string>> listB = new List<List<string>>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                listA.Add(values[0]);
                listA.Add(values[1]);
                listA.Add(values[2]);
                listB.Add(listA);
            }
            foreach (var s in listA)
            {
                foreach (var j in listB)
                {
                    Console.WriteLine(j);

                }
                Console.WriteLine(s);
            }

        }
    }
}