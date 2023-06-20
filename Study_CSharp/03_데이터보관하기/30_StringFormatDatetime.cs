using System;
using System.Globalization;
using static System.Console;

/* 날짜및 시간 서식화
 
서식지정자       대상서식        설명
    y                   연도          - yy : 두자릿수 연도(2023-03-08 21:18:22 -> 23)
                                        - yyyy : 네 자릿수 연도(2023-03-08 21:18:22 -> 2023) 
 
    M                   월           - M : 한 자릿수 월(2023-03-08 21:18:22 -> 3)
                                        - MM : 두 자릿수 월(2023-03-08 21:18:22 -> 03)

    d                    일           - d : 한 지릿수 일(2023-03-08 21:18:22 -> 8)
                                        - dd : 두 자릿수 일(2023-03-08 21:18:22 -> 08)

    h                   시(1~12)     - h : 한 자릿수 시(2023-03-08 21:18:22 -> 9)
                                         - hh 두 자릿수 시(2023-03-08 21:18:22 -> 09)

    H                   시(0~23)     - H : 한 자릿수 시(2023-03-08 21:18:22 -> 21)
                                         - HH : 두 자릿수 시(2023-03-08 21:18:22 ->21)

    m                   분           - m : 한 자릿수 분(2023-03-08 21:18:22 -> 18)
                                        - mm : 두 자릿수 분(2023-03-08 21:18:22 -> 18)
    
    s                    초           - s : 한 자릿수 초(2023-03-08 21:18:22 -> 22)
                                       - ss : 두 자릿수 초(2023-03-08 21:18:22 -> 22)

    tt                  오전/오후      

    ddd                 요일          - ddd : 약식요일 -> 토
                                          - dddd : 전체요일 -> 토요일


 */

namespace Study_CSharp._03_데이터보관하기
{
    internal class _30_StringFormatDatetime
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023, 03, 04, 23, 18, 22);

            WriteLine("12시간 형식: {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
            WriteLine("24시간 형식: {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt);

            CultureInfo ciKo = new CultureInfo("ko-KR");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciKo));
            WriteLine(dt.ToString(ciKo));

            CultureInfo ciEn = new CultureInfo("en-US");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciEn));
            WriteLine(dt.ToString(ciEn));
        }
    }
}





