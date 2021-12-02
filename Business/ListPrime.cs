using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ListPrime
    {
        public bool AllClear = true;
        Data.Prime primeN = new Data.Prime();
        public int firstP { get; set; }
        public int lastP { get; set; }
        public int lowP { get; set; }
        public int highP { get; set; }
        public int countP { get; set; }
        public string obsP = "Sin observaciones";
        public bool done;

        public void SetAll()
        {
            countP = countPrime(firstP, lastP);
            lowP = lowPrime();
            highP = highPrime();
            done = true;
        }
        public bool firstIsInteger(string s)
        {
            bool v = int.TryParse(s, out int n);
            if (v)
            {
                firstP = n;
            }
            return v;
        }
        public bool lastIsInteger(string s)
        {
            bool v = int.TryParse(s, out int n);
            if (v)
            {
                lastP = n;
            }
            return v;
        }
        public bool allClear(string a, string b)
        {
            if (firstIsInteger(a) == false | lastIsInteger(b) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public int countPrime(int m, int n)
        {
            return primeN.PrimesList(m, n);
        }
        public int lowPrime()
        {
            return primeN.firstPrime();
        }
        public int highPrime()
        {
            return primeN.lastPrime();
        }
       
    }
}
