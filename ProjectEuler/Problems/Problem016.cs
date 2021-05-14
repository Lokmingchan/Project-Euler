using System;
using ProjectEuler.Interfaces;
using static ProjectEuler.Toolbox.Utilities;

namespace ProjectEuler.Problems
{
    class Problem016 : IProblem
    {
        public void Solution()
        {
            ulong x = (ulong)Math.Pow(2, 63);
            Console.WriteLine("Sum of Digits " + SumOfDigits(x));
        }
    }
}
