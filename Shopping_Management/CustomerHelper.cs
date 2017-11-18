using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Management
{
    class CustomerHelper
    {
        private DbManager manager;

        public CustomerHelper()
        {
            manager = new DbManager();
            manager.open();
        }

        public bool AddNewCustomer(Customer customer)
        {
            try
            {
                String sql = @"insert into [customer] values(@name, @dob, @sex, @status, @phone,  @address)";

                SqlParameter p1 = new SqlParameter("@name", customer.name);
                SqlParameter p2 = new SqlParameter("@dob", customer.dob);
                SqlParameter p3 = new SqlParameter("@sex", customer.sex);
                SqlParameter p4 = new SqlParameter("@status", customer.status);
                SqlParameter p5 = new SqlParameter("@phone", customer.phone);
                SqlParameter p6 = new SqlParameter("@address", customer.address);


                SqlParameter[] param = { p1, p2, p3, p4, p5, p6 };
                return manager.executeUpdate(sql, param);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
