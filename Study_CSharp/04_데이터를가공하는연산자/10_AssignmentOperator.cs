using System;
using static System.Console;

namespace Study_CSharp._04_데이터를가공하는연산자
{
    internal class _10_AssignmentOperator
    {
        static void Main(string[] args)
        {
            int a;
            WriteLine($"a = 100 : {a = 100}");
            WriteLine($"a += 90 : {a += 90}");
            WriteLine($"a -= 80 : {a -= 80}");
            WriteLine($"a *= 70 : {a *= 70}");
            WriteLine($"a /= 60 : {a /= 60}");
            WriteLine($"a %= 50 : {a %= 50}");
            WriteLine($"a &= 40 : {a &= 40}");
            WriteLine($"a |= 30 : {a |= 30}");
            WriteLine($"a ^= 20 : {a ^= 20}");
            WriteLine($"a <<= 10: {a <<= 10}");
            WriteLine($"a >>= 1 : {a >>= 1}");

            int? b = null;
            WriteLine($"b ?? 10 : {b ?? 10}");
        }
    }
}
