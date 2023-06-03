using NUnit.Framework;
using FluentAssertions;
namespace CSD
{
    [TestFixture]
    public class PrimeGeneratorTest
    {

        [TestCase(0, new int[] { })]
        [TestCase(2, new int[] { 2 })]
        [TestCase(3, new int[] { 2, 3 })]
        [TestCase(100, new int[] {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 
            43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97})]
        public void TestPrimes(int maxValue, int[] expect)
        { 
            new PrimeGenerator().GeneratePrimes(maxValue)
                .Should().Equal(expect);
        }

        [Test]
        public void TestExhaustive()
        {
            for (int i = 2; i < 500; i++)
            {
                VerifyPrimeList(new PrimeGenerator().GeneratePrimes(i));
            }
        }

        private void VerifyPrimeList(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                VerifyPrime(list[i]);
            }
        }

        private void VerifyPrime(int n)
        {
            for (int factor = 2; factor < n; factor++)
            {
                Assert.IsTrue(n % factor != 0);
            }
        }
    }
}