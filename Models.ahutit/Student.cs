using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ahutit
{
    public class Student
    {
        public string StdName { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }
        public string idNo { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public Int32 Classid { get; set; }
        public int Age { get; set; }
        public string CardNo { get; set; } = string.Empty;
        public string StdImage { get; set; } = string.Empty;
        public int StdId { get; set; }
        public string ClassName { get; set; } = string.Empty;
        public string? StudentPwd { get; set; }
    }
}
