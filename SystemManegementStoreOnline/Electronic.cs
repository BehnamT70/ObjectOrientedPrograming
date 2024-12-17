using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManegementStoreOnline
{
    class Electronic:Product,Idiscountable
    {
        // Propertise
        public int WarrantyPeriod { get; set; }

        // Constructor
        public Electronic(string name, decimal price, int warrantyPeriod)
            : base(name, price)
        {
            WarrantyPeriod = warrantyPeriod;
        }

        // Implementing The ApplyDiscount Method
        public void ApplyDiscount(decimal discountPercentage)
        {
            Price -= Price * discountPercentage / 100;
        }

        public override string GetProductDetails()
        {
            return $"{base.GetProductDetails()}, Warranty Period: {WarrantyPeriod} Months";
        }
    }
}
