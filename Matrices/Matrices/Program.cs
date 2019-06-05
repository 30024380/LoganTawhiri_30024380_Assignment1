using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name: Logan Tawhiri
//Purpose: 2D Array
namespace Matrices
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            //Random number generator
            Random rand = new Random();

            int[,] matrixA = new int[3, 3];

            int[,] matrixB = new int[3, 3];
            
            //Generating Matrix A with random numbers between -10, 10
            for(int i = 0; i < matrixA.GetLength(0); i++)
            {
                for(int j = 0; j <matrixA.GetLength(1); j++)
                {
                    matrixA[i, j] = rand.Next(-10, 10);
                }
                
            }

           //Generating Matrix B with random numbers between -10, 10
            for(int i = 0; i < matrixB.GetLength(0); i++)
            {
                for(int j = 0; j < matrixB.GetLength(1); j++)
                {
                    matrixB[i, j] = rand.Next(-10, 10);
                }
                
            }

            //Displays the first array
            Console.WriteLine("Array A: ");
            Display(matrixA);      

            //Displays the second array
            Console.WriteLine("Array B: ");
            Display(matrixB);

            //Both arrays added together
            Console.WriteLine("Arrays Added Together: ");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(matrixA[i, j] + matrixB[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        //To display the arrays
        public static void Display(int[,] gg)
        {
            for (int i = 0; i < gg.GetLength(0); i++)
            {
                for (int j = 0; j < gg.GetLength(1); j++)
                {
                    Console.Write(gg[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }  
}
