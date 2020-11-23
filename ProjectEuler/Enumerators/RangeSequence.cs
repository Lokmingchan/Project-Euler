using System.Collections;
using System.Collections.Generic;

namespace ProjectEuler.Enumerators
{
    public class RangeSequence : IEnumerable<ulong>
    {
        private readonly ulong min, max;
        public RangeSequence(ulong min, ulong max)
        {
            this.min = min;
            this.max = max;
        }

        public IEnumerator<ulong> GetEnumerator()
        {
            for (ulong n = min; n <= max; n++)
            {
                yield return n;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
