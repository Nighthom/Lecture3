using System;

namespace _3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("임의의 정수 n을 입력하시오: ");
            int input = int.Parse(Console.ReadLine());

            if (input == 0)
                Console.Write("팩토리얼 0의 값: 1");

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
