using System;

namespace Study_CSharp._05_코드의흐름제어하기
{
    internal class _12_InfiniteFor
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (; ; )      //무한 for문
                Console.WriteLine(i++);
        }
    }
}
