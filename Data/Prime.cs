using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Prime
    {
        public int first;
        public int last;
        
        List<int> primes;

        public int PrimesList(int min, int max)
        {
            primes = new List<int>();
            int dif = 0;
            for (int i = 3; i < (max + 1); i += 2)
            {

                double root = Math.Sqrt(i);
                bool found = false;
                for (int j = 0, count = primes.Count; j < count; j++)
                {
                    int div = primes[j];
                    if (div > root)
                    {
                        break;
                    }
                    else if ((i % div) == 0)
                    {
                        found = true;
                        break;
                    }
                }
                if (found == false)
                {
                    primes.Add(i);
                }
                
            }
            primes.Insert(0, 2);
            foreach (int k in primes)
            {
                if (k < min)
                {
                    dif++;
                }
            }
            for (int l = 0; l < dif; l++)
            {
                primes.RemoveAt(0);
            }
            return primes.Count;
        }
        public int firstPrime()
        {
            if (primes.Count == 0)
            {
                return 0;
            }
            else
            {
                return this.primes[0];
            }
            
        }
        public int lastPrime()
        {
            return primes[(primes.Count() - 1)];
        }

    }
}
