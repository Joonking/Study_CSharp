using System;


namespace Study_CSharp._03_데이터보관하기
{
    internal class _09_Multiline
    {
        static void Main(string[] args)
        {
            //큰따옴표 세개 붙여쓰면 여러줄로 이어진 문자열 리터럴을 만들 수 있음.
            string multiline = """
                별 하나에 추억과
                별 하나에 사랑과
                별 하나에 쓸쓸함과
                별 하나에 동경과
                별 하나에 시와
                별 하나에 어머니, 어머니
                """;
        
            Console.WriteLine(multiline);
        
        }
    }
}
