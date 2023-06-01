namespace CSD
{
    internal class LeapYear
    {
        internal static bool IsLeapYear(int year) => 
            IsDividedBy(year, 400) || (!IsDividedBy(year, 100) && IsDividedBy(year, 4));

        private static bool IsDividedBy(int year, int n) => 
            year % n == 0;
    }
}