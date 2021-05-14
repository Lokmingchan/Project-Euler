using System;
using ProjectEuler.Interfaces;
using static ProjectEuler.Toolbox.Utilities;

namespace ProjectEuler.Problems
{
    class Problem015 : IProblem
    {
        const int gridSize = 20;
        long paths = 1;

        public void Solution()
        {

            Console.WriteLine("Paths to Traverse 20x20 Grid: " + CalculatePaths());
        }

        public long CalculatePaths()
        {
            for(var i = 0; i < gridSize; i++)
            {
                paths *= (2 * gridSize) - i;
                paths /= i + 1;
            }

            return paths;
        }
    }
}
