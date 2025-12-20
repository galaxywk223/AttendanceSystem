using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ahutit;
using System.Data.SqlClient;

namespace DAL.ahutit
{
    public class StudentClassService
    {
        public List<Class> GetAllClass()
        {
            string sql = "SELECT ClassId, ClassName FROM StudentClass";
            List<Class> list = new List<Class>();
            try
            {
                SqlDataReader objReader = SQLHelper.GetReader(sql);
                while (objReader.Read())
                {
                    list.Add(new Class()
                    {
                        Id = Convert.ToInt32(objReader["ClassId"]),
                        ClassName = objReader["ClassName"]?.ToString() ?? string.Empty
                    });
                }
                objReader.Close();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Get class list failed: " + ex.Message);
            }
        }

        public bool ClassNameExists(string className, int? excludeId = null)
        {
            string sql = "SELECT COUNT(1) FROM StudentClass WHERE ClassName=@ClassName";
            if (excludeId.HasValue)
            {
                sql += " AND ClassId<>@ExcludeId";
            }

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@ClassName", className)
            };
            if (excludeId.HasValue)
            {
                parameters.Add(new SqlParameter("@ExcludeId", excludeId.Value));
            }

            object result = SQLHelper.GetSingleResult(sql, parameters.ToArray()) ?? 0;
            return Convert.ToInt32(result) > 0;
        }

        public int AddClass(Class newClass)
        {
            string sql = "INSERT INTO StudentClass(ClassName) VALUES(@ClassName); SELECT SCOPE_IDENTITY();";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ClassName", newClass.ClassName)
            };
            object result = SQLHelper.GetSingleResult(sql, parameters);
            return Convert.ToInt32(result);
        }

        public int UpdateClass(Class classToUpdate)
        {
            string sql = "UPDATE StudentClass SET ClassName=@ClassName WHERE ClassId=@ClassId";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ClassName", classToUpdate.ClassName),
                new SqlParameter("@ClassId", classToUpdate.Id)
            };
            return SQLHelper.Update(sql, parameters);
        }

        public int DeleteClass(int classId)
        {
            string sql = "DELETE FROM StudentClass WHERE ClassId=@ClassId";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ClassId", classId)
            };
            return SQLHelper.Update(sql, parameters);
        }

        public bool ClassHasStudents(int classId)
        {
            string sql = "SELECT COUNT(1) FROM Student WHERE ClassId=@ClassId";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ClassId", classId)
            };
            object result = SQLHelper.GetSingleResult(sql, parameters) ?? 0;
            return Convert.ToInt32(result) > 0;
        }
    }
}
