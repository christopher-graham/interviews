using System;

namespace chris_graham.interviews.primenumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number to check Prime: ");
            int input = int.Parse(Console.ReadLine());

            var isPrime = IsPrime(input);

            if (isPrime)
                Console.Write("Number is prime.");
            else
                Console.WriteLine("Number is not prime.");
        }

        private static bool IsPrime(int input)
        {
            if (input <= 1) return false;
            if (input == 2) return true;

            int i;
            for (i = 2; i <= input - 1; i++)
            {
                if (input % i == 0)
                {
                    return false;
                }
            }

            if (i == input)
            {
                return true;
            }

            return false;
        }
    }
}
