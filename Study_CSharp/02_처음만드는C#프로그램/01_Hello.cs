using System;
using static System.Console;

namespace Study_CSharp._02_처음만드는C_프로그램
{
    internal class _01_Hello
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            WriteLine("Hello, {0}!", str);
        }
    }
}
