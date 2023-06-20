using System;

/* 케이스 가드
케이스 가드란 switch 문의 case 절의 패턴을 더 구체적으로 만들어주는 추가적인 조건 검사임.
케이스 가드는 case 절에 뒤에 when 절을 붙여 사용함.
when 절은 if문 처럼 true / false로 결과가 나오는 식을 입력받음.
 */

namespace Study_CSharp._05_코드의흐름제어하기
{
    internal class _05_SwitchWhen
    {
        static void Main(string[] args)
        {
            object obj = null;

            string s = Console.ReadLine();

            if (int.TryParse(s, out int out_i))    
                obj = out_i;
            else if (float.TryParse(s, out float out_f))
                obj = out_f;
            else
                obj = s;

            switch (obj)
            {
                case int:
                    Console.WriteLine($"{(int)obj}는 int 형식입니다.");
                    break;
                case float f when f >= 0:   //obj가 float 형식이며 0보다 크거나 같은 경우
                    Console.WriteLine($"{f}는 양의 float 형식입니다.");
                    break;
                case float:
                    Console.WriteLine($"{(float)obj}는 음의 float 형식입니다.");
                    break;
                default:
                    Console.WriteLine($"{obj}는 모르는 형식입니다.");
                    break;
            }
        }
    }
}
