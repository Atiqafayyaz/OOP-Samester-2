using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{

    internal class Program
    {
        
        static void Main(string[] args)
        {

            string name, password, role; 
            string path = "C:\\Users\\mjuna\\OneDrive\\Desktop\\OOP-Samester-2\\Week2\\Task6\\file.txt";
            while (true)
            {

                Console.Clear();
                MUser.ReadData(path);
                string option = Menu();
                if (option == "1")
                {

                    Console.Clear();
                    Console.WriteLine("                    SignUp Menu");
                    Console.WriteLine("Enter UserName:  ");
                    name = Console.ReadLine();
                    while (!NameValidation(name))
                    {
                        Console.WriteLine("Invalid User Name Please try again");
                        name = Console.ReadLine();
                    }
                    Console.WriteLine("Enter Password:  ");
                    password = Console.ReadLine();
                    while (!PasswordValidation(password))
                    {
                        Console.WriteLine("Password Must Contain At Least 8 Character and Should not containing Space.");
                        password = Console.ReadLine();
                    }
                    Console.WriteLine("Enter Role (admin/user):  ");
                    role = Console.ReadLine();

                    MUser mUser = new MUser(name, password, role);
                    Console.WriteLine(mUser.SignUp(path)); 
                                                                
                }


                else if (option == "2")
                {
                    Console.Clear();
                    Console.WriteLine("                Sign In Menu");

                    Console.WriteLine("Enter UserName: ");
                    name = Console.ReadLine();
                    while (!NameValidation(name))
                    {
                        Console.WriteLine("Invalid User Name Please try again");
                        name = Console.ReadLine();
                    }
                    Console.WriteLine("Enter Password:  ");
                    password = Console.ReadLine();
                    while (!PasswordValidation(password))
                    {
                        Console.WriteLine("Password Must Contain At Least 8 Character and Should not containing Space.");
                        password = Console.ReadLine();
                    }
                    
                    MUser Muser = new MUser(name, password , "");
                    
                    string role1 = Muser.Signin();
                    if (role1 == "Undefined")
                    {
                        Console.WriteLine("Invalid UserName or Password");

                    }
                    else if (role1 == "user")
                    {
                        Console.Clear();
                        UserMenu();
                    }
                    else if (role1 == "admin")
                    {
                        Console.Clear();
                        AdminMenu();
                    }

            }
                else if (option == "3")
                {
                    Console.WriteLine("Exiting the Programm...");
                    break;
                }
                else if (option != "1" && option != "2" && option != "3")
                {
                    Console.WriteLine("Invalid Option");
                }
                Console.ReadKey();
            }


        }
       


        static bool NameValidation(string input)
        {
            for (int idx = 0; idx < input.Length; idx = idx + 1)
            {
                char c = input[idx];
                if (!(c >= 'A' && c <= 'Z') && !(c >= 'a' && c <= 'z') && (c != ' '))

                {
                    return false;
                }
            }
            return true;
        }
        static bool PasswordValidation(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            for (int idx = 0; idx < password.Length; idx = idx + 1)
            {
                if (password[idx] == ' ')
                {
                    return false;
                }
            }
            return true;
        }
        static string Menu()
        {
            Console.WriteLine("               LogIn Menu");
            Console.WriteLine("Select One of the Option: ");
            Console.WriteLine("1.Sign Up");
            Console.WriteLine("2.Sign In");
            Console.WriteLine("3.Exit");
            string option = Console.ReadLine();
            return option;


        }
        static void UserMenu()
        {
            Console.WriteLine("                  UserMenu");
            Console.WriteLine("1.Books Menu");
            Console.WriteLine("2.Borrow Book");
            Console.WriteLine("3.Return Book");
            Console.WriteLine("4.Give FeedBack");
            Console.WriteLine("5.Students FeeadBack");
            Console.WriteLine("6.Exit");
        }
        static void AdminMenu()
        {
            Console.WriteLine("                   AdminMenu");
            Console.WriteLine("1.Add Member");
            Console.WriteLine("2.Remove Member");
            Console.WriteLine("3.Add Book");
            Console.WriteLine("4.Remove Book");
            Console.WriteLine("5.View Library Record");
            Console.WriteLine("6.View Members Redord");
            Console.WriteLine("7.view Books Record");
        }
    }
}
   

