using System;
using System.Collections;
using System.Collections.Generic;

namespace ProjectEuler.Enumerators
{
    public class PythagoreanTriples : IEnumerable<Tuple<ulong, ulong, ulong>>
    {
        public IEnumerator<Tuple<ulong, ulong, ulong>> GetEnumerator()
        {
            for (ulong c = 1; ; c++)
                for (ulong b = 1; b <= c; b++)
                    for (ulong a = 1; a < b; a++)
                        if ((a * a) + (b * b) == c * c)
                            yield return Tuple.Create(a, b, c);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
