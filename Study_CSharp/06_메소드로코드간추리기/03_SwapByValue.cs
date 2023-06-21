using System;

namespace Study_CSharp._06_메소드로코드간추리기
{
    internal class _03_SwapByValue
    {
        public static void Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine("x:{0}, y:{1}", x, y);

            Swap(x, y);

            Console.WriteLine("x:{0}, y:{1}", x, y);
        }
    }
}
