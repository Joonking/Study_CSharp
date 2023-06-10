using System;

//부호 있는 정수 형식과 부호 없는 정수 형식 사이의 변환

namespace Study_CSharp._03_데이터보관하기
{
    internal class _15_SignedUnsignedConversion
    {
        static void Main(string[] args)
        {
            int a = 500;
            Console.WriteLine(a);   

            uint b = (uint)a;  
            Console.WriteLine(b);

            int x = -30;
            Console.WriteLine(x);

            uint y = (uint)x;                   //언더플로
            Console.WriteLine(y);  
        }
    }
}
