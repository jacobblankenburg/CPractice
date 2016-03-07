using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomString customstring = new CustomString();

            customstring.ToUpper();
            customstring.ToLowerCase();
            Console.WriteLine(customstring.Contains("JAKE")); 
            Console.WriteLine(customstring.Count);
            customstring.Split("tony");
            Console.ReadLine();

            
        }
    }
}
