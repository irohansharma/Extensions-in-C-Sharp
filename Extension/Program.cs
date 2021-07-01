using System;

namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 100;

            if (value.IsGreater(50))
            {
                Console.WriteLine("Yes Greater");
            }
            else
            {
                Console.WriteLine("NOT Greater");

            }

            if (value.IsOdd())
            {
                Console.WriteLine("Odd");
            }
            else
            {
                Console.WriteLine("NOT Odd");

            }

            if (value.IsEven())
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("NOT Even");

            }

            if (value.IsDivisibleBy(35))
            {
                Console.WriteLine("Yes Divisible");
            }
            else
            {
                Console.WriteLine("NOT Divisible");

            }

        }
    }
}
