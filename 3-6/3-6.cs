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
            int sum = 0;
            for(int i=1; i<=100; i++)
            {
                if (isPrime(i))
                    sum += i;
            }
            Console.WriteLine("1부터 100까지의 정수 중 소수의 합 : " + sum);
        }
    }
}
