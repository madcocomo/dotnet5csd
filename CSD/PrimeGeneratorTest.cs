using NUnit.Framework;
namespace CSD
{
    [TestFixture]
    public class PrimeGeneratorTest
    {
        [Test]
        public void TestPrimes()
        {
            int[] nullArray = new PrimeGenerator().GeneratePrimes(0);
            Assert.AreEqual(0, nullArray.Length);

            int[] minArray = new PrimeGenerator().GeneratePrimes(2);
            Assert.AreEqual(1, minArray.Length);
            Assert.AreEqual(2, minArray[0]);

            int[] threeArray = new PrimeGenerator().GeneratePrimes(3);
            Assert.AreEqual(2, threeArray.Length);
            Assert.AreEqual(2, threeArray[0]);
            Assert.AreEqual(3, threeArray[1]);

            int[] centArray = new PrimeGenerator().GeneratePrimes(100);
            Assert.AreEqual(25, centArray.Length);
            Assert.AreEqual(97, centArray[24]);
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