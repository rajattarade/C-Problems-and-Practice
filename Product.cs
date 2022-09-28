using System;

namespace ConsoleApp2
{
    public class Product //Defined a class
    {
        public string name { get; set; } // Data
        public int price { get; set; }
        public decimal product_id { get; set; }

        private static int seed = 0; //use of Private datatype
        
        public Product(string name, int price) //Constructor
        {
            this.name = name;
            this.price = price;
            this.product_id = seed;
            seed++;
        }

        public int buy(int qty) // Method 
        {
            return (qty * this.price);
        }
    }
}
