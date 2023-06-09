using System;

//C#은 2진수를 0b
//        16진수는 0X 또는 0x 접두사를 이용하여 표현 가능.


namespace Study_CSharp._03_데이터보관하기
{
    internal class _02_IntegerLiterals
    {
        static void Main(string[] args)
        {
            byte a = 240;                           //10진수 리터럴
            Console.WriteLine($"a={a}");

            byte b = 0b1111_0000;               //2진수 리터럴
            Console.WriteLine($"b={b}");

            byte c = 0XF0;                           //16진수 리터럴
            Console.WriteLine($"c={c}");

            uint d = 0x1234_abcd;                 //16진수 리터럴
            Console.WriteLine($"d={d}");
        }
    }
}
