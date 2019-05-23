using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name: Logan Tawhiri
//Purpose: Employee Payroll System
namespace PayrollSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------Welcome--------------------------------------------------");
            Console.WriteLine("------------------------------------------Here You Can Check Your------------------------------------------");
            Console.WriteLine("--------------------------------------------------Payroll--------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");


            //New Object
            Employee e1 = new Employee();

            //Asking the user for their First Name
            Console.Write("Please Enter Your First Name: ");
            e1.Fname = Console.ReadLine();

            //Asking the user for their Last Name
            Console.Write("Please Enter Your Last Name: ");
            e1.Lname = Console.ReadLine();

            //Asking the user their Tax Rate
            Console.Write("Please Enter Your Tax Rate: ");
            e1.Tax = double.Parse(Console.ReadLine());

            //Asking the user for Annual Gross Salary
            Console.Write("Please Enter Your Annual Gross Salary: ");
            e1.Gross = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"Net Salary: ${e1.CalcNet()}");

            Console.ReadLine();
        }
    }
    //Creating the Employee Class
    class Employee
    {
        // Private Instance Variables
        private string fname;

        private string lname;

        private double gross;

        private double tax;

        //Getters & Setters
        public string Fname { get { return fname; } set { fname = value; } }

        public string Lname { get { return lname; } set { lname = value; } }

        public double Gross { get { return gross; } set { gross = value; } }

        public double Tax { get { return tax; } set { tax = 15; } } 

        //Constructor
        public Employee()
        {
            Console.WriteLine("");
            Console.WriteLine("Employee Record Created");
            Console.WriteLine("");
        }
        //Method to calculate Net Salary
        public double CalcNet()
        {
            return Gross - (Gross * (Tax / 100));
        }
    }
}
