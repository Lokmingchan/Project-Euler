using System;
using ProjectEuler.Interfaces;
using static ProjectEuler.Toolbox.Utilities;

namespace ProjectEuler.Problems
{
    public class Problem001 : IProblem
    {
        public void Solution()
        {
            Console.WriteLine("SumOfMultiples3And5(1, 9): " + SumOfMultiples3And5(1, 9));
            Console.WriteLine("SumOfMultiples3And5(1, 999): " + SumOfMultiples3And5(1, 999));
        }

        protected static int SumOfMultiples3And5(int min, int max)
        {
            var total = 0;
            for (var x = min; x <= max; x++)
            {
                if (IsDivisible(x, 3) || IsDivisible(x, 5))
                {
                    total += x;
                }
                    
            }

            return total;
        }
    }
}
