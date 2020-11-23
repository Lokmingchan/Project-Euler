using System.Collections;
using System.Collections.Generic;

namespace ProjectEuler.Enumerators
{
    public class PrimeFactorSequence : IEnumerable<ulong>
    {
        private ulong value;
        private IEnumerable<ulong> primeSequence;
        public PrimeFactorSequence(ulong value, IEnumerable<ulong> primeSequence)
        {
            this.value = value;
            this.primeSequence = primeSequence;
        }

        public IEnumerator<ulong> GetEnumerator()
        {
            foreach (var prime in primeSequence)
            {
                while (value % prime == 0)
                {
                    value /= prime;
                    yield return prime;
                }

                if (value == 1)
                {
                    yield break;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
