using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // int decimal float double bool - değer tip
            // array, class, interface - bunlar ise referans tipleridir
            //bellekte stack ve heap diye iki sey var, deger tip olanlar stack olarak gerceklesir..
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            Console.WriteLine(sayilar1[0]);
         
            
        }
    }
}
