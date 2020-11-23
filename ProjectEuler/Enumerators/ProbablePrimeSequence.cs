using System.Collections;
using System.Collections.Generic;

namespace ProjectEuler.Enumerators
{
    public class ProbablePrimeSequence : IEnumerable<ulong>
    {
        public IEnumerator<ulong> GetEnumerator()
        {
            yield return 2;
            yield return 3;
            ulong i = 5;
            while (true)
            {
                yield return i;
                if (i % 6 == 1)
                    i += 2;
                i += 2;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
