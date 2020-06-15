using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Avast.Utilities.Test
{
    [TestClass]
    public class PrimeNumbersTest
    {
        [TestMethod]
        public void GetListofPrimeNumbers_Should_return_not_null()
        {
            PrimeNumbers primeNumbers = new PrimeNumbers();
            var primeNumbersList= primeNumbers.GetListofPrimeNumbers(100);
            Assert.IsNotNull(primeNumbersList);
        }

        [TestMethod]
        public void GetListofPrimeNumbers_first_prime_number_is_2()
        {
            PrimeNumbers primeNumbers = new PrimeNumbers();
            var primeNumbersList = primeNumbers.GetListofPrimeNumbers(100);
            Assert.AreEqual(primeNumbersList.ToList()[0], 2);
        }


        [TestMethod]
        public void GetListofPrimeNumbers_list_count_same_as_input_number()
        {
            PrimeNumbers primeNumbers = new PrimeNumbers();
            int count = 100;
            var primeNumbersList = primeNumbers.GetListofPrimeNumbers(count);
            Assert.AreEqual(primeNumbersList.Count(), count);
        }

        [TestMethod]
        public void GetListofPrimeNumbers_one_element_basic_test()
        {
            PrimeNumbers primeNumbers = new PrimeNumbers();
            var primeNumbersList = primeNumbers.GetListofPrimeNumbers(1);
            Assert.IsNotNull(primeNumbersList);
            Assert.AreEqual(primeNumbersList.ToList()[0], 2);
        }

    }
}
