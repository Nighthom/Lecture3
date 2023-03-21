using System;

namespace _3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("임의의 정수 n을 입력하시오: ");
            int input;
            while ((input = int.Parse(Console.ReadLine())) < 0)
            {
                Console.WriteLine("Error: 유효하지 않은 범위입니다. 다시 입력하세요. ");
                Console.Write("임의의 정수 n을 입력하시오: ");
            }
            
            if (input < 2)
            {
                Console.Write("팩토리얼 " + input + "의 값: 1");
                return;
            }

            int[] ans = new int[input + 1];
            ans[0] = 1;
            ans[1] = 1;
            int num = 2;

            do
            {
                ans[num] = num * ans[num - 1];
            } while (++num <= input);

            Console.Write("팩토리얼 " + input + "의 값: " + ans[input]);
        }
    }
}
