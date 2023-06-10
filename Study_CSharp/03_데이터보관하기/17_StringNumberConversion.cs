using System;

//문자열을 숫자로, 숫자를 문자열로

//parse() : 문자열 -> 숫자로
//C#은 정수계열 형식, 부동 소수점 형식 모두에게 Parse() 라는 메소드를 넣어놨음.
//이 메소드는 문자열을 넘겨주면 숫자로 반환해줌.

//ToString() : 숫자 -> 문자열로
//C#은 숫자 데이터 형식을 문자열로 바꾸는 방법을 마련해놨음.
//object로 부터 물려받은 ToString() 함수를 재정의했음.

namespace Study_CSharp._03_데이터보관하기
{
    internal class _17_StringNumberConversion
    {
        static void Main(string[] args)
        {
            int a = 123;
            string b = a.ToString();
            Console.WriteLine(b);

            float c = 3.14f;
            string d = c.ToString();
            Console.WriteLine(d);

            string e = "123456";
            int f = Convert.ToInt32(e);
            Console.WriteLine(f);

            string g = "1.2345";
            float h = float.Parse(g);
            Console.WriteLine(h);   
        }
    }
}



