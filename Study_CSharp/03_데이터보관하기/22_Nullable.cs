using System;

//Nullable 은 비어 있는 상태가 될 수 있는 형식이라는 뜻임.
//Nullable 형식의 변수를 선언할때는 데이터 형식 이름 뒤에 ? 를 붙임.
//int? a = null; 은 해당 변수를 비운다는 뜻임. int a = null; 이라고 하면 에러남.
//int 형식은 비워둘 수 없는(null 값을 가질 수 없는) 데이터 형식이기 때문임.

//모든 Nullable 형식은 HasValue 와 Value 두 가지 속성을 가짐.
//HasValue 속성은 해당 변수가 값을 갖고 있는지 또는 그렇지 않은지를 나타냄.
//Value 속성은 변수에 담겨있는 값을 나타냄.

namespace Study_CSharp._03_데이터보관하기
{
    internal class _22_Nullable
    {
        static void Main(string[] args)
        {
            int? a = null;

            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);

            a = 3;
            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);
            Console.WriteLine(a.Value);
        }
    }
}
