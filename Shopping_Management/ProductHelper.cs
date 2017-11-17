using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Management
{
    class ProductHelper
    {
        private DbManager manager;

        public ProductHelper()
        {
            manager = new DbManager();
            manager.open();
        }

        public List<Product> getAll()
        {
            String sql = "select * from [product]";
            DataTable table = manager.executeQuery(sql);

            List<Product> list = new List<Product>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                int productID =(int)row["product_id"];
                string name = (string)row["name"];
                int unit_type = (int)row["unit_type"];
                int quantity = (int)row["quantity"];
                string price = (string)row["price"];
                int available = (int)row["available"];
                Product product = new Product(productID, name, unit_type, quantity, price, available);
                list.Add(product);
            }


            return list;
        }

        public bool InsertProduct(Product pro)
        {
            try
            {
                if(manager.executeQuery("select * from [product] where product_id = "+ pro.productID.ToString()).Rows.Count==0)
                {
                    String sql = @"insert into [product] values(@productid, @productname, @type, @quantity, @price,  @available)";

                    SqlParameter p1 = new SqlParameter("@productid", pro.productID);
                    SqlParameter p2 = new SqlParameter("@productname", pro.productName);
                    SqlParameter p3 = new SqlParameter("@type", pro.unit);
                    SqlParameter p4 = new SqlParameter("@quantity", pro.quantity);
                    SqlParameter p5 = new SqlParameter("@price", pro.price);
                    SqlParameter p6 = new SqlParameter("@available", pro.available);


                    SqlParameter[] param = { p1, p2, p3, p4, p5, p6 };
                    return manager.executeUpdate(sql, param);
                }
                else
                {
                    String sql = @"update  [product] set name = @productname,unit_type = @type,quantity =  @quantity,price =  @price, available =  @available where product_id = @productid ";

                   
                    SqlParameter p2 = new SqlParameter("@productname", pro.productName);
                    SqlParameter p3 = new SqlParameter("@type", pro.unit);
                    SqlParameter p4 = new SqlParameter("@quantity", pro.quantity);
                    SqlParameter p5 = new SqlParameter("@price", pro.price);
                    SqlParameter p6 = new SqlParameter("@available", pro.available);
                    SqlParameter p1 = new SqlParameter("@productid", pro.productID);


                    SqlParameter[] param = {  p2, p3, p4, p5, p6, p1 };
                    return manager.executeUpdate(sql, param);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
