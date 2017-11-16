using System;
using System.Collections.Generic;
using System.Data;
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

        public int CheckLogin(int id, string pass)
        {
            String sql = @"select * from [staff] where staff_id = @id and password = @pass";
            SqlParameter p1 = new SqlParameter("@id", id);
            SqlParameter p2 = new SqlParameter("@pass", Encryption.sha256(pass));
            SqlParameter[] param = { p1, p2 };
            DataTable res = manager.executeQuery(sql, param);
            if (res.Rows.Count > 0)
            {
                DataRow row = res.Rows[0];

                int admin = (int)row["role"];
                if (admin == 1)
                    return 1;
                else
                    return 0;
            }
               
            return -1;

        }
        public bool InsertUser(UserLogin user)
        {
            try
            {
                String sql = @"insert into [staff] values(@staff_id, @password, @fullname, @dob, @sex,  @phone, @address, @admin)";

                SqlParameter p1 = new SqlParameter("@staff_id", user.staff_id);
                SqlParameter p2 = new SqlParameter("@password", user.password);
                SqlParameter p3 = new SqlParameter("@fullname", user.fullname);
                SqlParameter p4 = new SqlParameter("@dob", user.DOB);
                SqlParameter p5 = new SqlParameter("@sex", user.sex);
                SqlParameter p6 = new SqlParameter("@phone", user.phone);
                SqlParameter p7 = new SqlParameter("@address", user.address);
                SqlParameter p8 = new SqlParameter("@admin", user.admin);

                SqlParameter[] param = { p1, p2, p3 ,p4,p5,p6,p7,p8};
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
