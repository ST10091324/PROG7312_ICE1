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
            displayMenu();
        }

        public static void displayMenu()
        {
            int userSelection = 0;
            Console.WriteLine("=============== WELCOME ===============");

            // Create a student repository for various objects
            var repoObj = new StudentRepository<object>();

            // Instantiates a new undergraduate object 
            Student<object> undergraduate1 = new Student<object>("ST10091324", "Eben", "Mwema", "BCAD701", "Contact", 76.00);
            repoObj.AddStudent(undergraduate1);

            // Instantiates a new postgraduate object 
            Student<object> postgraduate1 = new Student<object>("ST10209476", "Lesego", "Ramosa", "HCS1", "Contact", 90.00);
            repoObj.AddStudent(postgraduate1);

            // Instantiates a new part time object 
            Student<object> partTime1 = new Student<object>("ST10301249", "Lwazi", "Mesatywa", "HCS1", "Distance", 87.00);
            repoObj.AddStudent(partTime1);

            while (userSelection != 4)
            {
                Console.WriteLine();
                Console.WriteLine("Choose an option by entering a number");
                Console.WriteLine("Enter 1 to display a list of students");
                Console.WriteLine("Enter 2 to remove a student");
                Console.WriteLine("Enter 3 to display top achievers");
                Console.WriteLine("Enter 4 to exit program");
                Console.Write("User selection: ");
                userSelection = Int32.Parse(Console.ReadLine());


                if (userSelection == 1)
                {
                    //Displays all students
                    repoObj.ListStudents();
                }
                else if(userSelection == 2)
                {
                    Console.WriteLine();
                    Console.Write("Enter student id to remove:");
                    string userID = Console.ReadLine();

                    // Removes student with this id
                    repoObj.RemoveStudent(userID);
                }
                else if(userSelection == 3)
                {
                    Console.WriteLine();
                    Console.Write("Enter how many top achievers to display:");
                    int numOfTopAchievers = Int32.Parse(Console.ReadLine());

                    // Display top performing student
                    repoObj.DisplayTopPerformingStudentsUsingPointer(numOfTopAchievers);
                }
                else if(userSelection == 4) 
                {
                    Console.WriteLine("============================================================");
                    Console.WriteLine("exiting system....");
                    Environment.Exit(0);
                }
            }        
            
        }
    }

}
