using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Management
{
    class DbManager
    {
        private SqlConnection conn;
        private SqlCommand cmd;


        public SqlConnection open()
        {
            conn = new SqlConnection(@"Data Source=AJAX997-PC;Initial Catalog=Shopping_Management;Persist Security Info=True;User ID=sa;Password=123456");
            conn.Open();
            return conn;
        }

        public void close()
        {
            try
            {
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        public DataTable executeQuery(String sql)
        {
            cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable executeQuery(String sql, SqlParameter[] parameters)
        {
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddRange(parameters);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public bool executeUpdate(String sql, SqlParameter[] parameters)
        {
            try
            {
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddRange(parameters);
                int row = cmd.ExecuteNonQuery();
                return (row == 1);
            }
            catch (Exception e)
            {
                Console.WriteLine("Loi: " + e.Message);
                throw e;
            }
        }
    }
}
