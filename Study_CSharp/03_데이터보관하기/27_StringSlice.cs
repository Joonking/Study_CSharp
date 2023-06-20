using System;
using System.Security.Cryptography.X509Certificates;
using static System.Console;


//Split()               지정된 문자를 기준으로 현재 문자열을 분리한 다음 분리한 문자열의 배열을 반환
//SubString()        현재 문자열의 지정된 위치로부터 지정된 수만큼의 문자로 이루어진 새 문자열을 반환

namespace Study_CSharp._03_데이터보관하기
{
    internal class _27_StringSlice
    {
        static void Main(string[] args)
        {
            String greeting = "Good morning.";

            WriteLine(greeting.Substring(0, 5));        //"Good"
            WriteLine(greeting.Substring(5));           //"moring"
            WriteLine();

            //공백을 기준으로 string을 나누고 string 배열로 반환
            string[] arr = greeting.Split(new string[] {" "}, StringSplitOptions.None);
            //string[] arr = greeting.Split(" ", StringSplitOptions.None); 이렇게 해도됨.

            //구분할것이 string이 아니고 문자라면
            //greeting.Split(new char[]{' '}); 만 써주면됨
            //string일때는 두번째 매개변수 StringSplitOptions.None을 써야함
            //StringSplitOptions.RemoveEmptyEntries 옵션은 내용이 없는 공백이 연속으로 있을 경우 Split에 담을 배열에서 제거하겠다는 뜻임.
            WriteLine("Word Count : {0}", arr.Length);

            foreach(string element in arr)
            {
                WriteLine("{0}", element);
            }
        }
    }
}
