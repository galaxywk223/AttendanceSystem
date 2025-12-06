using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Models.ahutit;
using DAL;
using DAL.ahutit;

namespace AMS.ahutit
{
    public partial class FrmLogin : Form
    {
        public SysAdminService objSysAdminService = new SysAdminService();
        private readonly StudentService _studentService = new StudentService();
        public FrmLogin()
        {
            InitializeComponent();
            cmbRole.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //数据验证
            if (this.tbxName.Text.Trim().Length == 0)
            {
                MessageBox.Show("您不能输入空字符！", "提示信息", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                this.tbxName.Focus();
                return;
            }
            if (this.tbxPsw.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入密码！", "提示信息");
                this.tbxPsw.Focus();
                return;
            }

            string loginId = tbxName.Text.Trim();
            string password = tbxPsw.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString() ?? "管理员";

            if (role == "管理员")
            {
                if (!Common.DataValidate.IsInteger(loginId))
                {
                    MessageBox.Show("登录账号格式不正确，请重新输入！", "提示信息");
                    this.tbxName.Focus();
                    return;
                }

                SysAdmin objAdmin = new SysAdmin()
                {
                    loginid = Convert.ToInt32(loginId),
                    Pwd = password
                };

                try
                {
                    Program.currentAdmin = objSysAdminService.AdminLogin(objAdmin);
                    Program.currentStudent = null;
                    if (Program.currentAdmin != null)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误", "提示信息");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "数据库访问异常");
                }
            }
            else
            {
                // 学员登录：用考勤卡号 + 默认密码123456
                Student? student = _studentService.StudentLogin(loginId, password);
                Program.currentStudent = student;
                Program.currentAdmin = null;
                if (student != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("考勤卡号或密码错误", "提示信息");
                }
            }

            //处理交互结果（保存数据、返回对象）
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            cmbRole.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.SelectedItem?.ToString() == "学员")
            {
                label1.Text = "考勤卡号：";
                tbxPsw.Text = "123456";
            }
            else
            {
                label1.Text = "登录账号：";
            }
        }
    }
}
