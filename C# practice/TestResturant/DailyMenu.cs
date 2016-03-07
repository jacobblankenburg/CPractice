using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestResturant
{
    public class DailyMenu
    {

        public void ViewMenus()
        {
            UserControls user = new UserControls();

            Console.WriteLine(" Choose 1 to view Daily Menu\n Choose 2 to view Happy Hour Menu\n Choose 3 to End\n Choose 4 to go to Menu\n");
            bool Running = true;

            while (Running)
            {

                switch (Console.ReadKey().KeyChar.ToString())
                {

                    case "1":
                        DisplayMenu();
                        continue;

                    case "2":
                        DisplayHappyHourMenu();
                        continue;

                    case "3":
                        Running = false;
                        break;

                    case "4":
                        Console.WriteLine(" Menu:   \n");
                        user.GetUserControl();
                        return;

                    default:
                        Console.WriteLine(" Not valid user input");
                        continue;
                }

            }

        }

        public void DisplayMenu()
        {
            Console.WriteLine("\t\t\t\tMenu: ");
            Console.WriteLine("Breakfast: \n $9.50 Eggs, Bacon, HashBrowns, Coffee");
            Console.WriteLine("Lunch: \n $10.25 Hamburger, Fries, Soda");
            Console.WriteLine("Dinner: \n $36.95 Filet Migon, Baked Potatoe, Wine");
        }
        public void DisplayHappyHourMenu()
        {
            Console.WriteLine("\t\t\t\tHappy Hour Menu: ");
            Console.WriteLine("Happy Hour is from 4-7 P.M daily");
            Console.WriteLine("Happy Hour:\n Drinks- 50% off Appatizers- all Appatizers $5.00 Tacos- Buy two for $7.00 get one free");
        }


    }
}
