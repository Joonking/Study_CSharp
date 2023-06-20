using System;

namespace Study_CSharp._05_코드의흐름제어하기
{
    internal class _07_While
    {
        static void Main(string[] args)
        {
            int i = 10;

            while (i > 0)
            {
                Console.WriteLine($"i : {i--}");
            }
        }
    }
}
