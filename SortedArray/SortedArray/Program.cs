/*
 * This program will use .NET's binarysearch function to find a value in a sorted array
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedArray
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string receivedNum = Console.ReadLine();
            int num;

            int.TryParse(receivedNum,out num);

            int retIndex = checkArraySorted(num);

            if (retIndex == -1)
            {
                Console.WriteLine(num.ToString() + " was not found in the array");
            }
            else
            {
                Console.WriteLine(num.ToString() + " was found in the array at index: " + retIndex);
            }
            Console.ReadLine();
        }

        public static int checkArraySorted(int num)
        {
            int[] numbers = new int[] {1,5,2,3,7,6,4,9,8,10,13,98,23,45};

            Array.Sort(numbers);

            return Array.BinarySearch(numbers, num);       
        }
    }
}
