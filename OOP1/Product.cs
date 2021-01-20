using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //    ürün
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } // kodun okunurluğu içib bu sırayla yazılır.
        public string ProductName { get; set; } // ürün adı
        public double UnitPrice { get; set; } // birim fiyat
        public int UnitsInStock { get; set; } //ürünün stok adeti



    }
}
