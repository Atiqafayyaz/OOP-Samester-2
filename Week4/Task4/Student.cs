using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Student
    {
        public string Name;
        public int Age;
        public int FSCMarks;
        public int ECATMarks;
        public string DegreeProgram;
        public int Preferences;

        private static List<Student> studentsList = new List<Student>();
        public Student(string name, int age, int fMarks, int eMarks, string program, int preference)
        {
            Name = name;
            Age = age;
            FSCMarks = fMarks;
            ECATMarks = eMarks;
            Preferences = preference;     
        }

        public void AddStudent()
        {
            studentsList.Add(this);
            Console.WriteLine("Student Added Successfully");
        }


    }
    

}
