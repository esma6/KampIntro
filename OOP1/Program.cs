﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {  
            //TANIMLAMA 1
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; // 2 numaranın kategorisi mobilya demek olsun
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //TANIMLAMA 2
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName); // kamera oldu

            //productManager.Topla(3,6);

            //int toplamaSonucu = productManager.Topla(3,6);

            //Console.WriteLine(toplamaSonucu * 2);

            //int sayi =100;
            //productManager.BiSeyYap(sayi);
            //Console.WritLine(sayi); //çıktı 100
            
        }
    }
}
