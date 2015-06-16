/*
 * This is a simple example of using a method inside of a different class
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerClass;

namespace ReferencedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            List<int> numbers = new List<int> {10,5,10};

            Console.WriteLine(calc.Multiply(numbers).ToString());
        }
    }
}
