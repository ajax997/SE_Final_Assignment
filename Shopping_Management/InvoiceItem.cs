using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Management
{
    class InvoiceItem
    {
        public int InvoiceID { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public int Quantity { get; set; } 
        public string Price { get; set; }
        public string Total { get; set; }

        public InvoiceItem(int invoiceID, int productID, string name,string unit, int quantity, string price, string total)
        {
            InvoiceID = invoiceID;
            ProductID = productID;
            Name = name;
            Unit = unit;
            Quantity = quantity;
            Price = price;
            Total = total;
        }
    }
}
