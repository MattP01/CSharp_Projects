using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerClass
{
    public class Calculator
    {
        public int Multiply(List<int> nums)
        {
            int total = 1;

            foreach (var num in nums)
            {
                total = total * num;
            }
            return total;
        }
    }
}
