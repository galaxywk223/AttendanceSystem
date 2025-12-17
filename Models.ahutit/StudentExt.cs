using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ahutit
{
    public class StudentExt : Student
    {
        public int AttendanceCount { get; set; }
        public int TotalSessions { get; set; }
        public int AttendanceScore { get; set; } // Percentage 0-100
    }
}
