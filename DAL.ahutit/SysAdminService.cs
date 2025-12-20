using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ahutit;
using System.Data.SqlClient;

namespace DAL.ahutit
{
    public class SysAdminService
    {
        public SysAdmin? AdminLogin(SysAdmin objAdmin)
        {
            string sql = "SELECT AdminName, LoginPwd FROM SysAdmin WHERE LoginId=@LoginId AND LoginPwd=@Pwd";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@LoginId", objAdmin.loginid),
                new SqlParameter("@Pwd", objAdmin.Pwd)
            };

            try
            {
                SqlDataReader objReader = SQLHelper.GetReader(sql, param);
                if (objReader.Read())
                {
                    objAdmin.AdminName = objReader["AdminName"]?.ToString() ?? string.Empty;
                    objAdmin.Pwd = objReader["LoginPwd"]?.ToString() ?? string.Empty;
                    objReader.Close();
                    return objAdmin;
                }
                else
                {
                    objReader.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Login failed: " + ex.Message);
            }
        }
        public int ModifyPSW(SysAdmin objAdmin)
        {
            string sql = "UPDATE SysAdmin SET LoginPwd=@Pwd WHERE LoginId=@LoginId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Pwd", objAdmin.Pwd),
                new SqlParameter("@LoginId", objAdmin.loginid)
            };

            try
            {
                return SQLHelper.Update(sql, param);
            }
            catch (Exception ex)
            {
                throw new Exception("Modify password failed: " + ex.Message);
            }
        }
    }
}
