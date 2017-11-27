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

        public UserLogin CheckLogin(int id, string pass)
        {
            String sql = @"select * from [staff] where staff_id = @id and password = @pass";
            SqlParameter p1 = new SqlParameter("@id", id);
            SqlParameter p2 = new SqlParameter("@pass", Encryption.sha256(pass));
            SqlParameter[] param = { p1, p2 };
            DataTable res = manager.executeQuery(sql, param);
            if (res.Rows.Count > 0)
            {
                DataRow row = res.Rows[0];
                UserLogin user = new UserLogin((int)row["staff_id"], null, (string)row["name"], "Male", null, null, null, (int)row["role"]);
                return user;
            }

            return null;

        }

        public int GetCurrentStaffNumber()
        {
            String sql = "SELECT TOP 1 * FROM [staff] ORDER BY staff_id DESC";
            DataTable res = manager.executeQuery(sql);
            if (res.Rows.Count == 0)
                return -1;
            else
            {
                DataRow row = res.Rows[0];
                return (int)row["staff_id"];
            }

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

        public List<UserLogin> GetAllStaff(bool admin)
        {
            String sql;

            if (!admin) { sql = "select * from [staff] where role != 1"; }
            else
            {
                sql = "select * from [staff] where role = 1";
            }

            DataTable res = manager.executeQuery(sql);
            List<UserLogin> users = new List<UserLogin>();
            foreach (DataRow row in res.Rows)
            {
                UserLogin user = new UserLogin((int)row["staff_id"], " ", (string)row["name"], (string)row["sex"], (string)row["dob"], (string)row["phone"], (string)row["address"], 0);
                users.Add(user);
            }
            return users;

        }

        public bool UpdateUser(UserLogin user, bool admin)
        {
            String sql;
            if (admin)
            {
                sql = "update [staff] set name = @name, password = @password where staff_id = @staffID";
            }
            else
            {
                sql = "update [staff] set name = @name, password =@password, dob = @dob, sex = @sex, phone = @phone, address = @address, role = @role where staff_id = @staffID";
            }

            SqlParameter p1 = new SqlParameter("@staffID", user.staff_id);
            SqlParameter p2 = new SqlParameter("@password", user.password);
            SqlParameter p3 = new SqlParameter("@name", user.fullname);
            SqlParameter p4 = new SqlParameter("@dob", user.DOB);
            SqlParameter p5 = new SqlParameter("@sex", user.sex);
            SqlParameter p6 = new SqlParameter("@phone", user.phone);
            SqlParameter p7 = new SqlParameter("@address", user.address);
            SqlParameter p8 = new SqlParameter("@role", user.admin);

            SqlParameter[] param;
            if (!admin)
            {
                param = new SqlParameter[] {p1, p2, p3, p4, p5, p6, p7, p8 };
            }
            else
            { param = new SqlParameter[] { p1, p2, p3 }; };
            return manager.executeUpdate(sql, param);
        }
        public void Close()
        {
            manager.close();
        }
    }
}
