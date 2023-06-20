using System;

namespace Study_CSharp._04_데이터를가공하는연산자
{
    internal class _02_IncDecOperator
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a++);
            Console.WriteLine(++a);

            Console.WriteLine(a--);
            Console.WriteLine(--a);
        }
    }
}
