using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManegementStoreOnline
{
    class Clothing:Product
    {
        // Propertise
        public string Material { get; set; }
        public string Size { get; set; }

        // Constructor
        public Clothing(string name, decimal price, string material, string size)
            : base(name, price)
        {
            Material = material;
            Size = size;
        }

        public override string GetProductDetails()
        {
            return $"{base.GetProductDetails()}, Material: {Material}, Size: {Size}";
        }
    }
}
