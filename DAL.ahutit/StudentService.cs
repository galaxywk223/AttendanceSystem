using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ahutit;

namespace DAL.ahutit
{
    public class StudentService
    {
        public bool isIdNoExisted(string idNo)
        {
            //此处应有数据库操作代码，此处省略
            //模拟数据库中已有身份证号为"123456789012345678"的学生记录
            if (idNo == "123456789012345678")
            {
                return true; //身份证号已存在
            }
            else
            {
                return false; //身份证号不存在
            }
        }
        public bool isCardNoExisted(string cardNo)
        {
            //此处应有数据库操作代码，此处省略
            //模拟数据库中已有卡号为"20230001"的学生记录
            if (cardNo == "20230001")
            {
                return true; //卡号已存在
            }
            else
            {
                return false; //卡号不存在
            }
        }
        public int addNewStd(Student newStudent)
        {
            //此处应有数据库操作代码，此处省略
            //模拟添加成功，返回1
            return 1;
        }
        public List<Student> getAllStudents()
        {
            return new List<Student>();
        }
        public void updateSingleStdInfo(Student student) { }
        public List<Student> getStudentsByClass(string className)
        {
            return new List<Student>();
        }
        public Student getStudentByStdID(string stdId)
        {
            return new Student();
        }
        public int deleteStdInfoByID(Student student)
        {
            return 1;
        }
    }
}
