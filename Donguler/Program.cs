using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //intelicies
            //tabtab iskeleti tamamlar
            //javada aşağıdaki kod %100 aynıdır.
            //for döngüsünde "i" yaşam döngüsü anlamınagleiyor
            // for döngüsü 1 den başla  10 a kadar devam et anlamına geliyor.
            // aşağıdaki aynı zamanda bir bloktur.
            // ++ 1,1 arttır demektir.
            // şarta <= ekleseydik 10 a kadar yazdıracaktı. <= >=
            // i'yi 2,2 arrtırmak için i+=2
            // kursları ekranda dinamik olarak liste formatında göstermemiz gerekir.Çünkü bir ticaret sitesinde 200 den fazla ürün bulunmaktadır.200 tane ürünü tek tek tanımlayamazsınız.
            // bu tip listeleme olarak göstermek için array yani dizileri kullanırız.
            //sayfa sonuna footer denir.
            // kurslar.length demek bloğu dinamize etmemize yarar. kursda kaç eleman varsa ona göre hareket eder.
            //foreach dizitemelli tek tek döndürme işlemi yapar.Kursları tek tek dolaş demektir.
            //foreach dizilere uygulanır.
            string[] kurslar = new string[]
            {
                "Yazılım Geliştirici Yetiştirme Kampı","Programlamaya Başlangıç için Temel Kurs","Java","Python","Packet Tracer"
            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");

            //aşağıda tek tek yazmak yerine yukarıdaki arrayi kullanırız.
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);




            for (int i = 1; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
