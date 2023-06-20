using System;

namespace Study_CSharp._05_코드의흐름제어하기
{
    internal class _15_Continue
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    continue;

                Console.WriteLine($"{i} : 홀수");
            }
        }
    }
}
