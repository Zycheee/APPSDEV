using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryCalculatorDiscountApp
{

    class productData
    {
        public string Name { get; set; }
        public decimal Price { get; }
        public int PurchasedQuantity { get; set; }

        public productData (string Name, decimal Price, int PurchasedQuantity)
        {
            this.Name = Name;
            this.Price = Price;
            this.PurchasedQuantity = PurchasedQuantity;
        }
        public static class ShoppingCart
        {
            public static List<productData> Items { get; set; } = new List<productData>();
        }
    }
}
