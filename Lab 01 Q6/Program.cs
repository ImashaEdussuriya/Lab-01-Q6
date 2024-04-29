using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student's name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter exam marks:");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 0 && marks <= 100)
            {
                string grade = CalculateGrade(marks);
                Console.WriteLine($"Student Name: {name}");
                Console.WriteLine($"Grade: {grade}");
            }
            else
            {
                Console.WriteLine("Error: Marks should be between 0 and 100.");
            }
        }

        static string CalculateGrade(int marks)
        {
            if (marks >= 75 && marks <= 100)
                return "A";
            else if (marks >= 60 && marks <= 74)
                return "B";
            else if (marks >= 50 && marks <= 59)
                return "C";
            else if (marks >= 40 && marks <= 49)
                return "D";
            else
                return "Failed";
        }
    }
}
        

    