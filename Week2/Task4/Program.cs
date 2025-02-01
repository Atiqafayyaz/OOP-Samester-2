using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option;
            while (true)
            {
                Console.WriteLine("   Choose an option:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Show Students");
                Console.WriteLine("3. Calculate Aggregate");
                Console.WriteLine("4. Top Students");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.Write("Enter Student Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Matric Marks: ");
                    float matric_Marks = float.Parse(Console.ReadLine());
                    Console.Write("Enter FSC Marks: ");
                    float fsc_Marks = float.Parse(Console.ReadLine());
                    Console.Write("Enter ECAT Marks: ");
                    float ecat_Marks = float.Parse(Console.ReadLine());

                    Student student = new Student(name, matric_Marks, fsc_Marks, ecat_Marks);
                    student.AddStudent();
                }
                else if (option == "2")
                {
                    Student.ShowStudents();
                }
                else if (option == "3")
                {
                    Student.CalculateAggregateForAll();
                }
                else if (option == "4")
                {
                    Student.ShowTopStudents();
                }
                else if (option == "5")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option! Please try again.");
                }
            }
        }
    }
}
