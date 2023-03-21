using System;

namespace _3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int num=1; num<=100; num++)
            {
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                if(num % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                if (num % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }
                Console.WriteLine(num);
            }
        }
    }
}
