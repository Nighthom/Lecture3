using System;

namespace _3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("임의의 양수 n을 입력하시오 : ");
            int input = int.Parse(Console.ReadLine());

            Console.Write(input + "의 약수: [");
            for(int num = 1; num <= input / 2; num++)
            {
                if (input % num == 0)
                    Console.Write(num + ", ");
            }
            Console.Write(input);
            Console.Write("]");
        }
    }
}
