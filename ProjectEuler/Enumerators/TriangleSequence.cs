using System.Collections;
using System.Collections.Generic;

namespace ProjectEuler.Enumerators
{
    public class TriangleSequence : IEnumerable<ulong>
    {
        public IEnumerator<ulong> GetEnumerator()
        {
            ulong sum = 0;
            for (ulong n = 1; ; n++)
            {
                sum += n;
                yield return sum;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
