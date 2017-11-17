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

        public string CheckCustomerExist(int id)
        {
            String sql = "select * from [customer] where customer_id = @id or phone = @id";
            SqlParameter p = new SqlParameter("@id", id);
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
                Product product = new Product((int)row["product_id"], (string)row["name"], (string)row["unit_type"], (int)row["quantity"], (string)row["quantity"], (int)row["available"]);
                return product;
            }
        }

    }
}
