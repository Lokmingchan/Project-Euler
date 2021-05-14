using System;
using ProjectEuler.Interfaces;
using static ProjectEuler.Toolbox.Utilities;

namespace ProjectEuler.Problems
{
    public class Problem005 : IProblem
    {
        public void Solution()
        {
            Console.WriteLine("Smallest possible number evenly divisible by all numbers from 1 to 10: " + GetLowestCommonMultipleForRange(1, 10));
            Console.WriteLine("Smallest possible number evenly divisible by all numbers from 1 to 20: " + GetLowestCommonMultipleForRange(1, 20));
        }
    }
}
