using System;

namespace ConsoleApp2
{
    public class Product
    {
        public string name { get; set; }
        public int price { get; set; }
        public decimal product_id { get; set; }

        private static int seed = 0;
        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
            this.product_id = seed;
            seed++;
        }

        public int buy(int qty)
        {
            return (qty * this.price);
        }
    }
}
