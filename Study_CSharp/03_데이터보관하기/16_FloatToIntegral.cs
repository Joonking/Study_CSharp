using System;

//부동 소수점 형식과 정수 형식 사이의 변환
//부동 소수점 형식의 변수를 정수 형식으로 변환하면 데이터에서 소수점 아래는 버리고
//소수점 위의 값만 남김.
//0.1을 변환하면 0 0.9를 변환해도 0 즉, 반올림은 없음.

namespace Study_CSharp._03_데이터보관하기
{
    internal class _16_FloatToIntegral
    {
        static void Main(string[] args)
        {
            float a = 0.9f;
            int b = (int)a; 
            Console.WriteLine(b);

            float c = 1.1f;
            int d = (int)c;
            Console.WriteLine(d);
        }
    }
}
