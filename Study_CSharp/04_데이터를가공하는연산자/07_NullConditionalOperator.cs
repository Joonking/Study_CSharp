using System.Collections;
using static System.Console;

/* null 조건부 연산자

?. 가 하는일은 객체의 멤버에 접근하기 전에 해당 객체가 null인지 검사하여 
그 결과가 참이면 그 결과로 null을 반환하고
그렇지 않은 경우에는 . 뒤에 지정된 멤버를 반환함.

ex) 
class Foo
{
    public int member;
}
Foo foo = null;
int? bar;
if(foo == null)
    bar = null;
else
    bar = foo.member;

위의 코드를 ?.을 이용한다면

bar = foo?.member       //foo 객체가 null이 아니면 member 필드에 접근하게 해줌.

?[] 도 동일한  기능을 수행하는 연산자임. 비슷하지만 객체의 멤버 접근이 아니라
배열과 같은 컬렉션 객체의 첨자를 이용한 참조에 사용됨.
ex>
ArrayList a = null;
WriteLine($"{a?[0]}");

*/

namespace Study_CSharp._04_데이터를가공하는연산자
{
    internal class _07_NullConditionalOperator
    {
        static void Main(string[] args)
        {
            ArrayList a = null;
            a?.Add("야구");       //a?. 가 null을 반환하므로 Add() 메소드는 호출되지 않음.
            a?.Add("축구");
            WriteLine($"Count: {a?.Count}");  
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");

            a = new ArrayList();    //a는 더이상 null이 아님.
            a?.Add("야구");
            a?.Add("축구");
            WriteLine($"Count: {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");
        }
    }
}
