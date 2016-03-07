using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestResturant
{
    public class MakeStaff
    {
        Waitstaff waitstaff = new Waitstaff(null, 0, null);
        BarStaff barstaff = new BarStaff(null, 0, null);
        KitchenStaff kitchenstaff = new KitchenStaff(null, 0, null);
        FileWritter filewriter = new FileWritter();
        UserControls usercontrols = new UserControls();

        public void MakeResturantStaff()
        {
            Console.WriteLine(" Choose 1 to add Employees to Wait Staff\n Choose 2 to add Employees to Bar Staff\n Choose 3 to add Employees to Kitchen Staff\n Choose 4 to end program\n Choose 5 to go to Menu\n");
            bool Running = true;

            while (Running)
            {

                switch (Console.ReadKey().KeyChar.ToString())
                {

                    case "1":
                        Console.WriteLine(" Add Wait Staff:");
                        MakewaitStaff();
                        break;

                    case "2":
                        Console.WriteLine(" Add Bar Staff:");
                        MakeBarStaff();
                        break;

                    case "3":
                        Console.WriteLine(" Add Kithen Staff:");
                        MakeKitchenStaff();
                        break;

                    case "4":
                        Running = false;
                        break;

                    case "5":
                        Console.WriteLine(" Menu:   \n");
                        usercontrols.GetUserControl();
                        return;

                    default:
                        Console.WriteLine(" Not valid user input");
                        continue;
                }
            }
        }




        public void MakewaitStaff()
        {

            List<string> WaitStaff = new List<string>();
            List<string> Staff = new List<string>();

            Console.WriteLine("Enter the Employees name");
            this.waitstaff.Name = Console.ReadLine();
            Console.WriteLine("Enter the Employees Pay");
            this.waitstaff.StartingPay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employees Position (Waiter, Host, Busser)");
            this.waitstaff.EmployeePosition = Console.ReadLine();

            WaitStaff.Add(waitstaff.ToString());
            Staff.Add(waitstaff.ToString());
            filewriter.WriteToFile("../../WaitStaff.txt", WaitStaff);
            Console.WriteLine(waitstaff);
            filewriter.WriteToFile("../../Staff.txt", Staff);
        }
        public void MakeBarStaff()
        {

            List<string> BarStaff = new List<string>();
            List<string> Staff = new List<string>();

            Console.WriteLine("Enter the Employees name");
            this.barstaff.Name = Console.ReadLine();
            Console.WriteLine("Enter the Employees Pay");
            this.barstaff.StartingPay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employees Position (Bartender)");
            this.barstaff.EmployeePosition = Console.ReadLine();

            BarStaff.Add(barstaff.ToString());
            Staff.Add(barstaff.ToString());
            filewriter.WriteToFile("../../BarStaff.txt", BarStaff);
            Console.WriteLine(barstaff);
            filewriter.WriteToFile("../../Staff.txt", Staff);
        }
        public void MakeKitchenStaff()
        {

            List<string> KitchenStaff = new List<string>();
            List<string> Staff = new List<string>();

            Console.WriteLine("Enter the Employees name");
            this.kitchenstaff.Name = Console.ReadLine();
            Console.WriteLine("Enter the Employees Pay");
            this.kitchenstaff.StartingPay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employees Position (Cook, DishWasher)");
            this.kitchenstaff.EmployeePosition = Console.ReadLine();

            KitchenStaff.Add(kitchenstaff.ToString());
            Staff.Add(kitchenstaff.ToString());
            filewriter.WriteToFile("../../KitchenStaff.txt", KitchenStaff);
            Console.WriteLine(kitchenstaff);
            filewriter.WriteToFile("../../Staff.txt", Staff);
        }
    }
}
