using System;

namespace _3_8
{
    class Program
    {
        static char toUpper(char c)
        {
            if ('a' <= c && c <= 'z')
                return (char)(c - 0x20);
            return c;
        }
        static void Main(string[] args)
        {
            Console.Write("변환할 문자열을 입력하세요: ");
            string[] input = Console.ReadLine().Split(" ");

            string output = "";
            foreach(var word in input)
            {
                var firstCh = toUpper(word[0]);
                output += firstCh;

                for (int i = 1; i < word.Length; i++)
                    output += word[i];
                output += " ";
            }
            Console.WriteLine("전환 결과: " + output);
        }
    }
}
