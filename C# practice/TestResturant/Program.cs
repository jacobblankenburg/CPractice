using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestResturant
{
    class Program
    {
        static void Main(string[] args)
        {
            UserControls usercontrols = new UserControls();
            usercontrols.GetUserControl();
            Console.ReadLine();
        }
    }
}
