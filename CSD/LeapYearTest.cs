using NUnit.Framework;
namespace CSD
{
    public class LeapYearTest
    {
        [TestCase(2001, false)]
        [TestCase(2004, true)]
        [TestCase(2100, false)]
        [TestCase(2000, true)]
        public void TestLeapYears(int year, bool expected)
        {
            Assert.That(LeapYear.IsLeapYear(year), Is.EqualTo(expected));
        }
    }
}