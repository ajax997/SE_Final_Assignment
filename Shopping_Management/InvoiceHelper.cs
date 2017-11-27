using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Management
{
    class InvoiceHelper
    {
        private DbManager manager;

        public InvoiceHelper()
        {
            manager = new DbManager();
            manager.open();
        }

        public int GetCurrentInvoiceNumber()
        {
            String sql = "SELECT TOP 1 * FROM [invoice] ORDER BY invoice_id DESC";
            DataTable res = manager.executeQuery(sql);
            if (res.Rows.Count == 0)
                return -1;
            else
            {
                DataRow row = res.Rows[0];
                return (int)row["invoice_id"];
            }

        }

        public string CheckCustomerExist(string id)
        {
            String sql = "select * from [customer] where phone = @phone ";
            SqlParameter p = new SqlParameter("@phone", id);
            DataTable res = manager.executeQuery(sql, new SqlParameter[] { p });
            if(res.Rows.Count == 0)
            {
                return "-1";
            }
            else
            {
                DataRow row = res.Rows[0];
                return (string)row["name"];
            }
        }

        public Product CheckProductID(int product_id)
        {
            String sql = "select * from [product] where product_id = @product_id";
            SqlParameter p = new SqlParameter("@product_id", product_id);
            DataTable res = manager.executeQuery(sql, new SqlParameter[] { p });
            if (res.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                DataRow row = res.Rows[0];
                Product product = new Product((int)row["product_id"], (string)row["name"], (string)row["unit_type"], (int)row["quantity"], (string)row["price"], (int)row["available"]);
                return product;
            }
        }
        public bool InsertInvoice(Invoice invoice)
        {
           
            String sql = "insert into [invoice] values(@invoiceID, @staffID, @staffName, @customerID, @date, @totalPrice, @quantity, @payment_menthol)";
            SqlParameter p1 = new SqlParameter("@invoiceID", invoice.invoice_id);
            SqlParameter p2 = new SqlParameter("@staffID", invoice.staff_id);
            SqlParameter p3 = new SqlParameter("@staffName", invoice.staff_name);
            SqlParameter p4 = new SqlParameter("@customerID", invoice.customer_id);
            SqlParameter p5 = new SqlParameter("@date", invoice.date);
            SqlParameter p6 = new SqlParameter("@totalPrice", invoice.total_price);
            SqlParameter p7 = new SqlParameter("@quantity", invoice.product_quantity);
            SqlParameter p8 = new SqlParameter("@payment_menthol", invoice.payment_menthol);
            SqlParameter[] parameter = { p1,p2,p3,p4,p5,p6,p7,p8};
           return manager.executeUpdate(sql, parameter);

        }
        public bool InsertInvoiceItem(InvoiceItem invoiceItem)
        {

            String sql = "insert into [invoice_item] values(@invoiceID, @productID, @name, @quantity, @unit, @price, @total)";
            SqlParameter p1 = new SqlParameter("@invoiceID", invoiceItem.InvoiceID);
            SqlParameter p2 = new SqlParameter("@productID", invoiceItem.ProductID);
            SqlParameter p3 = new SqlParameter("@name", invoiceItem.Name);
            SqlParameter p4 = new SqlParameter("@quantity", invoiceItem.Quantity);
            SqlParameter p5 = new SqlParameter("@unit", invoiceItem.Unit);
            SqlParameter p6 = new SqlParameter("@price", invoiceItem.Price);
            SqlParameter p7 = new SqlParameter("@total", invoiceItem.Total);

            SqlParameter[] parameter = { p1, p2, p3, p4, p5, p6, p7};
            return manager.executeUpdate(sql, parameter);

        }
        public bool UpdateProduct(int productID, int quantity, int available)
        {
            String sql = @"update  [product] set quantity = @quantity, available = @available where product_id = @productID";
            SqlParameter p1 = new SqlParameter("@quantity", quantity);
            SqlParameter p2 = new SqlParameter("@available", available);
            SqlParameter p3 = new SqlParameter("@productID", productID);
            return manager.executeUpdate(sql, new SqlParameter[] { p1, p2, p3 });
        }

        public List<Invoice> GetAllInvoice()
        {
            String sql = "select * from [invoice]";
            List<Invoice> list = new List<Invoice>();
            DataTable res = manager.executeQuery(sql);
            foreach(DataRow row in res.Rows)
            {
                Invoice invoice = new Invoice((int)row["invoice_id"], (int)row["staff_id"], (string)row["staff_name"], (int)row["customer_id"]
                    , (string)row["date"], (string)row["total_price"], (int)row["product_quantity"], (string)row["payment_menthol"]);
                list.Add(invoice);
            }
            return list;
        }
        public List<InvoiceItem> GetAllItemFromInvoiceID(int invoiceID)
        {
            String sql = "select * from [invoice_item] where invoice_id = @invoice_id";
            
            List<InvoiceItem> list = new List<InvoiceItem>();
            DataTable res = manager.executeQuery(sql, new SqlParameter[] { new SqlParameter("@invoice_id", invoiceID)});
            foreach(DataRow row in res.Rows)
            {
                InvoiceItem item = new InvoiceItem((int)row["invoice_id"], (int)row["product_id"], (string)row["name"], (string)row["unti_type"], (int)row["quantity"], (string)row["price"], (string)row["total"]);
                list.Add(item);
            }
            return list;

        }
    }
}
