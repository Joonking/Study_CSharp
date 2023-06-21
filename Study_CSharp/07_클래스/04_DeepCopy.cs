using System;

/* 얕은 복사 vs 깊은 복사

클래스는 태생이 참조형식임.
참조 형식은 힙 영역에 객체를 할당하고 스택에 있는 참조가 힙 영역에 할당된 메모리를 가리킴.

MyClass source = new MyClass();
MyClass target = source;        //얕은 복사

위의 경우 source를 복사해서 받은 target은 힙에 있는 실제 객체가 아닌 스택에 있는 참조를 복사해서 받음.
그래서 source와 target 객체는 모두 힙의 같은 메모리 영역을 참조함.
이렇게 객체를 복사할 때 참조만 살짝 복사하는 것을 얕은 복사라고 함.

깊은 복사는 target이 힙에 보관되어 있는 내용을 source로 부터 복사해서 받아
별도의 힙 공간에 객체를 보관하는것을 말함.
C#에서는 이를 자동으로 해주는 구문이 없음. 
스스로 깊은 복사를 수행하는 코드를 만들어보자.
*/

namespace Study_CSharp._07_클래스
{
    class MyClass
    {
        public int MyField1;
        public int MyField2;

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;  
            return newCopy;
        }
    }

    internal class _04_DeepCopy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");
            //얕은복사 예제
            {   
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source;        //얕은 복사
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");
            }

            Console.WriteLine("Deep Copy");
            //깊은복사 예제
            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source.DeepCopy();        //얕은 복사
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");
            }
        }
    }
}
