using System;

/* 로컬함수
로컬함수는 메소드 안에서 선언되고, 선언된 메소드 안에서만 사용되는 특별한 함수임.
클래스의 멤버가 아니기에 메소드가 아니라 함수라고 부름
로컬함수는 자신이 존재하는 지역에 선언되어 있는 변수를 사용할 수 있음.
로컬함수는 자신이 속한 메소드의 지역변수를 사용할 수 있음.
*/

namespace Study_CSharp._06_메소드로코드간추리기
{
    internal class _11_LocalFunction
    {
        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }

            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90) // A~Z의 ASCII 값 : 65 : 90
                    return arr[i];
                else // a~z의 ASCII 값 : 97 : 122
                    return (char)(arr[i] + 32);
            }

            return new string(arr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerString("Hello!"));
            Console.WriteLine(ToLowerString("Good Morning."));
            Console.WriteLine(ToLowerString("This is C#."));
        }
    }
}
