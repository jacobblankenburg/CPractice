using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestResturant
{
    public class UserControls
    {


        public void GetUserControl()
        {
            MakeStaff MakeStaff = new MakeStaff();
            DailyMenu dailymenu = new DailyMenu();
            DailyStaff dailystaff = new DailyStaff();
            Resturant resturant = new Resturant();


            Console.WriteLine("   -----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("--- Make Staff, Daily Staff, Daily Menu, Restaurant, Training, End ---");
            Console.WriteLine("   -----------------------------------------------------------------------------------------------------------------");

            string UserSelect = Console.ReadLine();
            bool Running = true;

            while (Running)
            {

                switch (UserSelect.ToLower())
                {

                    case "make staff":
                        MakeStaff.MakeResturantStaff();
                        break;

                    case "daily staff":
                        Console.WriteLine("Menu:\n");
                        dailystaff.UserPicksEmployees();
                        break;

                    case "daily menu":
                        Console.WriteLine("Menu:\n");
                        dailymenu.ViewMenus();
                        break;

                    case "resturant":
                        Console.WriteLine("Resturant:\n");
                        resturant.UserChecksResturantStats();
                        break;

                    case "end":
                        Console.WriteLine("---------------------------------Thank you for using ResturantManager 1.0---------------------------------------------");
                        break;

                    default:
                        Console.WriteLine("Please enter a valid responce");
                        UserSelect = Console.ReadLine();
                       
                        break;

                }
                break;
            }
        }
    }
}

