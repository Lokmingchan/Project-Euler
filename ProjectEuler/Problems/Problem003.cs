using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEuler.Interfaces;
using static ProjectEuler.Toolbox.Utilities;
using ProjectEuler.Enumerators;

namespace ProjectEuler.Problems
{
    public class Problem003 : IProblem
    {
        public void Solution()
        {
            Console.Write("GetPrimeFactors(13195): ");
            //List<int> first = SortListAsc(GetPrimeFactors(13195)).ToList();
            var first = new PrimeFactorSequence(13195, new Eratosthenes());
            Console.WriteLine();
            Console.WriteLine("Largest factor in GetPrimeFactors(13195): " + first.Last());

            Console.Write("GetPrimeFactors(600851475143): ");
            //List<int> second = SortListAsc(GetPrimeFactors(600851475143)).ToList();
            var second = new PrimeFactorSequence(600851475143, new Eratosthenes());
            Console.WriteLine();
            Console.WriteLine("Largest factor in GetPrimeFactors(600851475143): " + second.Last());
        }
    }
}
