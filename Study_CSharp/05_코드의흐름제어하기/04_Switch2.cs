using System;

//switch의 형식 패턴

namespace Study_CSharp._05_코드의흐름제어하기
{
    internal class _04_Switch2
    {
        static void Main(string[] args)
        {
            object obj = null;

            string s = Console.ReadLine();

            /*TryParse() 와 Parse() 의 차이
            Parse() 메소드는 문자열을 숫자로 변환하는 메소드임.
            이 메소드는 변환이 실패하면 예외를 던짐.
            예외가 던져지면 프로그램은 현재 코드의 실행을 멈추고 흐름을 다른곳으로 이동함.

            반면 TryParse() 메소드는 변환의 성공 여부를 반환하기에 현재의 코드 흐름을 유지할 수 있음.
            TryParse()가 변환한 데이터는 두번째 매개변수에 저장됨.
             */

            if (int.TryParse(s, out int out_i))     //out int out_i 에서 out키워드는 출력 전용 매개변수임 나중에 설명
                obj = out_i;
            else if (float.TryParse(s, out float out_f))
                obj = out_f;
            else
                obj = s;

            switch(obj)
            {
                case int:
                    Console.WriteLine($"{(int)obj}는 int 형식입니다.");
                    break;
                case float:
                    Console.WriteLine($"{(float)obj}는 float 형식입니다.");
                    break;
                default:
                    Console.WriteLine($"{obj}는 모르는 형식입니다.");
                    break;
            }
        }
    }
}



