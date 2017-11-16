using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Management
{
    class AuthenticationHelper
    {
        private DbManager manager;

        public AuthenticationHelper()
        {
            manager = new DbManager();
            manager.open();
        }
        public bool InsertUser(UserLogin user)
        {
            try
            {
                String sql = @"insert into [user] values(@staff_id, @password, @fullname, @dob, @phone, @address, @admin)";

                SqlParameter p1 = new SqlParameter("@staff_id", user.staff_id);
                SqlParameter p2 = new SqlParameter("@password", user.password);
                SqlParameter p3 = new SqlParameter("@fullname", user.fullname);
                SqlParameter p4 = new SqlParameter("@dob", user.DOB);
                SqlParameter p5 = new SqlParameter("@phone", user.phone);
                SqlParameter p6 = new SqlParameter("@address", user.address);
                SqlParameter p7 = new SqlParameter("@admin", user.admin);

                SqlParameter[] param = { p1, p2, p3 ,p4,p5,p6,p7};
                return manager.executeUpdate(sql, param);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void Close()
        {
            manager.close();
        }
    }
}
