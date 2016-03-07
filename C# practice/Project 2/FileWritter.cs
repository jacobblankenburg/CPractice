using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public class FileWritter
    {
        public void WriteToFile()
        {
            //string UserInput;
            //UserInput = Console.ReadLine();
            string filePath = @"../../Test.csv";
            string space = ",";

            string[][] output = new string[][]
            {
                   new string[]{"jake", "is", "cool"},
                   new string[] {"dev", "code", "camp"} 
              };
            int length = output.GetLength(0);
            StringBuilder sb = new StringBuilder();
            for (int index = 0; index < length; index++)
                sb.AppendLine(string.Join(space, output[index]));

            File.WriteAllText(filePath, sb.ToString());
        }
    }
}