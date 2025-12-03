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
                        ClassName = objReader["ClassName"].ToString()
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
    }
}
