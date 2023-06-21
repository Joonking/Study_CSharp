using System;

/* 가변 개수의 인수

가변 개수의 인수란, 그 개수가 유연하게 변할 수 있는 인수를 말함.
가변 개수의 인수는 params 키워드와 배열을 이용해서 선언함.
int Sum(params int[] args)      //Sum 메소드에 입력한 모든 매개변수는 args 배열에 담김

가변 개수의 인수는 형식은 같으나 인수의 개수만 유연하게 달라질 수 있는 경우에 적함함.

*/

namespace Study_CSharp._06_메소드로코드간추리기
{
    internal class _08_UsingParams
    {
        static int Sum(params int[] args)
        {
            Console.Write("Summing.. ");

            int sum = 0;
            for(int i=0;i<args.Length; i++)
            {
                if (i > 0)
                    Console.Write(", ");
                Console.Write(args[i]);
                sum += args[i];

            }
            Console.WriteLine();
            return sum; 
        }

        static void Main(string[] args)
        {
            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine($"Sum : {sum}");
        }
    }
}
