using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Enumerators
{
    public class Eratosthenes : IEnumerable<ulong>
    {
        private readonly List<ulong> knownPrimes;

        public Eratosthenes()
        {
            knownPrimes = new List<ulong> { 2, 3 };
        }

        public IEnumerator<ulong> GetEnumerator()
        {
            // Return the ones we know first
            foreach (var prime in knownPrimes)
                yield return prime;

            // Then find new ones
            var possible = knownPrimes.Last();
            while (true)
                if (IsPrime(possible += 2))
                {
                    yield return possible;
                    knownPrimes.Add(possible);
                }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private bool IsPrime(ulong value)
        {
            var sqrt = (ulong)Math.Sqrt(value);
            return !knownPrimes
                .TakeWhile(x => x <= sqrt)
                .Any(x => value % x == 0);
        }
    }
}
