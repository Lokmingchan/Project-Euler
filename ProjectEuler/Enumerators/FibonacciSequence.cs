using System.Collections;
using System.Collections.Generic;

namespace ProjectEuler.Enumerators
{
    public class FibonacciSequence: IEnumerable<ulong>
    {
        private readonly List<ulong> knownFibonacci;
        public FibonacciSequence()
        {
            knownFibonacci = new List<ulong> { 1, 1 };
        }
        public FibonacciSequence(ulong a, ulong b)
        {
            knownFibonacci = new List<ulong> { a, b };
        }
        public IEnumerator<ulong> GetEnumerator()
        {
            foreach (var fibonacci in knownFibonacci)
                yield return fibonacci;

            while (true)
            {
                ulong sum = knownFibonacci[knownFibonacci.Count - 1] + knownFibonacci[knownFibonacci.Count - 2];
                yield return sum;
                knownFibonacci.Add(sum);
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
