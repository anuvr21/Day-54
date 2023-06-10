using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            AdvancedArithmetic calculator = new MyCalculator();
            int n = 6;
            int sum = calculator.divisor_sum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic");
            Console.WriteLine(sum);
        }
    }
}
