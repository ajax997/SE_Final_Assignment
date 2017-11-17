using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Management
{
    class Invoice
    {
        int invoice_id { get; set; }
        int staff_id { get; set; }
        int customer_id { get; set; }
        string product_id { get; set; }
        string date { get; set; }
        string total_price { get; set; }
        int product_quantity { get; set; }

        public Invoice(int invoice_id, int staff_id, int customer_id, string product_id, string date, string total_price, int product_quantity)
        {
            this.invoice_id = invoice_id;
            this.staff_id = staff_id;
            this.customer_id = customer_id;
            this.product_id = product_id;
            this.date = date;
            this.total_price = total_price;
            this.product_quantity = product_quantity;
        }
    }
}
