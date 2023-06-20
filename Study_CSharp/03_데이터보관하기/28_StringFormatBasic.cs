using System;
using static System.Console;

/*
Format() 메소드의 사용방법은 Console.WriteLine() 메소드와 똑같음.
WriteLine 메소드가 내부적으로 string.Format() 메소드를 사용함.
문자열 틀에 입력하는 {0}, {1} .. 을 서식항목(Format Item)이라고 함
{첨자, 맞춤: 서식문자열} 로 이루어짐. 

왼쪽/오른쪽 맞춤
{0,-10} : 왼쪽부터 문자를 채우는데 10칸안에 채움. 
{0, 10} : 오른쪽부터 문자를 채우고 10칸안에 채움.
*/
namespace Study_CSharp._03_데이터보관하기
{
    internal class _28_StringFormatBasic
    {
        static void Main(string[] args)
        {
            string fmt = "{0,-20}{1,-15}{2,30}";

            WriteLine(fmt, "Publisher", "Author", "Title");
            WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            WriteLine(fmt, "Hanbit", "KimMin Joon", "This is C#");
            WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Language");

            WriteLine("Total : {0, -7: D}", 123);
        }
    }
}
