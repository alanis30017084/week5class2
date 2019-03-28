/*Name: Alanis Correa Kriener
  Purpose: Basic quadradic solver*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5class2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<< Quadratic Equation Solver >>>\n");
            Console.Write("Please have your equation in the form 'Ax^2 + Bx + C = 0\nPlease enter your value for B: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Please enter your value for C: ");
            int C = int.Parse(Console.ReadLine());

            if (C > 0)
            {
                for (int i = 1; i <= C; i++)
                {
                    if (C % i == 0)
                    {
                        int fact1 = C / i;
                        if (i + fact1 == B)
                        {
                            int solution1 = i - i - i;
                            int solution2 = fact1 - fact1 - fact1;
                            Console.WriteLine($"\nSolution:\nx = {solution1}, x = {solution2}");
                        }
                    }
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nSorry, this program only supports positive numbers for B and C at this point.");
            }
        }
    }
}
