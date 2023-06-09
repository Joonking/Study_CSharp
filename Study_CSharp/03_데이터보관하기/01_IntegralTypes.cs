using System;

namespace Study_CSharp._03_데이터보관하기
{
    internal class _01_IntegralTypes
    {
        static void Main(string[] args)
        {
            sbyte a = -10;
            byte b = 40;

            Console.WriteLine($"a={a}, b={b}");

            short c = -30000;
            ushort d = 60000;

            Console.WriteLine($"c={c}, d={d}");

            int e = -1000_000;  //정수 리터럴을 타이핑 할때 자릿수 구분자(_)를 사용하면 편리함
            uint f = 3_0000_0000;

            Console.WriteLine($"e={e}, f={f}");

            long g = -5000_0000_0000;

            ulong h = 200_0000_0000_0000_0000;

            Console.WriteLine($"g={g}, h={h}");
        }

    }
}
