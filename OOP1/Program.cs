using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; // 2 ıd mobilya ya denks- geldin.
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;


            // ikinci görünüm
            Product product2 = new Product { Id = 2, CategoryId=5 , UnitsInStock =5, ProductName="kalem", UnitPrice=35 };

            ProductManager productManager = new ProductManager(); // ProdectManager türünde productManager türün
            productManager.Add(product1);
       
        
        
        
        
        
        }




    }
}
