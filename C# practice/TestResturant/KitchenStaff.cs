using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestResturant
{
    public class KitchenStaff
    {
        public string Name { get; set; }
        public int StartingPay { get; set; }
        public string EmployeePosition { get; set; }
        public bool SectionClean { get; set; }


        public KitchenStaff(string name, int startingpay, string position)
        {
            this.Name = name;
            this.StartingPay = startingpay;
            this.EmployeePosition = position;
            this.SectionClean = false;
        }
        public override string ToString()
        {
            return (Name + " has a Pay of " + StartingPay + " and is a " + EmployeePosition+ " seciontion is currently clean? : " + SectionClean);
        }
        public void UpdateSectionToClean()
        {
            this.SectionClean = true;

        }
    }
}
