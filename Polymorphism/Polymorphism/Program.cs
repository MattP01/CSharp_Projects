/*
 * This program is an example of simple polymorphism, changing the implementation of getFullName() for each derived class
 * 
 * It also implements a simple Add method using a List<int>, so that users can add a user-defined number of numbers
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee()
            {
                FirstName = "Matt",
                LastName = "Pinelli"
            };

            FullTimeEmployee e2 = new FullTimeEmployee()
            {
                FirstName = "Holly",
                LastName = "Pinelli"
            };

            PartTimeEmployee e3 = new PartTimeEmployee()
            {
                FirstName = "Sam",
                LastName = "Harris"
            };

            ContractEmployee e4 = new ContractEmployee()
            {
                FirstName = "Geralt",
                LastName = "Rivia"
            };

            Console.WriteLine(e1.getFullName());
            Console.WriteLine(e2.getFullName());
            Console.WriteLine(e3.getFullName());
            Console.WriteLine(e4.getFullName());

            Calcuator calc = new Calcuator();

            List<int> numbers = new List<int> { 1, 5, 2, 19, 23 };

            Console.WriteLine("----------------------------");
            Console.WriteLine(calc.Add(numbers).ToString());

        }
    }

    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual string getFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
    }

    class FullTimeEmployee : Employee
    {
        public override string getFullName()
        {
            return this.FirstName + " " + this.LastName + " - Full Time";
        }
    }

    class PartTimeEmployee : Employee
    {
        public override string getFullName()
        {
            return this.FirstName + " " + this.LastName + " - Part Time";
        }
    }

    class ContractEmployee : Employee
    {
        public override string getFullName()
        {
            return this.FirstName + " " + this.LastName + " - Contract";
        }
    }

    class Calcuator
    {
        public int Add(List<int> nums)
        {
            int total = 0;

            foreach (int num in nums)
            {
                total += num;
            }
            return total;
        }
    }
}
