﻿using System;


namespace Study_CSharp._03_데이터보관하기
{
    internal class _03_SignedUnsigned
    {
        static void Main(string[] args)
        {
            byte a = 255;               //byte 형식 255는 1111 1111
            sbyte b = (sbyte)a;         //(sbyte)는 변수를 sbyte 형식으로 변환하는 연산자

            Console.WriteLine(a);
            Console.WriteLine(b);  
        }

    }
}
