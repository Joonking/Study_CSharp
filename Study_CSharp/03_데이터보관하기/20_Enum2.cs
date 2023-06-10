using System;


namespace Study_CSharp._03_데이터보관하기
{
    internal class _20_Enum2
    {
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }
        static void Main(string[] args)
        {
            DialogResult result = DialogResult.YES;

            Console.WriteLine(result == DialogResult.YES);
            Console.WriteLine(result == DialogResult.NO);
            Console.WriteLine(result == DialogResult.CANCEL);
            Console.WriteLine(result == DialogResult.CONFIRM);  
            Console.WriteLine(result == DialogResult.OK);
        }
    }
}
