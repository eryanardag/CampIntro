using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //gerçek hayatta veriler tek bir kelimeden oluşmaz.bilgi sadece bir alandan oluşmuyor.
            //excelde müşterilerin ismini tuttuğunuz bir tablonuz olsun.Müşteri adı,T.C. No(String olarak tutulur),Doğum Yeri,Yaşı(int),
            //Class ları içinde birden fazla veri tutmak için kullanırız.

            string adi = "engin";
            int yas = 27;


            //kurs diye bir veri tanımlayabiliriz ama öncelikle Kurs adında bir class oluşturmamız gerekir.
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "EnginDemirog";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem";
            kurs2.İzlenmeOrani = 50;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Aydın";
            kurs3.İzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "MuratKurtbogan";
            kurs4.İzlenmeOrani = 100;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
    }
        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int İzlenmeOrani { get; set; }
        }
    }

    
