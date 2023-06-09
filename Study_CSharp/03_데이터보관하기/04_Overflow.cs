using System;


namespace Study_CSharp._03_데이터보관하기
{
    internal class _04_Overflow
    {
        static void Main(string[] args)
        {
            uint a = uint.MaxValue;     //uint의 최댓값 4294967295
            Console.WriteLine(a);

            a = a + 1;
            Console.WriteLine(a);

            //uint 최댓값에 1을 더했을때 오버플로가 생겨 0으로 돌아감.
            //최댓값을 넘어갈때는 오버플로
            //최솟값을 넘어갈때는 언더플로

            int b = int.MaxValue;
            Console.WriteLine(b);

            b = b + 1;
            Console.WriteLine(b);
        }
    }
}
