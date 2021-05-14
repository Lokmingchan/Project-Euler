using System;
using ProjectEuler.Interfaces;
using static ProjectEuler.Toolbox.Utilities;

namespace ProjectEuler.Problems
{
    class Problem014 : IProblem
    {
        public void Solution()
        {
            Console.WriteLine("GetLongestCollatzSequence(1000000): " + GetLongestCollatzSequence(1000000));
        }
    }
}
