using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AMS.ahutit.Common
{
    /// <summary>
    /// 基于正则表达式的验证
    /// </summary>
    public class DataValidate
    {
        public static bool IsInteger(string txt)
        {
            Regex objReg = new Regex(@"^[1-9]\d*$");
            return objReg.IsMatch(txt);
        }

        /// <summary>
        /// 身份证号码格式验证
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool IsIDCardNo(string txt)
        {
            Regex objReg = new Regex(@"(^\d{15}$)|(^\d{17}(\d|X|x)$)");
            return objReg.IsMatch(txt);
        }
    }
}
