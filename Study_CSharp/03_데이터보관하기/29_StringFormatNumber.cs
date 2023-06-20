using System;
using static System.Console;

/*숫자 서식화

서식지정자         대상 서식             설명,예시
        D               10진수                입력된 수를 10진수로 서식화함.
                                                   WriteLine("{0:D}", 255);                                 //255
                                                   WriteLine("{0:D}", 0xFF);                                //255

        X               16진수                입력된 수를 16진수로 서식화함.
                                                    WriteLine("{0:X}", 255);                                 //0xFF
                                                    WriteLine("{0:X}", 0xFF);                                //0xFF

        N               콤마(,)로 묶어       입력된 수를 콤마로 구분하여 출력함 
                        표현한 수               WriteLine("{0:N}", 123456789);                       //123,456,789.00

        F               고정 소수점          입력된 수를 고정 소수점 형식으로 서식화함.
                                                    WriteLine("고정 소수점 : {0:F}", 123.45);           //123.45
        
        E               지수                    입력된 수를 지수 표기호 서식화함.
                                                    WriteLine("공학: {0:E}", 123.456789);               //1.234568E+002
*/


namespace Study_CSharp._03_데이터보관하기
{
    internal class _29_StringFormatNumber
    {
        static void Main(string[] args)
        {
            //D : 10진수
            WriteLine("10진수: {0:D}", 123);
            WriteLine("10진수: {0, 20:D}", 123);
            WriteLine("10진수: {0:D5}", 123);             
            
            //X : 16진수
            WriteLine("16진수: 0x{0:X}", 0xFF1234);
            WriteLine("16진수: 0x{0:X8}", 0xFF1234);

            //N : 숫자
            WriteLine("숫자: {0:N}", 123456789);
            WriteLine("숫자: {0:N0}", 123456789);     //자릿수 0은 소수점 이하를 제거함

            //F : 고정소수점
            WriteLine("고정 소수점 : {0:F}", 123.45);
            WriteLine("고정 소수점 : {0:F5}", 123.456);

            //E : 공학용
            WriteLine("공학: {0:E}", 123.456789);
        }
    }
}
