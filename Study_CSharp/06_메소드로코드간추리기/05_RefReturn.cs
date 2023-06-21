using System;

namespace Study_CSharp._06_메소드로코드간추리기
{
    class Product
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Price :{price}");
        }
    }

    internal class _05_RefReturn
    {
        static void Main(string[] args)
        {
            Product carrot = new Product();

            //참조로 반환 받은 결과를 담는 지역변수를 참조 지역 변수라고 부름
            ref int ref_local_price = ref carrot.GetPrice();    //ref_local_price 를 수정하면 carrot.price의 내용도 바뀜
            int normal_local_price = carrot.GetPrice();

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price :{ref_local_price}");
            Console.WriteLine($"Normal Local Price :{normal_local_price}");

            ref_local_price = 200;

            carrot.PrintPrice();
            Console.WriteLine($"Local Price :{ref_local_price}");
            Console.WriteLine($"Normal Local Price :{normal_local_price}");
        }
    }
}
