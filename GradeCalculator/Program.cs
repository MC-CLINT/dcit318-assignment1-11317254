using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numerical grade (0-100)");
            string input = Console.ReadLine();

            //Detects for empty or whitespace-only input
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("An input value is required. Enter a numerical value within the range of 0 to 100");
                return;
            }

            // Parse input as double to support decimal values (e.g., 83.5)
            if(double.TryParse(input, out double grade))
            {
                if(grade < 0 || grade > 100)
                {
                    Console.WriteLine("Grade must be between 0 and 100.");
                    return;
                }

                // Rounding to the nearest whole number
                int roundedGrade = (int)Math.Round(grade);

                // Determining the letter grade
                if (roundedGrade >= 90)
                    Console.WriteLine("Letter grade: A");

                else if (roundedGrade >= 80)
                    Console.WriteLine("Letter grade: B");

                else if (roundedGrade >= 70)
                    Console.WriteLine("Letter grade: C");

                else if (roundedGrade >= 60)
                    Console.WriteLine("Letter grade: D");

                else
                    Console.WriteLine("Letter grade: F");
            }
            else
            {
                Console.WriteLine("Please enter a valid number (eg., 75, 83.5).");
            }

            Console.WriteLine("Press any key to exit....");
            Console.ReadKey();

        }
    }
}
