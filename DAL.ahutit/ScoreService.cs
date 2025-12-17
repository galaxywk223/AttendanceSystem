using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ahutit;

namespace DAL.ahutit
{
    public class ScoreService
    {
        public List<StudentExt> GetStudentScores(string className = null)
        {
            // Calculate Attendance Score: (SignCount / TotalSessions) * 100
            
            // First get Total Sessions
            string sqlTotal = "SELECT COUNT(*) FROM AttendanceSession WHERE EndTime IS NOT NULL"; // Only finished sessions count towards score base? Or all? Usually strict attendance counts all "past and checked" sessions.
            // Let's assume all started sessions count, but maybe only closed ones? The requirement says "shutdown this attendance before valid". 
            // Usually, Total = Count of sessions that *have occurred*.
            // Let's count all sessions.
            sqlTotal = "SELECT COUNT(*) FROM AttendanceSession";
            int totalSessions = 0;
            try { totalSessions = Convert.ToInt32(SQLHelper.GetSingleResult(sqlTotal)); } catch { }

            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("SELECT St.StudentId, St.StudentName, St.Gender, St.PhoneNumber, Cl.ClassName, ");
            sqlBuilder.Append("(SELECT COUNT(*) FROM AttendanceRecord Ar WHERE Ar.StudentId = St.StudentId) AS AttendanceCount ");
            sqlBuilder.Append("FROM Student St ");
            sqlBuilder.Append("INNER JOIN StudentClass Cl ON St.ClassId = Cl.ClassId ");
            
            if (!string.IsNullOrEmpty(className))
            {
                sqlBuilder.Append("WHERE Cl.ClassName = @ClassName ");
            }

            sqlBuilder.Append("ORDER BY Cl.ClassName, St.StudentId ASC");

            SqlParameter[] param = null;
            if (!string.IsNullOrEmpty(className))
            {
                param = new SqlParameter[]
                {
                    new SqlParameter("@ClassName", className)
                };
            }

            List<StudentExt> list = new List<StudentExt>();
            try
            {
                SqlDataReader objReader = SQLHelper.GetReader(sqlBuilder.ToString(), param);
                while (objReader.Read())
                {
                    int attCount = Convert.ToInt32(objReader["AttendanceCount"]);
                    int score = 0;
                    if (totalSessions > 0)
                    {
                        score = (int)((double)attCount / totalSessions * 100);
                    }
                    // Handle edge case if no sessions yet, maybe give 100? No, 0 is safer or N/A. Requirement says "4 times, signed 3 times is 75". So 0/0 is ? Let's say 100 or 0.
                    // If total is 0, score is not applicable really. Let's set 0 for start.
                    
                    list.Add(new StudentExt()
                    {
                        StdId = Convert.ToInt32(objReader["StudentId"]),
                        StdName = objReader["StudentName"].ToString(),
                        Gender = objReader["Gender"].ToString(),
                        PhoneNumber = objReader["PhoneNumber"] != DBNull.Value ? objReader["PhoneNumber"].ToString() : "",
                        ClassName = objReader["ClassName"].ToString(),
                        AttendanceCount = attCount,
                        TotalSessions = totalSessions,
                        AttendanceScore = score
                    });
                }
                objReader.Close();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Get attendance scores failed: " + ex.Message);
            }
        }

        public StudentExt? GetStudentScoreByStudentId(int studentId)
        {
             // First get Total Sessions
            string sqlTotal = "SELECT COUNT(*) FROM AttendanceSession";
            int totalSessions = 0;
            try { totalSessions = Convert.ToInt32(SQLHelper.GetSingleResult(sqlTotal)); } catch { }

            string sql = "SELECT St.StudentId, St.StudentName, St.Gender, St.PhoneNumber, Cl.ClassName, " +
                         "(SELECT COUNT(*) FROM AttendanceRecord Ar WHERE Ar.StudentId = St.StudentId) AS AttendanceCount " +
                         "FROM Student St " +
                         "INNER JOIN StudentClass Cl ON St.ClassId = Cl.ClassId " +
                         "WHERE St.StudentId = @StudentId";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StudentId", studentId)
            };

            try
            {
                SqlDataReader objReader = SQLHelper.GetReader(sql, param);
                StudentExt? studentScore = null;
                if (objReader.Read())
                {
                    int attCount = Convert.ToInt32(objReader["AttendanceCount"]);
                    int score = 0;
                    if (totalSessions > 0)
                    {
                        score = (int)((double)attCount / totalSessions * 100);
                    }

                    studentScore = new StudentExt()
                    {
                        StdId = Convert.ToInt32(objReader["StudentId"]),
                        StdName = objReader["StudentName"].ToString(),
                        Gender = objReader["Gender"].ToString(),
                        PhoneNumber = objReader["PhoneNumber"] != DBNull.Value ? objReader["PhoneNumber"].ToString() : "",
                        ClassName = objReader["ClassName"].ToString(),
                        AttendanceCount = attCount,
                        TotalSessions = totalSessions,
                        AttendanceScore = score
                    };
                }
                objReader.Close();
                return studentScore;
            }
            catch (Exception ex)
            {
                throw new Exception("Get student attendance score by ID failed: " + ex.Message);
            }
        }
    }
}
