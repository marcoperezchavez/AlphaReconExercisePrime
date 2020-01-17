using AlphaRecon.Classes;
using AlphaRecon.Interfaces;
using System;

namespace AlphaRecon
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrime _prime = new Prime();
            var listPrime = _prime.Get1000FirstPrimeNumber();
            foreach(var lis in listPrime)
            {
                Console.WriteLine(lis);
            }

        }
    }
}
