using System;

//출력 전용 매개변수 out은 ref에는 없는 안전 장치가 있음.
//ref 키워드를 이용해서 매개변수를 넘기는 경우 메소드가 해당 매개변수에 결과를 저장하지 않아도
//컴파일러는 아무런 경고를 하지 않음. 
//반면에 out 키워드를 이용해서 매개변수를 넘길때는 메소드가 해당 매개변수에 결과를 저장하지 않으면
//컴파일러가 에러 메시지를 출력함.
//또한 메소드를 호출하는 쪽에서는 초기화하지 않은 지역변수를 메소드의 out 매개변수로 넘길 수 잇음.
//컴파일러가 호출당하는 메소드에서 그 지역 변수를 할당할 것을 보장하기 때문임.

namespace Study_CSharp._06_메소드로코드간추리기
{
    internal class _06_UsingOut
    {
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;

            Divide(a, b, out int c, out int d);  
            // 출력 전용 매개변수는 메소드를 호출하기 전에 미리 선언 할 필요가 없음.
            //호출할 때 매개변수 목록 안에서 즉석으로 선언하면 됨.

            Console.WriteLine($"a:{a}, b:{b}, a/b:{c}, a%b:{d}");
        }
    }
}
