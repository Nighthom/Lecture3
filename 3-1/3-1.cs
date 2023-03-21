using System;

namespace Lecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int sum = 0;

            while(true)
            {
                num++;
                if (num > 1000)
                    break;
                if (num % 3 == 0 || num % 5 == 0)
                    sum += num;
            }
            Console.Write("1부터 1000까지의 정수 중 3 또는 5의 배수들의 합: " + sum);
        }
    }
}
