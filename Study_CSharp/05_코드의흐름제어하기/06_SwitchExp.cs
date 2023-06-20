using System;

/* switch 식

식은 결과값을 만들 수 있는 연산자와 연산자의 조합임
switch 식을 사용하면 분기를 거쳐 값을 내야하는 경우 사용하면 좋음. 코드가 간편해지고 break 도 없음.

switch(score)               //switch 문
{
    case 90:
        grade = "A";
        break;
    default:
        grade = "F";
 }

bool tf = true;

string grade = score switch
{
    90  => "A",         //case가 빠지고 => 을 쓰고 콤마로 구분함.
    80 when tf == true => "B+",             //케이스 가드 (추가적인 분기 처리)
    _    => "F"         //default 키워드는 _ 무시패턴으로 변경
}
 */

namespace Study_CSharp._05_코드의흐름제어하기
{
    internal class _06_SwitchExp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("점수를 입력하세요");
            int score = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("재수강인가요? (y/n)");
            string line = Console.ReadLine();
            bool repeated = line == "y" ? true : false;

            string grade = (int)(Math.Truncate(score / 10.0) * 10) switch
            {
                90 when repeated == true => "B+",       //케이스 가드  90이어도 repeated이 true면 B+
                90 => "A",
                80 => "B",
                70 => "C",
                60 => "D",
                _ => "F"                //무시 패턴 나중에 다룸
            };

            Console.WriteLine($"학점 : {grade}");
        }
    }
}
