using System;

//박싱과 언박싱
//object 형식은 참조 형식이기 때문에 힙에 데이터를 할당함.
//int, double 같은 애들은 값 형식이라 스택에 데이터를 할당함.
//이전 예제에서 값 형식의 데이터를 object 참조 형식에 담음. 이때는 어느 메모리에 데이터가 할당될까?

//object 형식은 값 형식의 데이터를 힙에 할당하기 위한 박싱 기능을 제공함.
//object 형식에 값 형식의 데이터를 할당하려는 시도가 이루어지면 object 형식은 박싱을 수행해서 
//해당 데이터를 힙에 할당함. 

namespace Study_CSharp._03_데이터보관하기
{
    internal class _12_BoxingUnboxing
    {
        static void Main(string[] args)
        {
            int a = 123;
            object b = (object)a;       //a에 담긴 값을 박싱해서 힙에 저장
            int c = (int)b;                 //b에 담긴 값을 언박싱해서 스택에 저장

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            double x = 3.1414213;
            object y = x;                   //x에 담긴 값을 박싱해서 힙에 저장
            double z = (double)y;       //y에 담긴 값을 언박싱해서 스택에 저장

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
                
        }
    }
}
