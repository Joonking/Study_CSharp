using System;

namespace Study_CSharp._05_코드의흐름제어하기
{
    internal class _13_InfiniteWhile
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
                Console.WriteLine(i++);
        }
    }
}
