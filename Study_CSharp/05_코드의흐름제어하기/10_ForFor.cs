using System;

namespace Study_CSharp._05_코드의흐름제어하기
{
    internal class _10_ForFor
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
