using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileWritter fw = new FileWritter();
            fw.WriteToFile();
            FileReader fr = new FileReader();
            fr.ReadFromFile();
            FileSearch fs = new FileSearch();
            fs.Search();
            Console.ReadLine();

        }
    }
}
