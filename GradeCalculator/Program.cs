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
        }
    }
}
