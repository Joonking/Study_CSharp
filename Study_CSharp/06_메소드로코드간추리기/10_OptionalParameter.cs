using System;

namespace Study_CSharp._06_메소드로코드간추리기
{
    internal class _10_OptionalParameter
    {
        static void PrintProfile(string name, string phone = "")
        {
            Console.WriteLine("Name:{0}, Phone:{1}", name, phone);
        }

        static void Main(string[] args)
        {
            PrintProfile("중근");
            PrintProfile("관순", "010-123-1234");
            PrintProfile(name: "봉길");
            PrintProfile(name: "동주", phone: "010-789-7890");
        }
    }
}
