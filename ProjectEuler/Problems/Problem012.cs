using System;
using ProjectEuler.Interfaces;
using static ProjectEuler.Toolbox.Utilities;

namespace ProjectEuler.Problems
{
    class Problem012 : IProblem
    {
        public void Solution()
        {
            Console.WriteLine("FindMostDivisorsForTriangleNumber(500): " + FindMostDivisorsForTriangleNumber(500));
        }
    }
}
