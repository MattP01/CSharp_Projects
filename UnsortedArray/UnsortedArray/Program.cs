/*
 * This program will take a user input, and check to see if it exists in an array.
 * It will convert the given word, as well as each word in the array, to upper case so that the user can input either * 
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word to search for: ");
            string word = Console.ReadLine();

            bool found = findItemUnsorted(word);

            if (found)
            {
                Console.WriteLine(word + " found in array");
            }
            else
            {
                Console.WriteLine(word + " not found in array");
            }
            Console.ReadLine();
        }

        public static bool findItemUnsorted(string word)
        {
            string upperWord = word.ToUpper();

            int counter = 0;
            bool found = false;
            string[] wordArray = new string[] { "Hello", "My", "Name", "Is", "Matt", "I", "Am", "A", "Developer", "At", "OpenText" };
            
            // Convert array to upper case
            var wordArrayUpper = wordArray.Select(s => s.ToUpperInvariant()).ToArray();
            
            while (counter < wordArrayUpper.Count())
            {
                if (upperWord == wordArrayUpper[counter])
                {
                    found = true;
                    break;
                }
                else
                {
                    found = false;
                }
                counter++;
            }
            return found;
        }
    }
}
