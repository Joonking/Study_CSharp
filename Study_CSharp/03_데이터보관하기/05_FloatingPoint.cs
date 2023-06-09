using System;

//float 는 단일 정밀도 부동 소수점 형식 (7개의 자릿수만 다룰 수 있음. 크기는 4바이트
//4바이트(32비트) = (앞에서 부터) 1비트 부호비트, 8비트 지수부, 23비트 가수부

//double은 복수 정밀도 부동 소수점 형식 15~16개의 자릿수를 다룰 수 있음. 크기는 8바이트

namespace Study_CSharp._03_데이터보관하기
{
    internal class _05_FloatingPoint
    {
        static void Main(string[] args)
        {
            float a = 3.1415_9265_3589_7932_3846f;
            Console.WriteLine(a);

            double b = 3.1415_9265_3589_7932_3846;
            Console.WriteLine(b);  

        }
    }
}
