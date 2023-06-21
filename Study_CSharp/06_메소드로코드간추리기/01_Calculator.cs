using System;

namespace Study_CSharp._06_메소드로코드간추리기
{
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(in int a, in int b)
        {
            return a - b;
        }
    }

    internal class _01_Calculator
    {
        public static void Main()
        {
            int result = Calculator.Plus(3, 4);
            Console.WriteLine(result);

            result = Calculator.Minus(5, 2);
            Console.WriteLine(result);
        }
    }
}
