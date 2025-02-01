using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using System.IO;
using System.Net.Sockets;

namespace SignUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name , password , Role;
            string path = "C:\\Users\\mjuna\\OneDrive\\Desktop\\OOPLab\\SignUp\\file.txt";
            string[] UserName = new string[100];
            string[] UserPassword = new string[100];
            string[] role = new string[100];
            int idx = 0;
            while(true)
            {

                Console.Clear();
                readData(path, UserName, UserPassword, role, ref idx);
                string option = Menu();
                if (option == "1")
                {
                    Console.Clear();
                    Console.WriteLine("                Sign In Menu");
                    Console.WriteLine("Enter UserName: ");
                    name = Console.ReadLine();
                    while (!nameValidation(name))
                    {
                        Console.WriteLine("Invalid User Name Please try again");
                        name = Console.ReadLine();
                    }
                    Console.WriteLine("Enter Password:  ");
                    password = Console.ReadLine();
                    while (!passwordValidation(password))
                    {
                        Console.WriteLine("Password Must Contain At Least 8 Character and Should not containing Space.");
                        password = Console.ReadLine();
                    }
                    string role1 = signin(UserName, UserPassword, role, name, password, ref idx);
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
                else if (option == "2")
                {
                    Console.Clear();
                    Console.WriteLine("                    SignUp Menu");
                    Console.WriteLine("Enter UserName:  ");
                    name = Console.ReadLine();
                    while (!nameValidation(name))
                    {
                        Console.WriteLine("Invalid User Name Please try again");
                        name = Console.ReadLine();
                    }
                    Console.WriteLine("Enter Password:  ");
                    password = Console.ReadLine();
                    while (!passwordValidation(password))
                    {
                        Console.WriteLine("Password Must Contain At Least 8 Character and Should not containing Space.");
                        password = Console.ReadLine();
                    }
                    Console.WriteLine("Enter Role (admin/user):  ");
                    Role = Console.ReadLine();
                    SignUp(UserName, name, password, Role, path, ref idx);
                


                }
                else if (option == "3")
                {
                    Console.WriteLine("Exiting the Programm...");
                    break;
                }
                else if(option != "1" && option != "2" && option != "3")
                {
                    Console.WriteLine("Invalid Option");
                }
                Console.ReadKey();
            }

        }
        static string signin(string []UserName , string []UserPassword , string []role  , string name, string password, ref int idx)
        {
            for (int x = 0; x < idx; x = x + 1)
            {
                if (name == UserName[x] && password == UserPassword[x])
                {
                    return role[x];
                }
            }
            return "Undefined";
        }
        static void SignUp(string[] UserName , string name , string password , string role , string path , ref int idx)
        {
            for (int x = 0; x < idx; x = x + 1)
            {
                if (name == UserName[x] )
                {
                    Console.WriteLine("The User Already Exist");
                }
            }

            StreamWriter file = new StreamWriter(path , true);
            file.WriteLine(name + "," + password + "," + role);
            file.Flush();
            file.Close();
        }
        static void readData(string path, string[] UserName, string[] UserPassword, string[] role, ref int idx)
        {
            if(File.Exists(path))
            {
               StreamReader file = new StreamReader (path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    UserName[idx] = GetField(record, 1);
                    UserPassword[idx] = GetField(record, 2);
                    role[idx] = GetField(record, 3);
                    idx++;
                    if(idx >= 100)
                    {
                        break;
                    }

                }
                file.Close();

            }
            else
            {
                Console.WriteLine("Not Exist");
            }
        }
        static string GetField(string record, int field)
        {
            int countComma = 1;
            string item ="";
            for (int x = 0; x < record.Length; x = x + 1)
            {
                if (record[x] == ',')
                {
                    countComma = countComma + 1;
                }
                else if (countComma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        static bool nameValidation(string input)
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
        static bool passwordValidation(string password)
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
            Console.WriteLine("1.Sign In");
            Console.WriteLine("2.Sign Up");
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
