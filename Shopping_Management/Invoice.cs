using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Management
{
    class Invoice
    {
       public int invoice_id { get; set; }
      public  int staff_id { get; set; }
        public string staff_name { get; set; }
        public int customer_id { get; set; }

        public string date { get; set; }
        public string total_price { get; set; }
        public int product_quantity { get; set; }
        public string payment_menthol { get; set; }

        public Invoice(int invoice_id, int staff_id, string staff_name, int customer_id,  string date, string total_price, int product_quantity, string payment_menthol)
        {
            this.invoice_id = invoice_id;
            this.staff_id = staff_id;
            this.staff_name = staff_name;
            this.customer_id = customer_id;
            this.payment_menthol = payment_menthol;
            this.date = date;
            this.total_price = total_price;
            this.product_quantity = product_quantity;
        }
    }
}
