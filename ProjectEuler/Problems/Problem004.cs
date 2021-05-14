using System;
using ProjectEuler.Interfaces;
using static ProjectEuler.Toolbox.Utilities;

namespace ProjectEuler.Problems
{
    public class Problem004 : IProblem
    {
        public void Solution()
        {
            Console.Write("Highest Product Made by Two Digit Numbers: ");
            HighestProductOfPalindrome(10, 99);
            Console.WriteLine();
            Console.Write("Highest Product Made by Three Digit Numbers: ");
            HighestProductOfPalindrome(100, 999);
            Console.WriteLine();
        }

        internal static void HighestProductOfPalindrome(int min, int max)
        {
            var highestProduct = -1;
            int highX = 0, highY = 0;
            for (var x = min; x <= max; x++)
            {
                for (var y = min; y <= max; y++)
                {
                    var z = x*y;
                    if (!IsStringPalindrome(z.ToString()) || z <= highestProduct) continue;
                    highestProduct = z;
                    highX = x;
                    highY = y;
                }
            }
            Console.Write(highX + " x " + highY + " = " + highestProduct);    
        }
    }
}
