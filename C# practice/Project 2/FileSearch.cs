using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public class FileSearch
    {
        public void Search()
        {
            string csvFile = "../../Test.csv";
            string searchString = "jake";
            char space = ',';

            foreach (string line in File.ReadLines(csvFile))
                foreach (string value in line.Replace("\"", "").Split('\r', '\n', space))
                    if (value.Trim() == searchString.Trim())

            Console.WriteLine("[ {0} ] found in: {1}", value, line);


        }
    }
}
