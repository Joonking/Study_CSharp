using System;

namespace Study_CSharp._04_데이터를가공하는연산자
{
    internal class _06_ConditionalOperator
    {
        static void Main(string[] args)
        {
            string result = (10 % 2) == 0 ? "짝수" : "홀수";

            Console.WriteLine(result);
        }
    }
}
