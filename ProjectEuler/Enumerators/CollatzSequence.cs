using System.Collections;
using System.Collections.Generic;

namespace ProjectEuler.Enumerators
{
    public class CollatzSequence : IEnumerable<ulong>
    {
        private ulong value;
        public CollatzSequence(ulong value)
        {
            this.value = value;
        }
        public IEnumerator<ulong> GetEnumerator()
        {
            while (value != 1)
            {
                if (value % 2 == 1)
                    value = (3 * value) + 1;
                else
                    value /= 2;

                yield return value;
                
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
