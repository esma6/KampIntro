using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //Entity=varlik
    {
        public int Id { get; set; } //PK
        public int CategoryId { get; set; } // FK genelde ikinci siraya yazariz kod okunurlugu icin
        public string ProductName { get; set; } 
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
}
