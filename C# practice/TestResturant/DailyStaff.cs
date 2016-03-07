using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestResturant
{
    public class DailyStaff
    {
        UserControls usercontrols = new UserControls();
        FileWritter filewriter = new FileWritter();
        FileReader filereader = new FileReader();
        List<string> Staff = new List<string>();

        public void UserPicksEmployees()
        {
            Console.WriteLine(" Choose 1 to add Employees to Staff \n Choose 2 to remove Employees to Staff\n Choose 3 to display your Staff\n Choose 4 to save Staff\n Choose 5 to display Crew\n Choose 6 to end program\n Choose 7 to go to Menu\n");
            bool Running = true;

            while (Running)
            {

                switch (Console.ReadKey().KeyChar.ToString())
                {

                    case "1":
                        Console.WriteLine(" Add Employees for the day:");
                        AddEmployees();
                        continue;

                    case "2":
                        Console.WriteLine(" Remove Employess from Daily Staff:");
                        RemoveEmployees();
                        continue;

                    case "3":
                        Console.WriteLine(" Staff:");
                        foreach (string s in Staff)
                        {
                            Console.WriteLine(s);
                        }
                        continue;

                    case "4":
                        Console.WriteLine(" Save Staff:");
                        SaveStaff();
                        continue;

                    case "5":
                        Console.WriteLine(" All Staff:");
                        filereader.ReadFromFile("../../Staff.txt");
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




        public void AddEmployees()
        {
            string input = Console.ReadLine();
            Staff.Add(input);
        }
        public void RemoveEmployees()
        {
            string input = Console.ReadLine();
            Staff.Remove(input);
        }
        public void DisplayStaff()
        {
            Console.WriteLine(Staff);
        }
        public void SaveStaff()
        {
            filewriter.WriteToFile("../../DailyStaff.txt", Staff);
        }
        public override string ToString()
        {
            return (Staff + " ");
        }
    }
}
