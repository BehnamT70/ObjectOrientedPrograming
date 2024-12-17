using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManegementStoreOnline
{
    internal interface Idiscountable
    {
        void ApplyDiscount(decimal discountPercentage);
    }
}
