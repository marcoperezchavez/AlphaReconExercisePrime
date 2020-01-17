using AlphaRecon.Classes;
using AlphaRecon.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlphaReconPrimeTest
{
    [TestClass]
    public class AlphaReconPrimeTest
    {
        [TestMethod]
        public void CountResultListPrime100FirstNumbers()
        {
            IPrime prime = new Prime();
            int resultado = 1000;

            var listPrime = prime.Get1000FirstPrimeNumber();

            Assert.AreEqual(listPrime.Count, resultado);
        }
    }
}
