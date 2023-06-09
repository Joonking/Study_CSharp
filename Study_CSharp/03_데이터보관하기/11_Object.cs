using System;

//C#은 object가 모든 데이터를 다룰 수 있도록 하기 위해 특별한 조치를 취했음.
//모든 데이터 형식(기본데이터 형식 뿐 아니라 모든 복합 데이터 형식, 심지어는 프로그래머가 만드는
//데이터 형식 마저도)이 자동으로 object 형식으로부터 상속 받게 한거임.
//다시 말해 object 형식이 모든 데이터 형식의 조상
//컴파일러는 어떤 형식의 데이터라도 object에 담아 처리 할 수 있음.

namespace Study_CSharp._03_데이터보관하기
{
    internal class _11_Object
    {
        static void Main(string[] args)
        {
            object a = 123;
            object b = 3.1415_9265_3589_7932_3846_2643_3832_79m;
            object c = true;
            object d = "안녕하세요.";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
