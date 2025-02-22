using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Subject
    {
        public string Code;
        public string Type;
        public int CreditHours;
        public int Fees;

        public static List<Subject> Subjects = new List<Subject>();

        public Subject(string code , string type , int Chours , int fees)
        {
            Code = code;
            Type = type;
            CreditHours = Chours;
            Fees = fees;
        }
        public List<Subject> GetSubjects()
        {
            return Subjects;
        }

    }
    

}
