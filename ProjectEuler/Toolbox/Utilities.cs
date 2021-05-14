using ProjectEuler.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Toolbox
{
    public class Utilities
    {
        public static bool IsDivisible(long dividend, long divisor)
        {
            return dividend % divisor == 0;
        }

        public static ulong SumOfDivisibleFibonacci(ulong max, ulong divisor)
        {
            return new FibonacciSequence(1, 2)
                .Where(x => x % divisor == 0)
                .TakeWhile(x => x < max)
                .Aggregate((sum, x) => sum + x);
        }

        public static ulong SumOfFibonacci(ulong max)
        {
            return new FibonacciSequence(1, 2)
                .Take((int)max)
                .Aggregate((sum, x) => sum + x);
        }

        public static ulong GetGreatestCommonDivisor(ulong a, ulong b)
        {
            while (b != 0)
            {
                ulong t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        public static ulong GetLowestCommonMultiple(ulong a, ulong b)
        {
            return (a / GetGreatestCommonDivisor(a, b)) * b;
        }

        public static ulong GetLowestCommonMultipleForRange(ulong min, ulong max)
        {
            ulong lcm = min;
            ulong newMin = min < ((max / 2) + 1) ? ((max / 2) + 1) : min;

            return new RangeSequence(newMin, max)
                .Aggregate(1UL, GetLowestCommonMultiple);
        }

        public static ulong SquareOfSum(ulong min, ulong max)
        {
            var total = 0UL;
            for (var x = min; x <= max; x++)
            {
                total += x;
            }

            return total * total;
        }

        public static ulong SumOfSquares(ulong min, ulong max)
        {
            var total = 0UL;
            for (var x = min; x <= max; x++)
            {
                total += x * x;
            }
            return total;
        }

        public static ulong GetNthPrimeNumber(int n)
        {
            return new Eratosthenes().ElementAt(n - 1);
        }

        public static ulong FindPythagoreanTripleMatchesSum(ulong sum)
        {
            var t = new PythagoreanTriples()
                .First(x => x.Item1 + x.Item2 + x.Item3 == sum);
            return t.Item1 * t.Item2 * t.Item3;
        }

        public static ulong SumOfPrimes(ulong max)
        {
            //var answer = new Eratosthenes().TakeWhile(x => x < max).Aggregate((sum, x) => sum + x);
            var answer = new Atkin(max).Aggregate((sum, x) => sum + x);
            return answer;
        }

        public static ulong FindMostDivisorsForTriangleNumber(ulong maxNumDivisors)
        {
            return new TriangleSequence().First(x => GetCountOfDivisors(x) > maxNumDivisors);
        }

        public static ulong GetCountOfDivisors(ulong number)
        {
            if (number == 0)
                return 0;

            var divisors = 1UL;

            foreach (var prime in new ProbablePrimeSequence())
            {
                var exponent = 0UL;
                while (number % prime == 0)
                {
                    exponent += 1;
                    number /= prime;
                }

                if (exponent > 0)
                    divisors *= exponent + 1;

                if (number == 1)
                    break;
            }
            return divisors;
        }

        public static ulong GetLongestCollatzSequence(ulong max)
        {
            var numWithLargestChain = 0UL;
            var seqLength = 0UL;
            for(var x = 2UL; x <= max; x++)
            {
                var collatz = new CollatzSequence(x);
                var n = 0UL;
                foreach(var c in collatz)
                {
                    n++;
                }

                if (n > seqLength)
                {
                    seqLength = n;
                    numWithLargestChain = x;
                }
            }
            return numWithLargestChain;
        }

        public static ulong SumOfDigits(ulong num)
        {
            var total = 0UL;
            while (num != 0)
            {
                total += num % 10;
                num /= 10;
            }

            return total;
        }

        #region List Manipulation
        public static IEnumerable<int> SortListAsc(IEnumerable<int> list)
        {
            return list.OrderBy(i => i);
        }

        public static IEnumerable<int> SortListDesc(IEnumerable<int> list)
        {
            return list.OrderByDescending(i => i);
        }

        public static IEnumerable<int> RemoveDupesList(IEnumerable<int> list)
        {
            return list.Distinct().ToList();
        }
        #endregion

        #region String Manipulation
        public static string ReverseString(string text)
        {
            if (text == null) return null;

            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        public static bool IsStringPalindrome(string a)
        {
            var b = ReverseString(a);
            return a == b;
        }

        public static IEnumerable<int> ConvertStringToListOfNumbers(string substring)
        {
            var chars = substring.ToArray();
            List<int> digits = new List<int>(substring.Length);
            foreach(char c in chars)
            {
                digits.Add(Int32.Parse(c.ToString()));
            }

            return digits;
        }

        public static long ProductOfList(IEnumerable<int> digitsList)
        {
            long total = 1;
            foreach(int n in digitsList)
            {
                total *= n;
            }
            return total;
        }

        public static long GetHighestProduct(string digits, int numOfChars)
        {
            long highestProduct = -1;
            var place = -1;
            for(var x=0; x < (digits.Length - numOfChars); x++)
            {
                if (digits[x + numOfChars - 1] == '0')
                {
                    x += numOfChars;
                    continue;
                }
                var substr = digits.Substring(x, numOfChars);
                var list = ConvertStringToListOfNumbers(substr);
                var product = ProductOfList(list);
                if (product > highestProduct)
                {
                    highestProduct = (long)product;
                    place = x;
                }
            }
            Console.WriteLine(place.ToString() + " " + digits.Substring(place, numOfChars));
            return highestProduct;
        }
        #endregion

        #region Matrix Manipulation
        public static int GetHighestProductGrid(int[,] grid)
        {
            var rows = grid.GetLength(0);
            var columns = grid.GetLength(1);

            var greatest = 0;

            for (var r = 0; r < rows; r++)
                for (var c = 0; c < columns; c++)
                {
                    if (c < columns - 3)
                    {
                        // Right and "Left"
                        greatest = Math.Max(greatest, grid[r, c] * grid[r, c + 1] * grid[r, c + 2] * grid[r, c + 3]);
                    }

                    if (r < rows - 3)
                    {
                        // Down and "Up"
                        greatest = Math.Max(greatest, grid[r, c] * grid[r + 1, c] * grid[r + 2, c] * grid[r + 3, c]);

                        // Diagonally, down to the right
                        if (c < columns - 3)
                            greatest = Math.Max(greatest, grid[r, c] * grid[r + 1, c + 1] * grid[r + 2, c + 2] * grid[r + 3, c + 3]);

                        // Diagonally, down to the left
                        if (c > 3)
                            greatest = Math.Max(greatest, grid[r, c] * grid[r + 1, c - 1] * grid[r + 2, c - 2] * grid[r + 3, c - 3]);
                    }
                }

            return greatest;
        }
        #endregion
    }
}
