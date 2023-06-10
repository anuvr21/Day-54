using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedArithmetic
{
    interface AdvancedArithmetic
    {
        int divisor_sum(int n);
    }
    class MyCalculator : AdvancedArithmetic
    {
        public int divisor_sum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
