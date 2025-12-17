using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ahutit
{
    public class AttendanceSession
    {
        public int SessionId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string OperatorName { get; set; } = string.Empty;
    }
}
