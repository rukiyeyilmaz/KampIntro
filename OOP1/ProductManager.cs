using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager // ürünle ilgili operasyonlar var demek. ekleme,arama,listeleme,silme,güncelleme vs. işlemler
    {
        // void ile git ekle, git sil demek istiyoruz
        public void Add(Product product) // strin ad der gibi product türünde product
        {
            Console.WriteLine(product.ProductName +" eklendi.");
        }

       
    }
}
