using System;

namespace Study_CSharp._04_데이터를가공하는연산자
{
    internal class _01_ArithmaticOperators
    {
        static void Main(string[] args)
        {
            int a = 111 + 222;
            Console.WriteLine($"a : {a}");

            int b = a - 100;
            Console.WriteLine($"b : {b}");

            int c = b * 10;
            Console.WriteLine($"c : {c}");

            double d = c / 6.3;     //피연산자 중 한쪽이 부동 소수형이면 부동 소수형 버전의 연산자가 사용되며,
                                         // 나머지 피연산자도 부동 소수형으로 형식 변환됨.
            Console.WriteLine($"d : {d}");

            Console.WriteLine($"22 / 7 = {22 / 7}({22 % 7})");
        }
    }
}
