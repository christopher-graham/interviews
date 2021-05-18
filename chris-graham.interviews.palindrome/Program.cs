using System;
using System.Text;

namespace chris_graham.interviews.palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var temp = new StringBuilder();

            for(int i = input.Length -1; i >= 0; i--)
            {
                temp.Append(input[i]);

                if(temp.ToString() == input)
                {
                    Console.WriteLine("String is a palindrome|");
                    Console.ReadKey();
                    return;
                }
            }

            Console.WriteLine("String is not a palindrome");
            Console.ReadKey();
        }
    }
}
