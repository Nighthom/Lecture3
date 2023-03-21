using System;

namespace _3_7
{
    class Program
    {
        static int alphaToIndex(char c)
        {
            return c - 'a';
        }
        static char indexToAlpha(int index)
        {
            return (char)(index + 'a');
        }

        static char toLower(char c)
        {
            if ('A' <= c && c < 'a')
                return (char)(c + 0x20);
            return c;
        }
        static void Main(string[] args)
        {
            int[] alpha_count = new int[26];
            Console.WriteLine("문자열을 입력하세요(제한: 알파벳 A-Za-z 범위의 문자만 입력) :");
            string input = Console.ReadLine();

            foreach(var c in input)
            {
                char ch = toLower(c);
                alpha_count[alphaToIndex(ch)]++;
            }

            int max_count = 0;
            int max_alphabet_index = 0;
            for(int i = 0; i<alpha_count.Length; i++)
            {
                int count = alpha_count[i];
                if (max_count < count)
                {
                    max_count = count;
                    max_alphabet_index = i;
                }
            }

            Console.WriteLine("가장 많이 출력된 알파벳: " + indexToAlpha(max_alphabet_index));
            Console.WriteLine("출력된 횟수 : " + max_count);
        }
    }
}
