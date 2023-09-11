using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class InventoryItem
    {
        public string ProductName { get; set; }

        public int QuantityOnHand { get; set; }
    }
}
