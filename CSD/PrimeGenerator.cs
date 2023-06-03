using System;
using System.Linq;

namespace CSD
{
    public class PrimeGenerator
    {
        /**
         *
         * @param maxValue
         *            is the generation limit
         * @return
         */
        public int[] GeneratePrimes(int maxValue)
        {
            bool[] isPrimes = InitIsPrimeArray(maxValue);
            Sieve(isPrimes);
            return PickPrimes(isPrimes);
        }

        private static bool[] InitIsPrimeArray(int maxValue)
        {
            return Enumerable.Range(0, maxValue + 1)
                .Select(i => i > 1)
                .ToArray();
        }

        private static int[] PickPrimes(bool[] isPrimes)
        {
            return isPrimes.Select((isPrime, index) => isPrime ? index : 0)
                .Where(n => n > 0)
                .ToArray();
        }

        private static void Sieve(bool[] isPrimes)
        {
            for (int i = 2; i < Math.Sqrt(isPrimes.Length) + 1; i++)
            {
                if (isPrimes[i]) // if i is uncrossed, cross its multiples
                {
                    CrossoutMultiples(isPrimes, i);
                }
            }
        }

        private static void CrossoutMultiples(bool[] isPrimes, int number)
        {
            for (int j = 2 * number; j < isPrimes.Length; j += number)
            {
                isPrimes[j] = false; // multiple is not prime
            }
        }
    }
}