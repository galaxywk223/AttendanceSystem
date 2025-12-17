using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ahutit;
using System.Data.SqlClient;

namespace DAL.ahutit
{
    public class StudentService
    {


        public bool isIdNoExisted(string idNo)
        {
            string sql = "SELECT COUNT(*) FROM Student WHERE StudentIdNo=@StudentIdNo";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StudentIdNo", idNo)
            };
            try
            {
                int result = Convert.ToInt32(SQLHelper.GetSingleResult(sql, param));
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Check ID No exists failed: " + ex.Message);
            }
        }
        public bool isCardNoExisted(string cardNo)
        {
            string sql = "SELECT COUNT(*) FROM Student WHERE CardNo=@CardNo";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CardNo", cardNo)
            };
            try
            {
                int result = Convert.ToInt32(SQLHelper.GetSingleResult(sql, param));
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Check Card No exists failed: " + ex.Message);
            }
        }
        public int addNewStd(Student newStudent)
        {
            string sql = "INSERT INTO Student (StudentName, Gender, Birthday, StudentIdNo, CardNo, PhoneNumber, StudentAddress, ClassId, StudentImage, Age) " +
                         "VALUES (@StudentName, @Gender, @Birthday, @StudentIdNo, @CardNo, @PhoneNumber, @StudentAddress, @ClassId, @StudentImage, @Age); " +
                         "SELECT @@IDENTITY";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StudentName", newStudent.StdName),
                new SqlParameter("@Gender", newStudent.Gender),
                new SqlParameter("@Birthday", newStudent.Birthday),
                new SqlParameter("@StudentIdNo", newStudent.idNo),
                new SqlParameter("@CardNo", newStudent.CardNo),
                new SqlParameter("@PhoneNumber", newStudent.PhoneNumber),
                new SqlParameter("@StudentAddress", newStudent.Address),
                new SqlParameter("@ClassId", newStudent.Classid),
                new SqlParameter("@StudentImage", newStudent.StdImage),
                new SqlParameter("@Age", newStudent.Age)
            };
            try
            {
                return Convert.ToInt32(SQLHelper.GetSingleResult(sql, param));
            }
            catch (Exception ex)
            {
                throw new Exception("Add student failed: " + ex.Message);
            }
        }
        public List<Student> getAllStudents()
        {
            string sql = "SELECT StudentId, StudentName, Gender, Birthday, StudentIdNo, CardNo, PhoneNumber, StudentAddress, Student.ClassId, StudentImage, Age, ClassName " +
                         "FROM Student INNER JOIN StudentClass ON Student.ClassId = StudentClass.ClassId";
            List<Student> list = new List<Student>();
            try
            {
                SqlDataReader objReader = SQLHelper.GetReader(sql);
                while (objReader.Read())
                {
                    list.Add(new Student()
                    {
                        StdId = Convert.ToInt32(objReader["StudentId"]),
                        StdName = objReader["StudentName"]?.ToString() ?? string.Empty,
                        Gender = objReader["Gender"]?.ToString() ?? string.Empty,
                        Birthday = Convert.ToDateTime(objReader["Birthday"]),
                        idNo = objReader["StudentIdNo"]?.ToString() ?? string.Empty,
                        CardNo = objReader["CardNo"]?.ToString() ?? string.Empty,
                        PhoneNumber = objReader["PhoneNumber"] != DBNull.Value ? objReader["PhoneNumber"]?.ToString() ?? string.Empty : string.Empty,
                        Address = objReader["StudentAddress"] != DBNull.Value ? objReader["StudentAddress"]?.ToString() ?? string.Empty : string.Empty,
                        Classid = Convert.ToInt32(objReader["ClassId"]),
                        StdImage = objReader["StudentImage"] != DBNull.Value ? objReader["StudentImage"]?.ToString() ?? string.Empty : string.Empty,
                        Age = objReader["Age"] != DBNull.Value ? Convert.ToInt32(objReader["Age"]) : 0,
                        ClassName = objReader["ClassName"]?.ToString() ?? string.Empty
                    });
                }
                objReader.Close();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Get all students failed: " + ex.Message);
            }
        }
        public int updateSingleStdInfo(Student student) 
        {
            string sql = "UPDATE Student SET StudentName=@StudentName, Gender=@Gender, Birthday=@Birthday, StudentIdNo=@StudentIdNo, " +
                         "CardNo=@CardNo, PhoneNumber=@PhoneNumber, StudentAddress=@StudentAddress, ClassId=@ClassId, StudentImage=@StudentImage, Age=@Age " +
                         "WHERE StudentId=@StudentId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StudentName", student.StdName),
                new SqlParameter("@Gender", student.Gender),
                new SqlParameter("@Birthday", student.Birthday),
                new SqlParameter("@StudentIdNo", student.idNo),
                new SqlParameter("@CardNo", student.CardNo),
                new SqlParameter("@PhoneNumber", student.PhoneNumber),
                new SqlParameter("@StudentAddress", student.Address),
                new SqlParameter("@ClassId", student.Classid),
                new SqlParameter("@StudentImage", student.StdImage),
                new SqlParameter("@Age", student.Age),
                new SqlParameter("@StudentId", student.StdId)
            };
            try
            {
                return SQLHelper.Update(sql, param);
            }
            catch (Exception ex)
            {
                throw new Exception("Update student failed: " + ex.Message);
            }
        }
        public List<Student> getStudentsByClass(string className)
        {
            string sql = "SELECT StudentId, StudentName, Gender, Birthday, StudentIdNo, CardNo, PhoneNumber, StudentAddress, Student.ClassId, StudentImage, Age, ClassName " +
                         "FROM Student INNER JOIN StudentClass ON Student.ClassId = StudentClass.ClassId " +
                         "WHERE ClassName=@ClassName";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ClassName", className)
            };
            List<Student> list = new List<Student>();
            try
            {
                SqlDataReader objReader = SQLHelper.GetReader(sql, param);
                while (objReader.Read())
                {
                    list.Add(new Student()
                    {
                        StdId = Convert.ToInt32(objReader["StudentId"]),
                        StdName = objReader["StudentName"]?.ToString() ?? string.Empty,
                        Gender = objReader["Gender"]?.ToString() ?? string.Empty,
                        Birthday = Convert.ToDateTime(objReader["Birthday"]),
                        idNo = objReader["StudentIdNo"]?.ToString() ?? string.Empty,
                        CardNo = objReader["CardNo"]?.ToString() ?? string.Empty,
                        PhoneNumber = objReader["PhoneNumber"] != DBNull.Value ? objReader["PhoneNumber"]?.ToString() ?? string.Empty : string.Empty,
                        Address = objReader["StudentAddress"] != DBNull.Value ? objReader["StudentAddress"]?.ToString() ?? string.Empty : string.Empty,
                        Classid = Convert.ToInt32(objReader["ClassId"]),
                        StdImage = objReader["StudentImage"] != DBNull.Value ? objReader["StudentImage"]?.ToString() ?? string.Empty : string.Empty,
                        Age = objReader["Age"] != DBNull.Value ? Convert.ToInt32(objReader["Age"]) : 0,
                        ClassName = objReader["ClassName"]?.ToString() ?? string.Empty
                    });
                }
                objReader.Close();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Get students by class failed: " + ex.Message);
            }
        }
        public Student? getStudentByStdID(string stdId)
        {
            string sql = "SELECT StudentId, StudentName, Gender, Birthday, StudentIdNo, CardNo, PhoneNumber, StudentAddress, Student.ClassId, StudentImage, Age, ClassName " +
                         "FROM Student INNER JOIN StudentClass ON Student.ClassId = StudentClass.ClassId " +
                         "WHERE StudentId=@StudentId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StudentId", stdId)
            };
            try
            {
                SqlDataReader objReader = SQLHelper.GetReader(sql, param);
                Student? student = null;
                if (objReader.Read())
                {
                    student = new Student()
                    {
                        StdId = Convert.ToInt32(objReader["StudentId"]),
                        StdName = objReader["StudentName"]?.ToString() ?? string.Empty,
                        Gender = objReader["Gender"]?.ToString() ?? string.Empty,
                        Birthday = Convert.ToDateTime(objReader["Birthday"]),
                        idNo = objReader["StudentIdNo"]?.ToString() ?? string.Empty,
                        CardNo = objReader["CardNo"]?.ToString() ?? string.Empty,
                        PhoneNumber = objReader["PhoneNumber"] != DBNull.Value ? objReader["PhoneNumber"]?.ToString() ?? string.Empty : string.Empty,
                        Address = objReader["StudentAddress"] != DBNull.Value ? objReader["StudentAddress"]?.ToString() ?? string.Empty : string.Empty,
                        Classid = Convert.ToInt32(objReader["ClassId"]),
                        StdImage = objReader["StudentImage"] != DBNull.Value ? objReader["StudentImage"]?.ToString() ?? string.Empty : string.Empty,
                        Age = objReader["Age"] != DBNull.Value ? Convert.ToInt32(objReader["Age"]) : 0,
                        ClassName = objReader["ClassName"]?.ToString() ?? string.Empty
                    };
                }
                objReader.Close();
                return student;
            }
            catch (Exception ex)
            {
                throw new Exception("Get student by ID failed: " + ex.Message);
            }
        }

        public Student? GetStudentByCardNo(string cardNo)
        {
            string sql = "SELECT StudentId, StudentName, Gender, Birthday, StudentIdNo, CardNo, PhoneNumber, StudentAddress, Student.ClassId, StudentImage, Age, ClassName " +
                         "FROM Student INNER JOIN StudentClass ON Student.ClassId = StudentClass.ClassId " +
                         "WHERE CardNo=@CardNo";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CardNo", cardNo)
            };
            try
            {
                SqlDataReader objReader = SQLHelper.GetReader(sql, param);
                Student? student = null;
                if (objReader.Read())
                {
                    student = new Student()
                    {
                        StdId = Convert.ToInt32(objReader["StudentId"]),
                        StdName = objReader["StudentName"]?.ToString() ?? string.Empty,
                        Gender = objReader["Gender"]?.ToString() ?? string.Empty,
                        Birthday = Convert.ToDateTime(objReader["Birthday"]),
                        idNo = objReader["StudentIdNo"]?.ToString() ?? string.Empty,
                        CardNo = objReader["CardNo"]?.ToString() ?? string.Empty,
                        PhoneNumber = objReader["PhoneNumber"] != DBNull.Value ? objReader["PhoneNumber"]?.ToString() ?? string.Empty : string.Empty,
                        Address = objReader["StudentAddress"] != DBNull.Value ? objReader["StudentAddress"]?.ToString() ?? string.Empty : string.Empty,
                        Classid = Convert.ToInt32(objReader["ClassId"]),
                        StdImage = objReader["StudentImage"] != DBNull.Value ? objReader["StudentImage"]?.ToString() ?? string.Empty : string.Empty,
                        Age = objReader["Age"] != DBNull.Value ? Convert.ToInt32(objReader["Age"]) : 0,
                        ClassName = objReader["ClassName"]?.ToString() ?? string.Empty
                    };
                }
                objReader.Close();
                return student;
            }
            catch (Exception ex)
            {
                throw new Exception("Get student by card failed: " + ex.Message);
            }
        }

        public Student? StudentLogin(string loginId, string password)
        {
            // 默认密码：123456；后续如增加学生密码字段可在此扩展
            if (!string.Equals(password, "123456"))
            {
                return null;
            }
            return GetStudentByCardNo(loginId);
        }
        public int deleteStdInfoByID(string stdId)
        {
            string sql = "DELETE FROM AttendanceRecord WHERE StudentId=@StudentId; " + 
                         "DELETE FROM Student WHERE StudentId=@StudentId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StudentId", stdId)
            };
            try
            {
                return SQLHelper.Update(sql, param);
            }
            catch (Exception ex)
            {
                throw new Exception("Delete student failed: " + ex.Message);
            }
        }
    }
}
