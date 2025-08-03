using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTypeIdentifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter three side lengths of a triangle (or type 'exit' to quit):");

                double[] sides = new double[3];

                for (int i=0; i < 3; i++)
                {
                    Console.Write($"Side {i + 1}: ");
                    string input = Console.ReadLine();

                    if (input.Trim().ToLower() == "exit")
                    {
                        Console.WriteLine("Exiting Program. Goodbye !");
                        return;
                    }
                    
                    if(!double.TryParse(input, out sides[i]) || sides[i] <= 0)
                            {
                    Console.WriteLine("Input is not valid. Please enter a positive number. \n ");
                    i--;
                        continue;
                }
                }
                bool isValid = sides[0] + sides[1] > sides[2] &&
                          sides[1] + sides[2] > sides[0] &&
                          sides[2] + sides[0] > sides[1];

                if (!isValid)
                {
                    Console.WriteLine("\nThe sides do not form a valid triangle.\n");
                }
                else
                {
                    Console.WriteLine("\nTriangle Type:");
                    if (sides[0] == sides[1] && sides[1] == sides[2])
                        Console.WriteLine("Equilateral");
                    else if (sides[0] == sides[1] || sides[1] == sides[2] || sides[2] == sides[0])
                        Console.WriteLine("Isosceles");
                    else
                        Console.WriteLine("Scalene");
                }

                Console.WriteLine("\nWould you like to try another triangle? (yes/no)");

                string again = Console.ReadLine().Trim().ToLower();

                if (again != "yes")
                {
                    Console.WriteLine("Thanks for using the Triangle Type Identifier. Goodbye!");
                    break;
                }
            }
        }
    }
}
