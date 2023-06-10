using System;

namespace Study_CSharp._03_데이터보관하기
{
    internal class _19_Enum
    {
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }
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
