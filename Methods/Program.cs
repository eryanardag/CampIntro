using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string ProductName = "Elma";
            double ProductPrice = 15;
            string ProductInfo = "Amasya Elması";

            Product product1 = new Product();
            product1.ProductName = "elma";
            product1.ProductPrice = 15;
            product1.ProductInfo = "Amasya Elması";

            Product product2 = new Product();
            product2.ProductName = "Karpuz";
            product2.ProductPrice = 80;
            product2.ProductInfo = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };//şeklinde array oluşturabiliriz.

            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.ProductPrice);
                Console.WriteLine(product.ProductInfo);
                Console.WriteLine("---------");

            }

            Console.WriteLine("----Metodlar--------");
            //instance -- örek
            //encapsulation 
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 11);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 21);
        }
    }
}
