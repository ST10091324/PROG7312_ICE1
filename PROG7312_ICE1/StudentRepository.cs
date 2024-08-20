using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_ICE1
{
    internal class StudentRepository<Thing>
    {
        private List<Student<Thing>> students = new List<Student<Thing>>();

        // Method to add a student to the list
        public void AddStudent(Student<Thing> student)
        {
            students.Add(student);
        }

        // Method to remove a student by ID
        public bool RemoveStudent(Thing id)
        {
            // Check if the ID and the student's ID have the same type and equality comparison
            foreach (var student in students)
            {
                if (student.Id.Equals(id))
                {
                    students.Remove(student);
                    Console.WriteLine($"Student \"{id}\" successfully removed.");
                    return true;
                }
            }
            Console.WriteLine("Unable to remove student, something went wrong!");
            return false;
        }

        // Method to list all students
        public void ListStudents()
        {
            foreach (var student in students)
            {
                student.DisplayInfo();
            }
        }

        // Static method to get and display top-performing students
        private static void DisplayTopPerformingStudents(List<Student<Thing>> students, int topCount)
        {
            if (topCount <= 0)
            {
                Console.WriteLine("You have chosen to not display any top achievers.");
                return;
            }

            // Sorts list by student average mark
            var topStudents = students
                .OrderByDescending(s => s.AverageMark) 
                .Take(topCount)
                .ToList();

            Console.WriteLine();

            if (topStudents.Count == 1)
            {
                Console.WriteLine("Top Performing Student:");
            }
            else
            {
                Console.WriteLine($"Top {topCount} Performing Students:");
            }

            foreach (var student in topStudents)
            {
                student.DisplayInfo();
            }
        }

        // Define a delegate to hold the method pointer
        private delegate void DisplayTopPerformingStudentsDelegate(int topCount);

        // Method to retrieve and display top-performing students using function pointers
        public void DisplayTopPerformingStudentsUsingPointer(int topCount)
        {
            unsafe
            {
                // Define a function pointer type
                delegate*<List<Student<Thing>>, int, void> displayDelegate = &DisplayTopPerformingStudents;

                // Call the method via the function pointer
                displayDelegate(students, topCount);
            }
        }
    }
}
