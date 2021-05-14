using System;
using ProjectEuler.Interfaces;
using static ProjectEuler.Toolbox.Utilities;

namespace ProjectEuler.Problems
{
    public class Problem007 : IProblem
    {
        public void Solution()
        {
            Console.WriteLine("The 6th Prime Number is: " + GetNthPrimeNumber(6));
            Console.WriteLine("The 10001th Prime Number is: " + GetNthPrimeNumber(10001));
        }
    }
}
