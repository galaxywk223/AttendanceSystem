using DAL.ahutit;
using Models;
using Models.ahutit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Globalization;
namespace AMS.ahutit
{
    public partial class FrmStdEdit : Form
    {
        //创建数据访问对象
        private StudentClassService stdClassService = new StudentClassService();
        private StudentService studentService = new StudentService();
        private Student CurrentStd=new Student();

        //图片路径
        string ImageName = "";
        string ImagePath = "";

        
        public FrmStdEdit(Student student)
        {
            InitializeComponent();
            txtStdID.Text = student.StdId.ToString();
            this.txtName.Text = student.StdName;
            this.txtAddress.Text = student.Address;
            txtIDNo.Text = student.idNo;
            this.txtPhone.Text = student.PhoneNumber;
            txtAttNo.Text = student.CardNo;
            picStdImage.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/image/" + student.StdImage);
            if (student.Gender == "男")
            {
                rdbMale.Checked = true;
            }
            else { rdbFemale.Checked = true; }
            dtpBirthday.Text = student.Birthday.ToString();
            //初始化班级下拉框
            cmbClass.DataSource = stdClassService.GetAllClass();
            cmbClass.DisplayMember = "ClassName";
            cmbClass.ValueMember = "Id";
            cmbClass.SelectedValue = student.Classid;
            CurrentStd=student;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIDNo_TextChanged(object sender, EventArgs e)
        {
            DateTime? birth = TryParseBirthdayFromId(txtIDNo.Text.Trim());
            if (birth.HasValue)
            {
                dtpBirthday.Value = birth.Value;
            }
        }

        private static DateTime? TryParseBirthdayFromId(string idNo)
        {
            if (idNo.Length >= 14)
            {
                string birthStr = idNo.Substring(6, 8);
                if (DateTime.TryParseExact(birthStr, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birth))
                {
                    return birth;
                }
            }
            return null;
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                picStdImage.Image = Image.FromFile(ofd.FileName);
                ImagePath = ofd.FileName;
                ImageName = ofd.SafeFileName;
            }
        }

        private string[] BuildImageName()
        {
            string[] returnString = { "", "" };
            string[] OnlyImageName = ImageName.Split('.');
            string NewImageName = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString() + "." + OnlyImageName[OnlyImageName.Length - 1];
            returnString[0] = NewImageName;
            //long unixTimestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            string fileNameDes = AppDomain.CurrentDomain.BaseDirectory + "/image/" + NewImageName;
            returnString[1] = fileNameDes;
            //File.Copy(ImagePath, fileNameDes);
            return returnString;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            #region 数据验证
            //非空验证
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("学生姓名不能为空！", "提示信息");
                txtName.Focus();
                return;
            }
            if (txtAttNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("学生考勤卡号不能为空！", "提示信息");
                txtAttNo.Focus();
                return;
            }
            if (!rdbMale.Checked && !rdbFemale.Checked)
            {
                MessageBox.Show("请选择学生性别！", "提示信息");
                return;
            }
            if (cmbClass.SelectedIndex == -1)
            {
                MessageBox.Show("请选择班级！", "提示信息");
                cmbClass.Focus();
                return;
            }
            int age = DateTime.Now.Year - Convert.ToDateTime(dtpBirthday.Text).Year;
            if (age > 40 || age < 16)
            {
                MessageBox.Show("出生日期选择有误！", "提示信息");
                return;
            }

            //身份证号码格式验证
            if (!Common.DataValidate.IsIDCardNo(txtIDNo.Text.Trim()))
            {
                MessageBox.Show("身份证号码不符合要求！", "提示信息");
                txtIDNo.SelectAll();
                txtIDNo.Focus();
                return;
            }
            //验证身份证中的身份日期与用户选择的出生日期是否一致
            string birthday = Convert.ToDateTime(dtpBirthday.Text).ToString("yyyyMMdd");
            if (!txtIDNo.Text.Trim().Contains(birthday))
            {
                MessageBox.Show("身份证中的身份日期与用户选择的出生日期不匹配！", "提示信息");
                txtIDNo.SelectAll();
                txtIDNo.Focus();
                return;
            }
            //判断身份证号码和考勤卡号是否存在
            //判断身份证号码有没有变？
            if (txtIDNo.Text.Trim() != CurrentStd.idNo)
            {
                if (studentService.isIdNoExisted(txtIDNo.Text.Trim()))
                {
                    MessageBox.Show("身份证号码已存在！", "提示信息");
                    txtIDNo.SelectAll();
                    txtIDNo.Focus();
                    return;
                }
            }
            //判断考勤卡号没有变？
            if (txtAttNo.Text.Trim() != CurrentStd.CardNo)
            {
                if (studentService.isCardNoExisted(txtAttNo.Text.Trim()))
                {
                    MessageBox.Show("考勤卡号已存在！", "提示信息");
                    txtAttNo.SelectAll();
                    txtAttNo.Focus();
                    return;
                }
            }
            #endregion

            #region 封装对象
            Student newStudent = new Student()
            {
                StdId=CurrentStd.StdId,
                StdName = txtName.Text.Trim(),
                Gender = rdbMale.Checked ? "男" : "女",
                Birthday = Convert.ToDateTime(dtpBirthday.Text),
                idNo = txtIDNo.Text.Trim(),
                PhoneNumber = txtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Classid = Convert.ToInt32(cmbClass.SelectedValue),
                Age = DateTime.Now.Year - Convert.ToDateTime(dtpBirthday.Text).Year,
                CardNo = txtAttNo.Text.Trim(),
                StdImage = CurrentStd.StdImage
            };
            try
            {
                //复制图片文件到相对目录
                if (ImagePath != "")
                {
                    string[] newImageFileInfo = BuildImageName();
                    File.Copy(ImagePath, newImageFileInfo[1]);
                    newStudent.StdImage = newImageFileInfo[0];
                }
                studentService.updateSingleStdInfo(newStudent);
                MessageBox.Show("更新学号为[" + txtStdID.Text.Trim() + "]学员信息成功！", "更新成功");                
            }
            catch (Exception)
            {
                throw;
            }
            //

            #endregion

        }

    }
}
