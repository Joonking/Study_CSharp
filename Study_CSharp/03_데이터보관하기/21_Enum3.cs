﻿using System;


namespace Study_CSharp._03_데이터보관하기
{
    internal class _20_Enum3
    {
        enum DialogResult { YES=10, NO, CANCEL, CONFIRM=50, OK }
        static void Main(string[] args)
        {
            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);   
            Console.WriteLine((int)DialogResult.CANCEL);    
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);
        }
    }
}
