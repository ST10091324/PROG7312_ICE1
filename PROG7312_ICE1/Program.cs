using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_ICE1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiates a new undergraduate object 
            Student<object> undergraduate1 = new Student<object>("ST10091324", "Eben", "Mwema", "BCAD701", "Contact", 76.00);
            undergraduate1.DisplayInfo();

            // Instantiates a new postgraduate object 
            Student<object> postgraduate1 = new Student<object>("ST10209476", "Lesego", "Ramosa", "HCS1", "Contact", 90.00);
            postgraduate1.DisplayInfo();

            // Instantiates a new part time object 
            Student<object> partTime1 = new Student<object>("ST10301249", "Lwazi", "Mesatywa", "HCS1", "Distance", 87.00);
            partTime1.DisplayInfo();

            Console.WriteLine("============================================================");
            Console.WriteLine("Press enter to exit....");
            Console.ReadKey();
        }
    }
}
