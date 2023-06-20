using System;

/* null 병합 연산자
null 병합 연산자 ??는 변수/객체의 null 검사를 간결하게 해줌
ex> Console.WriteLine($"{num ?? 0}");   num이 null이면 오른쪽 0이 출력, null이 아니면 왼쪽 num의 값 출력
 */

namespace Study_CSharp._04_데이터를가공하는연산자
{
    internal class _11_NullCoalescing
    {
        static void Main(string[] args)
        {
            int? num = null;
            Console.WriteLine($"{num ?? 0}");           //null이면 오른쪽

            num = 99;
            Console.WriteLine($"{num ?? 0}");           //null이 아니면 왼쪽에 든 값 출력

            string str = null;
            Console.WriteLine($"{str ?? "Defalut"}");

            str = "Specific";
            Console.WriteLine($"{str ?? "Default"}");
        }
    }
}
