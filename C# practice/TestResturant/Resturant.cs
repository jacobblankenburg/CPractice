using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestResturant
{
    public class Resturant
    {
        string UserEntersName;
        int UserPicksPeople;
        int UserPicksDate;
        int UserPicksTime;

        public void UserChecksResturantStats()
        {
            MakeStaff makestaff = new MakeStaff();
            UserControls usercontrols = new UserControls();

            Console.WriteLine(" Choose 1 to check inventory of ingredients \n Choose 2 to hire an employee\n Choose 3 to check if resturant is clean \n Choose 4 to take reservations\n Choose 5 to \n Choose 6 to End \n Choose 7 to go to Menu\n");
            bool Running = true;

            while (Running)
            {

                switch (Console.ReadKey().KeyChar.ToString())
                {

                    case "1":
                        Console.WriteLine(" Inventory:");
                        Inventory();
                        continue;

                    case "2":
                        Console.WriteLine(" Hire:");
                        makestaff.MakeResturantStaff();
                        continue;

                    case "3":
                        Console.WriteLine(" Resturant:");
                        Isclean();
                        continue;

                    case "4":
                        Console.WriteLine(" :");
                        TakeReservations();
                        continue;

                    case "5":
                        Console.WriteLine(" :");

                        continue;

                    case "6":
                        Running = false;
                        break;

                    case "7":
                        Console.WriteLine(" Menu:   \n");
                        usercontrols.GetUserControl();
                        return;

                    default:
                        Console.WriteLine(" Not Valid User Input");
                        continue;
                }

                break;
            }
        }

        public void Inventory()
        {
            int beer = 50;
            int wine = 50;
            int cheese = 46;
            int tacos = 90;
            int steak = 35;
            int hamburgers = 50;

            Console.WriteLine("Beer = " + beer + " bottles. Wine =  " + wine + " glasses. Cheese =  " + cheese + " cubes. Tacos = " + tacos + " left. Steaks = " + steak + " Left. Hamburgers = " + hamburgers + " left");
        }
        public bool Isclean()
        {

            return true;
        }
        public void TakeReservations()
        {
            Console.WriteLine("Enter your Name :");
            this.UserEntersName = Console.ReadLine();
            Console.WriteLine("How many people? ");
            this.UserPicksPeople = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("On What Day? ");
            this.UserPicksDate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Time? ");
            this.UserPicksTime = Convert.ToInt32(Console.ReadLine());
        }
        public override string ToString()
        {
            return (UserEntersName + " has a reservation for " + UserPicksPeople + " people on " + UserPicksDate + " at " + UserPicksTime);
        }
    }
}
