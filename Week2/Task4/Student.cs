using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task4
{
    public class Student
    {
        public string Name;
        public float Matric_Marks;
        public float Fsc_Marks;
        public float Ecat_Marks;
        public float Aggregate; 

        private static List<Student> studentList = new List<Student>();

        
        public Student(string name, float matric_Marks, float fsc_Marks, float ecat_Marks)
        {
            Name = name;
            Matric_Marks = matric_Marks;
            Fsc_Marks = fsc_Marks;
            Ecat_Marks = ecat_Marks;
            Aggregate = CalculateAggregate();
        }

        private float CalculateAggregate()
        {
            return (Matric_Marks / 1100 * 10) + (Fsc_Marks / 1100 * 40) + (Ecat_Marks / 400 * 50);
        }

       
        public void AddStudent()
        {
            studentList.Add(this);                        //F2 means 2 decimal places
            Console.WriteLine("Student added successfully! Aggregate: " + Aggregate.ToString("F2") + "%");
        }

        
        public static void ShowStudents()
        {
            if (studentList.Count == 0)
            {
                Console.WriteLine("No students added yet.");
                return;
            }
            Console.WriteLine("  List of Students:");
            foreach (Student student in studentList)
            {
                Console.WriteLine($"Name: {student.Name}, Matric: {student.Matric_Marks}, FSC: {student.Fsc_Marks}, ECAT: {student.Ecat_Marks}, Aggregate: {student.Aggregate:F2}%");
            }
        }

       
        public static void CalculateAggregateForAll()
        {
            if (studentList.Count == 0)
            {
                Console.WriteLine("No students available to calculate aggregate.");
                return;
            }

            Console.WriteLine("  Aggregates of All Students:");
            foreach (Student student in studentList)
            {
                Console.WriteLine($"Name: {student.Name}, Aggregate: {student.Aggregate:F2}%");
            }
        }

       
        public static void ShowTopStudents()
        {
            if (studentList.Count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }

           
            var topStudents = studentList.OrderByDescending(s => s.Aggregate).Take(3).ToList();

            Console.WriteLine("  Top 3 Students:");
            for (int i = 0; i < topStudents.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Name: {topStudents[i].Name}, Aggregate: {topStudents[i].Aggregate:F2}%");
            }
        }
    }
}