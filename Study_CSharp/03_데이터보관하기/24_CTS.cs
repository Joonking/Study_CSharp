using System;

//CTS(Common Type System) : 공용형식 시스템
// '모두가 함께 사용하는 데이터 형식 체계' 라는 의미임.
// 모두는 C#을 비롯한 .NET을 지원하는 모든 언어를 뜻함.
// .NET 언어들끼리 서로 호환성을 갖도록 하기 위해서 만듬.
// 기본 데이터 형식이 CTS에서 어떻게 정의 되어있는지는 책 94p를 볼것.

namespace Study_CSharp._03_데이터보관하기
{
    internal class _24_CTS
    {
        static void Main(string[] args)
        {
            System.Int32 a = 123;
            int b = 456;

            Console.WriteLine("a type : {0}, value : {1}", a.GetType().ToString(), a);
            Console.WriteLine("b type : {0}, value : {1}", b.GetType().ToString(), b);

            System.String c = "abc";
            string d = "def";

            Console.WriteLine("c type : {0}, value : {1}", c.GetType().ToString(), c);
            Console.WriteLine("d type : {0}, value : {1}", d.GetType().ToString(), d);
        }
    }
}
