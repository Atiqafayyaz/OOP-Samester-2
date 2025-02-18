using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task6
{
    public class MUser
    {
        public string Name;              //whenever i use these attribute i have to attach that object name jis k through 
        public string Password;          //hum isy use ker rahy hon gy 
        public string Role;

        private static List<MUser> users = new List<MUser>();
        public MUser(string name , string password , string role)
        {
            Name = name;
            Password = password;
            Role = role;
        }

        public  string SignUp( string path)
        {
            
            foreach (MUser user1 in users)
            { 
                if(user1.Name == Name)
                {
                    return "UserName Already Exist.";
                        
                }

            }
            
            StreamWriter file1 = new StreamWriter(path, true);
            file1.WriteLine(Name + "," + Password + "," + Role);
            file1.Flush();
            file1.Close();

            return "Sign Up Successfully";
        }

        public  string Signin()
        {
            foreach(MUser user1 in users) 
            {
                if (Name == user1.Name && Password == user1.Password)
                {
                    return user1.Role;
                }
            }
            return "Undefined";
        }
        public static void ReadData(string path)
        {

            users.Clear();                     //Clears the list before adding new data to prevent duplicates
            StreamReader file = new StreamReader(path);
            string record;
            while ((record = file.ReadLine()) != null)
            {
                string[] feild = record.Split(',');  // Splits the line into an array using , (comma) as a separator. means split the string in substring and save in array
                                                     // Before Split() → "Alice,password123,Admin"
                                                     //After Split() → ["Alice", "password123", "Admin"]

                if (feild.Length < 3)
                    continue;
                MUser user1 = new MUser(feild[0], feild[1], feild[2]);
                users.Add(user1);
            }                                // in list many object store where each object have 3 attributes in this case
                                             // so whenever i compare attribute in list i have to add this object name with that attribute 
            file.Close();


        }

    }
}
