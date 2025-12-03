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
        public SysAdmin AdminLogin(SysAdmin objAdmin)
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
                    objAdmin.AdminName = objReader["AdminName"].ToString();
                    objAdmin.Pwd = objReader["LoginPwd"].ToString(); // Map DB LoginPwd to Model Pwd
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
            //此处应有数据库操作代码，此处省略
            //模拟密码修改成功，返回1
            return 1;
        }
    }
}
