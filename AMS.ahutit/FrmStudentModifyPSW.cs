using System;
using System.Windows.Forms;
using DAL.ahutit;
using Models.ahutit;

namespace AMS.ahutit
{
    public partial class FrmStudentModifyPSW : Form
    {
        private readonly Student _student;
        private readonly StudentService _studentService = new StudentService();

        public FrmStudentModifyPSW(Student student)
        {
            _student = student;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string oldPwd = txtOldPSW.Text.Trim();
            string newPwd = txtNewPSW.Text.Trim();
            string confirmPwd = txtConfirmPSW.Text.Trim();

            if (oldPwd.Length == 0)
            {
                MessageBox.Show("原密码不能为空", "输入错误");
                txtOldPSW.Focus();
                return;
            }

            string currentPwd = string.IsNullOrEmpty(_student.StudentPwd) ? "123456" : _student.StudentPwd;
            if (!string.Equals(oldPwd, currentPwd))
            {
                MessageBox.Show("原密码输入错误", "输入错误");
                txtOldPSW.Focus();
                txtOldPSW.SelectAll();
                return;
            }

            if (newPwd.Length < 6)
            {
                MessageBox.Show("新密码长度不能小于6位", "提示");
                txtNewPSW.Focus();
                return;
            }

            if (confirmPwd.Length == 0)
            {
                MessageBox.Show("请再次输入新密码", "提示");
                txtConfirmPSW.Focus();
                return;
            }

            if (!string.Equals(newPwd, confirmPwd))
            {
                MessageBox.Show("两次输入密码不一致", "提示");
                txtNewPSW.Text = "";
                txtConfirmPSW.Text = "";
                return;
            }

            try
            {
                int result = _studentService.ModifyStudentPwd(_student.StdId, newPwd);
                if (result > 0)
                {
                    _student.StudentPwd = newPwd;
                    MessageBox.Show("密码修改成功", "提示");
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("密码修改失败", "错误");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("密码修改失败: " + ex.Message, "错误");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtOldPSW.Text = "";
            txtNewPSW.Text = "";
            txtConfirmPSW.Text = "";
            txtOldPSW.Focus();
        }
    }
}
