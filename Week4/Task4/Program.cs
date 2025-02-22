using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        public static List<DegreeProgram> programList = new List<Student>();
        static void Main(string[] args)
        {
            
            while(true)
            {
                Console.WriteLine("                      UAMS");
                Console.WriteLine("1.Add Student ");
                Console.WriteLine("2.Add Degree Program");
                Console.WriteLine("3.Generate Merit");
                Console.WriteLine("4.View Registered Students");
                Console.WriteLine("5.View Student of specific program");
                Console.WriteLine("6.Register Subject for specific Student");
                Console.WriteLine("7.Calculate fee of all Register Student");
                Console.WriteLine("8.Exit");
                Console.WriteLine("Enter one of the following option");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Enter Student Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Person Age: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Fsc Marks: ");
                    int fMarks = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Ecat Marks: ");
                    int eMarks = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Degree Program");
                    string program = Console.ReadLine();
                    Console.WriteLine("Enter Number of Preferences");
                    int preference = int.Parse(Console.ReadLine());

                    Student student = new Student(name , age , fMarks , eMarks , program , preference);
                    student.AddStudent();

                }
                else if(option == "2")
                {
                    Console.WriteLine("Enter Degree Name: ");
                    string Degreename = Console.ReadLine();
                    Console.WriteLine("Enter Degree Duration: ");
                    int Degreeduration = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Seats for Degree: ");
                    int seats = int.Parse(Console.ReadLine());
                    Console.WriteLine("Number of Subjects to Enter: ");
                    int n = int.Parse(Console.ReadLine());

                    DegreeProgram degreeProgram = new DegreeProgram(Degreename, Degreeduration,seats);

                    for(int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Enter Subject Code: ");
                        string code = Console.ReadLine();
                        Console.WriteLine("Subject Type: ");
                        string type = Console.ReadLine();
                        Console.WriteLine("Subject Credit Hours: ");
                        int Chours = int.Parse(Console.ReadLine());
                        Console.WriteLine("Subject Fees: ");
                        int fees = int.Parse(Console.ReadLine());

                        Subject subject = new Subject(code , type , Chours , fees);


                    }


                }
            }
        }
    }
}
