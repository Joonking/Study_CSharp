using System;

namespace Study_CSharp._07_클래스
{
    class Cat
    {
        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }

    internal class _01_BasicClass
    {
        static void Main(string[] args)
        {
            Cat Kitty = new Cat();
            Kitty.Color = "하얀색";
            Kitty.Name = "키티";

            Kitty.Meow();
            Console.WriteLine($"{Kitty.Name} : {Kitty.Color}");

            Cat nero = new Cat();
            nero.Color = "검은색";
            nero.Name = "네로";
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
}
