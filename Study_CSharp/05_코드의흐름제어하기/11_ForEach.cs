using System;

namespace Study_CSharp._05_코드의흐름제어하기
{
    internal class _11_ForEach
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4 };

            foreach (int i in arr) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
