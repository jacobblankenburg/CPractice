using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class CustomString 
    {
        List<string> list = new List<string>();

        public void ToUpper()
        {
            ToUpper toupper = new ToUpper("jake");
            string output;
            output = toupper.CustomToUpper();
            toupper.display();
            list.Add(output);
            
        }

       public void ToLowerCase()
        {
            ToLower toLower = new ToLower("JAKE IS A NEAT GUY");
            string output;
            output = toLower.CustomToLower();
            toLower.display();
            list.Add(output);
        }

        public bool Contains(string stringcontains)
        {
            bool isFound = false;
            for (int i = 0; i < list.Capacity; i++)
            {
                if (list.Contains(stringcontains))
                {
                    isFound = true;
                }
            }
            return isFound;
        }

        public void Split(string value)
        {
            string output;
            output = "";
            char[] array = value.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                output += (array[i] + " . "); 
            }
            Console.WriteLine(output);
        }

        public int Count
        {
            get
            {
                return list.Capacity;
            }
        }

        public void Replace()
        {
           
        }
    }
}
