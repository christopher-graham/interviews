using System;

namespace chris_graham.interviews.fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodOne();
            Console.ReadKey();
        }

        public static void MethodOne()
        {
            for (int i = 0; i < 100; i++)
            {
                var output = string.Empty;

                if (i % 3 == 0)
                    output += "Fizz";

                if (i % 5 == 0)
                    output += "Buzz";

                Console.WriteLine(output);
            }
        }

        public static void MethodTwo()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }
        }
    }
}
