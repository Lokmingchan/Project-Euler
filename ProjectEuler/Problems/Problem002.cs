using System;
using ProjectEuler.Interfaces;
using static ProjectEuler.Toolbox.Utilities;

namespace ProjectEuler.Problems
{
    public class Problem002 : IProblem
    {
        public void Solution()
        {
            Console.WriteLine("SumOfFibonacci(1,10): " + SumOfFibonacci(10));
            Console.WriteLine("SumOfDivisibleFibonacci(1,4000000,2): " + SumOfDivisibleFibonacci(4000000, 2));
        }
    }
}
