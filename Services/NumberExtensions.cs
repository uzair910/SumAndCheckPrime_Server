using System;

namespace Services
{
    public static class NumberExtensions
    {
        public static bool IsPrime(this int iInput)
        {
            if (iInput <= 1)
            {
                return false;
            }
            if (iInput == 2)
            {
                return true;
            }
            else
            {
                for (int a = 2; a <= iInput / 2; a++)
                {
                    if (iInput % a == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
