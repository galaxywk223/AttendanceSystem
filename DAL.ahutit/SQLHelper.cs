using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL.ahutit
{
    public class SQLHelper
    {
        private static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        // Execute Update (INSERT, UPDATE, DELETE)
        public static int Update(string sql, SqlParameter[]? param = null)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    // Log error or rethrow
                    throw;
                }
            }
        }

        // Get Single Result (First row, first column)
        public static object GetSingleResult(string sql, SqlParameter[]? param = null)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                try
                {
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        // Get Reader
        public static SqlDataReader GetReader(string sql, SqlParameter[]? param = null)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                conn.Close();
                throw;
            }
        }
    }
}
