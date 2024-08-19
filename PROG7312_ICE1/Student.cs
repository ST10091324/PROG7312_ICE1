using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PROG7312_ICE1
{
    internal class Student<Thing>
    {
        // Properties for the student
        public Thing Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public double AverageMark { get; set; }

        public string CourseName { get; set; }

        public string LearningType { get; set; }

        // Constructor to initialize a student object
        public Student(Thing id, string name, string surname,string courseName, string learningType, double averageMark)
        {
            Id = id;
            Name = name;
            Surname = surname; 
            CourseName = courseName;
            LearningType = learningType;
            AverageMark = averageMark;
        }

        // Method to display student information
        public void DisplayInfo()
        {
            Console.WriteLine("=============== DISPLAYING STUDENT DETIALS ===============");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Course: {CourseName}");
            Console.WriteLine($"Learning type: {LearningType}");
            Console.WriteLine($"Average Mark: {AverageMark:F2}");
        }
    }
}
