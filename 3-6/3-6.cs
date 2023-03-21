using System;

namespace _3_6
{
    class Program
    {
        static bool isPrime(int num)
        {
            if (num == 0 || num == 1)
                return false;
            for(int i=2; i * i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            for(int i=1; i<=100; i++)
            {
                if (isPrime(i))
                    Console.WriteLine(i);
            }
        }
    }
}
