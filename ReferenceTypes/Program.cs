using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int ,decimal,float,enum,boolean,value types
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("Sayı 1 : "+sayi1); //20

            //arrays,class,interface....reference types
            int[] sayilar1 = new int[] {1,2,3,4 };
            int[] sayilar2 = new int[] {10,20,30,40 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;

            Console.WriteLine("Sayılar1[0] = "+sayilar1[0]);

            Console.WriteLine("Hello World!");
        }
    }
}
