using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManegementStoreOnline
{
    abstract class Product
    {
        // Propertise
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Constructor
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        // Method To Display Product Details
        public virtual string GetProductDetails()
        {
            return $"Product Name: {Name}, Price: {Price}$";
        }
    }
}
