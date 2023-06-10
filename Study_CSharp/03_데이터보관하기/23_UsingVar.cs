using System;

//var : 데이터 형식을 컴파일러가 판단
//var 키워드를 통해서 약한 형식 검사를 지원함.
//var를 사용해서 변수를 선언하면 컴파일러가 자동으로 해당 변수의 형식을 지정해줌.
//단, var 키워드를 이용해서 변수를 선언하려면 반드시 선언과 동시에 초기화 해줘야함.

//var는 지역변수로만 사용할 수 있음.
//클래스의 필드를 선언할 때는 반드시 명시적 형식을 선언해야함.
//클래스의 필드는 선언과 같이 초기화 하지 않는 경우가 많은데
//(보통 생성자에서 초기화 하는 경우가 대부분이라)
//var 키워드로 필드를 선언하면 컴파일러가 무슨 형식인지 파악할 길이 없기 때문임.

//참고로 C#은 전역변수를 지원하지 않음.

namespace Study_CSharp._03_데이터보관하기
{
    internal class _23_UsingVar
    {
        static void Main(string[] args)
        {
            var a = 20;         //var로 선언하는 변수는 반드시 초기화 해야함.
            Console.WriteLine("Type : {0}, Value : {1}", a.GetType(), a);

            var b = 3.1414213;
            Console.WriteLine("Type : {0}, Value : {1}", b.GetType(), b);

            var c = "Hello, World";
            Console.WriteLine("Type : {0}, Value : {1}", c.GetType(), c);

            var d = new int[] { 10, 20, 30 };
            Console.Write("Type : {0}, Value : ", d.GetType());
            foreach (var e in d)
                Console.Write("{0} ", e);

            Console.WriteLine();
        }
    }
}
