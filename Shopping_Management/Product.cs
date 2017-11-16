using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Management
{
    class Product
    {
        public string productID { get; set; }
        public string productName { get; set; }
        public int unit { get; set; }
        public int quantity { get; set; }
        public string price { get; set; }
        public string expiredDate { get; set; }
        public string note { get; set; }

        public Product(string productID, string productName, int unit, int quantity, string price, string expiredDate, string note)
        {
            this.productID = productID;
            this.productName = productName;
            this.unit = unit;
            this.quantity = quantity;
            this.price = price;
            this.expiredDate = expiredDate;
            this.note = note;
        }
    }
}
