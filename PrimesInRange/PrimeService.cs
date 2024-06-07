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
        ///  ancient algorithm for finding all prime numbers up to provided limit
        /// </summary>
        private bool[] SieveOfEratosthenes(int limit)
        {
            bool[] isPrime = new bool[limit + 1];
            // is it possible to init a bool array with true?
            for (int i = 2; i < limit; i++) isPrime[i] = true;

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
    }
}
