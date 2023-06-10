using System;

//크기가 서로 다른 정수 형식 사이의 변환

namespace Study_CSharp._03_데이터보관하기
{
    internal class _13_IntegralConversion
    {
        static void Main(string[] args)
        {
            sbyte a = 127;
            Console.WriteLine(a);

            int b  =(int)a;
            Console.WriteLine(b);

            int x = 128;                        //sbyte의 최댓값 127보다 1 큰수
            Console.WriteLine(x);

            sbyte y = (sbyte)x;                 //오버플로 발생
            Console.WriteLine(y);
        }
    }
}
