using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_CSharp._06_메소드로코드간추리기
{
    internal class _04_SwapByRef
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine($"x:{x}, y:{y}");

            Swap(ref x, ref y);

            Console.WriteLine($"x:{x}, y:{y}");
        }
    }
}
