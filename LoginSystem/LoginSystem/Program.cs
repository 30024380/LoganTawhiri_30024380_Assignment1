using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Logan Tawhiri
//Purpose: Assignment Part 1, Login System

namespace LoginSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------Welcome--------------------------------------------------");
            Console.WriteLine("-----------------------------------------------Here You Can------------------------------------------------");
            Console.WriteLine("---------------------------------------------------Login---------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators
            bool userName = true;
            bool passWord = true;

            while (userName)
            {
                string username;

                //Prompts the user to enter their username
                Console.WriteLine("\nPlease Enter Your Username");
                //calls to the validateUsername method
                userName = validateUsername(username = Console.ReadLine());
                if (userName == false)
                {
                    while (passWord)
                    {
                        //Prompts the user to enter their password
                        Console.WriteLine("\nPlease Enter Your Password");
                        string password1 = Console.ReadLine();

                        Console.WriteLine("\nPlease Enter Your Password Again");
                        //Calls to the validatePassword method
                        passWord = validatePassword(password1, Console.ReadLine());
                    }
                }
                else
                {
                    Console.WriteLine("\nThis Username is Invalid, Try Again");
                    Console.ReadLine();
                }
            }
        }
        public static bool validateUsername(string username)
        {
            //Statement to tell the user that the username they input was valid
            if (username.Length > 7)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public static bool validatePassword(string password1, string password2)
        {
            //Infinitely loops until user enters in the correct password length     
            {
                //Statement to confirm the correct length of the users password and the 2 password entries are the same
                if (password1.Length > 7 && password1 == password2)
                {
                    Console.WriteLine("\nYou Have Been Successfully Logged In");
                    Console.WriteLine($"\nUsername And Password Have Been Accepted");

                    Console.ReadLine();
                    return false;
                }
                else
                {
                    Console.WriteLine("\nThat Password Is Invalid, Try Again");

                    Console.ReadLine();
                    return true;
                }
            }
        }
    }
}
