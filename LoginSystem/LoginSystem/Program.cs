using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name: Logan Tawhiri
//Purpose: Assignment Part 1
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

           

            //Prompts the user to enter their username
            Console.WriteLine("Please Enter Your Username");
            string username = Console.ReadLine();

            //Calls to the validateUsername Method
            Console.WriteLine("");
            validateUsername(username);
           
            //Prompts the user to enter their password
            Console.WriteLine("Please Enter Your Password");
            string password1 = Console.ReadLine();

             //Prompts the user to enter their password
             Console.WriteLine("Please Enter Your Password Again");
             string password2 = Console.ReadLine();

             //Calls to the method
             Console.WriteLine("");
             validatePassword(password1, password2);
            

            //Displays username and password
            Console.WriteLine("Username and Password Have Been Accepted");
            Console.WriteLine($"Username: {username}\nPassword: {password1}");
            Console.ReadLine();
        }
        public static void validateUsername(string username)
        {           
            //infinitely loops until the user inputs the correct username length
            while(true)
            {
                //Statement to tell the user that the username they input was valid
                if (username.Length > 7)
                {
                    Console.WriteLine("This Username Is Valid");
                    Console.ReadLine();
                    break;
                }

                //Statement to tell the user that the username they input was invalid 
                else if (username.Length < 8)
                {
                    Console.WriteLine("This Username Is Invalid, Try Again");
                    Console.ReadLine();
                }

                Console.WriteLine("Enter Your Username");
                username = Console.ReadLine();
                Console.WriteLine("");
            } 
        }
        public static void validatePassword(string password1, string password2)
        {
                                                         
                //Statement to confirm the correct length of the users password and asks for another password entering prompt
                if (password1.Length > 7)
                {                                      
                    //statement to confirm that the password they entered was the same
                    if (password2 == password1)
                    {
                        Console.WriteLine("You Have Been Logged In");
                        Console.ReadLine();
                        
                    }

                    //Statement to tell the user that the password they entered wasn't the same
                    else
                    {
                        Console.WriteLine("This Password Is Invalid, Try Again");
                        Console.ReadLine();
                    }
                }
                //Statement that tells the user their password length wasn't enough
                else if (password1.Length < 8)
                {
                    Console.WriteLine("Password was not long enough, Try Again");
                    Console.ReadLine();
                }  
                
        }
    }
}
