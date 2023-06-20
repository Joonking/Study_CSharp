using System;

namespace Study_CSharp._05_코드의흐름제어하기
{
    internal class _14_Break
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("계속할까요?(예/아니오) : ");
                string answer = Console.ReadLine();

                if (answer == "아니오")
                    break;
            }
        }
    }
}
