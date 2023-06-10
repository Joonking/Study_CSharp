using static System.Console;

//문자열 다루기

//함수명                           설명
//IndexOf()                 현재 문자열 내에서 찾으려고 하는 지정된 문자 또는 문자열의 위치를 찾음.
//LastIndexOf()            현재 문자열 내에서 찾으려고 하는 지정된 문자 또는 문자열의 위치를 뒤에서 부터 찾음.
//StartsWith()              현재 문자열이 지정된 문자열로 시작하는지를 평가함.
//EndsWith()               현재 문자열이 지정된 문자열로 끝나는지를 평가함.
//Contains()                현재 문자열이 지정된 문자열을 포함하는지를 평가함.
//Replace()                 현재 문자열에서 지정된 문자열이 다른 지정된 문자열로 모두 바뀐 새 문자열을 반환함.


namespace Study_CSharp._03_데이터보관하기
{
    internal class _25_StringSearch
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            WriteLine(greeting);
            WriteLine();

            //IndexOf()
            WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));
            WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o'));

            //LastIndexOf()
            WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));
            WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf('o'));

            //StartsWith()
            WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));
            WriteLine("StartsWith 'Morning' : {0}", greeting.StartsWith("Morning"));

            //EndsWith()
            WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good"));
            WriteLine("EndsWith 'Morning' : {0}", greeting.EndsWith("Morning"));

            //Contains()
            WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));
            WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));

            //Replace()
            WriteLine("Replace 'Morning' with 'Evening' : {0}", greeting.Replace("Morning", "Evening"));
        }
    }
}

