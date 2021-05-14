using System;
using ProjectEuler.Interfaces;
using static ProjectEuler.Toolbox.Utilities;

namespace ProjectEuler.Problems
{
    class Problem009 : IProblem
    {
        public void Solution()
        {
            Console.WriteLine("Pythagorean Triple Product is: " + FindPythagoreanTripleMatchesSum(1000));
        }
    }
}
