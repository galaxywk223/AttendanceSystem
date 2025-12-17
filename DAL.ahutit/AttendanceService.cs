using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ahutit;

namespace DAL.ahutit
{
    public class AttendanceService
    {
        // Start a new session
        public int StartSession(string operatorName)
        {
            // Close any existing open sessions first to be safe
            EndSession();

            string sql = "INSERT INTO AttendanceSession (StartTime, OperatorName) VALUES (@StartTime, @OperatorName); SELECT @@IDENTITY";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StartTime", DateTime.Now),
                new SqlParameter("@OperatorName", operatorName)
            };
            try
            {
                return Convert.ToInt32(SQLHelper.GetSingleResult(sql, param));
            }
            catch (Exception ex)
            {
                throw new Exception("Start attendance session failed: " + ex.Message);
            }
        }

        // End currently active session
        public int EndSession()
        {
            string sql = "UPDATE AttendanceSession SET EndTime = @EndTime WHERE EndTime IS NULL";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@EndTime", DateTime.Now)
            };
            try
            {
                return SQLHelper.Update(sql, param);
            }
            catch (Exception ex)
            {
                throw new Exception("End attendance session failed: " + ex.Message);
            }
        }

        // Check if there is an active session
        public bool IsSessionActive()
        {
            string sql = "SELECT COUNT(*) FROM AttendanceSession WHERE EndTime IS NULL";
            try
            {
                return Convert.ToInt32(SQLHelper.GetSingleResult(sql, null)) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Check active session failed: " + ex.Message);
            }
        }

        // Get Current Active Session ID
        public int GetActiveSessionId()
        {
            string sql = "SELECT SessionId FROM AttendanceSession WHERE EndTime IS NULL";
            try
            {
                object result = SQLHelper.GetSingleResult(sql, null);
                if (result == null) return -1;
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                throw new Exception("Get active session ID failed: " + ex.Message);
            }
        }

        // Student Sign In
        public int SignIn(int studentId)
        {
            int sessionId = GetActiveSessionId();
            if (sessionId == -1)
            {
                throw new Exception("当前没有正在进行的考勤。");
            }

            // Check if already signed in
            if (IsSigned(sessionId, studentId))
            {
                throw new Exception("您已经签到过了。");
            }

            string sql = "INSERT INTO AttendanceRecord (SessionId, StudentId, SignTime) VALUES (@SessionId, @StudentId, @SignTime)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@SessionId", sessionId),
                new SqlParameter("@StudentId", studentId),
                new SqlParameter("@SignTime", DateTime.Now)
            };
            try
            {
                return SQLHelper.Update(sql, param);
            }
            catch (Exception ex)
            {
                throw new Exception("Sign in failed: " + ex.Message);
            }
        }

        public bool IsSigned(int sessionId, int studentId)
        {
            string sql = "SELECT COUNT(*) FROM AttendanceRecord WHERE SessionId=@SessionId AND StudentId=@StudentId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@SessionId", sessionId),
                new SqlParameter("@StudentId", studentId)
            };
            try
            {
                return Convert.ToInt32(SQLHelper.GetSingleResult(sql, param)) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Check is signed failed: " + ex.Message);
            }
        }
    }
}
