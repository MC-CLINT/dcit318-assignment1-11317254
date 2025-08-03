using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPriceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                if (input.Trim().ToLower() == "exit")
                {
                    Console.WriteLine("Exiting Program. Goodbye");
                    break;
                }

                // Validate input first
                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Age Input cannot be empty.");
                    continue;
                }

                if (int.TryParse(input, out int age))
                {
                    if (age < 0 || age > 120)
                    {
                        Console.WriteLine("Please enter your right age).");
                    }
                    else
                    {
                        int ticketPrice = (age <= 12 || age >= 65) ? 7 : 10;
                        Console.WriteLine($"Your ticket price is GHC{ticketPrice}.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid age using a whole number (eg., 25).");
                }

                Console.WriteLine("Would you like to try another age? (yes/no)");
                string response = Console.ReadLine().Trim().ToLower();

                if (response != "yes")
                {
                    Console.WriteLine("Thanks for using the Ticket Price Calculator. Goodbye!");
                    break;
                }
            }
        }
    }
}
