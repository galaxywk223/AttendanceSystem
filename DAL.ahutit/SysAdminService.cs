using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ahutit;

namespace DAL.ahutit
{
    public class SysAdminService
    {
        public SysAdmin AdminLogin(SysAdmin objAdmin)
        {
            //此处应有数据库操作代码，此处省略
            //模拟数据库中有一个管理员账号，loginid=1001，密码=admin123
            if (objAdmin.loginid == 1001 && objAdmin.Pwd == "admin123")
            {
                //登录成功，返回完整的管理员对象
                return new SysAdmin()
                {
                    loginid = 1001,
                    Pwd = "admin123"
                    //其他属性可在此处赋值
                };
            }
            else
            {
                //登录失败，返回null
                return null;
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
