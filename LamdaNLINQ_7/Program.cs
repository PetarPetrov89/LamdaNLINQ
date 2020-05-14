using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student() {FirstName = "Kalin", LastName = "Javorov", Age = 29},
                new Student() {FirstName = "Genoveva", LastName = "Petrova", Age = 25},
                new Student() {FirstName = "Petar", LastName = "Dimitrov", Age = 24},
                new Student() {FirstName = "Penka", LastName = "Filipova", Age = 20},
                new Student() {FirstName = "Galia", LastName = "Hristova", Age = 29},

            };
            var comparedStudents = students.OrderByNames().Select(s => new { Name = s.FirstName
                 + " " + s.LastName, Age = s.Age});


            var studentsByAge = students.Where(s => s.Age > 18 && s.Age < 24).Select(s => new
            {
                Name = s.FirstName
                       + " " + s.LastName,
                Age = s.Age
            });
            Console.WriteLine(string.Join(", ", comparedStudents));
            Console.WriteLine(string.Join(", ", studentsByAge));
        }
        
    }

        public static class StudentExtensions
        {
            public static List<Student> OrderByNames(this Student[] students)
            {
                return students.Where(s => s.FirstName.CompareTo(s.LastName) < 0).ToList();
            }
        }
}


