using System;

namespace _3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ans = new int[30];
            ans[0] = 1;
            ans[1] = 1;

            for (int num = 0; num < ans.Length; num++)
            {
                if(num >= 2)
                    ans[num] = ans[num - 1] + ans[num - 2];
                
                Console.WriteLine("fibonazzi(" + (num + 1) + "): " + ans[num]);
            }
        }
    }
}
