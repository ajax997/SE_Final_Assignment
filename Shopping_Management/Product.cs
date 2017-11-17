using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Management
{
    class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public string unit { get; set; }
        public int quantity { get; set; }
        public string price { get; set; }
        public int available { get; set; }
        

        public Product(int productID, string productName, string unit, int quantity, string price, int available)
        {
            this.productID = productID;
            this.productName = productName;
            this.unit = unit;
            this.quantity = quantity;
            this.price = price;
            this.available = available;
        }
    }
}
