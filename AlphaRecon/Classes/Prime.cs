using AlphaRecon.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaRecon.Classes
{
    public class Prime : IPrime
    {
        public List<int> Get1000FirstPrimeNumber()
        {
            List<int> primeNumbers = new List<int>();
            int count = 0;
            for (int i = 2; count < 100; i++)
            {
                bool isPrime = true;
                int divider = 2;
                while (divider < i)
                {
                    if ((i % divider) == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    else
                    {
                        isPrime = true;
                    }
                    divider++;
                }
                if (isPrime)
                {
                    primeNumbers.Add(i);
                    count++;
                }  
            }
            return primeNumbers;

        }
    }
}
