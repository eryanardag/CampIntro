using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi : " + product.ProductName);
        }

        public void Ekle2(string ProductName, string ProductInfo, double ProductPrice, int stokAdedi)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + ProductName);
        }
    }
}
