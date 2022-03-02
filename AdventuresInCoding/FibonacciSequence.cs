using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC.Functionality
{

    public static class FibonacciSequence
    {
        //assume: starts at 0,1; Return n number of ints for the sequence
        public static List<int> fibonacci(int n)
        {
            var rawSequence = new List<int> { 0, 1 };

            if (n < 2)
            {
                return rawSequence.GetRange(0, n);
            }

            for (int i = 2; i < n; i++)
            {
                var newNumber = rawSequence[i-1] + rawSequence[i-2];
                rawSequence.Add(newNumber);
            }

            return rawSequence;
        }
    }
}
