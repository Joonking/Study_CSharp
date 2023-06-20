using System;

namespace Study_CSharp._05_코드의흐름제어하기
{
    internal class _08_DoWhile
    {
        static void Main(string[] args)
        {
            int i = 10;

            do
            {
                Console.WriteLine($"a) i : {i--}");
            }
            while (i > 0);

            do
            {
                Console.WriteLine($"b) i : {i--}");
            }
            while (i > 0);
        }
    }
}
