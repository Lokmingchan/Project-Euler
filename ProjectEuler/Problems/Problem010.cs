using System;
using ProjectEuler.Interfaces;
using static ProjectEuler.Toolbox.Utilities;

namespace ProjectEuler.Problems
{
    class Problem010 : IProblem
    {
        public void Solution()
        {
            Console.WriteLine("SumOfPrimes(10): " + SumOfPrimes(10));
            Console.WriteLine("SumOfPrimes(2000000): " + SumOfPrimes(2000000));
        }
    }
}
