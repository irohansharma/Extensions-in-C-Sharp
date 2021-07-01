using System;
using System.Collections.Generic;
using System.Text;

namespace Extension
{
    public static class IntegerExtention
    {
        public static bool IsGreater(this int i , int x)
        {

            return i > x;
        }

        public static bool IsOdd(this int i)
        {

            return (i%2==1);
        }

        public static bool IsEven(this int i)
        {

            return (i % 2 == 0);
        }

        public static bool IsPrime(this int i)
        {
            for (int j = 3; j * j <= i; j++)
            {
                if (i % j == 0)
                    return false;
            }

            return true;           
        }

        public static bool IsDivisibleBy(this int i, int x)
        {
            return (i%x==0);
        }


    }
}
