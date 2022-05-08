using System;
using System.Linq;

namespace Services
{
    public static class StringExtensions
    {
        public static int GetSpecialSum(this string sInput)
        {
            try
            {
                return sInput?.Split(",").Sum(x => int.Parse(x)) ?? 0;
            }
            catch
            {
                return int.MinValue;
            }
        }
    }
}
