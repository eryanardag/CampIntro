using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
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

            //int,decimal,float,double,bool = bunlara değer tip deniyor.
            //array, class,interface = bunlar ise karşımıza referans tip olarak çıkar.
            //bellekte 2 tane alan var; stack ve heap.
            //stack: değer tipler  stackde gerçekleşiyor.
            //new demek heap de yeni bir adres oluşturmaya yarıyor.
            //sayilar1 in referans numarası = sayilar2 nin referans numarası
            //.net in garbage collector gelip sayilar1 i bellekten atar.
        }
    }
}
