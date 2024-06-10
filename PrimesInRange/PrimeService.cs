namespace PrimesInRange
{
    public class PrimeService
    {
        public PrimeService() { }

        public List<int> GetPrimesInRange(int lowerLimit, int upperLimit)
        {
            bool[] soe = SieveOfEratosthenes(upperLimit);
            List<int> primes = new();

            for (int i = lowerLimit; i <= upperLimit; i++)
            {
                if (soe[i])
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        /// <summary>
        ///  An ancient algorithm for finding all prime numbers up to provided limit.
        /// </summary>
        /// <returns>
        ///  A boolean array where the index of a true value indicates a prime number.
        /// </returns>
        private bool[] SieveOfEratosthenes(int limit)
        {
            bool[] isPrime = new bool[limit + 1];
            // is it possible to init a bool array with true?
            for (int i = 2; i <= limit; i++) isPrime[i] = true;

            // walk along the still unmarked numbers
            for (int p = 2; p * p <= limit; p++)
            {
                // p = highest prime in this iteration
                if (isPrime[p])
                {
                    // mark all numbers i which are multiples of p and >= p^2
                    for (int i = p * p; i <= limit; i = i + p)
                    {
                        isPrime[i] = false;
                    }
                }
            }
            return isPrime;
        }

        public Dictionary<int, int> GetPrimeDistances(List<int> primes) {
            Dictionary<int, int> distances = new();

            if (primes.Count >= 2)
            {
                for (int i = 1; i < primes.Count; i++)
                {
                    int diff = primes[i] - primes[i-1];
                    // if key doesn't exist, create it
                    distances.TryAdd(diff, 0);
                    distances[diff]++;
                }
            } else
            {
                // list of primes was too short
                // since 0 is theoretically never a key of the dict,
                // this edge case can be interpreted/handled as error/fallback
                distances.Add(0,0);
            }
            return distances;
        }
    }
}
