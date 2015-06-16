/*
 * FizzBuzz (Common interview question). For numbers between 1 and user input, if the number is divisible by 3, print "Fizz", 
 * divisible by 5", print "Buzz" and divisible by 3 and 5, print "FizzBuzz"
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer value: ");
            string response = Console.ReadLine();
            int maxValue;

            while (!int.TryParse(response, out maxValue))
            {
                Console.Write("Value either not an integer, or too large - try again: ");
                response = Console.ReadLine();
            }

            for (int i = 1; i <= maxValue; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
