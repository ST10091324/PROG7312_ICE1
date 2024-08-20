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

        public Student() { }

        // Method to display student information
        public void DisplayInfo()
        {
            Console.WriteLine("=============== DISPLAYING STUDENT DETIALS ===============");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Course: {CourseName}");
            Console.WriteLine($"Learning type: {LearningType}");
            Console.WriteLine($"Average Mark: {AverageMark}%");
        }

        // Comparison operators based on AverageMark
        public static bool operator >(Student<Thing> s1, Student<Thing> s2)
        {
            return s1.AverageMark > s2.AverageMark;
        }

        public static bool operator <(Student<Thing> s1, Student<Thing> s2)
        {
            return s1.AverageMark < s2.AverageMark;
        }

        public static bool operator >=(Student<Thing> s1, Student<Thing> s2)
        {
            return s1.AverageMark >= s2.AverageMark;
        }

        public static bool operator <=(Student<Thing> s1, Student<Thing> s2)
        {
            return s1.AverageMark <= s2.AverageMark;
        }

        public static bool operator ==(Student<Thing> s1, Student<Thing> s2)
        {
            // Check if both references are the same instance or both are null
            if (ReferenceEquals(s1, s2))
            {
                // Both are the same or both are null, so they are equal
                return true;
            }
            if (ReferenceEquals(s1, null))
            {
                return false;
            }
            if (ReferenceEquals(s2, null))
            {
                return false;
            }
            return s1.AverageMark == s2.AverageMark;
        }

        public static bool operator !=(Student<Thing> s1, Student<Thing> s2)
        {
            // Check if both objects are the same instance or both are null
            if (ReferenceEquals(s1, s2))
            {             
                return false;
            }
            if (ReferenceEquals(s1, null))
            {
                return false;
            }
            if (ReferenceEquals(s2, null))
            {
                return false;
            }

            // If one is null, they are not equal
            if (s1 == null || s2 == null)
            {
                return true;
            }
            return s1.AverageMark != s2.AverageMark;
        }

        // Implement IComparable<Student<TId>> for default comparison
        public int CompareTo(Student<Thing> other)
        {
            if (other == null) return 1;
            return AverageMark.CompareTo(other.AverageMark);
        }

        // Override Equals and GetHashCode
        public override bool Equals(object obj)
        {
            // Check if the object is the same instance or both are null
            if (ReferenceEquals(this, obj)) return true;

            // Check if the object is of the correct type
            if (obj is Student<Thing> other)
            {
                // Compare AverageMark if both are non-null
                return AverageMark == other.AverageMark;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return AverageMark.GetHashCode();
        }
    }
}
