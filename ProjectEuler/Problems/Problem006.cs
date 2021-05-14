using System;
using ProjectEuler.Interfaces;
using static ProjectEuler.Toolbox.Utilities;

namespace ProjectEuler.Problems
{
    public class Problem006 : IProblem
    {
        public void Solution()
        {
            Console.WriteLine("SquareOfSum(1, 10) = " + SquareOfSum(1, 10));
            Console.WriteLine("SumOfSquares(1, 10) = " + SumOfSquares(1, 10));
            Console.WriteLine("SquareOfSum(1, 10) - SumOfSquares(1, 10) = " + (SquareOfSum(1, 10) - SumOfSquares(1, 10)));
            Console.WriteLine();
            Console.WriteLine("SquareOfSum(1, 100) = " + SquareOfSum(1, 100));
            Console.WriteLine("SumOfSquares(1, 100) = " + SumOfSquares(1, 100));
            Console.WriteLine("SquareOfSum(1, 100) - SumOfSquares(1, 100) = " + (SquareOfSum(1, 100) - SumOfSquares(1, 100)));
        }
    }
}
